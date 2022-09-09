using System.Data.SqlClient;
using System.Data;

namespace Bootcamp5_V2_
{
    class DueDal
    {
        SqlConnection _connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Bootcamp5(V2); Integrated Security=true");
        public DataTable GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("select * from Dues", _connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;
        }

        public DataTable GetAllWithName()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("select * from Dues", _connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;
        }

        public void Add(Due due)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("insert into Dues values(@Ocak, @Subat, @Mart, @Nisan, @Mayis, @Haziran, @Temmuz, @Agustos, @Eylul, @Ekim, @Kasim, @Aralik)", _connection);
            command.Parameters.AddWithValue("@Ocak", due.Ocak);
            command.Parameters.AddWithValue("@Subat", due.Subat);
            command.Parameters.AddWithValue("@Mart", due.Mart);
            command.Parameters.AddWithValue("@Nisan", due.Nisan);
            command.Parameters.AddWithValue("@Mayis", due.Mayis);
            command.Parameters.AddWithValue("@Haziran", due.Haziran);
            command.Parameters.AddWithValue("@Temmuz", due.Temmuz);
            command.Parameters.AddWithValue("@Agustos", due.Agustos);
            command.Parameters.AddWithValue("@Eylul", due.Eylul);
            command.Parameters.AddWithValue("@Ekim", due.Ekim);
            command.Parameters.AddWithValue("@Kasim", due.Kasim);
            command.Parameters.AddWithValue("@Aralik", due.Aralik);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Update(Due due)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("update Dues set Ocak=@Ocak, Subat=@Subat, =Mart=@Mart, Nisan=@Nisan, Mayis=@Mayis, Haziran=@Haziran, Temmuz=@Temmuz, Agustos=@Agustos, Eylul=@Eylul, Ekim=@Ekim, Kasim=@Kasim, Aralik=@Aralik where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Id", due.Id);
            command.Parameters.AddWithValue("@Ocak", due.Ocak);
            command.Parameters.AddWithValue("@Subat", due.Subat);
            command.Parameters.AddWithValue("@Mart", due.Mart);
            command.Parameters.AddWithValue("@Nisan", due.Nisan);
            command.Parameters.AddWithValue("@Mayis", due.Mayis);
            command.Parameters.AddWithValue("@Hazian", due.Haziran);
            command.Parameters.AddWithValue("@Temmuz", due.Temmuz);
            command.Parameters.AddWithValue("@Agustos", due.Agustos);
            command.Parameters.AddWithValue("@Eylul", due.Eylul);
            command.Parameters.AddWithValue("@Ekim", due.Ekim);
            command.Parameters.AddWithValue("@Kasim", due.Kasim);
            command.Parameters.AddWithValue("@Aralik", due.Aralik);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void UpdateOneValue(int Id, string columnName, decimal value)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand($"Update Dues set {columnName}=@value where Id=@Id", _connection);
            command.Parameters.AddWithValue("@value", value);
            command.Parameters.AddWithValue("@Id", Id);
            command.ExecuteNonQuery();
            _connection.Close();
        }
        public void Delete(int Id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Dues where Id=@Id", _connection);
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
