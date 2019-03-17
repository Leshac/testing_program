using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_program
{
    class FuzzySetsAll
    {

    }

    class EvidenceRatingMatrixOLD
    {
        List<int> matrixOld;
        CountOldInSeverityConsequences CountOldInSeverityConsequences18_24 = new CountOldInSeverityConsequences(18,24,1);


    }

    class CountOldInSeverityConsequences
    {
        private int countOld = 0;
        private int minYear = 0;
        private int maxYear = 0;
        private int idSeriuosness;

        public int IdSeriuosness
        {
            get { return idSeriuosness; }
            set { idSeriuosness = value; }
        }

        public int CountOld
        {
            get { return countOld; }
            set { countOld = value; }
        }

        public int MinYaer
        {
            get { return minYear; }
            set { minYear = value; }
        }

        public int MaxYaer
        {
            get { return maxYear; }
            set { maxYear = value; }
        }

        public CountOldInSeverityConsequences(int minYear, int maxYear, int idSeriuosness)
        {
            MinYaer = minYear;
            MaxYaer = maxYear;
            IdSeriuosness = idSeriuosness;
            GetCountOld();
        }

        private void GetCountOld()
        {
            SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
            sqlConnection.Open();

            string sqlquery = $"SELECT Count(Age_on_accident) From Acc Where Age_on_accident>= " + MinYaer + " AND Age_on_accident < " + MaxYaer + " AND id_seriousness="+IdSeriuosness+"";
            SqlCommand sqlCommand = new SqlCommand(sqlquery, sqlConnection);
            CountOld = (int)sqlCommand.ExecuteScalar();

            sqlConnection.Close();
        }

    }
}
