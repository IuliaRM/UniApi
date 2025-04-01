using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Http;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Web.Api;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Dal.Repos;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public class MentorPracticaFirmaRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public MentorPracticaFirma MentorPracticaFirmaGet(long idMentorPracticaFirma)
        {
            return CBO.FillObject<MentorPracticaFirma>(SqlHelper.ExecuteReader(_connectionString, "MentorPracticaFirmaGet", idMentorPracticaFirma));
        }

        public List<MentorPracticaFirma> MentorPracticaFirmaList()
        {
            return CBO.FillCollection<MentorPracticaFirma>(SqlHelper.ExecuteReader(_connectionString, "MentorPracticaFirmaList"));
        }

        public List<MentorPracticaFirma> MentorPracticaFirmaListByIDFirma(long idFirma)
        {
            return CBO.FillCollection<MentorPracticaFirma>(SqlHelper.ExecuteReader(_connectionString, "MentorPracticaFirmaListByIDFirma", idFirma));
        }

        public void MentorPracticaFirmaAdd(MentorPracticaFirma objMentorPracticaFirma)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "MentorPracticaFirmaAdd",
                objMentorPracticaFirma.ID_Firma,
                objMentorPracticaFirma.NumeMentorPracticaFirma,
                objMentorPracticaFirma.EmailMentorPracticaFirma,
                objMentorPracticaFirma.TelefonMentorPracticaFirma,
                objMentorPracticaFirma.DataModificare,
                objMentorPracticaFirma.Status);
        }

        public void MentorPracticaFirmaUpdate(MentorPracticaFirma objMentorPracticaFirma)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "MentorPracticaFirmaUpdate",
                objMentorPracticaFirma.ID_MentorPracticaFirma,
                objMentorPracticaFirma.ID_Firma,
                objMentorPracticaFirma.NumeMentorPracticaFirma,
                objMentorPracticaFirma.EmailMentorPracticaFirma,
                objMentorPracticaFirma.TelefonMentorPracticaFirma,
                objMentorPracticaFirma.DataModificare,
                objMentorPracticaFirma.Status);
        }

        public void MentorPracticaFirmaDelete(long idMentorPracticaFirma)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "MentorPracticaFirmaDelete", idMentorPracticaFirma);
        }
    }
}
