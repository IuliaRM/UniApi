using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Dal.Repos;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public class LocuriCameraRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public LocuriCameraInfo LocuriCameraGet(long idLocuriCamera)
        {
            return CBO.FillObject<LocuriCameraInfo>(
                SqlHelper.ExecuteReader(_connectionString, "LocuriCameraGet", idLocuriCamera));
        }

        public List<LocuriCameraInfo> LocuriCameraList()
        {
            return CBO.FillCollection<LocuriCameraInfo>(
                SqlHelper.ExecuteReader(_connectionString, "LocuriCameraList"));
        }

        public List<LocuriCameraInfo> LocuriCameraListByAnUniversitar(long idAnUniversitar)
        {
            return CBO.FillCollection<LocuriCameraInfo>(
                SqlHelper.ExecuteReader(_connectionString, "LocuriCameraListByAnUniversitar", idAnUniversitar));
        }

        public List<LocuriCameraInfo> LocuriCameraListByCamera(long idCamera)
        {
            return CBO.FillCollection<LocuriCameraInfo>(
                SqlHelper.ExecuteReader(_connectionString, "LocuriCameraListByCamera", idCamera));
        }

        public long LocuriCameraAdd(LocuriCameraInfo locuriCameraInfo)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "LocuriCameraAdd",
                locuriCameraInfo.ID_Camera,
                locuriCameraInfo.NrLocuri,
                locuriCameraInfo.ID_AnUniv);

            return Convert.ToInt64(id);
        }

        public void LocuriCameraUpdate(LocuriCameraInfo locuriCameraInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "LocuriCameraUpdate",
                locuriCameraInfo.ID_LocuriCamera,
                locuriCameraInfo.ID_Camera,
                locuriCameraInfo.NrLocuri,
                locuriCameraInfo.ID_AnUniv);
        }

        public void LocuriCameraDelete(long idLocuriCamera)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "LocuriCameraDelete", idLocuriCamera);
        }
    }
}
