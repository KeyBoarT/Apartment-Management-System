using System.Data.SqlClient;
using System.Data;


namespace Bootcamp5_V2_
{
    class AdminDal
    {
        SqlConnection _connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Bootcamp5(V2); Integrated Security=true");

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
                _connection.Open();
        }

        public void Add(Admin admin)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("insert into Admins values(@Ad, @Soyad, @Password, @Resim)", _connection);
            command.Parameters.AddWithValue("@Ad", admin.Ad);
            command.Parameters.AddWithValue("@Soyad", admin.Soyad);
            command.Parameters.AddWithValue("@Password", admin.Password);
            command.Parameters.Add("@Resim", SqlDbType.Image, admin.Resim.Length).Value = admin.Resim;
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Update(Admin admin)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Admins set Ad=@Ad, Soyad=@Soyad, Password=@Password, Resim=@Resim where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Ad", admin.Ad);
            command.Parameters.AddWithValue("@Soyad", admin.Soyad);
            command.Parameters.AddWithValue("@Password", admin.Password);
            command.Parameters.AddWithValue("@Resim", admin.Resim);
            command.Parameters.AddWithValue("@Id", admin.Id);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public Admin Find(string userName, string password)
        {
            ConnectionControl();
            Admin admin = new Admin();
            SqlCommand command = new SqlCommand("Select * from Admins where Ad=@Ad and Password=@Password", _connection);
            command.Parameters.AddWithValue("@Ad", userName);
            command.Parameters.AddWithValue("@Password", password);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                admin.Ad = (string)reader["Ad"];
                admin.Soyad = (string)reader["Soyad"];
                admin.Password = (string)reader["Password"];
                admin.Resim = (byte[])reader["Resim"];
            }
            _connection.Close();
            return admin;
        }
    }
}
