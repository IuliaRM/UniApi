using System;
using System.Collections.Generic;
using UniApi.Models;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public class FirmaRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public Firma FirmaGet(long ID_Firma)
        {
            return CBO.FillObject<Firma>(
                SqlHelper.ExecuteReader(_ConnectionString, "Firma_GetFirma", ID_Firma));
        }

        public List<Firma> FirmaListGet()
        {
            return CBO.FillCollection<Firma>(
                SqlHelper.ExecuteReader(_ConnectionString, "Firma_GetFirmaList"));
        }

        public Firma FirmaByUserIdPortalGet(int ID_UserPortal)
        {
            return CBO.FillObject<Firma>(
                SqlHelper.ExecuteReader(_ConnectionString, "Firma_GetFirmaByUserIdPortal", ID_UserPortal));
        }

        public void FirmaAdd(Firma objFirma)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "Firma_AddFirma", objFirma);
        }

        public void FirmaUpdate(Firma objFirma)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "Firma_UpdateFirma", objFirma);
        }
    }
}
