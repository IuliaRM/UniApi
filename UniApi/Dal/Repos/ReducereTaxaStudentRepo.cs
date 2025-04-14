using System;
using System.Collections.Generic;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{

    public interface IReducereTaxaStudentRepo
    {
        ReducereTaxaStudentInfo ReducereTaxaStudentGet(long idReducereStudent);
        ReducereTaxaStudentInfo ReducereTaxaStudentGetByTaxaStudent(long idTaxaStudent);
        List<ReducereTaxaStudentInfo> ReducereTaxaStudentList();
        List<ReducereTaxaStudentInfo> ReducereTaxaStudentListByStudent(long idStudent);
        List<ReducereTaxaStudentInfo> ReducereTaxaStudentListByTaxaStudentStudent(long idTaxaStudent, long idStudent);
        List<ReducereTaxaStudentInfo> ReducereTaxaStudentListByTipReducere(long idTipReducere);
        long ReducereTaxaStudentAdd(ReducereTaxaStudentInfo objReducereTaxaStudent);
        void ReducereTaxaStudentUpdate(ReducereTaxaStudentInfo objReducereTaxaStudent);
        void ReducereTaxaStudentDelete(long idReducereStudent);
    }

    public class ReducereTaxaStudentRepo : IReducereTaxaStudentRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public ReducereTaxaStudentInfo ReducereTaxaStudentGet(long idReducereStudent)
        {
            return CBO.FillObject<ReducereTaxaStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ReducereTaxaStudentGet", idReducereStudent));
        }

        public ReducereTaxaStudentInfo ReducereTaxaStudentGetByTaxaStudent(long idTaxaStudent)
        {
            return CBO.FillObject<ReducereTaxaStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ReducereTaxaStudentGetByTaxaStudent", idTaxaStudent));
        }

        public List<ReducereTaxaStudentInfo> ReducereTaxaStudentList()
        {
            return CBO.FillCollection<ReducereTaxaStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ReducereTaxaStudentList"));
        }

        public List<ReducereTaxaStudentInfo> ReducereTaxaStudentListByStudent(long idStudent)
        {
            return CBO.FillCollection<ReducereTaxaStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ReducereTaxaStudentListByStudent", idStudent));
        }

        public List<ReducereTaxaStudentInfo> ReducereTaxaStudentListByTaxaStudentStudent(long idTaxaStudent, long idStudent)
        {
            return CBO.FillCollection<ReducereTaxaStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ReducereTaxaStudentListByTaxaStudent", idTaxaStudent, idStudent));
        }

        public List<ReducereTaxaStudentInfo> ReducereTaxaStudentListByTipReducere(long idTipReducere)
        {
            return CBO.FillCollection<ReducereTaxaStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ReducereTaxaStudentListByTipReducere", idTipReducere));
        }

        public long ReducereTaxaStudentAdd(ReducereTaxaStudentInfo objReducereTaxaStudent)
        {
            return Convert.ToInt64(SqlHelper.ExecuteScalar(_connectionString, "ReducereTaxaStudentAdd",
                objReducereTaxaStudent.ID_Student,
                objReducereTaxaStudent.ID_TipReducere,
                objReducereTaxaStudent.DataDeCand,
                objReducereTaxaStudent.DataPanaCand,
                objReducereTaxaStudent.MotivReducere));
        }

        public void ReducereTaxaStudentUpdate(ReducereTaxaStudentInfo objReducereTaxaStudent)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ReducereTaxaStudentUpdate",
                objReducereTaxaStudent.ID_ReducereStudent,
                objReducereTaxaStudent.ID_Student,
                objReducereTaxaStudent.ID_TipReducere,
                objReducereTaxaStudent.DataDeCand,
                objReducereTaxaStudent.DataPanaCand,
                objReducereTaxaStudent.MotivReducere);
        }

        public void ReducereTaxaStudentDelete(long idReducereStudent)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ReducereTaxaStudentDelete", idReducereStudent);
        }
    }
}
