using System;
using System.Collections.Generic;
using System.Text;
using OCA.Common;
using System.Data;
using System.Data.SqlClient;

namespace OCA.DataAccess.BaseInformation
{
    public class Clerk
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter sda;

        private string ConnectionString = "";

        OCA.Common.DataSets.BaseInformation.Clerk dsclerk = new OCA.Common.DataSets.BaseInformation.Clerk();

        public Clerk()
        {
            OCA.Common.Configuration config = new Configuration();
            ConnectionString = config.Connection_String;

            conn.ConnectionString = ConnectionString;
        }

        public string GetAccessNameByUsername(string Username)
        {
            try
            {
                sda = new SqlDataAdapter(" select * from Tbl_Clerk WHERE Username = '" + Username + "'", conn);

                dsclerk.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsclerk.Tbl_Clerk);

                return dsclerk.Tbl_Clerk[0].Access;
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

        public OCA.Common.DataSets.BaseInformation.Clerk GetNameByUsername(string Username)
        {
            try
            {
                sda = new SqlDataAdapter(" select * from Tbl_Clerk WHERE Username = '" + Username + "'", conn);

                dsclerk.Clear();

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

        public OCA.Common.DataSets.BaseInformation.Clerk GetClerks()
        {
            try
            {
                sda = new SqlDataAdapter("select * from Tbl_Clerk", conn);

                dsclerk.Clear();

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

        public OCA.Common.DataSets.BaseInformation.Clerk GetClerkByUsername(string Username)
        {
            try
            {
                sda = new SqlDataAdapter("select * from Tbl_Clerk where Username = '" + Username.Replace("ی", "ي") + "'", conn);

                dsclerk.Clear();

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

        public void InsertClerk(string Name, string Family, string Username, string Password, string ClerkGroup, string Access, string Semat, string Unit)
        {
            if (Check_PrimaryKey(Username)) throw new Exception("نام کاربری" + " '" + Username + "' " + "موجود است!");

            SqlCommand cmnd = new SqlCommand();
            cmnd.Parameters.AddWithValue("@Name", Name.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Family", Family.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Username", Username.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Password", Password.Replace("ی", "ي"));
            if (ClerkGroup != "")
                cmnd.Parameters.AddWithValue("@ClerkGroup", ClerkGroup.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Access", Access.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Semat", Semat.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@Unit", Unit.Replace("ی", "ي"));

            cmnd.CommandText = "Insert_Clerk";

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

        public Boolean Check_PrimaryKey(string Username)
        {
            sda = new SqlDataAdapter("select * from Tbl_Clerk where Username = '" + Username.Replace("ی", "ي") + "'", conn);

            try
            {
                dsclerk.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsclerk.Tbl_Clerk);
                if (dsclerk.Tbl_Clerk.Rows.Count == 0)
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

        public OCA.Common.DataSets.BaseInformation.Clerk GetClerkGroups()
        {
            sda = new SqlDataAdapter(" select * from Tbl_ClerkGroup", conn);

            try
            {
                dsclerk.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsclerk.Tbl_ClerkGroup);

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

        public void EditClerkGroup(string ClerkGroup, string newClerkGroup)
        {
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;

                cmnd.CommandText = "UPDATE Tbl_ClerkGroup SET GroupName = '" + newClerkGroup.Replace("ی", "ي") + "' WHERE GroupName = '" + ClerkGroup.Replace("ی", "ي") + "'";
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

        public void RemoveClerkGroup(string ClerkGroup)
        {
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;
                cmnd.CommandText = "DELETE FROM Tbl_ClerkGroup WHERE GroupName = '" + ClerkGroup.Replace("ی", "ي") + "'";
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

        public void InsertClerkGroup(string ClerkGroup)
        {
            if (Check_PrimaryKey2(ClerkGroup)) throw new Exception("گروه" + " " + ClerkGroup + " " + "موجود است!");

            SqlCommand cmnd = new SqlCommand();
            cmnd.Parameters.AddWithValue("@ClerkGroup", ClerkGroup.Replace("ی", "ي"));

            cmnd.CommandText = "Insert_ClerkGroup";

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

        public Boolean Check_PrimaryKey2(string ClerkGroup)
        {
            sda = new SqlDataAdapter("select GroupName from Tbl_ClerkGroup where GroupName = '" + ClerkGroup.Replace("ی", "ي") + "'", conn);

            try
            {
                dsclerk.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsclerk.Tbl_ClerkGroup);
                if (dsclerk.Tbl_ClerkGroup.Rows.Count == 0)
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

        public void UpdateClerk(string Username, string newUsername, string Name, string Family, string Password,
            string ClerkGroup, string Access, string Semat, string Unit)
        {
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;

                cmnd.CommandText = "UPDATE Tbl_Clerk SET Name_ = '" + Name.Replace("ی", "ي") + "'," +
                    "Family = '" + Family.Replace("ی", "ي") + "'," +
                    "Username = '" + newUsername.Replace("ی", "ي") + "'," +
                    "Pass = '" + Password.Replace("ی", "ي") + "'," +
                    "ClerkGroup = '" + ClerkGroup.Replace("ی", "ي") + "'," +
                    "Access = '" + Access.Replace("ی", "ي") + "'," +
                    "Semat = '" + Semat.Replace("ی", "ي") + "'," +
                    "Unit = '" + Unit.Replace("ی", "ي") + "' " +
                    "WHERE Username = '" + Username.Replace("ی", "ي") + "'";
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

        public void RemoveClerk(string Username)
        {
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;
                cmnd.CommandText = "DELETE FROM Tbl_Clerk WHERE Username = '" + Username.Replace("ی", "ي") + "'";
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

        public OCA.Common.DataSets.BaseInformation.Clerk SearchClerk(string SearchKind, string SearchWord)
        {
            sda = new SqlDataAdapter(" SELECT * FROM Tbl_Clerk WHERE " + SearchKind.Replace("ی", "ي") + " LIKE '%" + SearchWord.Replace("ی", "ي") + "%'", conn);

            try
            {
                dsclerk.Clear();

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

        public void UpdateClerkAcount(string Username, string Password, string Sex, string Age, string Tel, string Mobile, string Expert, string Email, string Address)
        {
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;

                cmnd.Parameters.AddWithValue("@Pass", Password.Replace("ی", "ي"));
                cmnd.Parameters.AddWithValue("@Sex", Sex.Replace("ی", "ي"));
                cmnd.Parameters.AddWithValue("@Age", Age);
                cmnd.Parameters.AddWithValue("@Tel", Tel.Replace("ی", "ي"));
                cmnd.Parameters.AddWithValue("@Mobile", Mobile.Replace("ی", "ي"));
                cmnd.Parameters.AddWithValue("@Expert", Expert.Replace("ی", "ي"));
                cmnd.Parameters.AddWithValue("@Email", Email.Replace("ی", "ي"));
                cmnd.Parameters.AddWithValue("@Address", Address.Replace("ی", "ي"));
                cmnd.Parameters.AddWithValue("@Username", Username.Replace("ی", "ي"));
          
                cmnd.CommandText = "Update_ClerkAcount";
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

        public void UpdateClerkImage(string Username, byte[] PicImage)
        {
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;

                cmnd.Parameters.AddWithValue("@ImagePic", PicImage);

                cmnd.Parameters.AddWithValue("@Username", Username.Replace("ی", "ي"));


                cmnd.CommandText = "Update_ClerkImage";
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

        public void UpdateClerkSign(string Username, byte[] PicSign)
        {
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;

                cmnd.Parameters.AddWithValue("@SignPic", PicSign);

                cmnd.Parameters.AddWithValue("@Username", Username.Replace("ی", "ي"));

                cmnd.CommandText = "Update_ClerkSign";
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

        public Boolean IsClerkGroupExist(string ClerkGroupName)
        {
            sda = new SqlDataAdapter("select * from Tbl_ClerkGroup where GroupName = '" + ClerkGroupName.Replace("ی", "ي") + "'", conn);

            try
            {
                dsclerk.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsclerk.Tbl_ClerkGroup);
                if (dsclerk.Tbl_ClerkGroup.Rows.Count == 0)
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

        public string GetUsernameByName(string Name)
        {
            try
            {
                sda = new SqlDataAdapter("select * from Tbl_Clerk Where RTRIM(Name_) + ' ' + RTRIM(Family) = '" + Name + "'", conn);

                dsclerk.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsclerk.Tbl_Clerk);

                return dsclerk.Tbl_Clerk[0].Username.Trim();
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
