using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface ICodEvaluareRepo
    {
        long CodEvaluareAdd(CodEvaluareInfo info);
        void CodEvaluareUpdate(CodEvaluareInfo info);
        void CodEvaluareDelete(long idCodEvaluare);
        CodEvaluareInfo CodEvaluareGet(long idCodEvaluare);
        List<CodEvaluareInfo> CodEvaluareList();
        List<CodEvaluareInfo> CodEvaluareListByProfesor(long idProfesor);
        List<CodEvaluareInfo> CodEvaluareListBySefCatedra(long idSefCatedra);
        List<CodEvaluareInfo> CodEvaluareListBySpecializareSemestru(long idSpecializare, int semestru);
        List<CodEvaluareInfo> CodEvaluareListByUserIdRol(long idUser, long idRol);
        List<CodEvaluareInfo> CodEvaluareListByUsernameRole(string username, string role);
        List<CodEvaluareInfo> CodEvaluareExamneListByAnUnivSesiuneActiva(long idAnUniv);
        void CodEvaluareUpdateDataEmail(long idCodEvaluare, DateTime dataTrimitere);
    }

    public class CodEvaluareRepo : ICodEvaluareRepo
    {
        private readonly string _connectionString;

        public CodEvaluareRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;
            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found.");
        }

        public long CodEvaluareAdd(CodEvaluareInfo info)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            try
            {
                return Convert.ToInt64(SqlHelper.ExecuteScalar(_connectionString, "CodEvaluareAdd",
                    info.ID_DetaliuPlanSemestru,
                    info.ID_EvaluareProfesor,
                    info.TipCursEvaluat,
                    info.CodEvaluare,
                    info.Status));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la adăugarea codului de evaluare.", ex);
            }
        }

        public void CodEvaluareUpdate(CodEvaluareInfo info)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "CodEvaluareUpdate",
                    info.ID_CodEvaluare,
                    info.ID_DetaliuPlanSemestru,
                    info.ID_EvaluareProfesor,
                    info.TipCursEvaluat,
                    info.CodEvaluare,
                    info.Status);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la actualizarea codului de evaluare.", ex);
            }
        }

        public void CodEvaluareDelete(long idCodEvaluare)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "CodEvaluareDelete", idCodEvaluare);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la ștergerea codului de evaluare.", ex);
            }
        }

        public CodEvaluareInfo CodEvaluareGet(long idCodEvaluare)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "CodEvaluareGet", idCodEvaluare))
                {
                    return CBO.FillObject<CodEvaluareInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obținerea codului de evaluare.", ex);
            }
        }

        public List<CodEvaluareInfo> CodEvaluareList()
        {
            try
            {
                return CBO.FillCollection<CodEvaluareInfo>(SqlHelper.ExecuteReader(_connectionString, "CodEvaluareList"));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea codurilor de evaluare.", ex);
            }
        }

        public List<CodEvaluareInfo> CodEvaluareListByProfesor(long idProfesor)
        {
            try
            {
                return CBO.FillCollection<CodEvaluareInfo>(SqlHelper.ExecuteReader(_connectionString, "CodEvaluareListByProfesor", idProfesor));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea codurilor după profesor.", ex);
            }
        }

        public List<CodEvaluareInfo> CodEvaluareListBySefCatedra(long idSefCatedra)
        {
            try
            {
                return CBO.FillCollection<CodEvaluareInfo>(SqlHelper.ExecuteReader(_connectionString, "CodEvaluareListBySefCatedra", idSefCatedra));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea codurilor după șef de catedră.", ex);
            }
        }

        public List<CodEvaluareInfo> CodEvaluareListBySpecializareSemestru(long idSpecializare, int semestru)
        {
            try
            {
                return CBO.FillCollection<CodEvaluareInfo>(SqlHelper.ExecuteReader(_connectionString, "CodEvaluareListBySpecializareSemestru", idSpecializare, semestru));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea codurilor după specializare și semestru.", ex);
            }
        }

        public List<CodEvaluareInfo> CodEvaluareListByUserIdRol(long idUser, long idRol)
        {
            try
            {
                return CBO.FillCollection<CodEvaluareInfo>(SqlHelper.ExecuteReader(_connectionString, "CodEvaluareListByUserIdRol", idUser, idRol));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea codurilor după user și rol.", ex);
            }
        }

        public List<CodEvaluareInfo> CodEvaluareListByUsernameRole(string username, string role)
        {
            try
            {
                return CBO.FillCollection<CodEvaluareInfo>(SqlHelper.ExecuteReader(_connectionString, "CodEvaluareListByUsernameRole", username, role));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea codurilor după username și rol.", ex);
            }
        }

        public List<CodEvaluareInfo> CodEvaluareExamneListByAnUnivSesiuneActiva(long idAnUniv)
        {
            try
            {
                return CBO.FillCollection<CodEvaluareInfo>(SqlHelper.ExecuteReader(_connectionString, "CodEvaluareExamneListByAnUnivSesiuneActiva", idAnUniv));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea codurilor de evaluare pentru sesiune activă.", ex);
            }
        }

        public void CodEvaluareUpdateDataEmail(long idCodEvaluare, DateTime dataTrimitere)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "CodEvaluareUpdateDataEmail", idCodEvaluare, dataTrimitere);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la actualizarea datei de trimitere pe email.", ex);
            }
        }
    }
}
