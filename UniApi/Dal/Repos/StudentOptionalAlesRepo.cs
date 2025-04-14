using System;
using System.Collections.Generic;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{

    public interface IStudentOptionalAlesRepo
    {
        StudentOptionalAlesInfo StudentOptionalAlesGet(long idStudentOptionalAles);
        List<StudentOptionalAlesInfo> StudentOptionalAlesList();
        List<StudentOptionalAlesInfo> StudentOptionalAlesListByStudent(long idStudent);
        List<StudentOptionalAlesInfo> StudentOptionalAlesListByDetaliuPlanSemestru(long idDetaliuPlanSemestru);
        long StudentOptionalAlesAdd(StudentOptionalAlesInfo studentOptionalAles);
        void StudentOptionalAlesUpdate(StudentOptionalAlesInfo studentOptionalAles);
        void StudentOptionalAlesDelete(long idStudentOptionalAles);
    }

    public class StudentOptionalAlesRepo : IStudentOptionalAlesRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public StudentOptionalAlesInfo StudentOptionalAlesGet(long idStudentOptionalAles)
        {
            return CBO.FillObject<StudentOptionalAlesInfo>(
                SqlHelper.ExecuteReader(_connectionString, "StudentOptionalAlesGet", idStudentOptionalAles));
        }

        public List<StudentOptionalAlesInfo> StudentOptionalAlesList()
        {
            return CBO.FillCollection<StudentOptionalAlesInfo>(
                SqlHelper.ExecuteReader(_connectionString, "StudentOptionalAlesList"));
        }

        public List<StudentOptionalAlesInfo> StudentOptionalAlesListByStudent(long idStudent)
        {
            return CBO.FillCollection<StudentOptionalAlesInfo>(
                SqlHelper.ExecuteReader(_connectionString, "StudentOptionalAlesListByStudent", idStudent));
        }

        public List<StudentOptionalAlesInfo> StudentOptionalAlesListByDetaliuPlanSemestru(long idDetaliuPlanSemestru)
        {
            return CBO.FillCollection<StudentOptionalAlesInfo>(
                SqlHelper.ExecuteReader(_connectionString, "StudentOptionalAlesListByDetaliuPlanSemestru", idDetaliuPlanSemestru));
        }

        public long StudentOptionalAlesAdd(StudentOptionalAlesInfo studentOptionalAles)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "StudentOptionalAlesAdd",
                studentOptionalAles.ID_Student,
                studentOptionalAles.ID_DetaliuPlanSemestru);
            return Convert.ToInt64(id);
        }

        public void StudentOptionalAlesUpdate(StudentOptionalAlesInfo studentOptionalAles)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "StudentOptionalAlesUpdate",
                studentOptionalAles.ID_StudentOptionalAles,
                studentOptionalAles.ID_Student,
                studentOptionalAles.ID_DetaliuPlanSemestru);
        }

        public void StudentOptionalAlesDelete(long idStudentOptionalAles)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "StudentOptionalAlesDelete", idStudentOptionalAles);
        }
    }
}
