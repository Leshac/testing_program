using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace testing_program
{
    public static class cb_Drop_down
    {
        public static void Drop_down_cb_sex(ComboBox target)
        {
            SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
            sqlConnection.Open();

            string sql_quiry = $"SELECT Name, id FROM Sex";

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql_quiry, sqlConnection);
            sqlDataAdapter.Fill(dataTable);


            target.DataSource = dataTable;
            target.DisplayMember = "Name";// столбец для отображения
            target.ValueMember = "id";//столбец с id
            target.SelectedIndex = -1;
            sqlConnection.Close();
        }

        public static void Drop_down_education(ComboBox target)
        {
            SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
            sqlConnection.Open();

            string sql_quiry = $"SELECT Name, id FROM Education";

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql_quiry, sqlConnection);
            sqlDataAdapter.Fill(dataTable);


            target.DataSource = dataTable;
            target.DisplayMember = "Name";// столбец для отображения
            target.ValueMember = "id";//столбец с id
            target.SelectedIndex = -1;

            sqlConnection.Close();
        }

        public static void Drop_down_profession(ComboBox target)
        {
            SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
            sqlConnection.Open();

            string sql_quiry = $"SELECT Name, id FROM Profession";

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql_quiry, sqlConnection);
            sqlDataAdapter.Fill(dataTable);


            target.DataSource = dataTable;
            target.DisplayMember = "Name";// столбец для отображения
            target.ValueMember = "id";//столбец с id
            target.SelectedIndex = -1;

            sqlConnection.Close();
        }

        public static void Drop_down_qualification(ComboBox target)
        {
            SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
            sqlConnection.Open();

            string sql_quiry = $"SELECT Name, id FROM Qualification";

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql_quiry, sqlConnection);
            sqlDataAdapter.Fill(dataTable);


            target.DataSource = dataTable;
            target.DisplayMember = "Name";// столбец для отображения
            target.ValueMember = "id";//столбец с id
            target.SelectedIndex = -1;

            sqlConnection.Close();
        }

        public static void Drop_down_family(ComboBox target)
        {
            SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
            sqlConnection.Open();

            string sql_quiry = $"SELECT Name, id FROM Family";

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql_quiry, sqlConnection);
            sqlDataAdapter.Fill(dataTable);


            target.DataSource = dataTable;
            target.DisplayMember = "Name";// столбец для отображения
            target.ValueMember = "id";//столбец с id
            target.SelectedIndex = -1;

            sqlConnection.Close();
        }

        public static void Drop_down_type_accident(ComboBox target)
        {
            SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
            sqlConnection.Open();

            string sql_quiry = $"SELECT  type_accident= CONCAT( N_type,Name,code),id_type FROM Type_accident";

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql_quiry, sqlConnection);
            sqlDataAdapter.Fill(dataTable);


            target.DataSource = dataTable;
            target.DisplayMember = "type_accident";// столбец для отображения
            target.ValueMember = "id_type";//столбец с id
            target.SelectedIndex = -1;

            sqlConnection.Close();
        }

        public static void Drop_down_people_for_edu(ComboBox target)
        {
            SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
            sqlConnection.Open();

            string sql_quiry = $"SELECT  FIO=CONCAT(LastName,Name,FatherName),id FROM People_for_edu";

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql_quiry, sqlConnection);
            sqlDataAdapter.Fill(dataTable);


            target.DataSource = dataTable;
            target.DisplayMember = "FIO";// столбец для отображения
            target.ValueMember = "id";//столбец с id
            target.SelectedIndex = -1;

            sqlConnection.Close();
        }

        public static void Drop_down_seriousness(ComboBox target)
        {
            SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
            sqlConnection.Open();

            string sql_quiry = $"SELECT  Seriousness,id FROM seriuosness";

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql_quiry, sqlConnection);
            sqlDataAdapter.Fill(dataTable);


            target.DataSource = dataTable;
            target.DisplayMember = "Seriousness";// столбец для отображения
            target.ValueMember = "id";//столбец с id
            target.SelectedIndex = -1;

            sqlConnection.Close();
        }

        public static void Drop_down_enterprise(ComboBox target)
        {
            SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
            sqlConnection.Open();

            string sql_quiry = $"SELECT  Name,id FROM Enterprise";

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql_quiry, sqlConnection);
            sqlDataAdapter.Fill(dataTable);


            target.DataSource = dataTable;
            target.DisplayMember = "Name";// столбец для отображения
            target.ValueMember = "id";//столбец с id
            target.SelectedIndex = -1;

            sqlConnection.Close();
        }

        public static void Drop_down_shedule(ComboBox target)
        {
            SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
            sqlConnection.Open();

            string sql_quiry = $"SELECT  Name,id FROM Shedule";

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql_quiry, sqlConnection);
            sqlDataAdapter.Fill(dataTable);


            target.DataSource = dataTable;
            target.DisplayMember = "Name";// столбец для отображения
            target.ValueMember = "id";//столбец с id
            target.SelectedIndex = -1;

            sqlConnection.Close();
        }
    }

}
