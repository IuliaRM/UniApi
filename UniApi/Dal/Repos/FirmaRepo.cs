using System;
using System.Collections.Generic;
using UniApi.Models;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using DotNetNuke.Common.Utilities;
using Microsoft.SqlServer.Server;

namespace UniApi.Dal.Repos
{
    public class FirmaRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public Firma GetFirma(long iD_Firma)
        {
            return CBO.FillObject<Firma>(SqlHelper.ExecuteReader(_ConnectionString, "FirmaGet", iD_Firma));
        }

        public List<Firma> GetFirmaList()
        {
            return CBO.FillCollection<Firma>(SqlHelper.ExecuteReader(_ConnectionString, "FirmaList"));
        }

        public Firma GetFirmaByUserIdPortal(int iD_UserPortal)
        {
            return CBO.FillObject<Firma>(SqlHelper.ExecuteReader(_ConnectionString, "FirmaGetByUserIdPortal", iD_UserPortal));
        }

        public void AddFirma(Firma objFirma)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "FirmaAdd", objFirma.UserIDPortal, objFirma.DenumireFirma, objFirma.NumeDirector, objFirma.TelefonDirector, objFirma.EmailDirector, objFirma.NumePersoanaContact, objFirma.TelefonPersoanaContact, objFirma.EmailPersoanaContact, objFirma.ID_Judet, objFirma.DataModificare);
        }

        public void UpdateFirma(Firma objFirma)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "FirmaUpdate", objFirma.ID_Firma, objFirma.UserIDPortal, objFirma.DenumireFirma, objFirma.NumeDirector, objFirma.TelefonDirector, objFirma.EmailDirector, objFirma.NumePersoanaContact, objFirma.TelefonPersoanaContact, objFirma.EmailPersoanaContact, objFirma.ID_Judet, objFirma.DataModificare);
        }
    }
}
