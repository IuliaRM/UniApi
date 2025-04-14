using System;
using System.Configuration;
using System.Data;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IFluxDocumentRegistraturaRepo
    {
        FluxDocumentRegistraturaInfo FluxDocumentRegistraturaGet(long id);
        DataTable FluxDocumentRegistraturaList();
        DataTable FluxDocumentRegistraturaListByDocumentRegistratura(long idDocReg, int anCalendaristic);
        long FluxDocumentRegistraturaAdd(FluxDocumentRegistraturaInfo info);
        void FluxDocumentRegistraturaUpdate(FluxDocumentRegistraturaInfo info);
        void FluxDocumentRegistraturaDelete(FluxDocumentRegistraturaInfo info);
        DataTable FluxDocumentRegistraturaStatisticiByAn(int anCalendaristic);
    }

    public class FluxDocumentRegistraturaRepo : IFluxDocumentRegistraturaRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public FluxDocumentRegistraturaInfo FluxDocumentRegistraturaGet(long id)
        {
            try
            {
                return CBO.FillObject<FluxDocumentRegistraturaInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "FluxDocumentRegistratura_GetFluxDocumentRegistratura", id));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la FluxDocumentRegistraturaGet", ex);
            }
        }

        public DataTable FluxDocumentRegistraturaList()
        {
            try
            {
                return SqlHelper.ExecuteDataset(_connectionString, "FluxDocumentRegistratura_GetFluxDocumentRegistraturaList").Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la FluxDocumentRegistraturaList", ex);
            }
        }

        public DataTable FluxDocumentRegistraturaListByDocumentRegistratura(long idDocReg, int anCalendaristic)
        {
            try
            {
                return SqlHelper.ExecuteDataset(_connectionString, "FluxDocumentRegistratura_GetFluxDocumentRegistraturaListByDocumentRegistratura", idDocReg, anCalendaristic).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la FluxDocumentRegistraturaListByDocumentRegistratura", ex);
            }
        }

        public long FluxDocumentRegistraturaAdd(FluxDocumentRegistraturaInfo info)
        {
            try
            {
                return (long)SqlHelper.ExecuteScalar(_connectionString, "FluxDocumentRegistratura_AddFluxDocumentRegistratura", info);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la FluxDocumentRegistraturaAdd", ex);
            }
        }

        public void FluxDocumentRegistraturaUpdate(FluxDocumentRegistraturaInfo info)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "FluxDocumentRegistratura_UpdateFluxDocumentRegistratura", info);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la FluxDocumentRegistraturaUpdate", ex);
            }
        }

        public void FluxDocumentRegistraturaDelete(FluxDocumentRegistraturaInfo info)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "FluxDocumentRegistratura_DeleteFluxDocumentRegistratura", info);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la FluxDocumentRegistraturaDelete", ex);
            }
        }

        public DataTable FluxDocumentRegistraturaStatisticiByAn(int anCalendaristic)
        {
            try
            {
                return SqlHelper.ExecuteDataset(_connectionString, "FluxDocumentRegistratura_GetFluxDocumentRegistraturaStatisticiByAn", anCalendaristic).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la FluxDocumentRegistraturaStatisticiByAn", ex);
            }
        }
    }
}
