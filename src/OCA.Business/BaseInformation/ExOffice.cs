using System;
using System.Collections.Generic;
using System.Text;

namespace OCA.Business.BaseInformation
{
    public class ExOffice
    {
        OCA.Common.DataSets.BaseInformation.ExOffice dsexoffice = new OCA.Common.DataSets.BaseInformation.ExOffice();
        OCA.DataAccess.BaseInformation.ExOffice exofficeclass = new OCA.DataAccess.BaseInformation.ExOffice();

        public OCA.Common.DataSets.BaseInformation.ExOffice GetExOffice()
        {
            try
            {
                dsexoffice.Clear();
                dsexoffice = exofficeclass.GetExOffice();
                return dsexoffice;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateExOffice(string PersonName, string PersonKind, string newPersonName, string Tel, string Fax,
            string Email, string Site, string Address)
        {
            try
            {
                exofficeclass.UpdateExOffice(PersonName, PersonKind, newPersonName, Tel, Fax, Email, Site, Address);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveExOffice(string PersonName)
        {
            try
            {
                exofficeclass.RemoveExOffice(PersonName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.BaseInformation.ExOffice SearchExOffice(string PersonName)
        {
            try
            {
                dsexoffice.Clear();
                dsexoffice = exofficeclass.SearchExOffice(PersonName);
                return dsexoffice;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void InsertExOffice(string PersonKind, string PersonName, string Tel, string Fax, string Email, string Site, string Address)
        {
            try
            {
                exofficeclass.InsertExOffice(PersonKind, PersonName, Tel, Fax,Email, Site, Address);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }




    }
}
