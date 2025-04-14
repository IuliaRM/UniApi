using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using UniApi.Info;

namespace UniApi.DAL.Repos
{

    public interface ISesiuneExameneSpecializareRepo
    {
        long SesiuneExameneSpecializareAdd(SesiuneExameneSpecializareInfo sesiuneInfo);
        void SesiuneExameneSpecializareDelete(long idSesiuneExameneSpecializare);
        SesiuneExameneSpecializareInfo SesiuneExameneSpecializareGet(long idSesiuneExameneSpecializare);
        List<SesiuneExameneSpecializareInfo> SesiuneExameneSpecializareList();
        List<SesiuneExameneSpecializareInfo> SesiuneExameneSpecializareListByProfesorAnUniv(long idProfesor, long idAnUniv);
        void SesiuneExameneSpecializareUpdate(SesiuneExameneSpecializareInfo sesiuneInfo);
        void SesiuneExameneSpecializareUpdateNumaiStudentiiDinMetaCurenta(long idSesiuneExameneSpecializare, bool numaiStudentiiDinMetaCurenta);
    }

    public class SesiuneExameneSpecializareRepo : ISesiuneExameneSpecializareRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public SesiuneExameneSpecializareInfo SesiuneExameneSpecializareGet(long idSesiuneExameneSpecializare)
        {
            return CBO.FillObject<SesiuneExameneSpecializareInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SesiuneExameneSpecializareGet", idSesiuneExameneSpecializare));
        }

        public List<SesiuneExameneSpecializareInfo> SesiuneExameneSpecializareList()
        {
            return CBO.FillCollection<SesiuneExameneSpecializareInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SesiuneExameneSpecializareList"));
        }

        public List<SesiuneExameneSpecializareInfo> SesiuneExameneSpecializareListByProfesorAnUniv(long idProfesor, long idAnUniv)
        {
            return CBO.FillCollection<SesiuneExameneSpecializareInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SesiuneExameneSpecializareListByProfesorAnUniv", idProfesor, idAnUniv));
        }

        public long SesiuneExameneSpecializareAdd(SesiuneExameneSpecializareInfo sesiuneInfo)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "SesiuneExameneSpecializareAdd",
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
            SqlHelper.ExecuteNonQuery(_connectionString, "SesiuneExameneSpecializareUpdate",
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

        public void SesiuneExameneSpecializareDelete(long idSesiuneExameneSpecializare)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "SesiuneExameneSpecializareDelete", idSesiuneExameneSpecializare);
        }

        public void SesiuneExameneSpecializareUpdateNumaiStudentiiDinMetaCurenta(long idSesiuneExameneSpecializare, bool numaiStudentiiDinMetaCurenta)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "SesiuneExameneSpecializareUpdateNumaiStudentiiDinMetaCurenta",
                idSesiuneExameneSpecializare,
                numaiStudentiiDinMetaCurenta);
        }
    }
}
