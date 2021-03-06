using System;
using System.Collections.Generic;
using System.Text;
using OCA.Common;
using System.Data;
using System.Data.SqlClient;

namespace OCA.DataAccess.BaseInformation
{
    public class ExOffice
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter sda;

        private string ConnectionString = "";

        OCA.Common.DataSets.BaseInformation.ExOffice dsexoffice = new OCA.Common.DataSets.BaseInformation.ExOffice();

        public ExOffice()
        {
            OCA.Common.Configuration config = new Configuration();
            ConnectionString = config.Connection_String;

            conn.ConnectionString = ConnectionString;
        }

        public OCA.Common.DataSets.BaseInformation.ExOffice GetExOffice()
        {
            try
            {
                sda = new SqlDataAdapter("select * from Tbl_ExOffice", conn);

                dsexoffice.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsexoffice.Tbl_ExOffice);

                return dsexoffice;
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

        public OCA.Common.DataSets.BaseInformation.ExOffice SearchExOffice(string PersonName)
        {
            sda = new SqlDataAdapter(" SELECT * FROM Tbl_ExOffice WHERE PersonName LIKE '%" + PersonName.Replace("ی", "ي") + "%'", conn);

            try
            {
                dsexoffice.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsexoffice.Tbl_ExOffice);

                return dsexoffice;
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

        public void RemoveExOffice(string PersonName)
        {
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;
                cmnd.CommandText = "DELETE FROM Tbl_ExOffice WHERE PersonName = '" + PersonName.Replace("ی", "ي") + "'";
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

        public void UpdateExOffice(string PersonName, string PersonKind, string newPersonName, string Tel, string Fax,
            string Email, string Site, string Address)
        {
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;

                cmnd.CommandText = "UPDATE Tbl_ExOffice SET PersonKind = '" + PersonKind.Replace("ی", "ي") + "'," +
                    "PersonName = '" + newPersonName.Replace("ی", "ي") + "'," +
                    "Tel = '" + Tel.Replace("ی", "ي") + "'," +
                    "Fax = '" + Fax.Replace("ی", "ي") + "'," +
                    "Email = '" + Email.Replace("ی", "ي") + "'," +
                    "WebSite = '" + Site.Replace("ی", "ي") + "'," +
                    "Address_ = '" + Address.Replace("ی", "ي") + "' " +
                    "WHERE PersonName = '" + PersonName.Replace("ی", "ي") + "'";
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

        public void InsertExOffice(string PersonKind, string PersonName, string Tel, string Fax,string Email, string Site, string Address)
        {
            if (Check_PrimaryKey(PersonName)) throw new Exception("شخص" + " '" + PersonName + "' " + "موجود است!");

            SqlCommand cmnd = new SqlCommand();
            cmnd.Parameters.AddWithValue("@PersonKind", PersonKind.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@PersonName", PersonName.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Tel", Tel.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Fax", Fax.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Email", Email.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@WebSite", Site.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Address_", Address.Replace("ی", "ي"));

            cmnd.CommandText = "Insert_ExOffice";

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

        public Boolean Check_PrimaryKey(string PersonName)
        {
            sda = new SqlDataAdapter("select * from Tbl_ExOffice where PersonName = '" + PersonName.Replace("ی", "ي") + "'", conn);

            try
            {
                dsexoffice.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsexoffice.Tbl_ExOffice);
                if (dsexoffice.Tbl_ExOffice.Rows.Count == 0)
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
