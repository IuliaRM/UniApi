using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class SportNeprofilStudentRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public SportNeprofilStudentInfo SportNeprofilStudentGet(long idSportNeprofilStudent)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<SportNeprofilStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SportNeprofilStudentGet", idSportNeprofilStudent));
        }

        public List<SportNeprofilStudentInfo> SportNeprofilStudentListBySportNeprofilGet(long idSportNeprofil)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<SportNeprofilStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SportNeprofilStudentListBySportNeprofil", idSportNeprofil));
        }

        public List<SportNeprofilStudentInfo> SportNeprofilStudentListByStudentGet(long idStudent)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<SportNeprofilStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SportNeprofilStudentListByStudent", idStudent));
        }

        public List<SportNeprofilStudentInfo> SportNeprofilStudentListByStudentAnUnivGet(long idStudent, long idAnUniv, int nrSemestru)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<SportNeprofilStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SportNeprofilStudentListByStudentAnUniv", idStudent, idAnUniv, nrSemestru));
        }

        public List<SportNeprofilStudentInfo2> SportNeprofilStudentListByStudentAnUniv2Get(long idStudent, long idAnUniv, int nrSemestru)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<SportNeprofilStudentInfo2>(
                SqlHelper.ExecuteReader(_connectionString, "SportNeprofilStudentListByStudentAnUniv", idStudent, idAnUniv, nrSemestru));
        }

        public long SportNeprofilStudentAdd(SportNeprofilStudentInfo sportNeprofilStudent)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "SportNeprofilStudentAdd",
                sportNeprofilStudent.ID_SportNeprofil, sportNeprofilStudent.ID_Student);
            return Convert.ToInt64(id);
        }

        public void SportNeprofilStudentUpdate(SportNeprofilStudentInfo sportNeprofilStudent)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "SportNeprofilStudentUpdate",
                sportNeprofilStudent.ID_SportNeprofilStudent, sportNeprofilStudent.ID_SportNeprofil, sportNeprofilStudent.ID_Student);
        }

        public void SportNeprofilStudentDelete(SportNeprofilStudentInfo sportNeprofilStudent)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "SportNeprofilStudentDelete", sportNeprofilStudent.ID_SportNeprofilStudent);
        }

        public List<SportNeprofilStudentInfo> SportNeprofilStudentListByAnUniversitarGet(long idAnUniv, int nrSemestru)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<SportNeprofilStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SportNeprofilStudentListByAnUniversitar", idAnUniv, nrSemestru));
        }
    }
}
