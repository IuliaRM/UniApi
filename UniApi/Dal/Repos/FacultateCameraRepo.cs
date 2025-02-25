using System;
using System.Collections.Generic;
using UniApi.Models;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using DotNetNuke.Common.Utilities;

namespace UniApi.Dal.Repos
{
    public class FacultateCameraRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public FacultateCameraInfo GetFacultateCamera(long iD_FacultateCamera)
        {
            return CBO.FillObject<FacultateCameraInfo>(SqlHelper.ExecuteReader(_ConnectionString, "FacultateCameraGet", iD_FacultateCamera));
        }

        public FacultateCameraInfo GetFacultateCameraByFacultateCamera(long ID_Facultate, long ID_Camera, long ID_AnUniv)
        {
            return CBO.FillObject<FacultateCameraInfo>(SqlHelper.ExecuteReader(_ConnectionString, "FacultateCameraGetByFacultateCamera", ID_Facultate, ID_Camera, ID_AnUniv));
        }

        public List<FacultateCameraInfo> GetFacultateCameraList()
        {
            return CBO.FillCollection<FacultateCameraInfo>(SqlHelper.ExecuteReader(_ConnectionString, "FacultateCameraList"));
        }

        public List<FacultateCameraInfo> GetFacultateCameraListByAnUniversitar(long iD_AnUniv)
        {
            return CBO.FillCollection<FacultateCameraInfo>(SqlHelper.ExecuteReader(_ConnectionString, "FacultateCameraListByAnUniversitar", iD_AnUniv));
        }

        public List<FacultateCameraInfo> GetFacultateCameraListByFacultate(long iD_Facultate)
        {
            return CBO.FillCollection<FacultateCameraInfo>(SqlHelper.ExecuteReader(_ConnectionString, "FacultateCameraListByFacultate", iD_Facultate));
        }

        public List<FacultateCameraInfo> GetFacultateCameraListByFacultateAnUniv(long iD_Facultate, long ID_AnUniv)
        {
            return CBO.FillCollection<FacultateCameraInfo>(SqlHelper.ExecuteReader(_ConnectionString, "FacultateCameraListByFacultateAnUniv", iD_Facultate, ID_AnUniv));
        }

        public List<FacultateCameraInfo> GetFacultateCameraListByCamera(long iD_Camera)
        {
            return CBO.FillCollection<FacultateCameraInfo>(SqlHelper.ExecuteReader(_ConnectionString, "FacultateCameraListByCamera", iD_Camera));
        }

        public long AddFacultateCamera(FacultateCameraInfo objFacultateCamera)
        {
            object ret = SqlHelper.ExecuteScalar(_ConnectionString, "FacultateCameraAdd", objFacultateCamera.ID_Facultate, objFacultateCamera.ID_Camera, objFacultateCamera.ID_AnUniv);
            return Convert.ToInt64(ret);
        }

        public void UpdateFacultateCamera(FacultateCameraInfo objFacultateCamera)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "FacultateCameraUpdate", objFacultateCamera.ID_FacultateCamera, objFacultateCamera.ID_Facultate, objFacultateCamera.ID_Camera, objFacultateCamera.ID_AnUniv);
        }

        public void DeleteFacultateCamera(FacultateCameraInfo objFacultateCamera)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "FacultateCameraDelete", objFacultateCamera.ID_FacultateCamera);
        }

        public void DeleteFacultateCameraByFacultateCamera(long ID_Facultate, long ID_Camera)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "FacultateCameraDeleteByFacultateCamera", ID_Facultate, ID_Camera);
        }
    }
}
