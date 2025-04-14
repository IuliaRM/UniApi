using System;
using System.Collections.Generic;
using System.Configuration;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{

    public interface IStudentInfoSuplimentareRepo
    {
        long StudentInfoSuplimentareAdd(StudentInfoSuplimentare sis);
        void StudentInfoSuplimentareDelete(long idStudentInfo);
        List<StudentInfoSuplimentare> StudentInfoSuplimentareList(long idStudent);
        long StudentInfoSuplimentareUpdate(StudentInfoSuplimentare sis);
    }

    public class StudentInfoSuplimentareRepo : IStudentInfoSuplimentareRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public long StudentInfoSuplimentareAdd(StudentInfoSuplimentare sis)
        {
            object ret = SqlHelper.ExecuteScalar(_connectionString, "StudentInfoSuplimentareAdd",
                sis.ID_Student, sis.StudentInfo, sis.StudentInfoEngleza, sis.TipInfoSuplimentara);
            return Convert.ToInt64(ret);
        }

        public long StudentInfoSuplimentareUpdate(StudentInfoSuplimentare sis)
        {
            object ret = SqlHelper.ExecuteScalar(_connectionString, "StudentInfoSuplimentareUpdate",
                sis.ID_StudentInformatii, sis.StudentInfo, sis.StudentInfoEngleza, sis.TipInfoSuplimentara);
            return Convert.ToInt64(ret);
        }

        public void StudentInfoSuplimentareDelete(long idStudentInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "StudentInfoSuplimentareDelete", idStudentInfo);
        }

        public List<StudentInfoSuplimentare> StudentInfoSuplimentareList(long idStudent)
        {
            return CBO.FillCollection<StudentInfoSuplimentare>(
                SqlHelper.ExecuteReader(_connectionString, "StudentInfoSuplimentareList", idStudent));
        }
    }
}