using System;
using System.Collections.Generic;
using System.Text;
using OCA.Common;
using System.Data;
using System.Data.SqlClient;

namespace OCA.DataAccess.BaseInformation
{
    public class Semat
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter sda;

        private string ConnectionString = "";

        OCA.Common.DataSets.BaseInformation.Semat dssemat = new OCA.Common.DataSets.BaseInformation.Semat();

        public Semat()
        {
            OCA.Common.Configuration config = new Configuration();
            ConnectionString = config.Connection_String;

            conn.ConnectionString = ConnectionString;
        }

        public OCA.Common.DataSets.BaseInformation.Semat IsExistSemat(string SematName)
        {
            sda = new SqlDataAdapter("SELECT * FROM Tbl_Semat WHERE SematName = '" + SematName.Replace("ی", "ي") + "'", conn);

            try
            {
                dssemat.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dssemat.Tbl_Semat);

                return dssemat;
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

        public OCA.Common.DataSets.BaseInformation.Semat IsExistSematGroup(string SematGroupName)
        {
            sda = new SqlDataAdapter("SELECT * FROM Tbl_SematGroup WHERE GroupName = '" + SematGroupName.Replace("ی", "ي") + "'", conn);

            try
            {
                dssemat.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dssemat.Tbl_SematGroup);

                return dssemat;
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

        public OCA.Common.DataSets.BaseInformation.Semat GetSemats()
        {
            sda = new SqlDataAdapter(" select * from Tbl_Semat ORDER BY SematID", conn);

            try
            {
                dssemat.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dssemat.Tbl_Semat);

                return dssemat;
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

        public OCA.Common.DataSets.BaseInformation.Semat GetSematGroups()
        {
            sda = new SqlDataAdapter(" select * from Tbl_SematGroup", conn);

            try
            {
                dssemat.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dssemat.Tbl_SematGroup);

                return dssemat;
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

        public OCA.Common.DataSets.BaseInformation.Semat GetSematGroup(string SematName)
        {
            sda = new SqlDataAdapter(" select * from Tbl_Semat where SematName = '" + SematName.Replace("ی", "ي") + "'", conn);

            try
            {
                dssemat.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dssemat.Tbl_Semat);

                return dssemat;
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

        public void InsertSemat(string SematName, string UpperSemat, string SematGroup)
        {
            if (Check_PrimaryKey(SematName)) throw new Exception("واحد" + " " + SematName + " " + "موجود است!");

            SqlCommand cmnd = new SqlCommand();
            cmnd.Parameters.AddWithValue("@SematName", SematName.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@UpperSemat", UpperSemat.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@SematGroup", SematGroup.Replace("ی", "ي"));

            cmnd.CommandText = "Insert_Semat";

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

        public Boolean Check_PrimaryKey(string SematName)
        {
            sda = new SqlDataAdapter("select * from Tbl_Semat where SematName = '" + SematName.Replace("ی", "ي") + "'", conn);

            try
            {
                dssemat.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dssemat.Tbl_Semat);
                if (dssemat.Tbl_Semat.Rows.Count == 0)
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

        public void EditSemat(string SematName, string newSematName, string newSematGroup)
        {
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;

                if (newSematGroup == "")
                    cmnd.CommandText = "UPDATE Tbl_Semat SET SematName = '" + newSematName.Replace("ی", "ي") + "', SematGroup = null  WHERE SematName = '" + SematName.Replace("ی", "ي") + "'";
                else
                    cmnd.CommandText = "UPDATE Tbl_Semat SET SematName = '" + newSematName.Replace("ی", "ي") + "', SematGroup = '" + newSematGroup.Replace("ی", "ي") + "'  WHERE SematName = '" + SematName.Replace("ی", "ي") + "'";

                cmnd.ExecuteNonQuery();

                cmnd.CommandText = "UPDATE Tbl_Semat SET UpperSemat = '" + newSematName.Replace("ی", "ي") + "' WHERE UpperSemat = '" + SematName.Replace("ی", "ي") + "'";
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

        public void EditSematGroup(string SematGroup, string newSematGroup)
        {
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;

                cmnd.CommandText = "UPDATE Tbl_SematGroup SET GroupName = '" + newSematGroup.Replace("ی", "ي") + "' WHERE GroupName = '" + SematGroup.Replace("ی", "ي") + "'";
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

        public void RemoveSemat(string SematName)
        {
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;
                cmnd.CommandText = "DELETE FROM Tbl_Semat WHERE SematName = '" + SematName.Replace("ی", "ي") + "'";
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

        public void RemoveSematGroup(string SematGroup)
        {
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;
                cmnd.CommandText = "DELETE FROM Tbl_SematGroup WHERE GroupName = '" + SematGroup.Replace("ی", "ي") + "'";
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

        public void InsertSematGroup(string SematGroup)
        {
            if (Check_PrimaryKey2(SematGroup)) throw new Exception("گروه" + " " + SematGroup + " " + "موجود است!");

            SqlCommand cmnd = new SqlCommand();
            cmnd.Parameters.AddWithValue("@SematGroup", SematGroup.Replace("ی", "ي"));

            cmnd.CommandText = "Insert_SematGroup";

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

        public Boolean Check_PrimaryKey2(string SematGroup)
        {
            sda = new SqlDataAdapter("select GroupName from Tbl_SematGroup where GroupName = '" + SematGroup.Replace("ی", "ي") + "'", conn);

            try
            {
                dssemat.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dssemat.Tbl_SematGroup);
                if (dssemat.Tbl_SematGroup.Rows.Count == 0)
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

        public Boolean IsSematExist(string SematName)
        {
            sda = new SqlDataAdapter("select * from Tbl_Semat where SematName = '" + SematName.Replace("ی", "ي") + "'", conn);

            try
            {
                dssemat.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dssemat.Tbl_Semat);
                if (dssemat.Tbl_Semat.Rows.Count == 0)
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
