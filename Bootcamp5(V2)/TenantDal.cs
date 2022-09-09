using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Bootcamp5_V2_
{
    class TenantDal
    {
        SqlConnection _connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Bootcamp5(V2); Integrated Security=true");
        public List<Tenant> GetAll()
        {
            ConnectionControl();
            List<Tenant> tenants = new List<Tenant>();
            SqlCommand command = new SqlCommand("select * from Tenants", _connection);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Tenant tenant = new Tenant
                {
                    Id = (int)reader["Id"],
                    DaireNo = (int)reader["DaireNo"],
                    Ad = (string)reader["Ad"],
                    Soyad = (string)reader["Soyad"],
                    Tel = (string)reader["TelNo"],
                    TC = (string)reader["TC"],
                    Mail = (string)reader["Mail"],
                    AracPlaka = (string)reader["AracPlaka"]
                };
                tenants.Add(tenant);
            }
            reader.Close();
            _connection.Close();
            return tenants;
        }

        public void Add(Tenant tenant)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("insert into Tenants values(@DaireNo, @Ad, @Soyad, @Tel, @Mail, @TC, @AracPlaka)", _connection);
            command.Parameters.AddWithValue("@DaireNo", tenant.DaireNo);
            command.Parameters.AddWithValue("@Ad", tenant.Ad);
            command.Parameters.AddWithValue("@Soyad", tenant.Soyad);
            command.Parameters.AddWithValue("@Tel", tenant.Tel);
            command.Parameters.AddWithValue("@Mail", tenant.Mail);
            command.Parameters.AddWithValue("@TC", tenant.TC);
            command.Parameters.AddWithValue("@AracPlaka", tenant.AracPlaka);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Update(Tenant tenant)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("update Tenants set Ad=@Ad, Soyad=@Soyad, TelNo=@TelNo, Mail=@Mail, TC=@TC, AracPlaka=@AracPlaka where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Ad", tenant.Ad);
            command.Parameters.AddWithValue("@Soyad", tenant.Soyad);
            command.Parameters.AddWithValue("@TelNo", tenant.Tel);
            command.Parameters.AddWithValue("@Mail", tenant.Mail);
            command.Parameters.AddWithValue("@TC", tenant.TC);
            command.Parameters.AddWithValue("@AracPlaka", tenant.AracPlaka);
            command.Parameters.AddWithValue("@Id", tenant.Id);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Delete(int Id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Tenants where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Id", Id);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
                _connection.Open();
        }
    }
}
