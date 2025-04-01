using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class StudentOptionalAlesRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public StudentOptionalAlesInfo StudentOptionalAlesGet(long idStudentOptionalAles)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<StudentOptionalAlesInfo>(
                SqlHelper.ExecuteReader(_connectionString, "StudentOptionalAlesGet", idStudentOptionalAles));
        }

        public List<StudentOptionalAlesInfo> StudentOptionalAlesListGet()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<StudentOptionalAlesInfo>(
                SqlHelper.ExecuteReader(_connectionString, "StudentOptionalAlesList"));
        }

        public List<StudentOptionalAlesInfo> StudentOptionalAlesListByStudentGet(long idStudent)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<StudentOptionalAlesInfo>(
                SqlHelper.ExecuteReader(_connectionString, "StudentOptionalAlesListByStudent", idStudent));
        }

        public List<StudentOptionalAlesInfo> StudentOptionalAlesListByDetaliuPlanSemestruGet(long idDetaliuPlanSemestru)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<StudentOptionalAlesInfo>(
                SqlHelper.ExecuteReader(_connectionString, "StudentOptionalAlesListByDetaliuPlanSemestru", idDetaliuPlanSemestru));
        }

        public long StudentOptionalAlesAdd(StudentOptionalAlesInfo studentOptionalAles)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "StudentOptionalAlesAdd",
                studentOptionalAles.ID_Student, studentOptionalAles.ID_DetaliuPlanSemestru);
            return Convert.ToInt64(id);
        }

        public void StudentOptionalAlesUpdate(StudentOptionalAlesInfo studentOptionalAles)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "StudentOptionalAlesUpdate",
                studentOptionalAles.ID_StudentOptionalAles, studentOptionalAles.ID_Student, studentOptionalAles.ID_DetaliuPlanSemestru);
        }

        public void StudentOptionalAlesDelete(long idStudentOptionalAles)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "StudentOptionalAlesDelete", idStudentOptionalAles);
        }
    }
}
