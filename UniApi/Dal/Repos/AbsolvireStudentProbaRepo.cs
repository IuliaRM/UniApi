using System;
using System.Collections.Generic;
using System.Data;
using System.Web.Http;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public class AbsolvireStudentProbaRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public AbsolvireStudentProbaInfo AbsolvireStudentProbaGet(long idStudentAbsolventProba)
        {
            return CBO.FillObject<AbsolvireStudentProbaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "AbsolvireStudentProbaGet", idStudentAbsolventProba));
        }

        public List<AbsolvireStudentProbaInfo> AbsolvireStudentProbaList()
        {
            return CBO.FillCollection<AbsolvireStudentProbaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "AbsolvireStudentProbaList"));
        }

        public List<AbsolvireStudentProbaInfo> AbsolvireStudentProbaListByStudent(long idAbsolvireStudent)
        {
            return CBO.FillCollection<AbsolvireStudentProbaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "AbsolvireStudentProbaListByStudent", idAbsolvireStudent));
        }

        public List<AbsolvireStudentProbaInfo> AbsolvireStudentProbaListByAbsolventProgramProba(long idAbsolvireStudent, long idAbsolvireProgramProba)
        {
            return CBO.FillCollection<AbsolvireStudentProbaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "AbsolvireStudentProbaListByAbsolventProgramProba", idAbsolvireStudent, idAbsolvireProgramProba));
        }

        public long AbsolvireStudentProbaAdd(AbsolvireStudentProbaInfo probaInfo)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "AbsolvireStudentProbaAdd",
                probaInfo.ID_AbsolvireProgramProba,
                probaInfo.Nota,
                probaInfo.ID_NotaStudentMateriePachetAbsolvire,
                probaInfo.ID_AbsolvireStudent);

            return Convert.ToInt64(id);
        }

        public void AbsolvireStudentProbaUpdate(AbsolvireStudentProbaInfo probaInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireStudentProbaUpdate",
                probaInfo.ID_StudentAbsolventProba,
                probaInfo.ID_AbsolvireProgramProba,
                probaInfo.Nota,
                probaInfo.ID_NotaStudentMateriePachetAbsolvire,
                probaInfo.ID_AbsolvireStudent);
        }

        public void AbsolvireStudentProbaDelete(long idStudentAbsolventProba)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireStudentProbaDelete", idStudentAbsolventProba);
        }
    }
}
