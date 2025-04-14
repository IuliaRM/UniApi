using System;
using System.Configuration;
using System.Data;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Controllers;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IFacultateCameraRepo
    {
        FacultateCameraInfo FacultateCameraGet(long idFacultateCamera);
        FacultateCameraInfo FacultateCameraGetByFacultateCamera(long idFacultate, long idCamera, long idAnUniv);
        DataTable FacultateCameraList();
        DataTable FacultateCameraListByAnUniversitar(long idAnUniv);
        DataTable FacultateCameraListByFacultate(long idFacultate);
        DataTable FacultateCameraListByFacultateAnUniv(long idFacultate, long idAnUniv);
        DataTable FacultateCameraListByFacultateAnUnivCamin(long idFacultate, long idAnUniv, long idCamin);
        DataTable FacultateCameraListByFacultateCaminEtajAnUniv(long idFacultate, long idCamin, int etaj, long idAnUniv);
        DataTable FacultateCameraListByCamera(long idCamera);
        DataTable FacultateCameraRaportLocuriByCaminAnUniv(long idCamin, long idAnUniv);

        long FacultateCameraAdd(FacultateCameraInfo info);
        void FacultateCameraUpdate(FacultateCameraInfo info);
        void FacultateCameraMerge(FacultateCameraInfo info);

        void FacultateCameraImportDinAltAnUniv(long idAnUnivSursa, long idAnUnivDestinatie);
        void FacultateCameraDelete(FacultateCameraInfo info);
        void FacultateCameraDeleteByFacultateCamera(long idFacultate, long idCamera);
    }
    public class FacultateCameraRepo : IFacultateCameraRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public FacultateCameraInfo FacultateCameraGet(long idFacultateCamera)
        {
            try
            {
                return CBO.FillObject<FacultateCameraInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "FacultateCamera_GetFacultateCamera", idFacultateCamera));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la FacultateCameraGet", ex);
            }
        }

        public FacultateCameraInfo FacultateCameraGetByFacultateCamera(long idFacultate, long idCamera, long idAnUniv)
        {
            try
            {
                return CBO.FillObject<FacultateCameraInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "FacultateCamera_GetFacultateCameraByFacultateCamera", idFacultate, idCamera, idAnUniv));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la FacultateCameraGetByFacultateCamera", ex);
            }
        }

        public DataTable FacultateCameraList()
        {
            try
            {
                return SqlHelper.ExecuteDataset(_connectionString, "FacultateCamera_GetFacultateCameraList").Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la FacultateCameraList", ex);
            }
        }

        public DataTable FacultateCameraListByAnUniversitar(long idAnUniv)
        {
            try
            {
                return SqlHelper.ExecuteDataset(_connectionString, "FacultateCamera_GetFacultateCameraListByAnUniversitar", idAnUniv).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la FacultateCameraListByAnUniversitar", ex);
            }
        }

        public DataTable FacultateCameraListByFacultate(long idFacultate)
        {
            try
            {
                return SqlHelper.ExecuteDataset(_connectionString, "FacultateCamera_GetFacultateCameraListByFacultate", idFacultate).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la FacultateCameraListByFacultate", ex);
            }
        }

        public DataTable FacultateCameraListByFacultateAnUniv(long idFacultate, long idAnUniv)
        {
            try
            {
                return SqlHelper.ExecuteDataset(_connectionString, "FacultateCamera_GetFacultateCameraListByFacultateAnUniv", idFacultate, idAnUniv).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la FacultateCameraListByFacultateAnUniv", ex);
            }
        }

        public DataTable FacultateCameraListByFacultateAnUnivCamin(long idFacultate, long idAnUniv, long idCamin)
        {
            try
            {
                return SqlHelper.ExecuteDataset(_connectionString, "FacultateCamera_GetFacultateCameraListByFacultateAnUnivCamin", idFacultate, idAnUniv, idCamin).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la FacultateCameraListByFacultateAnUnivCamin", ex);
            }
        }

        public DataTable FacultateCameraListByFacultateCaminEtajAnUniv(long idFacultate, long idCamin, int etaj, long idAnUniv)
        {
            try
            {
                return SqlHelper.ExecuteDataset(_connectionString, "FacultateCamera_GetFacultateCameraListByFacultateCaminEtajAnUniv", idFacultate, idCamin, etaj, idAnUniv).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la FacultateCameraListByFacultateCaminEtajAnUniv", ex);
            }
        }

        public DataTable FacultateCameraListByCamera(long idCamera)
        {
            try
            {
                return SqlHelper.ExecuteDataset(_connectionString, "FacultateCamera_GetFacultateCameraListByCamera", idCamera).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la FacultateCameraListByCamera", ex);
            }
        }

        public DataTable FacultateCameraRaportLocuriByCaminAnUniv(long idCamin, long idAnUniv)
        {
            try
            {
                return SqlHelper.ExecuteDataset(_connectionString, "FacultateCamera_GetRaportLocuriByCaminAnUniv", idCamin, idAnUniv).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la FacultateCameraRaportLocuriByCaminAnUniv", ex);
            }
        }

        public long FacultateCameraAdd(FacultateCameraInfo info)
        {
            try
            {
                return (long)SqlHelper.ExecuteScalar(_connectionString, "FacultateCamera_AddFacultateCamera", info);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la FacultateCameraAdd", ex);
            }
        }

        public void FacultateCameraUpdate(FacultateCameraInfo info)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "FacultateCamera_UpdateFacultateCamera", info);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la FacultateCameraUpdate", ex);
            }
        }

        public void FacultateCameraMerge(FacultateCameraInfo info)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "FacultateCamera_MergeFacultateCamera", info);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la FacultateCameraMerge", ex);
            }
        }

        public void FacultateCameraDelete(FacultateCameraInfo info)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "FacultateCamera_DeleteFacultateCamera", info);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la FacultateCameraDelete", ex);
            }
        }

        public void FacultateCameraDeleteByFacultateCamera(long idFacultate, long idCamera)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "FacultateCamera_DeleteFacultateCameraByFacultateCamera", idFacultate, idCamera);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la FacultateCameraDeleteByFacultateCamera", ex);
            }
        }

        public void FacultateCameraImportDinAltAnUniv(long idAnUnivSursa, long idAnUnivDestinatie)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "FacultateCamera_ImportDinAltAnUniv", idAnUnivSursa, idAnUnivDestinatie);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la FacultateCameraImportDinAltAnUniv", ex);
            }
        }
    }
}
