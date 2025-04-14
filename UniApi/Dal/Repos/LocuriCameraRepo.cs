using System;
using System.Configuration;
using System.Data;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface ILocuriCameraRepo
    {
        LocuriCameraInfo LocuriCameraGet(long idLocuriCamera);
        DataTable LocuriCameraList();
        DataTable LocuriCameraListByAnUniversitar(long idAnUniversitar);
        DataTable LocuriCameraListByCamera(long idCamera);
        long LocuriCameraAdd(LocuriCameraInfo info);
        void LocuriCameraUpdate(LocuriCameraInfo info);
        void LocuriCameraDelete(long idLocuriCamera);
        int LocuriCameraImportDinAltAnUniv(long idAnUnivSursa, long idAnUnivDestinatie);
        void LocuriCameraMerge(LocuriCameraInfo info);  // Add this line
    }

    public class LocuriCameraRepo : ILocuriCameraRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public LocuriCameraInfo LocuriCameraGet(long idLocuriCamera)
        {
            try
            {
                return CBO.FillObject<LocuriCameraInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "LocuriCameraGet", idLocuriCamera));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la LocuriCameraGet", ex);
            }
        }

        public DataTable LocuriCameraList()
        {
            try
            {
                return SqlHelper.ExecuteDataset(_connectionString, "LocuriCameraList").Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la LocuriCameraList", ex);
            }
        }

        public DataTable LocuriCameraListByAnUniversitar(long idAnUniversitar)
        {
            try
            {
                return SqlHelper.ExecuteDataset(_connectionString, "LocuriCameraListByAnUniversitar", idAnUniversitar).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la LocuriCameraListByAnUniversitar", ex);
            }
        }

        public DataTable LocuriCameraListByCamera(long idCamera)
        {
            try
            {
                return SqlHelper.ExecuteDataset(_connectionString, "LocuriCameraListByCamera", idCamera).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la LocuriCameraListByCamera", ex);
            }
        }

        public long LocuriCameraAdd(LocuriCameraInfo info)
        {
            try
            {
                return Convert.ToInt64(SqlHelper.ExecuteScalar(_connectionString, "LocuriCameraAdd",
                    info.ID_Camera,
                    info.NrLocuri,
                    info.ID_AnUniv));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la LocuriCameraAdd", ex);
            }
        }

        public void LocuriCameraUpdate(LocuriCameraInfo info)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "LocuriCameraUpdate",
                    info.ID_LocuriCamera,
                    info.ID_Camera,
                    info.NrLocuri,
                    info.ID_AnUniv);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la LocuriCameraUpdate", ex);
            }
        }

        public void LocuriCameraDelete(long idLocuriCamera)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "LocuriCameraDelete", idLocuriCamera);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la LocuriCameraDelete", ex);
            }
        }

        public void LocuriCameraMerge(LocuriCameraInfo info)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "LocuriCameraMerge",
                    info.ID_LocuriCamera,
                    info.ID_Camera,
                    info.NrLocuri,
                    info.ID_AnUniv);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la LocuriCameraMerge", ex);
            }
        }

        public int LocuriCameraImportDinAltAnUniv(long idAnUnivSursa, long idAnUnivDestinatie)
        {
            try
            {
                return SqlHelper.ExecuteNonQuery(_connectionString, "LocuriCameraImportDinAltAnUniv",
                    idAnUnivSursa,
                    idAnUnivDestinatie);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la LocuriCameraImportDinAltAnUniv", ex);
            }
        }
    }
}