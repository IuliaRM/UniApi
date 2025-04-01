using System;
using System.Collections.Generic;
using UniApi.Info;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using DotNetNuke.Common.Utilities;

namespace UniApi.Dal.Repos
{
    public class NotaRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public NotaInfo NotaGet(long ID_Nota)
        {
            return CBO.FillObject<NotaInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "Nota_Get", ID_Nota));
        }

        public List<NotaInfo> NotaListGet()
        {
            return CBO.FillCollection<NotaInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "Nota_GetList"));
        }

        public List<NotaInfo> NotaListByDetaliuPlanSemestruGet(long ID_DetaliuPlanSemestru)
        {
            return CBO.FillCollection<NotaInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "Nota_GetListByDetaliuPlanSemestru", ID_DetaliuPlanSemestru));
        }

        public List<NotaInfo> NotaListByStudentGet(long ID_Student, long ID_AnUniv)
        {
            return CBO.FillCollection<NotaInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "Nota_GetListByStudent", ID_Student, ID_AnUniv));
        }

        public long NotaAdd(NotaInfo NotaInfo)
        {
            return (long)SqlHelper.ExecuteScalar(_ConnectionString, "Nota_Add", NotaInfo);
        }

        public void NotaUpdate(NotaInfo NotaInfo)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "Nota_Update", NotaInfo);
        }

        public void NotaDelete(long ID_Nota)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "Nota_Delete", ID_Nota);
        }

        public List<NotaInfo> NotaListByUserAnUniversitarGet(int UserId, long ID_AnUniversitar)
        {
            return CBO.FillCollection<NotaInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "Nota_GetListByUserAnUniversitar", UserId, ID_AnUniversitar));
        }

        public List<NotaInfo> NotaListByUsernameAnUniversitarGet(string Username, long ID_AnUniversitar)
        {
            return CBO.FillCollection<NotaInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "Nota_GetListByUsernameAnUniversitar", Username, ID_AnUniversitar));
        }

        public List<NotaInfo> NotaListByStudentGet(long ID_Student)
        {
            return CBO.FillCollection<NotaInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "Nota_GetListByStudent", ID_Student));
        }

        public NotaInfo NotaByDetaliuPlanAndIdGet(long ID_DetaliuPlanSemestru, long ID_Nota)
        {
            return CBO.FillObject<NotaInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "Nota_GetByDetaliuPlanAndId", ID_DetaliuPlanSemestru, ID_Nota));
        }

        public void NotaEchivaleaza(long ID_DetaliuPlanSemestruRestanta, long ID_NotaCuCareSeEchivaleaza, long ID_Student, int ID_Utilizator)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "Nota_Echivaleaza", ID_DetaliuPlanSemestruRestanta, ID_NotaCuCareSeEchivaleaza, ID_Student, ID_Utilizator);
        }
    }
}
