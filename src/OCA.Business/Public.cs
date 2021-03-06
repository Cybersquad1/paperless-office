using System;
using System.Collections.Generic;
using System.Text;
using OCA.Business;
using OCA.Common;
using System.Drawing;
using System.IO;

namespace OCA.Business
{
    public class Public
    {
        OCA.DataAccess.Public pubclass = new OCA.DataAccess.Public();
        OCA.Common.DataSets.Public dspub = new OCA.Common.DataSets.Public();
        OCA.Common.DataSets.BaseInformation.Clerk dsclerk = new OCA.Common.DataSets.BaseInformation.Clerk();

        public void UpdateCompanyInfo(string OrganName, string tel1, string tel2, string tel3, string fax1, string fax2, string address1, string address2, string ImageFile)
        {
            try
            {
                byte[] ImageBuffer;

                if (ImageFile != "")
                {
                    FileStream myStream = new FileStream(ImageFile, FileMode.Open, FileAccess.Read);
                    ImageBuffer = new byte[myStream.Length];
                    myStream.Read(ImageBuffer, 0, (int)myStream.Length);
                    myStream.Close();
                }
                else
                    ImageBuffer = null;

                pubclass.UpdateCompanyInfo(OrganName, tel1, tel2, tel3, fax1, fax2, address1, address2, ImageBuffer);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.Public GetCompanyInfo()
        {
            try
            {
                dspub.Clear();
                dspub = pubclass.GetCompanyInfo();
                return dspub;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Boolean IsUserValid(string Username, string Password)
        {
            try
            {
                dsclerk.Clear();
                dsclerk = pubclass.IsUserValid(Username, Password.GetHashCode().ToString());
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            try
            {
                if (dsclerk.Tbl_Clerk[0].Username.Trim() == Username && dsclerk.Tbl_Clerk[0].Pass.Trim() == Password.GetHashCode().ToString())
                    return true;
                else
                    return false;
            }
            catch
            {
                throw new Exception("کاربر مورد نظر در سیستم موجود نمی باشد!");
            }
        }

        public string SqlInjection(string input_string)
        {
            StringBuilder str = new StringBuilder(input_string);

            str.Replace("-", "");
            str.Replace("=", "");
            str.Replace("<", "");
            str.Replace(">", "");
            str.Replace("'", "");
            str.Replace(";", "");
            str.Replace("[", "");
            str.Replace("]", "");
            str.Replace("%", "");
            str.Replace("/*", "");
            str.Replace("*/", "");
            str.Replace("sp", "");
            str.Replace("xp", "");
            str.Replace("exec", "");
            str.Replace("insert", "");
            str.Replace("update", "");
            str.Replace("select", "");
            str.Replace("delete", "");
            str.Replace("drop", "");
            str.Replace("shutdown", "");
            str.Replace("having", "");
            str.Replace("union", "");
            str.Replace("script", "");

            return str.ToString();
        }

         

    }
}
