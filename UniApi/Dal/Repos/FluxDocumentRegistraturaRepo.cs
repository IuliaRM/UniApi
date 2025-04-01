using System;
using System.Collections.Generic;
using UniApi.Info;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using DotNetNuke.Common.Utilities;

namespace UniApi.Dal.Repos
{
    public class FluxDocumentRegistraturaRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public FluxDocumentRegistraturaInfo FluxDocumentRegistraturaGet(long ID_FluxDocReg)
        {
            return CBO.FillObject<FluxDocumentRegistraturaInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "FluxDocumentRegistratura_GetFluxDocumentRegistratura", ID_FluxDocReg));
        }

        public List<FluxDocumentRegistraturaInfo> FluxDocumentRegistraturaListGet()
        {
            return CBO.FillCollection<FluxDocumentRegistraturaInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "FluxDocumentRegistratura_GetFluxDocumentRegistraturaList"));
        }

        public List<FluxDocumentRegistraturaInfo> FluxDocumentRegistraturaListByDocumentRegistraturaGet(long ID_DocReg, int AnCalendaristic)
        {
            return CBO.FillCollection<FluxDocumentRegistraturaInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "FluxDocumentRegistratura_GetFluxDocumentRegistraturaListByDocumentRegistratura", ID_DocReg, AnCalendaristic));
        }

        public long FluxDocumentRegistraturaAdd(FluxDocumentRegistraturaInfo objFluxDocumentRegistratura)
        {
            return (long)SqlHelper.ExecuteScalar(_ConnectionString, "FluxDocumentRegistratura_AddFluxDocumentRegistratura", objFluxDocumentRegistratura);
        }

        public void FluxDocumentRegistraturaUpdate(FluxDocumentRegistraturaInfo objFluxDocumentRegistratura)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "FluxDocumentRegistratura_UpdateFluxDocumentRegistratura", objFluxDocumentRegistratura);
        }

        public void FluxDocumentRegistraturaDelete(FluxDocumentRegistraturaInfo objFluxDocumentRegistratura)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "FluxDocumentRegistratura_DeleteFluxDocumentRegistratura", objFluxDocumentRegistratura);
        }

        public List<FluxDocumentRegistraturaInfo> FluxDocumentRegistraturaStatisticiByAnGet(int AnCalendaristic)
        {
            return CBO.FillCollection<FluxDocumentRegistraturaInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "FluxDocumentRegistratura_GetFluxDocumentRegistraturaStatisticiByAn", AnCalendaristic));
        }
    }
}
