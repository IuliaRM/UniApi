using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface ICererePrecazareRepo
    {
        long CererePrecazareAdd(CererePrecazareInfo info);
        void CererePrecazareUpdate(CererePrecazareInfo info);
        void CererePrecazareDelete(long idCererePrecazare);
        CererePrecazareInfo CererePrecazareGet(long idCererePrecazare);
        List<CererePrecazareInfo> CererePrecazareList();
        List<CererePrecazareInfo> CererePrecazareListByStudent(long idStudent);
        List<CererePrecazareInfo> CererePrecazareListByStudentComplet(long idStudent, long idAnUniv);
        List<CererePrecazareInfo> CererePrecazareListByCamera(long idCamera);
        List<CererePrecazareInfo> CererePrecazareListByStudentUsername(string username);
        List<CererePrecazareInfo> CererePrecazareListStudentCompletByFacultate(long idFacultate);
        List<CererePrecazareInfo> CererePrecazareListStudentCompletByFCFSAnUniv(long idFacultate, long idCamin, long idAnUniv);
        CererePrecazareInfo CererePrecazareGetByStudentIdAnUniversitar(long idStudent, long idAnUniv);
    }

    public class CererePrecazareRepo : ICererePrecazareRepo
    {
        private readonly string _connectionString;

        public CererePrecazareRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;
            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found.");
        }

        public long CererePrecazareAdd(CererePrecazareInfo info)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            try
            {
                return Convert.ToInt64(SqlHelper.ExecuteScalar(_connectionString, "CererePrecazareAdd",
                    info.ID_Student,
                    info.ID_Camera,
                    info.DataCerere,
                    info.Motiv,
                    info.ID_AnUniv));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la adăugarea cererii de precazare.", ex);
            }
        }

        public void CererePrecazareUpdate(CererePrecazareInfo info)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "CererePrecazareUpdate",
                    info.ID_CererePrecazare,
                    info.ID_Student,
                    info.ID_Camera,
                    info.DataCerere,
                    info.Motiv,
                    info.ID_AnUniv);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la actualizarea cererii de precazare.", ex);
            }
        }

        public void CererePrecazareDelete(long idCererePrecazare)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "CererePrecazareDelete", idCererePrecazare);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la ștergerea cererii de precazare.", ex);
            }
        }

        public CererePrecazareInfo CererePrecazareGet(long idCererePrecazare)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "CererePrecazareGet", idCererePrecazare))
                {
                    return CBO.FillObject<CererePrecazareInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obținerea cererii de precazare.", ex);
            }
        }

        public List<CererePrecazareInfo> CererePrecazareList()
        {
            try
            {
                return CBO.FillCollection<CererePrecazareInfo>(SqlHelper.ExecuteReader(_connectionString, "CererePrecazareList"));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea cererilor de precazare.", ex);
            }
        }

        public List<CererePrecazareInfo> CererePrecazareListByStudent(long idStudent)
        {
            try
            {
                return CBO.FillCollection<CererePrecazareInfo>(SqlHelper.ExecuteReader(_connectionString, "CererePrecazareListByStudent", idStudent));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea cererilor de precazare după student.", ex);
            }
        }

        public List<CererePrecazareInfo> CererePrecazareListByStudentComplet(long idStudent, long idAnUniv)
        {
            try
            {
                return CBO.FillCollection<CererePrecazareInfo>(SqlHelper.ExecuteReader(_connectionString, "CererePrecazareListByStudentComplet", idStudent, idAnUniv));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea completă a cererilor după student și an universitar.", ex);
            }
        }

        public List<CererePrecazareInfo> CererePrecazareListByCamera(long idCamera)
        {
            try
            {
                return CBO.FillCollection<CererePrecazareInfo>(SqlHelper.ExecuteReader(_connectionString, "CererePrecazareListByCamera", idCamera));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea cererilor după cameră.", ex);
            }
        }

        public List<CererePrecazareInfo> CererePrecazareListByStudentUsername(string username)
        {
            try
            {
                return CBO.FillCollection<CererePrecazareInfo>(SqlHelper.ExecuteReader(_connectionString, "CererePrecazareListByStudentUsername", username));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea cererilor după username student.", ex);
            }
        }

        public List<CererePrecazareInfo> CererePrecazareListStudentCompletByFacultate(long idFacultate)
        {
            try
            {
                return CBO.FillCollection<CererePrecazareInfo>(SqlHelper.ExecuteReader(_connectionString, "CererePrecazareListStudentCompletByFacultate", idFacultate));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea completă a cererilor după facultate.", ex);
            }
        }

        public List<CererePrecazareInfo> CererePrecazareListStudentCompletByFCFSAnUniv(long idFacultate, long idCamin, long idAnUniv)
        {
            try
            {
                return CBO.FillCollection<CererePrecazareInfo>(SqlHelper.ExecuteReader(_connectionString, "CererePrecazareListStudentCompletByFCFSAnUniv", idFacultate, idCamin, idAnUniv));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea cererilor după FCFS, cămin și an universitar.", ex);
            }
        }

        public CererePrecazareInfo CererePrecazareGetByStudentIdAnUniversitar(long idStudent, long idAnUniv)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "CererePrecazareGetByStudentIdAnUniversitar", idStudent, idAnUniv))
                {
                    return CBO.FillObject<CererePrecazareInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obținerea cererii după student și an universitar.", ex);
            }
        }
    }
}
