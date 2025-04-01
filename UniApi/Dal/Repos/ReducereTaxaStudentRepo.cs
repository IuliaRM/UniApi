using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class ReducereTaxaStudentRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public ReducereTaxaStudentInfo ReducereTaxaStudentGet(long idReducereStudent)
        {
            return CBO.FillObject<ReducereTaxaStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ReducereTaxaStudentGet", idReducereStudent));
        }

        public ReducereTaxaStudentInfo ReducereTaxaStudentByTaxaStudentGet(long idTaxaStudent)
        {
            return CBO.FillObject<ReducereTaxaStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ReducereTaxaStudentGetByTaxaStudent", idTaxaStudent));
        }

        public List<ReducereTaxaStudentInfo> ReducereTaxaStudentListGet()
        {
            return CBO.FillCollection<ReducereTaxaStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ReducereTaxaStudentList"));
        }

        public List<ReducereTaxaStudentInfo> ReducereTaxaStudentListByTipReducereGet(long idTipReducere)
        {
            return CBO.FillCollection<ReducereTaxaStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ReducereTaxaStudentListByTipReducere", idTipReducere));
        }

        public List<ReducereTaxaStudentInfo> ReducereTaxaStudentListByStudentGet(long idStudent)
        {
            return CBO.FillCollection<ReducereTaxaStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ReducereTaxaStudentListByStudent", idStudent));
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

        public void ReducereTaxaStudentDelete(ReducereTaxaStudentInfo objReducereTaxaStudent)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ReducereTaxaStudentDelete", objReducereTaxaStudent.ID_ReducereStudent);
        }
    }
}
