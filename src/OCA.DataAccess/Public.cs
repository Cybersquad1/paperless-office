using System;
using System.Collections.Generic;
using System.Text;
using OCA.Common;
using System.Data;
using System.Data.SqlClient;


namespace OCA.DataAccess
{
    public class Public
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter sda;

        OCA.Common.DataSets.Public dspub = new OCA.Common.DataSets.Public();
        OCA.Common.DataSets.BaseInformation.Clerk dsclerk = new OCA.Common.DataSets.BaseInformation.Clerk();

        private string ConnectionString = "";

        public Public()
        {
            OCA.Common.Configuration config = new Configuration();
            ConnectionString = config.Connection_String;

            conn.ConnectionString = ConnectionString;
        }

        public void UpdateTbl_Unit(string OrganName)
        {
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;
                cmnd.CommandText = "UPDATE Tbl_Unit SET UpperUnit = '" + OrganName.Replace("ی", "ي") + "' WHERE UpperUnit = (SELECT UnitName FROM Tbl_Unit WHERE UpperUnit is null)";
                cmnd.ExecuteNonQuery();

                cmnd.CommandText = "UPDATE Tbl_Unit SET UnitName = '" + OrganName.Replace("ی", "ي") + "' WHERE UpperUnit is null";
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

        public void UpdateCompanyInfo(string OrganName, string tel1, string tel2, string tel3, string fax1, string fax2, string address1, string address2, byte[] ImageBuffer)
        {
            UpdateTbl_Unit(OrganName);

            SqlCommand cmnd = new SqlCommand();
            cmnd.Parameters.AddWithValue("@OrganName", OrganName.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@tel1", tel1);
            cmnd.Parameters.AddWithValue("@tel2", tel2);
            cmnd.Parameters.AddWithValue("@tel3", tel3);
            cmnd.Parameters.AddWithValue("@fax1", fax1);
            cmnd.Parameters.AddWithValue("@fax2", fax2);
            cmnd.Parameters.AddWithValue("@address1", address1);
            cmnd.Parameters.AddWithValue("@address2", address2);

            if (ImageBuffer != null)
            {
                cmnd.Parameters.AddWithValue("@logopic", ImageBuffer);
                cmnd.CommandText = "Update_Organiztion";
            }
            else
                cmnd.CommandText = "Update_Organiztion_withoutPhoto";            

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

        public OCA.Common.DataSets.Public GetCompanyInfo()
        {
            sda = new SqlDataAdapter(" select * from Tbl_Organiztion where OrgID = 1", conn);

            try
            {
                dspub.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dspub.Tbl_Organiztion);

                return dspub;
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

        public OCA.Common.DataSets.BaseInformation.Clerk IsUserValid(string Username, string Password)
        {
            sda = new SqlDataAdapter(" select * from Tbl_Clerk where Username ='" + Username.Replace("ی", "ي") + "' and Pass ='" + Password.Replace("ی", "ي") + "'", conn);

            try
            {
                dspub.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsclerk.Tbl_Clerk);

                return dsclerk;
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
