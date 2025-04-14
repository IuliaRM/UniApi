using System;
using System.Collections.Generic;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{

    public interface ISportNeprofilStudentRepo
    {
        SportNeprofilStudentInfo SportNeprofilStudentGet(long idSportNeprofilStudent);
        List<SportNeprofilStudentInfo> SportNeprofilStudentListBySportNeprofil(long idSportNeprofil);
        List<SportNeprofilStudentInfo> SportNeprofilStudentListByStudent(long idStudent);
        List<SportNeprofilStudentInfo> SportNeprofilStudentListByStudentAnUniv(long idStudent, long idAnUniv);
        List<SportNeprofilStudentInfo> SportNeprofilStudentListByAnUniversitar(long idAnUniv);
        long SportNeprofilStudentAdd(SportNeprofilStudentInfo sportNeprofilStudent);
        void SportNeprofilStudentUpdate(SportNeprofilStudentInfo sportNeprofilStudent);
        void SportNeprofilStudentDelete(long idSportNeprofilStudent);
    }

    public class SportNeprofilStudentRepo : ISportNeprofilStudentRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public SportNeprofilStudentInfo SportNeprofilStudentGet(long idSportNeprofilStudent)
        {
            return CBO.FillObject<SportNeprofilStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SportNeprofilStudentGet", idSportNeprofilStudent));
        }

        public List<SportNeprofilStudentInfo> SportNeprofilStudentListBySportNeprofil(long idSportNeprofil)
        {
            return CBO.FillCollection<SportNeprofilStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SportNeprofilStudentListBySportNeprofil", idSportNeprofil));
        }

        public List<SportNeprofilStudentInfo> SportNeprofilStudentListByStudent(long idStudent)
        {
            return CBO.FillCollection<SportNeprofilStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SportNeprofilStudentListByStudent", idStudent));
        }

        public List<SportNeprofilStudentInfo> SportNeprofilStudentListByStudentAnUniv(long idStudent, long idAnUniv)
        {
            return CBO.FillCollection<SportNeprofilStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SportNeprofilStudentListByStudentAnUniv", idStudent, idAnUniv));
        }

        public List<SportNeprofilStudentInfo> SportNeprofilStudentListByAnUniversitar(long idAnUniv)
        {
            return CBO.FillCollection<SportNeprofilStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SportNeprofilStudentListByAnUniversitar", idAnUniv));
        }

        public long SportNeprofilStudentAdd(SportNeprofilStudentInfo sportNeprofilStudent)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "SportNeprofilStudentAdd",
                sportNeprofilStudent.ID_SportNeprofil,
                sportNeprofilStudent.ID_Student);
            return Convert.ToInt64(id);
        }

        public void SportNeprofilStudentUpdate(SportNeprofilStudentInfo sportNeprofilStudent)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "SportNeprofilStudentUpdate",
                sportNeprofilStudent.ID_SportNeprofilStudent,
                sportNeprofilStudent.ID_SportNeprofil,
                sportNeprofilStudent.ID_Student);
        }

        public void SportNeprofilStudentDelete(long idSportNeprofilStudent)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "SportNeprofilStudentDelete", idSportNeprofilStudent);
        }
    }
}
