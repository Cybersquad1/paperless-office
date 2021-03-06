using System;
using System.Collections.Generic;
using System.Text;
using OCA.Common;
using System.Data;
using System.Data.SqlClient;

namespace OCA.DataAccess.BaseInformation
{
    public class Unit
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter sda;

        private string ConnectionString = "";

        OCA.Common.DataSets.BaseInformation.Unit dsunit = new OCA.Common.DataSets.BaseInformation.Unit();

        public Unit()
        {
            OCA.Common.Configuration config = new Configuration();
            ConnectionString = config.Connection_String;

            conn.ConnectionString = ConnectionString;
        }

        public OCA.Common.DataSets.BaseInformation.Unit IsExistUnit(string UnitName)
        {
            sda = new SqlDataAdapter("SELECT * FROM Tbl_Unit WHERE UnitName = '" + UnitName.Replace("ی", "ي") + "'", conn);

            try
            {
                dsunit.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsunit.Tbl_Unit);

                return dsunit;
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


        public void EditUnit(string UnitName, string newUnitName)
        {
            if (Check_PrimaryKey(newUnitName)) throw new Exception("واحد" + " " + newUnitName + " " + "موجود است!");
            
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;

                cmnd.CommandText = "UPDATE Tbl_Unit SET UnitName = '" + newUnitName.Replace("ی", "ي") + "' WHERE UnitName = '" + UnitName.Replace("ی", "ي") + "'";
                cmnd.ExecuteNonQuery();

                cmnd.CommandText = "UPDATE Tbl_Unit SET UpperUnit = '" + newUnitName.Replace("ی", "ي") + "' WHERE UpperUnit = '" + UnitName.Replace("ی", "ي") + "'";
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

        public void RemoveUnit(string UnitName)
        {
            SqlCommand cmnd = new SqlCommand();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmnd.Connection = conn;
                cmnd.CommandText = "DELETE FROM Tbl_Unit WHERE UnitName = '" + UnitName.Replace("ی", "ي") + "'";
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

        public OCA.Common.DataSets.BaseInformation.Unit GetUnits()
        {
            sda = new SqlDataAdapter(" select * from Tbl_Unit where UpperUnit is not null  ORDER BY UnitID", conn);

            try
            {
                dsunit.Clear();
                
                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsunit.Tbl_Unit);

                return dsunit;
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

        public OCA.Common.DataSets.BaseInformation.Unit GetAllUnits()
        {
            sda = new SqlDataAdapter(" select * from Tbl_Unit ORDER BY UnitID", conn);

            try
            {
                dsunit.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsunit.Tbl_Unit);

                return dsunit;
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

        public Boolean Check_PrimaryKey(string UnitName)
        {
            sda = new SqlDataAdapter("select UnitName from Tbl_Unit where UnitName = '" + UnitName.Replace("ی","ي") + "'", conn);

            try
            {
                dsunit.Clear();
                
                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsunit.Tbl_Unit);
                if (dsunit.Tbl_Unit.Rows.Count == 0) 
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

        public void InsertUnit(string UnitName, string UpperUnit)
        {
            if (Check_PrimaryKey(UnitName)) throw new Exception("واحد" + " " + UnitName + " " + "موجود است!");

            SqlCommand cmnd = new SqlCommand();
            cmnd.Parameters.AddWithValue("@UnitName", UnitName.Replace("ی", "ي"));
            cmnd.Parameters.AddWithValue("@UpperUnit", UpperUnit.Replace("ی", "ي"));

            cmnd.CommandText = "Insert_Unit";

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

        public Boolean IsUnitExist(string UnitName)
        {
            sda = new SqlDataAdapter("select * from Tbl_Unit where UnitName = '" + UnitName.Replace("ی", "ي") + "'", conn);

            try
            {
                dsunit.Clear();

                if (conn.State == ConnectionState.Closed) conn.Open();

                sda.Fill(dsunit.Tbl_Unit);
                if (dsunit.Tbl_Unit.Rows.Count == 0)
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
