using System;
using System.Collections.Generic;
using UniApi.Dal.Repos;
using UniApi.Models;

namespace UniApi.Controllers
{
    public class FacultateCameraController
    {
        private readonly FacultateCameraRepo _repo;

        public FacultateCameraController()
        {
            _repo = new FacultateCameraRepo();
        }

        public FacultateCameraInfo GetFacultateCamera(long iD_FacultateCamera)
        {
            return _repo.GetFacultateCamera(iD_FacultateCamera);
        }

        public FacultateCameraInfo GetFacultateCameraByFacultateCamera(long ID_Facultate, long ID_Camera, long ID_AnUniv)
        {
            return _repo.GetFacultateCameraByFacultateCamera(ID_Facultate, ID_Camera, ID_AnUniv);
        }

        public List<FacultateCameraInfo> GetFacultateCameraList()
        {
            return _repo.GetFacultateCameraList();
        }

        public List<FacultateCameraInfo> GetFacultateCameraListByAnUniversitar(long iD_AnUniv)
        {
            return _repo.GetFacultateCameraListByAnUniversitar(iD_AnUniv);
        }

        public List<FacultateCameraInfo> GetFacultateCameraListByFacultate(long iD_Facultate)
        {
            return _repo.GetFacultateCameraListByFacultate(iD_Facultate);
        }

        public List<FacultateCameraInfo> GetFacultateCameraListByFacultateAnUniv(long iD_Facultate, long ID_AnUniv)
        {
            return _repo.GetFacultateCameraListByFacultateAnUniv(iD_Facultate, ID_AnUniv);
        }

        public List<FacultateCameraInfo> GetFacultateCameraListByCamera(long iD_Camera)
        {
            return _repo.GetFacultateCameraListByCamera(iD_Camera);
        }

        public long AddFacultateCamera(FacultateCameraInfo objFacultateCamera)
        {
            return _repo.AddFacultateCamera(objFacultateCamera);
        }

        public void UpdateFacultateCamera(FacultateCameraInfo objFacultateCamera)
        {
            _repo.UpdateFacultateCamera(objFacultateCamera);
        }

        public void DeleteFacultateCamera(FacultateCameraInfo objFacultateCamera)
        {
            _repo.DeleteFacultateCamera(objFacultateCamera);
        }

        public void DeleteFacultateCameraByFacultateCamera(long ID_Facultate, long ID_Camera)
        {
            _repo.DeleteFacultateCameraByFacultateCamera(ID_Facultate, ID_Camera);
        }
    }
}
