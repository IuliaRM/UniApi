using System;
using System.Collections.Generic;
using UniApi.Models;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using DotNetNuke.Common.Utilities;

namespace UniApi.Dal.Repos
{
    public class EvaluareProfesorRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public List<EvaluareProfesorInfo> GetEvaluareProfesorList()
        {
            return CBO.FillCollection<EvaluareProfesorInfo>(SqlHelper.ExecuteReader(_ConnectionString, "EvaluareProfesorList"));
        }

        public List<EvaluareProfesorInfo> GetEvaluareProfesorListNrChestionareCompletate(long ID_AnUniv, int NrSemestru)
        {
            return CBO.FillCollection<EvaluareProfesorInfo>(SqlHelper.ExecuteReader(_ConnectionString, "EvaluareProfesorListNrChestionareCompletate", ID_AnUniv, NrSemestru));
        }

        public List<EvaluareProfesorInfo> GetEvaluareProfesorListNrChestionareCompletate_Prof(long ID_AnUniv, int NrSemestru)
        {
            return CBO.FillCollection<EvaluareProfesorInfo>(SqlHelper.ExecuteReader(_ConnectionString, "EvaluareProfesorListNrChestionareCompletate_Prof", ID_AnUniv, NrSemestru));
        }

        public List<EvaluareProfesorInfo> GetEvaluareProfesorListProfiDeEvaluat(long ID_AnUniv, int NrSemestru)
        {
            return CBO.FillCollection<EvaluareProfesorInfo>(SqlHelper.ExecuteReader(_ConnectionString, "EvaluareProfesorListProfiDeEvaluat", ID_AnUniv, NrSemestru));
        }

        public long AddEvaluareProfesor(EvaluareProfesorInfo objEvaluareProfesor)
        {
            object o = SqlHelper.ExecuteScalar(_ConnectionString, "EvaluareProfesorAdd", objEvaluareProfesor.ID_Profesor, objEvaluareProfesor.ID_Specializare, objEvaluareProfesor.ID_AnUniv, objEvaluareProfesor.NrSemestru, objEvaluareProfesor.Status, objEvaluareProfesor.ID_DetaliuPlanSemestru);
            return Convert.ToInt64(o);
        }

        public void UpdateEvaluareProfesor(EvaluareProfesorInfo objEvaluareProfesor)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "EvaluareProfesorUpdate", objEvaluareProfesor.ID_EvaluareProfesor, objEvaluareProfesor.ID_Profesor, objEvaluareProfesor.ID_Specializare, objEvaluareProfesor.ID_AnUniv, objEvaluareProfesor.NrSemestru, objEvaluareProfesor.Status);
        }

        public void DeleteEvaluareProfesor(EvaluareProfesorInfo objEvaluareProfesor)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "EvaluareProfesorDelete", objEvaluareProfesor.ID_EvaluareProfesor);
        }

        public void DeleteEvaluareProfesorBySpecializareSemestru(long id_prof, long spec, int nrsem, long id_dps)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "EvaluareProfesorDeleteBySpecializareSemestru", id_prof, spec, nrsem, id_dps);
        }

        public void GenerateCoduriEvaluare(long ID_AnUniv, int NrSemestru)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "EvaluareProfesorGenereazaCoduriEvaluare", ID_AnUniv, NrSemestru, -1);
        }
    }
}
