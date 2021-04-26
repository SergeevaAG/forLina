using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konditerka
{
    public class Word
    {
        public static void wordConnection()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM [user]";
            SqlDataReader reader = cmd.ExecuteReader();

            StreamWriter write = new StreamWriter(@"D:\Рабочий стол\Отчет.txt");
            while (reader.Read())
            {
                write.Write("{0} {1} {2} {3} {4}", reader[0] + "\t", reader[1] + "\t",
                     reader[2] + "\t", reader[3] + "\t", reader[4]);
                write.WriteLine();
            }
            write.Close();
            conn.Close();
        }
        
    }
}
