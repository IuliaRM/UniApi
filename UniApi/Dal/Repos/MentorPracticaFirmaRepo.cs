using System;
using System.Configuration;
using System.Data;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IMentorPracticaFirmaRepo
    {
        MentorPracticaFirma MentorPracticaFirmaGet(long idMentorPracticaFirma);
        DataTable MentorPracticaFirmaList();
        DataTable MentorPracticaFirmaListByIDFirma(long idFirma);
        long MentorPracticaFirmaAdd(MentorPracticaFirma info);
        void MentorPracticaFirmaUpdate(MentorPracticaFirma info);
        void MentorPracticaFirmaDelete(long idMentorPracticaFirma);
    }

    public class MentorPracticaFirmaRepo : IMentorPracticaFirmaRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public MentorPracticaFirma MentorPracticaFirmaGet(long idMentorPracticaFirma)
        {
            try
            {
                return CBO.FillObject<MentorPracticaFirma>(
                    SqlHelper.ExecuteReader(_connectionString, "MentorPracticaFirmaGet", idMentorPracticaFirma));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la MentorPracticaFirmaGet", ex);
            }
        }

        public DataTable MentorPracticaFirmaList()
        {
            try
            {
                return SqlHelper.ExecuteDataset(_connectionString, "MentorPracticaFirmaList").Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la MentorPracticaFirmaList", ex);
            }
        }

        public DataTable MentorPracticaFirmaListByIDFirma(long idFirma)
        {
            try
            {
                return SqlHelper.ExecuteDataset(_connectionString, "MentorPracticaFirmaListByIDFirma", idFirma).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la MentorPracticaFirmaListByIDFirma", ex);
            }
        }

        public long MentorPracticaFirmaAdd(MentorPracticaFirma info)
        {
            try
            {
                return (long)SqlHelper.ExecuteScalar(_connectionString, "MentorPracticaFirmaAdd",
                    info.ID_Firma,
                    info.NumeMentorPracticaFirma,
                    info.EmailMentorPracticaFirma,
                    info.TelefonMentorPracticaFirma,
                    info.DataModificare,
                    info.Status);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la MentorPracticaFirmaAdd", ex);
            }
        }

        public void MentorPracticaFirmaUpdate(MentorPracticaFirma info)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "MentorPracticaFirmaUpdate",
                    info.ID_MentorPracticaFirma,
                    info.ID_Firma,
                    info.NumeMentorPracticaFirma,
                    info.EmailMentorPracticaFirma,
                    info.TelefonMentorPracticaFirma,
                    info.DataModificare,
                    info.Status);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la MentorPracticaFirmaUpdate", ex);
            }
        }

        public void MentorPracticaFirmaDelete(long idMentorPracticaFirma)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "MentorPracticaFirmaDelete", idMentorPracticaFirma);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la MentorPracticaFirmaDelete", ex);
            }
        }
    }
}
