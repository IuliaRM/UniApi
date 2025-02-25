using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using DotNetNuke.Common.Utilities;

namespace UniApi.Dal.Repos
{
    public class FluxDocumentRegistraturaRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public FluxDocumentRegistraturaInfo GetFluxDocumentRegistratura(long iD_FluxDocReg)
        {
            return CBO.FillObject<FluxDocumentRegistraturaInfo>(SqlHelper.ExecuteReader(_ConnectionString, "FluxDocumentRegistraturaGet", iD_FluxDocReg));
        }

        public List<FluxDocumentRegistraturaInfo> GetFluxDocumentRegistraturaList()
        {
            return CBO.FillCollection<FluxDocumentRegistraturaInfo>(SqlHelper.ExecuteReader(_ConnectionString, "FluxDocumentRegistraturaList"));
        }

        public List<FluxDocumentRegistraturaInfo> GetFluxDocumentRegistraturaListByDocumentRegistratura(long iD_DocReg, int AnCalendaristic)
        {
            return CBO.FillCollection<FluxDocumentRegistraturaInfo>(SqlHelper.ExecuteReader(_ConnectionString, "FluxDocumentRegistraturaListByDocumentRegistratura", iD_DocReg, AnCalendaristic));
        }

        public long AddFluxDocumentRegistratura(FluxDocumentRegistraturaInfo objFluxDocumentRegistratura)
        {
            object o = SqlHelper.ExecuteScalar(_ConnectionString, "FluxDocumentRegistraturaAdd", objFluxDocumentRegistratura.ID_DocReg, objFluxDocumentRegistratura.COD_SEC, objFluxDocumentRegistratura.DataInregistrare, objFluxDocumentRegistratura.TipIO, objFluxDocumentRegistratura.UserModificat, objFluxDocumentRegistratura.DocumentIdCodSec);
            return Convert.ToInt64(o);
        }

        public void UpdateFluxDocumentRegistratura(FluxDocumentRegistraturaInfo objFluxDocumentRegistratura)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "FluxDocumentRegistraturaUpdate", objFluxDocumentRegistratura.ID_FluxDocReg, objFluxDocumentRegistratura.ID_DocReg, objFluxDocumentRegistratura.COD_SEC, objFluxDocumentRegistratura.DataInregistrare, objFluxDocumentRegistratura.TipIO);
        }

        public void DeleteFluxDocumentRegistratura(FluxDocumentRegistraturaInfo objFluxDocumentRegistratura)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "FluxDocumentRegistraturaDelete", objFluxDocumentRegistratura.ID_FluxDocReg);
        }

        public List<FluxDocumentRegistraturaInfo> GetFluxDocumentRegistraturaStatisticiByAn(int AnCalendaristic)
        {
            return CBO.FillCollection<FluxDocumentRegistraturaInfo>(SqlHelper.ExecuteReader(_ConnectionString, "FluxDocumentRegistraturaStatisticiByAn", AnCalendaristic));
        }
    }
}
