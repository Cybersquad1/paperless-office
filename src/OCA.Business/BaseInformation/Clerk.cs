using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OCA.Business.BaseInformation
{
    public class Clerk
    {
        OCA.Common.DataSets.BaseInformation.Clerk dsclerk = new OCA.Common.DataSets.BaseInformation.Clerk();
        OCA.DataAccess.BaseInformation.Clerk clerkclass = new OCA.DataAccess.BaseInformation.Clerk();
        OCA.DataAccess.BaseInformation.Access accessclass = new OCA.DataAccess.BaseInformation.Access();
        OCA.DataAccess.BaseInformation.Semat sematclass = new OCA.DataAccess.BaseInformation.Semat();
        OCA.DataAccess.BaseInformation.Unit unitclass = new OCA.DataAccess.BaseInformation.Unit();

        public OCA.Common.DataSets.BaseInformation.Clerk GetClerks()
        {
            try
            {
                dsclerk.Clear();
                dsclerk = clerkclass.GetClerks();
                return dsclerk;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.BaseInformation.Clerk GetNameByUsername(string Username)
        {
            try
            {
                dsclerk.Clear();
                dsclerk = clerkclass.GetNameByUsername(Username);
                return dsclerk;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.BaseInformation.Clerk GetClerkByUsername(string Username)
        {
            try
            {
                dsclerk.Clear();
                dsclerk = clerkclass.GetClerkByUsername(Username);
                return dsclerk;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void InsertClerk(string Name, string Family, string Username, string Password, string ClerkGroup, string Access, string Semat, string Unit)
        {
            try
            {
                if (!accessclass.IsAccessExist(Access)) throw new Exception("سطح دسترسی بالا موجود نمی باشد!");
                if (!sematclass.IsSematExist(Semat)) throw new Exception("سمت سازمانی بالا موجود نمی باشد!");
                if (!unitclass.IsUnitExist(Unit)) throw new Exception("واحد سازمانی بالا موجود نمی باشد!");

                clerkclass.InsertClerk(Name, Family, Username, Password.GetHashCode().ToString(), ClerkGroup, Access, Semat, Unit);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.BaseInformation.Clerk GetClerkGroups()
        {
            try
            {
                dsclerk.Clear();
                dsclerk = clerkclass.GetClerkGroups();
                return dsclerk;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void InsertClerkGroup(string ClerkGroup)
        {
            try
            {
                clerkclass.InsertClerkGroup(ClerkGroup);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveClerkGroup(string ClerkGroup)
        {
            try
            {
                clerkclass.RemoveClerkGroup(ClerkGroup);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void EditClerkGroup(string ClerkGroup, string newClerkGroup)
        {
            try
            {
                clerkclass.EditClerkGroup(ClerkGroup, newClerkGroup);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateClerk(string Username, string newUsername, string Name, string Family, string Password,
            string ClerkGroup, string Access, string Semat, string Unit)
        {
            try
            {
                if (!accessclass.IsAccessExist(Access)) throw new Exception("سطح دسترسی بالا موجود نمی باشد!");
                if (!sematclass.IsSematExist(Semat)) throw new Exception("سمت سازمانی بالا موجود نمی باشد!");
                if (!unitclass.IsUnitExist(Unit)) throw new Exception("واحد سازمانی بالا موجود نمی باشد!");

                clerkclass.UpdateClerk(Username, newUsername, Name,  Family, Password.GetHashCode().ToString(), ClerkGroup, Access, Semat, Unit);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveClerk(string Username)
        {
            try
            {
                clerkclass.RemoveClerk(Username);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.BaseInformation.Clerk SearchClerk(string SearchKind, string SearchWord)
        {
            try
            {
                dsclerk.Clear();
                dsclerk = clerkclass.SearchClerk(SearchKind, SearchWord);
                return dsclerk;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateClerkAcount(string Username, string Password, string Sex, string Age, string Tel, string Mobile, string Expert, string Email, string Address, string str_PicSign, string str_PicImage)
        {
            try
            {
                byte[] PicSign;
                byte[] PicImage;

                if (str_PicSign != "")
                {
                    FileStream myStream = new FileStream(str_PicSign, FileMode.Open, FileAccess.Read);
                    PicSign = new byte[myStream.Length];
                    myStream.Read(PicSign, 0, (int)myStream.Length);
                    myStream.Close();

                    clerkclass.UpdateClerkSign(Username, PicSign);
                }

                if (str_PicImage != "")
                {
                    FileStream myStream = new FileStream(str_PicImage, FileMode.Open, FileAccess.Read);
                    PicImage = new byte[myStream.Length];
                    myStream.Read(PicImage, 0, (int)myStream.Length);
                    myStream.Close();

                    clerkclass.UpdateClerkImage(Username, PicImage);
                }

                clerkclass.UpdateClerkAcount(Username, Password.GetHashCode().ToString(), Sex, Age, Tel, Mobile, Expert, Email, Address);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string GetUsernameByName(string Name)
        {
            try
            {
                return clerkclass.GetUsernameByName(Name);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



    }
}
