using System;
using System.Collections.Generic;
using UniApi.Info;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using DotNetNuke.Common.Utilities;

namespace UniApi.Dal.Repos
{
    public class EvaluareProfesorRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public List<EvaluareProfesorInfo> EvaluareProfesorListGet()
        {
            return CBO.FillCollection<EvaluareProfesorInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "EvaluareProfesor_GetEvaluareProfesorList"));
        }

        public List<EvaluareProfesorInfo> EvaluareProfesorListNrChestionareCompletateGet(long ID_AnUniv, int NrSemestru)
        {
            return CBO.FillCollection<EvaluareProfesorInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "EvaluareProfesor_GetEvaluareProfesorListNrChestionareCompletate", ID_AnUniv, NrSemestru));
        }

        public List<EvaluareProfesorInfo> EvaluareProfesorListNrChestionareCompletateProfGet(long ID_AnUniv, int NrSemestru)
        {
            return CBO.FillCollection<EvaluareProfesorInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "EvaluareProfesor_GetEvaluareProfesorListNrChestionareCompletate_Prof", ID_AnUniv, NrSemestru));
        }

        public List<EvaluareProfesorInfo> EvaluareProfesorListProfiDeEvaluatGet(long ID_AnUniv, int NrSemestru)
        {
            return CBO.FillCollection<EvaluareProfesorInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "EvaluareProfesor_GetEvaluareProfesorListProfiDeEvaluat", ID_AnUniv, NrSemestru));
        }

        public long EvaluareProfesorAdd(EvaluareProfesorInfo objEvaluareProfesor)
        {
            return (long)SqlHelper.ExecuteScalar(_ConnectionString, "EvaluareProfesor_AddEvaluareProfesor", objEvaluareProfesor);
        }

        public void EvaluareProfesorUpdate(EvaluareProfesorInfo objEvaluareProfesor)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "EvaluareProfesor_UpdateEvaluareProfesor", objEvaluareProfesor);
        }

        public void EvaluareProfesorDelete(EvaluareProfesorInfo objEvaluareProfesor)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "EvaluareProfesor_DeleteEvaluareProfesor", objEvaluareProfesor);
        }

        public void EvaluareProfesorDeleteBySpecializareSemestru(long ID_Prof, long ID_Specializare, int NrSemestru, long ID_Dps)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "EvaluareProfesor_DeleteEvaluareProfesorBySpecializareSemestru", ID_Prof, ID_Specializare, NrSemestru, ID_Dps);
        }

        public void CoduriEvaluareGenerate(long ID_AnUniv, int NrSemestru)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "EvaluareProfesor_GenerateCoduriEvaluare", ID_AnUniv, NrSemestru);
        }
    }
}
