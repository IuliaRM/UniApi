using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class SesiuneExameneSpecializareRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public SesiuneExameneSpecializareInfo SesiuneExameneSpecializareGet(long idSesiuneExameneSpecializare)
        {
            return CBO.FillObject<SesiuneExameneSpecializareInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PE.SesiuneExameneSpecializareGet", idSesiuneExameneSpecializare));
        }

        public long SesiuneExameneSpecializareAdd(SesiuneExameneSpecializareInfo sesiuneInfo)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "PE.SesiuneExameneSpecializareAdd",
                sesiuneInfo.ID_SesiuneExamene,
                sesiuneInfo.ID_Specializare,
                sesiuneInfo.ID_AnStudiu,
                sesiuneInfo.DataInceputPeSpec,
                sesiuneInfo.DataSfarsitPeSpec,
                sesiuneInfo.DataLimitaNotePeSpec,
                sesiuneInfo.Activa,
                sesiuneInfo.ID_TipSesiuneExamene,
                sesiuneInfo.DenumireSesiuneExameneSpecializare);

            return Convert.ToInt64(id);
        }

        public void SesiuneExameneSpecializareUpdate(SesiuneExameneSpecializareInfo sesiuneInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "PE.SesiuneExameneSpecializareUpdate",
                sesiuneInfo.ID_SesiuneExameneSpecializare,
                sesiuneInfo.ID_SesiuneExamene,
                sesiuneInfo.ID_Specializare,
                sesiuneInfo.ID_AnStudiu,
                sesiuneInfo.DataInceputPeSpec,
                sesiuneInfo.DataSfarsitPeSpec,
                sesiuneInfo.DataLimitaNotePeSpec,
                sesiuneInfo.Activa,
                sesiuneInfo.ID_TipSesiuneExamene,
                sesiuneInfo.DenumireSesiuneExameneSpecializare);
        }

        public void NumaiStudentiiDinMetaCurentaUpdate(long idSesiuneExameneSpecializare, bool numaiStudentiiDinMetaCurenta)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "PE.SesiuneExameneSpecializareUpdateNumaiStudentiiDinMetaCurenta",
                idSesiuneExameneSpecializare,
                numaiStudentiiDinMetaCurenta);
        }
    }
}
