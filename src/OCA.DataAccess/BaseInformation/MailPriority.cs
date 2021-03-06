using System;
using System.Collections.Generic;
using System.Text;
using OCA.Common;
using System.Data;
using System.Data.SqlClient;

namespace OCA.DataAccess.BaseInformation
{
    public class MailPriority
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter sda;

        private string ConnectionString = "";

        OCA.Common.DataSets.BaseInformation.MailPriority dsmPriority = new OCA.Common.DataSets.BaseInformation.MailPriority();

        public MailPriority()
        {
            OCA.Common.Configuration config = new Configuration();
            ConnectionString = config.Connection_String;

            conn.ConnectionString = ConnectionString;
        }

        public OCA.Common.DataSets.BaseInformation.MailPriority GetMailPrioritys()
        {
            sda = new SqlDataAdapter("select * from Tbl_MailPriority", conn);

            try
            {
                dsmPriority.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmPriority.Tbl_MailPriority);

                return dsmPriority;
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

        public void EditMailPriority(string PriorityName, string newPriorityName)
        {
            if (Check_PrimaryKey2(newPriorityName)) throw new Exception("نوع اولویت نامه" + " " + newPriorityName + " " + "موجود است!");

            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;

                cmnd.CommandText = "UPDATE Tbl_MailPriority SET PriorityName = '" + newPriorityName.Replace("ی", "ي") + "' WHERE PriorityName = '" + PriorityName.Replace("ی", "ي") + "'";
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

        public void RemoveMailPriority(string PriorityName)
        {
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;
                cmnd.CommandText = "DELETE FROM Tbl_MailPriority WHERE PriorityName = '" + PriorityName.Replace("ی", "ي") + "'";
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

        public void InsertMailPriority(string PriorityName)
        {
            if (Check_PrimaryKey2(PriorityName)) throw new Exception("نوع اولویت نامه" + " " + PriorityName + " " + "موجود است!");

            SqlCommand cmnd = new SqlCommand();
            cmnd.Parameters.AddWithValue("@PriorityName", PriorityName.Replace("ی", "ي"));

            cmnd.CommandText = "Insert_MailPriority";

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

        public Boolean Check_PrimaryKey2(string PriorityName)
        {
            sda = new SqlDataAdapter("select * from Tbl_MailPriority where PriorityName = '" + PriorityName.Replace("ی", "ي") + "'", conn);

            try
            {
                dsmPriority.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmPriority.Tbl_MailPriority);
                if (dsmPriority.Tbl_MailPriority.Rows.Count == 0)
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




    }
}
