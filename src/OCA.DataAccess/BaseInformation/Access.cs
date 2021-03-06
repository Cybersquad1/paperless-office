using System;
using System.Collections.Generic;
using System.Text;
using OCA.Common;
using System.Data;
using System.Data.SqlClient;

namespace OCA.DataAccess.BaseInformation
{
    public class Access
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter sda;

        private string ConnectionString = "";

        OCA.Common.DataSets.BaseInformation.Access dsaccess = new OCA.Common.DataSets.BaseInformation.Access();

        public Access()
        {
            OCA.Common.Configuration config = new Configuration();
            ConnectionString = config.Connection_String;

            conn.ConnectionString = ConnectionString;
        }

        public void InsertAccess(string AccessName, int CreateMail, int EditMail, int Draft, int MailInbox, int MailOutbox,
            int ReferMail, int ArchiveMail, int MailHistory, int SearchMail, int InsertParvandeh, int ViewParvandeh,
            int MsgInbox, int MsgOutbox, int SendMessage, int DeletedMessage, int InsertImportMail, int ViewImportMail,
            int InsertExportMail, int ViewExportMail, int ViewInternalMail, int DefineChart, int ViewChart, int CompanyInfo,
            int NewSemat, int EditSemat, int SematGroup, int NewAccess, int EditAccess2, int EditAccess, int NewClerk, 
            int EditClerk, int ClerkGroup, int NewExOffice, int EditExOffice, int NewAddress, int EditAddress, int MailNumber,
            int MailTopic, int MailCondition, int MailPriority, int MailSecurity, int ReferenceDescription, int ColorSetting,
            int FaxSetting, int PrinterSetting, int ScanerSetting, int EmailSetting, int BackUp, int NewReminder,
            int EditReminder, int NewNews, int EditNews, int TextComm, int VoiceComm, int VideoComm)
        {
            if (Check_PrimaryKey(AccessName)) throw new Exception("سطح دسترسی" + " " + AccessName + " " + "موجود است!");

            SqlCommand cmnd = new SqlCommand();
            cmnd.CommandText = "Insert_Access";

            cmnd.Parameters.AddWithValue("@AccessName", AccessName.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@CreateMail", CreateMail);
            cmnd.Parameters.AddWithValue("@EditMail", EditMail);
            cmnd.Parameters.AddWithValue("@Draft", Draft);
            cmnd.Parameters.AddWithValue("@MailInbox", MailInbox);
            cmnd.Parameters.AddWithValue("@MailOutbox", MailOutbox);
            cmnd.Parameters.AddWithValue("@ReferMail", ReferMail);
            cmnd.Parameters.AddWithValue("@ArchiveMail", ArchiveMail);
            cmnd.Parameters.AddWithValue("@MailHistory", MailHistory);
            cmnd.Parameters.AddWithValue("@SearchMail", SearchMail);
            cmnd.Parameters.AddWithValue("@InsertParvandeh", InsertParvandeh);
            cmnd.Parameters.AddWithValue("@ViewParvandeh", ViewParvandeh);
            cmnd.Parameters.AddWithValue("@MsgInbox", MsgInbox);
            cmnd.Parameters.AddWithValue("@MsgOutbox", MsgOutbox);
            cmnd.Parameters.AddWithValue("@SendMessage", SendMessage);
            cmnd.Parameters.AddWithValue("@DeletedMessage", DeletedMessage);
            cmnd.Parameters.AddWithValue("@InsertImportMail", InsertImportMail);
            cmnd.Parameters.AddWithValue("@ViewImportMail", ViewImportMail);
            cmnd.Parameters.AddWithValue("@InsertExportMail", InsertExportMail);
            cmnd.Parameters.AddWithValue("@ViewExportMail", ViewExportMail);
            cmnd.Parameters.AddWithValue("@ViewInternalMail", ViewInternalMail);
            cmnd.Parameters.AddWithValue("@DefineChart", DefineChart);
            cmnd.Parameters.AddWithValue("@ViewChart", ViewChart);
            cmnd.Parameters.AddWithValue("@CompanyInfo", CompanyInfo);
            cmnd.Parameters.AddWithValue("@NewSemat", NewSemat);
            cmnd.Parameters.AddWithValue("@EditSemat", EditSemat);
            cmnd.Parameters.AddWithValue("@SematGroup", SematGroup);
            cmnd.Parameters.AddWithValue("@NewAccess", NewAccess);
            cmnd.Parameters.AddWithValue("@EditAccess2", EditAccess2);
            cmnd.Parameters.AddWithValue("@EditAccess", EditAccess);
            cmnd.Parameters.AddWithValue("@NewClerk", NewClerk);
            cmnd.Parameters.AddWithValue("@EditClerk", EditClerk);
            cmnd.Parameters.AddWithValue("@ClerkGroup", ClerkGroup);
            cmnd.Parameters.AddWithValue("@NewExOffice", NewExOffice);
            cmnd.Parameters.AddWithValue("@EditExOffice", EditExOffice);
            cmnd.Parameters.AddWithValue("@NewAddress", NewAddress);
            cmnd.Parameters.AddWithValue("@EditAddress", EditAddress);
            cmnd.Parameters.AddWithValue("@MailNumber", MailNumber);
            cmnd.Parameters.AddWithValue("@MailTopic", MailTopic);
            cmnd.Parameters.AddWithValue("@MailCondition", MailCondition);
            cmnd.Parameters.AddWithValue("@MailPriority", MailPriority);
            cmnd.Parameters.AddWithValue("@MailSecurity", MailSecurity);
            cmnd.Parameters.AddWithValue("@ReferenceDescription", ReferenceDescription);
            cmnd.Parameters.AddWithValue("@ColorSetting", ColorSetting);
            cmnd.Parameters.AddWithValue("@FaxSetting", FaxSetting);
            cmnd.Parameters.AddWithValue("@PrinterSetting", PrinterSetting);
            cmnd.Parameters.AddWithValue("@ScanerSetting", ScanerSetting);
            cmnd.Parameters.AddWithValue("@EmailSetting", EmailSetting);
            cmnd.Parameters.AddWithValue("@Back_Up", BackUp);
            cmnd.Parameters.AddWithValue("@NewReminder", NewReminder);
            cmnd.Parameters.AddWithValue("@EditReminder", EditReminder);
            cmnd.Parameters.AddWithValue("@NewNews", NewNews);
            cmnd.Parameters.AddWithValue("@EditNews", EditNews);
            cmnd.Parameters.AddWithValue("@TextComm", TextComm);
            cmnd.Parameters.AddWithValue("@VoiceComm", VoiceComm);
            cmnd.Parameters.AddWithValue("@VideoComm", VideoComm);


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

        public void UpdateAccess(string AccessName, int CreateMail, int EditMail, int Draft, int MailInbox, int MailOutbox,
            int ReferMail, int ArchiveMail, int MailHistory, int SearchMail, int InsertParvandeh, int ViewParvandeh,
            int MsgInbox, int MsgOutbox, int SendMessage, int DeletedMessage, int InsertImportMail, int ViewImportMail,
            int InsertExportMail, int ViewExportMail, int ViewInternalMail, int DefineChart, int ViewChart, int CompanyInfo,
            int NewSemat, int EditSemat, int SematGroup, int NewAccess, int EditAccess2, int EditAccess, int NewClerk,
            int EditClerk, int ClerkGroup, int NewExOffice, int EditExOffice, int NewAddress, int EditAddress, int MailNumber,
            int MailTopic, int MailCondition, int MailPriority, int MailSecurity, int ReferenceDescription, int ColorSetting,
            int FaxSetting, int PrinterSetting, int ScanerSetting, int EmailSetting, int BackUp, int NewReminder,
            int EditReminder, int NewNews, int EditNews, int TextComm, int VoiceComm, int VideoComm)
        {
            SqlCommand cmnd = new SqlCommand();
            cmnd.CommandText = "Update_Access";

            cmnd.Parameters.AddWithValue("@AccessName", AccessName.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@CreateMail", CreateMail);
            cmnd.Parameters.AddWithValue("@EditMail", EditMail);
            cmnd.Parameters.AddWithValue("@Draft", Draft);
            cmnd.Parameters.AddWithValue("@MailInbox", MailInbox);
            cmnd.Parameters.AddWithValue("@MailOutbox", MailOutbox);
            cmnd.Parameters.AddWithValue("@ReferMail", ReferMail);
            cmnd.Parameters.AddWithValue("@ArchiveMail", ArchiveMail);
            cmnd.Parameters.AddWithValue("@MailHistory", MailHistory);
            cmnd.Parameters.AddWithValue("@SearchMail", SearchMail);
            cmnd.Parameters.AddWithValue("@InsertParvandeh", InsertParvandeh);
            cmnd.Parameters.AddWithValue("@ViewParvandeh", ViewParvandeh);
            cmnd.Parameters.AddWithValue("@MsgInbox", MsgInbox);
            cmnd.Parameters.AddWithValue("@MsgOutbox", MsgOutbox);
            cmnd.Parameters.AddWithValue("@SendMessage", SendMessage);
            cmnd.Parameters.AddWithValue("@DeletedMessage", DeletedMessage);
            cmnd.Parameters.AddWithValue("@InsertImportMail", InsertImportMail);
            cmnd.Parameters.AddWithValue("@ViewImportMail", ViewImportMail);
            cmnd.Parameters.AddWithValue("@InsertExportMail", InsertExportMail);
            cmnd.Parameters.AddWithValue("@ViewExportMail", ViewExportMail);
            cmnd.Parameters.AddWithValue("@ViewInternalMail", ViewInternalMail);
            cmnd.Parameters.AddWithValue("@DefineChart", DefineChart);
            cmnd.Parameters.AddWithValue("@ViewChart", ViewChart);
            cmnd.Parameters.AddWithValue("@CompanyInfo", CompanyInfo);
            cmnd.Parameters.AddWithValue("@NewSemat", NewSemat);
            cmnd.Parameters.AddWithValue("@EditSemat", EditSemat);
            cmnd.Parameters.AddWithValue("@SematGroup", SematGroup);
            cmnd.Parameters.AddWithValue("@NewAccess", NewAccess);
            cmnd.Parameters.AddWithValue("@EditAccess2", EditAccess2);
            cmnd.Parameters.AddWithValue("@EditAccess", EditAccess);
            cmnd.Parameters.AddWithValue("@NewClerk", NewClerk);
            cmnd.Parameters.AddWithValue("@EditClerk", EditClerk);
            cmnd.Parameters.AddWithValue("@ClerkGroup", ClerkGroup);
            cmnd.Parameters.AddWithValue("@NewExOffice", NewExOffice);
            cmnd.Parameters.AddWithValue("@EditExOffice", EditExOffice);
            cmnd.Parameters.AddWithValue("@NewAddress", NewAddress);
            cmnd.Parameters.AddWithValue("@EditAddress", EditAddress);
            cmnd.Parameters.AddWithValue("@MailNumber", MailNumber);
            cmnd.Parameters.AddWithValue("@MailTopic", MailTopic);
            cmnd.Parameters.AddWithValue("@MailCondition", MailCondition);
            cmnd.Parameters.AddWithValue("@MailPriority", MailPriority);
            cmnd.Parameters.AddWithValue("@MailSecurity", MailSecurity);
            cmnd.Parameters.AddWithValue("@ReferenceDescription", ReferenceDescription);
            cmnd.Parameters.AddWithValue("@ColorSetting", ColorSetting);
            cmnd.Parameters.AddWithValue("@FaxSetting", FaxSetting);
            cmnd.Parameters.AddWithValue("@PrinterSetting", PrinterSetting);
            cmnd.Parameters.AddWithValue("@ScanerSetting", ScanerSetting);
            cmnd.Parameters.AddWithValue("@EmailSetting", EmailSetting);
            cmnd.Parameters.AddWithValue("@Back_Up", BackUp);
            cmnd.Parameters.AddWithValue("@NewReminder", NewReminder);
            cmnd.Parameters.AddWithValue("@EditReminder", EditReminder);
            cmnd.Parameters.AddWithValue("@NewNews", NewNews);
            cmnd.Parameters.AddWithValue("@EditNews", EditNews);
            cmnd.Parameters.AddWithValue("@TextComm", TextComm);
            cmnd.Parameters.AddWithValue("@VoiceComm", VoiceComm);
            cmnd.Parameters.AddWithValue("@VideoComm", VideoComm);


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

        public Boolean Check_PrimaryKey(string AccessName)
        {
            sda = new SqlDataAdapter("select * from Tbl_Access where AccessName = '" + AccessName.Replace("ی", "ي") + "'", conn);

            try
            {
                dsaccess.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsaccess.Tbl_Access);
                if (dsaccess.Tbl_Access.Rows.Count == 0)
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

        public OCA.Common.DataSets.BaseInformation.Access GetAccess()
        {
            sda = new SqlDataAdapter(" select * from Tbl_Access", conn);

            try
            {
                dsaccess.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsaccess.Tbl_Access);

                return dsaccess;
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

        public OCA.Common.DataSets.BaseInformation.Access GetAccessByAccessname(string AccessName)
        {
            sda = new SqlDataAdapter(" select * from Tbl_Access WHERE AccessName= '" + AccessName + "'", conn);

            try
            {
                dsaccess.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsaccess.Tbl_Access);

                return dsaccess;
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

        public void UpdateAccess(string AccessName, string newAccessName)
        {
            if (Check_PrimaryKey(newAccessName)) throw new Exception("سطح دسترسی" + " " + newAccessName + " " + "موجود است!");

            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;

                cmnd.CommandText = "UPDATE Tbl_Access SET AccessName = '" + newAccessName.Replace("ی", "ي") + "' WHERE AccessName = '" + AccessName.Replace("ی", "ي") + "'";
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

        public void RemoveAccess(string AccessName)
        {
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;
                cmnd.CommandText = "DELETE FROM Tbl_Access WHERE AccessName = '" + AccessName.Replace("ی", "ي") + "'";
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

        public Boolean IsAccessExist(string AccessName)
        {
            sda = new SqlDataAdapter("select * from Tbl_Access where AccessName = '" + AccessName.Replace("ی", "ي") + "'", conn);

            try
            {
                dsaccess.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsaccess.Tbl_Access);
                if (dsaccess.Tbl_Access.Rows.Count == 0)
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
