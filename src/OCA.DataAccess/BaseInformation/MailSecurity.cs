using System;
using System.Collections.Generic;
using System.Text;
using OCA.Common;
using System.Data;
using System.Data.SqlClient;

namespace OCA.DataAccess.BaseInformation
{
    public class MailSecurity
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter sda;

        private string ConnectionString = "";

        OCA.Common.DataSets.BaseInformation.MailSecurity dsmSecurity = new OCA.Common.DataSets.BaseInformation.MailSecurity();

        public MailSecurity()
        {
            OCA.Common.Configuration config = new Configuration();
            ConnectionString = config.Connection_String;

            conn.ConnectionString = ConnectionString;
        }

        public OCA.Common.DataSets.BaseInformation.MailSecurity GetMailSecuritys()
        {
            sda = new SqlDataAdapter(" select * from Tbl_MailSecurity", conn);

            try
            {
                dsmSecurity.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmSecurity.Tbl_MailSecurity);

                return dsmSecurity;
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

        public void EditMailSecurity(string SecurityName, string newSecurityName)
        {
            if (Check_PrimaryKey2(newSecurityName)) throw new Exception("نوع امنیت نامه" + " " + newSecurityName + " " + "موجود است!");

            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;

                cmnd.CommandText = "UPDATE Tbl_MailSecurity SET SecurityName = '" + newSecurityName.Replace("ی", "ي") + "' WHERE SecurityName = '" + SecurityName.Replace("ی", "ي") + "'";
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

        public void RemoveMailSecurity(string SecurityName)
        {
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;
                cmnd.CommandText = "DELETE FROM Tbl_MailSecurity WHERE SecurityName = '" + SecurityName.Replace("ی", "ي") + "'";
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

        public void InsertMailSecurity(string SecurityName)
        {
            if (Check_PrimaryKey2(SecurityName)) throw new Exception("نوع امنیت نامه" + " " + SecurityName + " " + "موجود است!");

            SqlCommand cmnd = new SqlCommand();
            cmnd.Parameters.AddWithValue("@SecurityName", SecurityName.Replace("ی", "ي"));

            cmnd.CommandText = "Insert_MailSecurity";

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

        public Boolean Check_PrimaryKey2(string SecurityName)
        {
            sda = new SqlDataAdapter("select * from Tbl_MailSecurity where SecurityName = '" + SecurityName.Replace("ی", "ي") + "'", conn);

            try
            {
                dsmSecurity.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmSecurity.Tbl_MailSecurity);
                if (dsmSecurity.Tbl_MailSecurity.Rows.Count == 0)
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
