using System;
using System.Collections.Generic;
using System.Data;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Models;

namespace UniApi.Dal.Repos
{
    public class NotaRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public NotaInfo NotaGet(long idNota)
        {
            return CBO.FillObject<NotaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "NotaGet", idNota));
        }

        public List<NotaInfo> NotaGetList()
        {
            return CBO.FillCollection<NotaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "NotaList"));
        }

        public List<NotaInfo> NotaGetListByDetaliuPlanSemestru(long idDetaliuPlanSemestru)
        {
            return CBO.FillCollection<NotaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "NotaListByDetaliuPlanSemestru", idDetaliuPlanSemestru));
        }

        public List<NotaInfo> NotaGetListByStudent(long idStudent, long idAnUniv)
        {
            return CBO.FillCollection<NotaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "NotaListByStudent", idStudent, idAnUniv));
        }

        public long NotaAdd(NotaInfo notaInfo)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "NotaAdd",
                notaInfo.ID_DetaliuPlanSemestru,
                notaInfo.ID_Student,
                notaInfo.DataNota,
                notaInfo.ID_TipNota,
                notaInfo.UltimaNotaActiva,
                notaInfo.DataModificare,
                notaInfo.ID_Utilizator,
                notaInfo.ID_TipLimba,
                notaInfo.UserID_Profesor,
                notaInfo.ForteazaAdaugareNotaNoua,
                notaInfo.ID_TipAcordareNota);

            return Convert.ToInt64(id);
        }

        public void NotaUpdate(NotaInfo notaInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "NotaUpdate",
                notaInfo.ID_Nota,
                notaInfo.ID_DetaliuPlanSemestru,
                notaInfo.ID_Student,
                notaInfo.DataNota,
                notaInfo.ID_TipNota,
                notaInfo.UltimaNotaActiva,
                notaInfo.DataModificare,
                notaInfo.ID_Utilizator,
                notaInfo.ID_TipLimba,
                notaInfo.UserID_Profesor,
                notaInfo.ForteazaAdaugareNotaNoua,
                notaInfo.ID_TipAcordareNota);
        }

        public void NotaDelete(long idNota)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "NotaDelete", idNota);
        }

        public List<NotaInfo> NotaGetListByUserAnuniversitar(int userId, long idAnUniversitar)
        {
            return CBO.FillCollection<NotaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "NotaListByUserAnuniversitar", userId, idAnUniversitar));
        }

        public List<NotaInfo> NotaGetListByUsernameAnUniversitar(string username, long idAnUniversitar)
        {
            return CBO.FillCollection<NotaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "NotaListByUsernameAnUniversitar", username, idAnUniversitar));
        }

        public List<NotaInfo> NotaGetListByStudent(long idStudent)
        {
            return CBO.FillCollection<NotaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "NoteListByIdStudent", idStudent));
        }

        public NotaInfo NotaGetByDetaliuPlanAndId(long idDetaliuPlanSemestru, long idNota)
        {
            return CBO.FillObject<NotaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "NotaGetByIdDetaliuPlanIdNota", idDetaliuPlanSemestru, idNota));
        }

        public void NotaEchivaleaza(long idDetaliuPlanSemestruRestanta, long idNotaCuCareSeEchivaleaza, long idStudent, int idUtilizator)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "EchivaleazaNota", idDetaliuPlanSemestruRestanta, idNotaCuCareSeEchivaleaza, idStudent, idUtilizator);
        }
    }
}
