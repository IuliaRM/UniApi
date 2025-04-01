using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public class AbsolvireProgramRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public AbsolvireProgramInfo AbsolvireProgramGet(long idAbsolvireProgram)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<AbsolvireProgramInfo>(
                SqlHelper.ExecuteReader(_connectionString, "AbsolvireProgramGet", idAbsolvireProgram));
        }

        public List<AbsolvireProgramInfo> AbsolvireProgramList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<AbsolvireProgramInfo>(
                SqlHelper.ExecuteReader(_connectionString, "AbsolvireProgramList"));
        }

        public List<AbsolvireProgramInfo> AbsolvireProgramListBySpecializare(long idSpecializare)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<AbsolvireProgramInfo>(
                SqlHelper.ExecuteReader(_connectionString, "AbsolvireProgramListBySpecializare", idSpecializare));
        }

        public List<AbsolvireProgramInfo> AbsolvireProgramListByAnUniversitar(long idAnUniversitar)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<AbsolvireProgramInfo>(
                SqlHelper.ExecuteReader(_connectionString, "AbsolvireProgramListByAnUniversitar", idAnUniversitar));
        }

        public long AbsolvireProgramAdd(AbsolvireProgramInfo programInfo)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "AbsolvireProgramAdd",
                programInfo.ID_AbsolvireProgram,
                programInfo.ID_AnUnivAbsolvire,
                programInfo.ID_UniversitateAbsolvita,
                programInfo.ID_FacultateAbsolvita,
                programInfo.ID_DomeniuAbsolvit,
                programInfo.ID_ProgramStudiuAbsolvit,
                programInfo.NrCrediteProgram,
                programInfo.TitlulObtinut,
                programInfo.ID_LocalitateProgram,
                programInfo.ID_UniversitateAcordaDiploma,
                programInfo.ID_FacultateAcordaDiploma,
                programInfo.SesiuneExamenAbsolvire,
                programInfo.AnExamenAbsolvire,
                programInfo.NrProbeExamenAbsolvire,
                programInfo.MedieMinimaPromovare,
                programInfo.ID_CicluInv,
                programInfo.ID_FormaInv,
                programInfo.NumeRector,
                programInfo.NumeDecan,
                programInfo.NumeSecretarSefUniversitate,
                programInfo.NumeSecretarSefFacultate,
                programInfo.ID_PachetAbsolvire);

            return Convert.ToInt64(id);
        }

        public void AbsolvireProgramUpdate(AbsolvireProgramInfo programInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireProgramUpdate",
                programInfo.ID_AbsolvireProgram,
                programInfo.ID_AnUnivAbsolvire,
                programInfo.ID_UniversitateAbsolvita,
                programInfo.ID_FacultateAbsolvita,
                programInfo.ID_DomeniuAbsolvit,
                programInfo.ID_ProgramStudiuAbsolvit,
                programInfo.NrCrediteProgram,
                programInfo.TitlulObtinut,
                programInfo.ID_LocalitateProgram,
                programInfo.ID_UniversitateAcordaDiploma,
                programInfo.ID_FacultateAcordaDiploma,
                programInfo.SesiuneExamenAbsolvire,
                programInfo.AnExamenAbsolvire,
                programInfo.NrProbeExamenAbsolvire,
                programInfo.MedieMinimaPromovare,
                programInfo.ID_CicluInv,
                programInfo.ID_FormaInv,
                programInfo.NumeRector,
                programInfo.NumeDecan,
                programInfo.NumeSecretarSefUniversitate,
                programInfo.NumeSecretarSefFacultate,
                programInfo.ID_PachetAbsolvire);
        }

        public void AbsolvireProgramDeleteBySpecializare(long idSpecializare)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireProgramDeleteBySpecializare", idSpecializare);
        }
    }
}
