using System;
using System.Collections.Generic;
using System.Data;
using UniApi.Models;
using Microsoft.ApplicationBlocks.Data;

namespace UniApi.Dal.Repos
{
    public class DetaliuPlanSemestruProfesorRepo
    {
        private readonly string _connectionString;

        public DetaliuPlanSemestruProfesorRepo()
        {
            _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;
        }

        public DetaliuPlanSemestruProfesorInfo DetaliuPlanSemestruProfesorGet(long ID_DetaliuPlanSemestruProfesor)
        {
            return CBO.FillObject<DetaliuPlanSemestruProfesorInfo>(
                SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruProfesorGet", ID_DetaliuPlanSemestruProfesor)
            );
        }

        public List<DetaliuPlanSemestruProfesorInfo> DetaliuPlanSemestruProfesorList()
        {
            return CBO.FillCollection<DetaliuPlanSemestruProfesorInfo>(
                SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruProfesorList")
            );
        }

        public List<DetaliuPlanSemestruProfesorInfo> DetaliuPlanSemestruProfesorListByProfesor(long ID_Profesor, long ID_AnUniv, long ID_Scenariu)
        {
            return CBO.FillCollection<DetaliuPlanSemestruProfesorInfo>(
                SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruProfesorListByProfesor", ID_Profesor, ID_AnUniv, ID_Scenariu)
            );
        }

        public List<DetaliuPlanSemestruProfesorInfo> DetaliuPlanSemestruProfesorListByTipOrePredate(long ID_TipOrePredate)
        {
            return CBO.FillCollection<DetaliuPlanSemestruProfesorInfo>(
                SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruProfesorListByTipOrePredate", ID_TipOrePredate)
            );
        }

        public int DetaliuPlanSemestruProfesorAdd(DetaliuPlanSemestruProfesorInfo objDetaliuPlanSemestruProfesor)
        {
            return (int)SqlHelper.ExecuteScalar(
                _connectionString,
                "DetaliuPlanSemestruProfesorAdd",
                objDetaliuPlanSemestruProfesor.ID_DetaliuPlanSemestru,
                objDetaliuPlanSemestruProfesor.ID_Profesor,
                objDetaliuPlanSemestruProfesor.ID_TipOrePredate,
                objDetaliuPlanSemestruProfesor.NumarOrePredateFizice
            );
        }

        public void DetaliuPlanSemestruProfesorUpdate(DetaliuPlanSemestruProfesorInfo objDetaliuPlanSemestruProfesor)
        {
            SqlHelper.ExecuteNonQuery(
                _connectionString,
                "DetaliuPlanSemestruProfesorUpdate",
                objDetaliuPlanSemestruProfesor.ID_DetaliuPlanSemestruProfesor,
                objDetaliuPlanSemestruProfesor.ID_DetaliuPlanSemestru,
                objDetaliuPlanSemestruProfesor.ID_Profesor,
                objDetaliuPlanSemestruProfesor.ID_TipOrePredate,
                objDetaliuPlanSemestruProfesor.NumarOrePredateFizice
            );
        }

        public void DetaliuPlanSemestruProfesorDelete(long ID_DetaliuPlanSemestruProfesor)
        {
            SqlHelper.ExecuteNonQuery(
                _connectionString,
                "DetaliuPlanSemestruProfesorDelete",
                ID_DetaliuPlanSemestruProfesor
            );
        }

        public List<DetaliuPlanSemestruProfesorInfo> DetaliuPlanSemestruProfesorListByProfesorComplet(long ID_Profesor, long ID_AnUniv, long ID_Scenariu)
        {
            return CBO.FillCollection<DetaliuPlanSemestruProfesorInfo>(
                SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruProfesorListByProfesorComplet", ID_Profesor, ID_AnUniv, ID_Scenariu)
            );
        }

        public List<DetaliuPlanSemestruProfesorInfo> DetaliuPlanSemestruProfesorListByDetaliuPlanSemestru(long ID_DetaliuPlanSemestru)
        {
            return CBO.FillCollection<DetaliuPlanSemestruProfesorInfo>(
                SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruProfesorListByDetaliuPlanSemestru", ID_DetaliuPlanSemestru)
            );
        }

        public List<DetaliuPlanSemestruProfesorInfo> DetaliuPlanSemestruProfesorListBySpecializareNrSemestruScenariuActiv(long ID_Domeniu, long ID_Specializare, int nrSem)
        {
            return CBO.FillCollection<DetaliuPlanSemestruProfesorInfo>(
                SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruProfesorListBySpecializareNrSemestruScenariuActiv", ID_Domeniu, ID_Specializare, nrSem)
            );
        }

        public List<DetaliuPlanSemestruProfesorInfo> DetaliuPlanSemestruProfesorListByProfesorSpecializare(long ID_Profesor, long ID_Domeniu, long ID_Specializare, int nrSem)
        {
            return CBO.FillCollection<DetaliuPlanSemestruProfesorInfo>(
                SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruProfesorListByProfesorSpecializare", ID_Profesor, ID_Domeniu, ID_Specializare, nrSem)
            );
        }
    }
}
