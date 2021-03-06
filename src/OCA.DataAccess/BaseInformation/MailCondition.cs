using System;
using System.Collections.Generic;
using System.Text;
using OCA.Common;
using System.Data;
using System.Data.SqlClient;

namespace OCA.DataAccess.BaseInformation
{
    public class MailCondition
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter sda;

        private string ConnectionString = "";

        OCA.Common.DataSets.BaseInformation.MailCondition dsmCondition = new OCA.Common.DataSets.BaseInformation.MailCondition();

        public MailCondition()
        {
            OCA.Common.Configuration config = new Configuration();
            ConnectionString = config.Connection_String;

            conn.ConnectionString = ConnectionString;
        }

        public OCA.Common.DataSets.BaseInformation.MailCondition GetMailConditions()
        {
            sda = new SqlDataAdapter(" select * from Tbl_MailCondition", conn);

            try
            {
                dsmCondition.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmCondition.Tbl_MailCondition);

                return dsmCondition;
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

        public void EditMailCondition(string ConditionName, string newConditionName)
        {
            if (Check_PrimaryKey2(newConditionName)) throw new Exception("وضعیت نامه" + " " + newConditionName + " " + "موجود است!");
            
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;

                cmnd.CommandText = "UPDATE Tbl_MailCondition SET ConditionName = '" + newConditionName.Replace("ی", "ي") + "' WHERE ConditionName = '" + ConditionName.Replace("ی", "ي") + "'";
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

        public void RemoveMailCondition(string ConditionName)
        {
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;
                cmnd.CommandText = "DELETE FROM Tbl_MailCondition WHERE ConditionName = '" + ConditionName.Replace("ی", "ي") + "'";
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

        public void InsertMailCondition(string ConditionName)
        {
            if (Check_PrimaryKey2(ConditionName)) throw new Exception("وضعیت نامه" + " " + ConditionName + " " + "موجود است!");

            SqlCommand cmnd = new SqlCommand();
            cmnd.Parameters.AddWithValue("@ConditionName", ConditionName.Replace("ی", "ي"));

            cmnd.CommandText = "Insert_MailCondition";

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

        public Boolean Check_PrimaryKey2(string ConditionName)
        {
            sda = new SqlDataAdapter("select * from Tbl_MailCondition where ConditionName = '" + ConditionName.Replace("ی", "ي") + "'", conn);

            try
            {
                dsmCondition.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmCondition.Tbl_MailCondition);
                if (dsmCondition.Tbl_MailCondition.Rows.Count == 0)
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
