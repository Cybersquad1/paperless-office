using System;
using System.Collections.Generic;
using System.Text;
using OCA.Common;
using System.Data;
using System.Data.SqlClient;

namespace OCA.DataAccess.Kartabl
{
    public class Parvandeh
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter sda;

        private string ConnectionString = "";

        OCA.Common.DataSets.Kartabl.Parvandeh dsparvandeh = new OCA.Common.DataSets.Kartabl.Parvandeh();

        public Parvandeh()
        {
            OCA.Common.Configuration config = new Configuration();
            ConnectionString = config.Connection_String;

            conn.ConnectionString = ConnectionString;
        }

        public void InsertParvandeh(string ParvandehName)
        {
            if (Check_PrimaryKey(ParvandehName)) throw new Exception("پرونده" + " " + ParvandehName + " " + "موجود است!");

            SqlCommand cmnd = new SqlCommand();
            cmnd.Parameters.AddWithValue("@ParvandehName", ParvandehName.Replace("ی", "ي"));

            cmnd.CommandText = "Insert_Parvandeh";

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;
                cmnd.CommandType = CommandType.StoredProcedure;
                cmnd.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("خطا در ارتباط با بانک اطلاعاتی!");
            }
            finally
            {
                conn.Close();
            }

        }

        public Boolean Check_PrimaryKey(string ParvandehName)
        {
            sda = new SqlDataAdapter("select * from Tbl_MailParvandeh where ParvandehName = '" + ParvandehName.Replace("ی", "ي") + "'", conn);

            try
            {
                dsparvandeh.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsparvandeh.Tbl_MailParvandeh);
                if (dsparvandeh.Tbl_MailParvandeh.Rows.Count == 0)
                    return false;
                else
                    return true;
            }
            catch
            {
                throw new Exception("خطا در ارتباط با بانک اطلاعاتی!");
            }
            finally
            {
                conn.Close();
            }
        }

        public OCA.Common.DataSets.Kartabl.Parvandeh GetParvandeh()
        {
            sda = new SqlDataAdapter(" select * from Tbl_MailParvandeh", conn);

            try
            {
                dsparvandeh.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsparvandeh.Tbl_MailParvandeh);

                return dsparvandeh;
            }
            catch
            {
                throw new Exception("خطا در ارتباط با بانک اطلاعاتی!");
            }
            finally
            {
                conn.Close();
            }
        }

        public void UpdateParvandeh(string ParvandehName, string newParvandehName)
        {
            if (Check_PrimaryKey(newParvandehName)) throw new Exception("پرونده" + " " + newParvandehName + " " + "موجود است!");

            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;

                cmnd.CommandText = "UPDATE Tbl_MailParvandeh SET ParvandehName = '" + newParvandehName.Replace("ی", "ي") + "' WHERE ParvandehName = '" + ParvandehName.Replace("ی", "ي") + "'";
                cmnd.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("خطا در ارتباط با بانک اطلاعاتی!");
            }
            finally
            {
                conn.Close();
            }
        }

        public void RemoveParvandeh(string ParvandehName)
        {
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;
                cmnd.CommandText = "DELETE FROM Tbl_MailParvandeh WHERE ParvandehName = '" + ParvandehName.Replace("ی", "ي") + "'";
                cmnd.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("خطا در ارتباط با بانک اطلاعاتی!");
            }
            finally
            {
                conn.Close();
            }
        }





    }
}
