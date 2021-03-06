using System;
using System.Collections.Generic;
using System.Text;
using OCA.Common;
using System.Data;
using System.Data.SqlClient;

namespace OCA.DataAccess.Kartabl
{
    public class MessageBox
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter sda;

        private string ConnectionString = "";

        OCA.Common.DataSets.Kartabl.MessageBox dsmessage = new OCA.Common.DataSets.Kartabl.MessageBox();

        public MessageBox()
        {
            OCA.Common.Configuration config = new Configuration();
            ConnectionString = config.Connection_String;

            conn.ConnectionString = ConnectionString;
        }

        public void InsertMessage(string Message_Date, string Message_Name, string Owner_User, string Sender_User, string Sender_Name, string Receiver_User, string Receiver_Name, string Message_Text)
        {
            SqlCommand cmnd = new SqlCommand();
            cmnd.Parameters.AddWithValue("@Message_Date", Message_Date.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Message_Name", Message_Name.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Owner_User", Owner_User.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Sender_User", Sender_User.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Sender_Name", Sender_Name.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Receiver_User", Receiver_User.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Receiver_Name", Receiver_Name.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Message_Text", Message_Text.Replace("ی", "ي"));

            cmnd.CommandText = "Insert_Message";

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

        public OCA.Common.DataSets.Kartabl.MessageBox GetReceivedMessages(string Username)
        {
            sda = new SqlDataAdapter(" select * from Tbl_MessageBox WHERE Receiver_User = '" + Username.Replace("ی", "ي") + "' and Owner_User = '" + Username + "' ORDER BY Message_Num DESC", conn);

            try
            {
                dsmessage.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmessage.Tbl_MessageBox);

                return dsmessage;
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

        public OCA.Common.DataSets.Kartabl.MessageBox GetSendedMessages(string Username)
        {
            sda = new SqlDataAdapter(" select * from Tbl_MessageBox WHERE Sender_User = '" + Username.Replace("ی", "ي") + "' and Owner_User = '" + Username + "' ORDER BY Message_Num DESC", conn);

            try
            {
                dsmessage.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmessage.Tbl_MessageBox);

                return dsmessage;
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

        public void RemoveMessage(string Message_Num)
        {
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;
                cmnd.CommandText = "DELETE FROM Tbl_MessageBox WHERE Message_Num = " + Message_Num.Replace("ی", "ي");
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

        public void Update_MessageColumn(string ColumnName, string OldValue, string NewValue)
        {
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;

                cmnd.CommandText = "UPDATE Tbl_MessageBox SET " + ColumnName + " = '" + NewValue.Replace("ی", "ي") + "' WHERE " + ColumnName + " = '" + OldValue.Replace("ی", "ي") + "'";
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
