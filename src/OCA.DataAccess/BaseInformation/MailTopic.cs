using System;
using System.Collections.Generic;
using System.Text;
using OCA.Common;
using System.Data;
using System.Data.SqlClient;

namespace OCA.DataAccess.BaseInformation
{
    public class MailTopic
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter sda;

        private string ConnectionString = "";

        OCA.Common.DataSets.BaseInformation.MailTopic dsmTopic = new OCA.Common.DataSets.BaseInformation.MailTopic();

        public MailTopic()
        {
            OCA.Common.Configuration config = new Configuration();
            ConnectionString = config.Connection_String;

            conn.ConnectionString = ConnectionString;
        }

        public OCA.Common.DataSets.BaseInformation.MailTopic GetMailTopics()
        {
            sda = new SqlDataAdapter("select * from Tbl_MailTopic", conn);

            try
            {
                dsmTopic.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmTopic.Tbl_MailTopic);

                return dsmTopic;
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

        public void EditMailTopic(string TopicName, string newTopicName)
        {
            if (Check_PrimaryKey2(newTopicName)) throw new Exception("موضوع نامه" + " " + newTopicName + " " + "موجود است!");

            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;

                cmnd.CommandText = "UPDATE Tbl_MailTopic SET TopicName = '" + newTopicName.Replace("ی", "ي") + "' WHERE TopicName = '" + TopicName.Replace("ی", "ي") + "'";
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

        public void RemoveMailTopic(string TopicName)
        {
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;
                cmnd.CommandText = "DELETE FROM Tbl_MailTopic WHERE TopicName = '" + TopicName.Replace("ی", "ي") + "'";
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

        public void InsertMailTopic(string TopicName)
        {
            if (Check_PrimaryKey2(TopicName)) throw new Exception("موضوع نامه" + " " + TopicName + " " + "موجود است!");

            SqlCommand cmnd = new SqlCommand();
            cmnd.Parameters.AddWithValue("@TopicName", TopicName.Replace("ی", "ي"));

            cmnd.CommandText = "Insert_MailTopic";

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

        public Boolean Check_PrimaryKey2(string TopicName)
        {
            sda = new SqlDataAdapter("select * from Tbl_MailTopic where TopicName = '" + TopicName.Replace("ی", "ي") + "'", conn);

            try
            {
                dsmTopic.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmTopic.Tbl_MailTopic);
                if (dsmTopic.Tbl_MailTopic.Rows.Count == 0)
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
