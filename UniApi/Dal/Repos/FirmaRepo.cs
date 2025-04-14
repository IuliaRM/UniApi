using System;
using System.Configuration;
using System.Data;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Controllers;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IFirmaRepo
    {
        Firma FirmaGet(long idFirma);
        Firma FirmaGetByUserIdPortal(int idUserPortal);
        DataTable FirmaList();
        long FirmaAdd(Firma info);
        void FirmaUpdate(Firma info);
    }
    public class FirmaRepo : IFirmaRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public Firma FirmaGet(long idFirma)
        {
            try
            {
                return CBO.FillObject<Firma>(
                    SqlHelper.ExecuteReader(_connectionString, "Firma_GetFirma", idFirma));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la FirmaGet", ex);
            }
        }

        public Firma FirmaGetByUserIdPortal(int idUserPortal)
        {
            try
            {
                return CBO.FillObject<Firma>(
                    SqlHelper.ExecuteReader(_connectionString, "Firma_GetFirmaByUserIdPortal", idUserPortal));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la FirmaGetByUserIdPortal", ex);
            }
        }

        public DataTable FirmaList()
        {
            try
            {
                return SqlHelper.ExecuteDataset(_connectionString, "Firma_GetFirmaList").Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la FirmaList", ex);
            }
        }

        public long FirmaAdd(Firma info)
        {
            try
            {
                return (long)SqlHelper.ExecuteScalar(_connectionString, "Firma_AddFirma", info);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la FirmaAdd", ex);
            }
        }

        public void FirmaUpdate(Firma info)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "Firma_UpdateFirma", info);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la FirmaUpdate", ex);
            }
        }
    }
}
