using System;
using System.Collections.Generic;
using System.Configuration;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class StudentInfoSuplimentareRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public long StudentInfoSuplimentaraAdd(StudentInfoSuplimentare sis)
        {
            object ret = SqlHelper.ExecuteScalar(_connectionString, "StudentInfoSuplimentareAdd",
                sis.ID_Student, sis.StudentInfo, sis.StudentInfoEngleza, sis.TipInfoSuplimentara);
            return Convert.ToInt64(ret);
        }

        public long StudentInfoSuplimentaraUpdate(StudentInfoSuplimentare sis)
        {
            object ret = SqlHelper.ExecuteScalar(_connectionString, "StudentInfoSuplimentareUpdate",
                sis.ID_StudentInformatii, sis.StudentInfo, sis.StudentInfoEngleza, sis.TipInfoSuplimentara);
            return Convert.ToInt64(ret);
        }

        public void StudentInfoSuplimentaraDelete(long idStudentInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "StudentInfoSuplimentareDelete", idStudentInfo);
        }

        public List<StudentInfoSuplimentare> StudentInfoSuplimentaraListGet(long idStudent)
        {
            return CBO.FillCollection<StudentInfoSuplimentare>(
                SqlHelper.ExecuteReader(_connectionString, "StudentInfoSuplimentareList", idStudent));
        }

        public List<StudentInfoSuplimentare> StudentInfoSuplimentaraListByTipGet(long idStudent, string tip)
        {
            return CBO.FillCollection<StudentInfoSuplimentare>(
                SqlHelper.ExecuteReader(_connectionString, "StudentInfoSuplimentaraListByTip", idStudent, tip));
        }
    }
}