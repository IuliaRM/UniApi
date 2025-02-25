using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;


namespace UniApi.Dal.Repos
{
    public class AbsolvireStudentProbaRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public AbsolvireStudentProbaInfo AbsolvireStudentProbaGet(long idStudentAbsolventProba)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<AbsolvireStudentProbaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "AbsolvireStudentProbaGet", idStudentAbsolventProba));
        }

        public AbsolvireStudentProbaInfo AbsolvireStudentProbaGetByAbsolventProgramProba(long idAbsolvireStudent, long idAbsolvireProgramProba)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<AbsolvireStudentProbaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "AbsolvireStudentProbaGetByAbsolventProgramProba", idAbsolvireStudent, idAbsolvireProgramProba));
        }

        public List<AbsolvireStudentProbaInfo> AbsolvireStudentProbaList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<AbsolvireStudentProbaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "AbsolvireStudentProbaList"));
        }

        public List<AbsolvireStudentProbaInfo> AbsolvireStudentProbaListByStudent(long idAbsolvireStudent)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<AbsolvireStudentProbaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "AbsolvireStudentProbaListByStudent", idAbsolvireStudent));
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
