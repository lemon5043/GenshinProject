using ISpan.Utility;
using Main_form.models.viewmodels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_form.models.services
{
	public class UserService
	{
		/// <summary>
		/// 傳回所有使用者記錄
		/// </summary>
		/// <returns></returns>
		public IEnumerable<UserIndexVM> GetAll()
		{
			string sql = @"SELECT * FROM Users ORDER BY ID DESC";

			var dbHelper = new SqlDbHelper("default");
			// 存放在field裡, 稍後在 grid CellClick事件會需要再度用到它
			return dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ParseToIndexVM(row))
				;
			// .ToList();
		}

		public void Create(UserVM model)
		{
			bool isExists = AccountExists(model.Account);
			if (isExists) throw new Exception("The account is already existed.");

			string sql = @"INSERT INTO Users
						 (name, account, password, email)
						 VALUES
						 (@Account,@Password, @Name, @email)";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Account", 50, model.Account)
				.AddNVarchar("Password", 50, model.Password)
				.AddNVarchar("Name", 50, model.Name)
				.AddNVarchar("email", 50, model.Email)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

		}

		private bool AccountExists(string account)
		{
			string sql = @"SELECT Count(*) as count FROM Users WHERE Account=@Account";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Account", 50, account)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		private bool AccountExists(UserVM model)
		{
			string sql = @"SELECT Count(*) as count FROM Users WHERE Account=@Account AND Id!=@Id";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Account", 50, model.Account)
				.AddInt("Id", model.Id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		private UserIndexVM ParseToIndexVM(DataRow row)
		{
			return new UserIndexVM
			{
				Id = row.Field<int>("Id"),
				Account = row.Field<string>("Account"),
				Name = row.Field<string>("Name")
			};
		}

		public UserVM Get(int id)
		{
			string sql = "SELECT * FROM Users WHERE Id=@Id";
			var parameters = new SqlParameterBuilder()
				.AddInt("Id", id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				throw new Exception("找不到要編輯的記錄");
				//MessageBox.Show("抱歉, 找不到要編輯的記錄");
				//this.DialogResult = DialogResult.Abort;


				//return;
			}

			// 將找到的一筆記錄由DataTable 轉換到 ProductVM
			return ToUserVM(data.Rows[0]);
		}

		private UserVM ToUserVM(DataRow row)
		{
			return new UserVM
			{
				Id = row.Field<int>("Id"),
				Account = row.Field<string>("Account"),
				Password = row.Field<string>("Password"),
				Name = row.Field<string>("Name"),
				Email = row.Field<string>("email")
			};
		}

		internal void Update(UserVM model)
		{
			bool isExists = AccountExists(model);
			if (isExists) throw new Exception("The account is already existed.");

			string sql = @"UPDATE Users
			SET Account=@Account, Password=@Password, Name=@Name, Email=@email
			WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Account", 50, model.Account)
				.AddNVarchar("Password", 50, model.Password)
				.AddNVarchar("Name", 50, model.Name)
				.AddNVarchar("Email", 50, model.Email)
				.AddInt("Id", model.Id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

		}

		internal void Delete(int id)
		{
			string sql = @"DELETE FROM Users WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
				.AddInt("Id", id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

		}

		public bool Authenticate(LoginVM model)
		{
			var user = Get(model.Account);
			if (user == null) return false; // 找不到符合的帳號

			return (user.Password == model.Password);
		}

		public UserVM Get(string account)
		{
			string sql = "SELECT * FROM Users WHERE Account=@Account";
			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Account", 50, account)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				return null;
			}

			// 將找到的一筆記錄由DataTable 轉換到 UserVM
			return ToUserVM(data.Rows[0]);
		}
	}
}
