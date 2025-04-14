using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IAbsolvireStudentProbaRepo
    {
        AbsolvireStudentProbaInfo AbsolvireStudentProbaGet(long idStudentAbsolventProba);
        List<AbsolvireStudentProbaInfo> AbsolvireStudentProbaList();
        List<AbsolvireStudentProbaInfo> AbsolvireStudentProbaListByStudent(long idAbsolvireStudent);
        List<AbsolvireStudentProbaInfo> AbsolvireStudentProbaGetByAbsolventProgramProba(long idAbsolvireStudent, long idAbsolvireProgramProba);
        long AbsolvireStudentProbaAdd(AbsolvireStudentProbaInfo probaInfo);
        void AbsolvireStudentProbaUpdate(AbsolvireStudentProbaInfo probaInfo);
        void AbsolvireStudentProbaDelete(long idStudentAbsolventProba);
    }
    public class AbsolvireStudentProbaRepo : IAbsolvireStudentProbaRepo
    {
        private readonly string _connectionString;

        public AbsolvireStudentProbaRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;

            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found.");
        }

        public AbsolvireStudentProbaInfo AbsolvireStudentProbaGet(long idStudentAbsolventProba)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "AbsolvireStudentProbaGet", idStudentAbsolventProba))
                {
                    return CBO.FillObject<AbsolvireStudentProbaInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving AbsolvireStudentProba.", ex);
            }
        }

        public List<AbsolvireStudentProbaInfo> AbsolvireStudentProbaList()
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "AbsolvireStudentProbaList"))
                {
                    return CBO.FillCollection<AbsolvireStudentProbaInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving AbsolvireStudentProba list.", ex);
            }
        }

        public List<AbsolvireStudentProbaInfo> AbsolvireStudentProbaListByStudent(long idAbsolvireStudent)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "AbsolvireStudentProbaListByStudent", idAbsolvireStudent))
                {
                    return CBO.FillCollection<AbsolvireStudentProbaInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving AbsolvireStudentProba list by student.", ex);
            }
        }

        public List<AbsolvireStudentProbaInfo> AbsolvireStudentProbaListByAbsolventProgramProba(long idAbsolvireStudent, long idAbsolvireProgramProba)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "AbsolvireStudentProbaListByAbsolventProgramProba", idAbsolvireStudent, idAbsolvireProgramProba))
                {
                    return CBO.FillCollection<AbsolvireStudentProbaInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving AbsolvireStudentProba by program/proba.", ex);
            }
        }

        public long AbsolvireStudentProbaAdd(AbsolvireStudentProbaInfo probaInfo)
        {
            if (probaInfo == null)
                throw new ArgumentNullException(nameof(probaInfo));

            try
            {
                var result = SqlHelper.ExecuteScalar(_connectionString, "AbsolvireStudentProbaAdd",
                    probaInfo.ID_AbsolvireProgramProba,
                    probaInfo.Nota,
                    probaInfo.ID_NotaStudentMateriePachetAbsolvire,
                    probaInfo.ID_AbsolvireStudent
                );

                return Convert.ToInt64(result);
            }
            catch (Exception ex)
            {
                throw new DataException("Error adding AbsolvireStudentProba.", ex);
            }
        }

        public void AbsolvireStudentProbaUpdate(AbsolvireStudentProbaInfo probaInfo)
        {
            if (probaInfo == null)
                throw new ArgumentNullException(nameof(probaInfo));

            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireStudentProbaUpdate",
                    probaInfo.ID_StudentAbsolventProba,
                    probaInfo.ID_AbsolvireProgramProba,
                    probaInfo.Nota,
                    probaInfo.ID_NotaStudentMateriePachetAbsolvire,
                    probaInfo.ID_AbsolvireStudent
                );
            }
            catch (Exception ex)
            {
                throw new DataException("Error updating AbsolvireStudentProba.", ex);
            }
        }

        public void AbsolvireStudentProbaDelete(long idStudentAbsolventProba)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireStudentProbaDelete", idStudentAbsolventProba);
            }
            catch (Exception ex)
            {
                throw new DataException("Error deleting AbsolvireStudentProba.", ex);
            }
        }

        public List<AbsolvireStudentProbaInfo> AbsolvireStudentProbaGetByAbsolventProgramProba(long idAbsolvireStudent, long idAbsolvireProgramProba)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "AbsolvireStudentProbaGetByAbsolventProgramProba", idAbsolvireStudent, idAbsolvireProgramProba))
                {
                    return CBO.FillCollection<AbsolvireStudentProbaInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving AbsolvireStudentProba by student and program/proba.", ex);
            }
        }

    }
}
