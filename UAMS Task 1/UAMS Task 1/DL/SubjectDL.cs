using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UAMS
{
    internal class SubjectDL
    {
        List<SubjectBL> AllSubjects = new List<SubjectBL>();
        //public static void StoreSubjectsInFile(string path, SubjectBL d)
        //{
        //    StreamWriter file = new StreamWriter(path, true);
        //    file.WriteLine(d.Code + "," + d.Type + "," + d.CreditHours + "," + d.SubjectFees);
        //    file.Flush();
        //    file.Close();
        //}

        public static string connection = "server=DESKTOP-5MQPGIM\\SQLEXPRESS;Database=UAMS;Trusted_Connection=True";
        public static SubjectBL CreateSubject(SubjectBL subject)
        {
            string query = string.Format("INSERT INTO Subject(SubjectCode ,Type,CredirHours,Fees) " +
                "Values('{0}','{1}',{2},{3})",
                subject.Code, subject.Type, subject.CreditHours, subject.SubjectFees);
            using (SqlConnection connection = new SqlConnection(query))
            {
                SqlCommand cmd = new SqlCommand(query,connection);
                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                    return subject;
            }
            return null;
        }

        public static student
    }
}
