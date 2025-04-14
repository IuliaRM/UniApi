using System;
using System.Configuration;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Controllers;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IEvaluareProfesorRepo
    {
        void EvaluareProfesorAdd(EvaluareProfesorInfo info);
        void EvaluareProfesorUpdate(EvaluareProfesorInfo info);
        void EvaluareProfesorDelete(EvaluareProfesorInfo info);
        void EvaluareProfesorDeleteBySpecializareSemestru(long idProf, long idSpecializare, int nrSemestru, long idDps);
        void EvaluareProfesor_DeleteBySpecializareSemestru(long idSpecializare, int nrSemestru);
        void EvaluareProfesorGenereazaCoduriEvaluare(long idAnUniv, int nrSemestru);
        void EvaluareProfesorGenereazaCoduriEvaluare_OLD(long idAnUniv, int nrSemestru);
        void EvaluareProfesorBifeazaProfesorDinStatImportatInDetaliuPlanSemestru(long idAnUniv);
        DataTable EvaluareProfesorList();
        DataTable EvaluareProfesorListNrChestionareCompletate(long idAnUniv, int nrSemestru);
        DataTable EvaluareProfesorListNrChestionareCompletate_Prof(long idAnUniv, int nrSemestru);
        DataTable EvaluareProfesorListProfiDeEvaluat(long idAnUniv, int nrSemestru);
    }

    public class EvaluareProfesorRepo : IEvaluareProfesorRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public DataTable EvaluareProfesorList()
        {
            try
            {
                return SqlHelper.ExecuteDataset(_connectionString, "EvaluareProfesor_GetEvaluareProfesorList").Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la EvaluareProfesorList", ex);
            }
        }

        public DataTable EvaluareProfesorListNrChestionareCompletate(long idAnUniv, int nrSemestru)
        {
            try
            {
                return SqlHelper.ExecuteDataset(_connectionString, "EvaluareProfesor_GetEvaluareProfesorListNrChestionareCompletate", idAnUniv, nrSemestru).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la EvaluareProfesorListNrChestionareCompletate", ex);
            }
        }

        public DataTable EvaluareProfesorListNrChestionareCompletate_Prof(long idAnUniv, int nrSemestru)
        {
            try
            {
                return SqlHelper.ExecuteDataset(_connectionString, "EvaluareProfesor_GetEvaluareProfesorListNrChestionareCompletate_Prof", idAnUniv, nrSemestru).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la EvaluareProfesorListNrChestionareCompletate_Prof", ex);
            }
        }

        public DataTable EvaluareProfesorListProfiDeEvaluat(long idAnUniv, int nrSemestru)
        {
            try
            {
                return SqlHelper.ExecuteDataset(_connectionString, "EvaluareProfesor_GetEvaluareProfesorListProfiDeEvaluat", idAnUniv, nrSemestru).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la EvaluareProfesorListProfiDeEvaluat", ex);
            }
        }

        public void EvaluareProfesorAdd(EvaluareProfesorInfo info)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "EvaluareProfesor_AddEvaluareProfesor", info);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la EvaluareProfesorAdd", ex);
            }
        }

        public void EvaluareProfesorUpdate(EvaluareProfesorInfo info)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "EvaluareProfesor_UpdateEvaluareProfesor", info);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la EvaluareProfesorUpdate", ex);
            }
        }

        public void EvaluareProfesorDelete(EvaluareProfesorInfo info)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "EvaluareProfesor_DeleteEvaluareProfesor", info);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la EvaluareProfesorDelete", ex);
            }
        }

        public void EvaluareProfesorDeleteBySpecializareSemestru(long idProf, long idSpecializare, int nrSemestru, long idDps)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "EvaluareProfesor_DeleteEvaluareProfesorBySpecializareSemestru", idProf, idSpecializare, nrSemestru, idDps);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la EvaluareProfesorDeleteBySpecializareSemestru", ex);
            }
        }

        public void EvaluareProfesor_DeleteBySpecializareSemestru(long idSpecializare, int nrSemestru)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "EvaluareProfesor_DeleteEvaluareProfesor_BySpecializareSemestru", idSpecializare, nrSemestru);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la EvaluareProfesor_DeleteBySpecializareSemestru", ex);
            }
        }

        public void EvaluareProfesorGenereazaCoduriEvaluare(long idAnUniv, int nrSemestru)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "EvaluareProfesor_GenerateCoduriEvaluare", idAnUniv, nrSemestru);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la EvaluareProfesorGenereazaCoduriEvaluare", ex);
            }
        }

        public void EvaluareProfesorGenereazaCoduriEvaluare_OLD(long idAnUniv, int nrSemestru)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "EvaluareProfesor_GenerateCoduriEvaluare_OLD", idAnUniv, nrSemestru);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la EvaluareProfesorGenereazaCoduriEvaluare_OLD", ex);
            }
        }

        public void EvaluareProfesorBifeazaProfesorDinStatImportatInDetaliuPlanSemestru(long idAnUniv)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "EvaluareProfesor_BifeazaProfesorImportatInDps", idAnUniv);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la EvaluareProfesorBifeazaProfesorDinStatImportatInDetaliuPlanSemestru", ex);
            }
        }
    }
}
