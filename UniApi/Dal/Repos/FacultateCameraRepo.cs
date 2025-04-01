using System;
using System.Collections.Generic;
using UniApi.Info;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using DotNetNuke.Common.Utilities;

namespace UniApi.Dal.Repos
{
    public class FacultateCameraRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public FacultateCameraInfo FacultateCameraGet(long ID_FacultateCamera)
        {
            return CBO.FillObject<FacultateCameraInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "FacultateCamera_GetFacultateCamera", ID_FacultateCamera));
        }

        public FacultateCameraInfo FacultateCameraByFacultateCameraGet(long ID_Facultate, long ID_Camera, long ID_AnUniv)
        {
            return CBO.FillObject<FacultateCameraInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "FacultateCamera_GetFacultateCameraByFacultateCamera", ID_Facultate, ID_Camera, ID_AnUniv));
        }

        public List<FacultateCameraInfo> FacultateCameraListGet()
        {
            return CBO.FillCollection<FacultateCameraInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "FacultateCamera_GetFacultateCameraList"));
        }

        public List<FacultateCameraInfo> FacultateCameraListByAnUniversitarGet(long ID_AnUniv)
        {
            return CBO.FillCollection<FacultateCameraInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "FacultateCamera_GetFacultateCameraListByAnUniversitar", ID_AnUniv));
        }

        public List<FacultateCameraInfo> FacultateCameraListByFacultateGet(long ID_Facultate)
        {
            return CBO.FillCollection<FacultateCameraInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "FacultateCamera_GetFacultateCameraListByFacultate", ID_Facultate));
        }

        public List<FacultateCameraInfo> FacultateCameraListByFacultateAnUnivGet(long ID_Facultate, long ID_AnUniv)
        {
            return CBO.FillCollection<FacultateCameraInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "FacultateCamera_GetFacultateCameraListByFacultateAnUniv", ID_Facultate, ID_AnUniv));
        }

        public List<FacultateCameraInfo> FacultateCameraListByCameraGet(long ID_Camera)
        {
            return CBO.FillCollection<FacultateCameraInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "FacultateCamera_GetFacultateCameraListByCamera", ID_Camera));
        }

        public long FacultateCameraAdd(FacultateCameraInfo objFacultateCamera)
        {
            return (long)SqlHelper.ExecuteScalar(_ConnectionString, "FacultateCamera_AddFacultateCamera", objFacultateCamera);
        }

        public void FacultateCameraUpdate(FacultateCameraInfo objFacultateCamera)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "FacultateCamera_UpdateFacultateCamera", objFacultateCamera);
        }

        public void FacultateCameraDelete(FacultateCameraInfo objFacultateCamera)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "FacultateCamera_DeleteFacultateCamera", objFacultateCamera);
        }

        public void FacultateCameraDeleteByFacultateCamera(long ID_Facultate, long ID_Camera)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "FacultateCamera_DeleteFacultateCameraByFacultateCamera", ID_Facultate, ID_Camera);
        }
    }
}
