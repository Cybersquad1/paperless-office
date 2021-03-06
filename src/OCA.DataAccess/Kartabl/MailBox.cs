using System;
using System.Collections.Generic;
using System.Text;
using OCA.Common;
using System.Data;
using System.Data.SqlClient;

namespace OCA.DataAccess.Kartabl
{
    public class MailBox
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter sda;

        private string ConnectionString = "";

        OCA.Common.DataSets.Kartabl.MailBox dsmail = new OCA.Common.DataSets.Kartabl.MailBox();
        OCA.Common.DataSets.Kartabl.Attach dsattach = new OCA.Common.DataSets.Kartabl.Attach();

        public MailBox()
        {
            OCA.Common.Configuration config = new Configuration();
            ConnectionString = config.Connection_String;

            conn.ConnectionString = ConnectionString;
        }

        public void InsertDraft(string Draft_User, string Draft_Name, string Draft_Text)
        {
            if (Check_PrimaryKeyDraft(Draft_User, Draft_Name)) throw new Exception("پیش نویس" + " " + Draft_Name + " " + "موجود است!");

            SqlCommand cmnd = new SqlCommand();
            cmnd.Parameters.AddWithValue("@Draft_User", Draft_User.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Draft_Name", Draft_Name.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Draft_Text", Draft_Text.Replace("ی", "ي"));

            cmnd.CommandText = "Insert_Draft";

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

        public Boolean Check_PrimaryKeyDraft(string Draft_User, string Draft_Name)
        {
            sda = new SqlDataAdapter("select * from Tbl_Draft where Draft_User = '" + Draft_User.Replace("ی", "ي") + "' and Draft_Name = '" + Draft_Name.Replace("ی", "ي") + "'", conn);

            try
            {
                dsmail.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmail.Tbl_Draft);
                if (dsmail.Tbl_Draft.Rows.Count == 0)
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

        public OCA.Common.DataSets.Kartabl.MailBox GetDrafts(string Username)
        {
            sda = new SqlDataAdapter(" select * from Tbl_Draft WHERE Draft_User = '" + Username.Replace("ی", "ي") + "'", conn);

            try
            {
                dsmail.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmail.Tbl_Draft);

                return dsmail;
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

        public void RemoveDraft(string Draft_User, string Draft_Name)
        {
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;
                cmnd.CommandText = "DELETE FROM Tbl_Draft WHERE Draft_User = '" + Draft_User.Replace("ی", "ي") + "' and Draft_Name = '" + Draft_Name.Replace("ی", "ي") + "'";
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

        public OCA.Common.DataSets.Kartabl.MailBox SearchDraft(string Username , string SearchWord)
        {
            sda = new SqlDataAdapter(" SELECT * FROM Tbl_Draft WHERE Draft_Name LIKE '%" + SearchWord.Replace("ی", "ي") + "%' and Draft_User = '" + Username.Replace("ی", "ي") + "'", conn);

            try
            {
                dsmail.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmail.Tbl_Draft);

                return dsmail;
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

        public OCA.Common.DataSets.Kartabl.MailBox GetMails(string Owner_Username)
        {
            sda = new SqlDataAdapter(" select * from Tbl_MailBox WHERE Mail_Owner_User = '" + Owner_Username.Replace("ی", "ي") + "'", conn);

            try
            {
                dsmail.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmail.Tbl_MailBox);

                return dsmail;
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

        public OCA.Common.DataSets.Kartabl.MailBox SearchMailProgress(string SearchWord)
        {
            sda = new SqlDataAdapter(" select * from Tbl_MailBox WHERE Mail_Name LIKE '%" + SearchWord.Replace("ی", "ي") + "%' and Sender_User = Mail_Owner_User", conn);

            try
            {
                dsmail.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmail.Tbl_MailBox);

                return dsmail;
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

        public OCA.Common.DataSets.Kartabl.MailBox GetAllMails()
        {
            sda = new SqlDataAdapter(" select * from Tbl_MailBox where Sender_User = Mail_Owner_User", conn);

            try
            {
                dsmail.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmail.Tbl_MailBox);

                return dsmail;
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

        public Boolean IsMailExist(string MailName)
        {
            sda = new SqlDataAdapter("select * from Tbl_MailBox where Mail_Name = '" + MailName.Replace("ی", "ي") + "'", conn);

            try
            {
                dsmail.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmail.Tbl_MailBox);
                if (dsmail.Tbl_MailBox.Rows.Count == 0)
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

        public void InsertMail(string Mail_Date, string Mail_Owner_User, string Owner_Name, string Mail_Name, string Sender_User, string Sender_Name, string Receiver_User, string Receiver_Name, string Mail_Topic, string Mail_Priority, string Mail_Security, string Mail_Condition, string Refer_Description, string Mail_Text, string Mail_SignerName, byte[] Mail_Sign)
        {
            SqlCommand cmnd = new SqlCommand();
            cmnd.Parameters.AddWithValue("@Mail_Date", Mail_Date.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Mail_Owner_User", Mail_Owner_User.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Owner_Name", Owner_Name.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Mail_Name", Mail_Name.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Sender_User", Sender_User.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Sender_Name", Sender_Name.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Receiver_User", Receiver_User.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Receiver_Name", Receiver_Name.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Mail_Topic", Mail_Topic.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Mail_Priority", Mail_Priority.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Mail_Security", Mail_Security.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Mail_Condition", Mail_Condition.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Refer_Description", Refer_Description);
            cmnd.Parameters.AddWithValue("@Mail_Text", Mail_Text);
            cmnd.Parameters.AddWithValue("@Mail_SignerName", Mail_SignerName.Replace("ی", "ي"));
            if (Mail_Sign != null)
                cmnd.Parameters.AddWithValue("@Mail_Sign", Mail_Sign);

            cmnd.CommandText = "Insert_Mail";

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

        public decimal GetMailNum(string Owner_Username, string MailName, string Sender_Username, string Receiver_Username)
        {
            sda = new SqlDataAdapter("select * from Tbl_MailBox where Mail_Owner_User ='" +
                Owner_Username.Replace("ی", "ي") + "' and Mail_Name = '" + MailName.Replace("ی", "ي") +
                "' and Sender_User = '" + Sender_Username.Replace("ی", "ي") + "' and Receiver_User = '" +
                Receiver_Username.Replace("ی", "ي") + "'", conn);

            try
            {
                dsmail.Clear();
                sda.Fill(dsmail.Tbl_MailBox);

                return dsmail.Tbl_MailBox[0].Mail_Num;
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

        public void InsertAttach(string Mail_Num, string Attach_Name, string Attach_Kind, byte[] Attach_File)
        {
            SqlCommand cmnd = new SqlCommand();
            cmnd.Parameters.AddWithValue("@Mail_Num", Mail_Num.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Attach_Name", Attach_Name.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Attach_Kind", Attach_Kind.Replace("ی", "ي"));
            if (Attach_File != null)
                cmnd.Parameters.AddWithValue("@Attach_File", Attach_File);

            cmnd.CommandText = "Insert_Attach";

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

        public OCA.Common.DataSets.Kartabl.MailBox GetReceivedMails(string Username)
        {
            sda = new SqlDataAdapter(" select * from Tbl_MailBox WHERE Receiver_User = '" + Username.Replace("ی", "ي") + "' and Mail_Owner_User = '" + Username + "' and Mail_Archive = 0 ORDER BY Mail_Num DESC", conn);

            try
            {
                dsmail.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmail.Tbl_MailBox);

                return dsmail;
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

        public OCA.Common.DataSets.Kartabl.MailBox GetSendedMails(string Username)
        {
            sda = new SqlDataAdapter(" select * from Tbl_MailBox WHERE Sender_User = '" + Username.Replace("ی", "ي") + "' and Mail_Owner_User = '" + Username + "' and Mail_Archive = 0 ORDER BY Mail_Num DESC", conn);

            try
            {
                dsmail.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmail.Tbl_MailBox);

                return dsmail;
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

        public OCA.Common.DataSets.Kartabl.MailBox GetArchivedMails(string Username)
        {
            sda = new SqlDataAdapter(" select * from Tbl_MailBox WHERE Mail_Owner_User = '" + Username + "' and Mail_Archive = 1 ORDER BY Mail_Num DESC", conn);

            try
            {
                dsmail.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmail.Tbl_MailBox);

                return dsmail;
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

        public OCA.Common.DataSets.Kartabl.MailBox GetInternalMails()
        {
            sda = new SqlDataAdapter(" select * from Viw_InternalMailBox where Mail_Owner_User = Sender_User", conn);

            try
            {
                dsmail.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmail.Tbl_MailBox);

                return dsmail;
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

        public OCA.Common.DataSets.Kartabl.MailBox GetReceivedDabirkhanehMails()
        {
            sda = new SqlDataAdapter(" select * from Viw_ImportMailBox WHERE Mail_Owner_User = 'دبيرخانه' ORDER BY Mail_Num DESC", conn);

            try
            {
                dsmail.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmail.Tbl_MailBox);

                return dsmail;
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

        public OCA.Common.DataSets.Kartabl.MailBox GetSendedDabirkhanehMails()
        {
            sda = new SqlDataAdapter(" select * from Viw_ExportMailBox WHERE Mail_Owner_User = 'دبيرخانه' ORDER BY Mail_Num DESC", conn);

            try
            {
                dsmail.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmail.Tbl_MailBox);

                return dsmail;
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

        public OCA.Common.DataSets.Kartabl.Attach GetAttaches(string Mail_Num)
        {
            sda = new SqlDataAdapter(" select * from Tbl_Attach WHERE Mail_Num = " + Mail_Num.Replace("ی", "ي") , conn);

            try
            {
                dsattach.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsattach.Tbl_Attach);

                return dsattach;
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

        public void RemoveAttach(string Mail_Num)
        {
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;
                cmnd.CommandText = "DELETE FROM Tbl_Attach WHERE Mail_Num = " + Mail_Num.Replace("ی", "ي");
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

        public void RemoveMail(string Mail_Num)
        {
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;
                cmnd.CommandText = "DELETE FROM Tbl_MailBox WHERE Mail_Num = " + Mail_Num.Replace("ی", "ي");
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

        public OCA.Common.DataSets.Kartabl.MailBox SearchReceivedMail(string Username , string SearchWord)
        {
            sda = new SqlDataAdapter(" SELECT * FROM Tbl_MailBox WHERE Mail_Name LIKE '%" + SearchWord.Replace("ی", "ي") + "%' and Mail_Owner_User = '" + Username.Replace("ی", "ي") + "' and Receiver_User ='" + Username.Replace("ی", "ي") + "' and Mail_Archive = 0 ORDER BY Mail_Num DESC", conn);

            try
            {
                dsmail.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmail.Tbl_MailBox);

                return dsmail;
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

        public OCA.Common.DataSets.Kartabl.MailBox SearchReceivedDabirkhanehMail(string SearchWord)
        {
            sda = new SqlDataAdapter(" SELECT * FROM Viw_ImportMailBox WHERE Mail_Name LIKE '%" + SearchWord.Replace("ی", "ي") + "%' and Mail_Owner_User = 'دبيرخانه' ORDER BY Mail_Num DESC", conn);

            try
            {
                dsmail.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmail.Tbl_MailBox);

                return dsmail;
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

        public OCA.Common.DataSets.Kartabl.MailBox SearchSendedDabirkhanehMail(string SearchWord)
        {
            sda = new SqlDataAdapter(" SELECT * FROM Viw_ExportMailBox WHERE Mail_Name LIKE '%" + SearchWord.Replace("ی", "ي") + "%' and Mail_Owner_User = 'دبيرخانه' ORDER BY Mail_Num DESC", conn);

            try
            {
                dsmail.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmail.Tbl_MailBox);

                return dsmail;
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

        public OCA.Common.DataSets.Kartabl.MailBox SearchSendedMail(string Username, string SearchWord)
        {
            sda = new SqlDataAdapter(" SELECT * FROM Tbl_MailBox WHERE Mail_Name LIKE '%" + SearchWord.Replace("ی", "ي") + "%' and Mail_Owner_User = '" + Username.Replace("ی", "ي") + "' and Sender_User ='" + Username.Replace("ی", "ي") + "' and Mail_Archive = 0 ORDER BY Mail_Num DESC", conn);

            try
            {
                dsmail.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmail.Tbl_MailBox);

                return dsmail;
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

        public OCA.Common.DataSets.Kartabl.MailBox SearchArchivedMail(string SearchKind, string Username, string SearchWord)
        {
            sda = new SqlDataAdapter(" SELECT * FROM Tbl_MailBox WHERE " + SearchKind.Replace("ی", "ي") + " LIKE '%" + SearchWord.Replace("ی", "ي") + "%' and Mail_Owner_User = '" + Username.Replace("ی", "ي") + "' and Mail_Archive = 1 ORDER BY Mail_Num DESC", conn);

            try
            {
                dsmail.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmail.Tbl_MailBox);

                return dsmail;
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

        public OCA.Common.DataSets.Kartabl.MailBox SearchAllMail(string SearchKind, string SearchWord)
        {
            sda = new SqlDataAdapter(" SELECT * FROM Tbl_MailBox WHERE " + SearchKind.Replace("ی", "ي") + " LIKE '%" + SearchWord.Replace("ی", "ي") + "%' and Sender_User = Mail_Owner_User", conn);

            try
            {
                dsmail.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmail.Tbl_MailBox);

                return dsmail;
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

        public OCA.Common.DataSets.Kartabl.MailBox SearchInternalMail(string SearchKind, string SearchWord)
        {
            sda = new SqlDataAdapter(" SELECT * FROM Viw_InternalMailBox WHERE " + SearchKind.Replace("ی", "ي") + " LIKE '%" + SearchWord.Replace("ی", "ي") + "%' and Sender_User = Mail_Owner_User", conn);

            try
            {
                dsmail.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmail.Tbl_MailBox);

                return dsmail;
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

        public void MakeArchiveMail(string Mail_Num)
        {
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;
                cmnd.CommandText = "UPDATE Tbl_MailBox SET Mail_Archive = 1 WHERE Mail_Num = " + Mail_Num.Replace("ی", "ي");
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

        public void SetParvandehMail(string Mail_Num, string ParvandehName)
        {
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;
                cmnd.CommandText = "UPDATE Tbl_MailBox SET Mail_Parvandeh = '" + ParvandehName.Replace("ی", "ي") + "' WHERE Mail_Num = " + Mail_Num.Replace("ی", "ي");
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

        public OCA.Common.DataSets.Kartabl.MailBox GetReportMailByMailNum(string Mail_Num)
        {
            sda = new SqlDataAdapter(" select * from Tbl_MailBox WHERE Mail_Num = " + Mail_Num.Replace("ی", "ي") , conn);

            try
            {
                dsmail.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsmail.Tbl_MailBox);

                return dsmail;
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

        public OCA.Common.DataSets.Kartabl.Attach GetAttachesByName(string Attach_Name, string Mail_Num)
        {
            sda = new SqlDataAdapter(" select * from Tbl_Attach WHERE Mail_Num = " + Mail_Num.Replace("ی", "ي") + " and RTRIM(Attach_Kind) = 'File' and Attach_Name = '" + Attach_Name.Replace("ی", "ي") + "'", conn);

            try
            {
                dsattach.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsattach.Tbl_Attach);

                return dsattach;
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

        public void Update_Mail(string Mail_Num, string Mail_Date, string Mail_Topic, string Mail_Priority,
            string Mail_Security, string Mail_Condition, string Mail_Text, string Mail_SignerName)
        {
            SqlCommand cmnd = new SqlCommand();
            cmnd.Parameters.AddWithValue("@Mail_Num", Mail_Num.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Mail_Date", Mail_Date.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Mail_Topic", Mail_Topic.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Mail_Priority", Mail_Priority.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Mail_Security", Mail_Security.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Mail_Condition", Mail_Condition.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Mail_Text", Mail_Text.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Mail_SignerName", Mail_SignerName.Replace("ی", "ي"));

            cmnd.CommandText = "Update_Mail";

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

        public void Update_MailSign(string Mail_Num, byte[] Mail_Sign)
        {
            SqlCommand cmnd = new SqlCommand();
            cmnd.Parameters.AddWithValue("@Mail_Num", Mail_Num.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Mail_Sign", Mail_Sign);

            cmnd.CommandText = "Update_MailSign";

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
  
        public void Update_MailColumn(string ColumnName, string OldValue, string NewValue)
        {
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;

                cmnd.CommandText = "UPDATE Tbl_MailBox SET " + ColumnName + " = '" + NewValue.Replace("ی", "ي") + "' WHERE " + ColumnName + " = '" + OldValue.Replace("ی", "ي") + "'";
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
