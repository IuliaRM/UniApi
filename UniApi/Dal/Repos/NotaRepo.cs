using System;
using System.Collections.Generic;
using System.Configuration;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface INotaRepo
    {
        NotaInfo NotaGet(long idNota);
        NotaInfo NotaByDetaliuPlanAndIdGet(long idDetaliuPlanSemestru, long idNota);
        List<NotaInfo> NotaList();
        List<NotaInfo> NotaListByDetaliuPlanSemestru(long idDetaliuPlanSemestru);
        List<NotaInfo> NotaListByStudent(long idStudent);
        List<NotaInfo> NotaListByStudent(long idStudent, long idAnUniv);
        List<NotaInfo> NotaListByUserAnUniversitar(int userId, long idAnUniv);
        List<NotaInfo> NotaListByUsernameAnUniversitar(string username, long idAnUniv);
        long NotaAdd(NotaInfo info);
        void NotaUpdate(NotaInfo info);
        void NotaDelete(long idNota);
        void NotaEchivaleaza(long idRestanta, long idEchivalare, long idStudent, int idUtilizator);
    }

    public class NotaRepo : INotaRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public NotaInfo NotaGet(long idNota)
        {
            try
            {
                return CBO.FillObject<NotaInfo>(SqlHelper.ExecuteReader(_connectionString, "Nota_Get", idNota));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la NotaGet", ex);
            }
        }

        public NotaInfo NotaByDetaliuPlanAndIdGet(long idDetaliuPlanSemestru, long idNota)
        {
            try
            {
                return CBO.FillObject<NotaInfo>(SqlHelper.ExecuteReader(_connectionString, "Nota_GetByDetaliuPlanAndId", idDetaliuPlanSemestru, idNota));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la NotaByDetaliuPlanAndIdGet", ex);
            }
        }

        public List<NotaInfo> NotaList()
        {
            try
            {
                return CBO.FillCollection<NotaInfo>(SqlHelper.ExecuteReader(_connectionString, "Nota_GetList"));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la NotaList", ex);
            }
        }

        public List<NotaInfo> NotaListByDetaliuPlanSemestru(long idDetaliuPlanSemestru)
        {
            try
            {
                return CBO.FillCollection<NotaInfo>(SqlHelper.ExecuteReader(_connectionString, "Nota_GetListByDetaliuPlanSemestru", idDetaliuPlanSemestru));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la NotaListByDetaliuPlanSemestru", ex);
            }
        }

        public List<NotaInfo> NotaListByStudent(long idStudent)
        {
            try
            {
                return CBO.FillCollection<NotaInfo>(SqlHelper.ExecuteReader(_connectionString, "Nota_GetListByStudent", idStudent));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la NotaListByStudent", ex);
            }
        }

        public List<NotaInfo> NotaListByStudent(long idStudent, long idAnUniv)
        {
            try
            {
                return CBO.FillCollection<NotaInfo>(SqlHelper.ExecuteReader(_connectionString, "Nota_GetListByStudent", idStudent, idAnUniv));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la NotaListByStudent cu an universitar", ex);
            }
        }

        public List<NotaInfo> NotaListByUserAnUniversitar(int userId, long idAnUniv)
        {
            try
            {
                return CBO.FillCollection<NotaInfo>(SqlHelper.ExecuteReader(_connectionString, "Nota_GetListByUserAnUniversitar", userId, idAnUniv));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la NotaListByUserAnUniversitar", ex);
            }
        }

        public List<NotaInfo> NotaListByUsernameAnUniversitar(string username, long idAnUniv)
        {
            try
            {
                return CBO.FillCollection<NotaInfo>(SqlHelper.ExecuteReader(_connectionString, "Nota_GetListByUsernameAnUniversitar", username, idAnUniv));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la NotaListByUsernameAnUniversitar", ex);
            }
        }

        public long NotaAdd(NotaInfo info)
        {
            try
            {
                return (long)SqlHelper.ExecuteScalar(_connectionString, "Nota_Add", info);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la NotaAdd", ex);
            }
        }

        public void NotaUpdate(NotaInfo info)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "Nota_Update", info);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la NotaUpdate", ex);
            }
        }

        public void NotaDelete(long idNota)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "Nota_Delete", idNota);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la NotaDelete", ex);
            }
        }

        public void NotaEchivaleaza(long idRestanta, long idEchivalare, long idStudent, int idUtilizator)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "Nota_Echivaleaza", idRestanta, idEchivalare, idStudent, idUtilizator);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la NotaEchivaleaza", ex);
            }
        }
    }
}
