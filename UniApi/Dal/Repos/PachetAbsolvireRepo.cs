using System;
using System.Collections.Generic;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class PachetAbsolvireRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public long PachetAbsolvireAdd(PachetAbsolvireInfo pachetAbs)
        {
            return Convert.ToInt64(SqlHelper.ExecuteScalar(_connectionString, "PachetAbsolvireAdd",
                pachetAbs.Id_AnUnivAbsolvire,
                pachetAbs.Id_Specializare,
                pachetAbs.DenumirePachet,
                pachetAbs.DenumireSesiuneAbsolvire,
                pachetAbs.AnSesiuneAbsolvire));
        }

        public PachetAbsolvireInfo PachetAbsolvireGet(long idPachetAbsolvire)
        {
            return CBO.FillObject<PachetAbsolvireInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PachetAbsolvireGet", idPachetAbsolvire));
        }

        public List<PachetAbsolvireInfo> PachetAbsolvireListGet()
        {
            return CBO.FillCollection<PachetAbsolvireInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PachetAbsolvireList"));
        }

        public List<PachetAbsolvireInfo> PachetAbsolvireListByAnUnivAndSpecializareGet(long idAnUniv, long idSpecializare)
        {
            return CBO.FillCollection<PachetAbsolvireInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PachetAbsolvireListByAnUnivIdSpecializare", idAnUniv, idSpecializare));
        }

        public void PachetAbsolvireUpdate(PachetAbsolvireInfo pachetAbs)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "PachetAbsolvireUpdate",
                pachetAbs.Id_PachetAbsolvire,
                pachetAbs.Id_AnUnivAbsolvire,
                pachetAbs.Id_Specializare,
                pachetAbs.DenumirePachet,
                pachetAbs.DenumireSesiuneAbsolvire,
                pachetAbs.ActivaInscriereStudenti,
                pachetAbs.ID_ProfesorPresedinteComisie,
                pachetAbs.CSVUsernameSecretariComisie,
                pachetAbs.CSVUsernameMembriComisie,
                pachetAbs.AnSesiuneAbsolvire);
        }

        public void PachetAbsolvireDelete(long idPachetAbsolvire)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "PachetAbsolvireDelete", idPachetAbsolvire);
        }
    }
}
