using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IAbsolvireProgramRepo
    {
        AbsolvireProgramInfo AbsolvireProgramGet(long idAbsolvireProgram);
        List<AbsolvireProgramInfo> AbsolvireProgramList();
        List<AbsolvireProgramInfo> AbsolvireProgramListBySpecializare(long idSpecializare);
        List<AbsolvireProgramInfo> AbsolvireProgramListByAnUniversitar(long idAnUniversitar);
        List<AbsolvireProgramInfo> AbsolvireProgramListByAnUnivFacDomSpec(long idAnUniversitar, long idFacultate, long idDomeniu, long idSpecializare);
        List<AbsolvireProgramInfo> AbsolvireProgramGetBySpecializare(long idSpecializare);
        List<AbsolvireProgramInfo> AbsolvireProgramGetBySpecializareSesiuneExamene(long idSpecializare, long idSesiune);
        long AbsolvireProgramAdd(AbsolvireProgramInfo programInfo);
        void AbsolvireProgramUpdate(AbsolvireProgramInfo programInfo);
        void AbsolvireProgramDeleteBySpecializare(long idSpecializare);
    }

    public class AbsolvireProgramRepo : IAbsolvireProgramRepo
    {
        private readonly string _connectionString;

        public AbsolvireProgramRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;

            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found in configuration.");
            }
        }

        public AbsolvireProgramInfo AbsolvireProgramGet(long idAbsolvireProgram)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "AbsolvireProgramGet", idAbsolvireProgram))
                {
                    return CBO.FillObject<AbsolvireProgramInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving AbsolvireProgram", ex);
            }
        }

        public List<AbsolvireProgramInfo> AbsolvireProgramList()
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "AbsolvireProgramList"))
                {
                    return CBO.FillCollection<AbsolvireProgramInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving AbsolvireProgram list", ex);
            }
        }

        public List<AbsolvireProgramInfo> AbsolvireProgramListBySpecializare(long idSpecializare)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "AbsolvireProgramListBySpecializare", idSpecializare))
                {
                    return CBO.FillCollection<AbsolvireProgramInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving AbsolvireProgram by Specializare", ex);
            }
        }

        public List<AbsolvireProgramInfo> AbsolvireProgramListByAnUniversitar(long idAnUniversitar)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "AbsolvireProgramListByAnUniversitar", idAnUniversitar))
                {
                    return CBO.FillCollection<AbsolvireProgramInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving AbsolvireProgram by AnUniversitar", ex);
            }
        }

        public List<AbsolvireProgramInfo> AbsolvireProgramListByAnUnivFacDomSpec(long idAnUniversitar, long idFacultate, long idDomeniu, long idSpecializare)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "AbsolvireProgramListByAnUnivFacDomSpec",
                    idAnUniversitar, idFacultate, idDomeniu, idSpecializare))
                {
                    return CBO.FillCollection<AbsolvireProgramInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving AbsolvireProgram by AnUniv-Fac-Dom-Spec", ex);
            }
        }

        public List<AbsolvireProgramInfo> AbsolvireProgramGetBySpecializare(long idSpecializare)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "AbsolvireProgramGetBySpecializare", idSpecializare))
                {
                    return CBO.FillCollection<AbsolvireProgramInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving AbsolvireProgram (GetBySpecializare)", ex);
            }
        }

        public List<AbsolvireProgramInfo> AbsolvireProgramGetBySpecializareSesiuneExamene(long idSpecializare, long idSesiune)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "AbsolvireProgramGetBySpecializareSesiuneExamene",
                    idSpecializare, idSesiune))
                {
                    return CBO.FillCollection<AbsolvireProgramInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving AbsolvireProgram by Specializare and Sesiune", ex);
            }
        }

        public long AbsolvireProgramAdd(AbsolvireProgramInfo programInfo)
        {
            if (programInfo == null)
                throw new ArgumentNullException(nameof(programInfo));

            try
            {
                var id = SqlHelper.ExecuteScalar(_connectionString, "AbsolvireProgramAdd",
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
            catch (Exception ex)
            {
                throw new DataException("Error adding AbsolvireProgram", ex);
            }
        }

        public void AbsolvireProgramUpdate(AbsolvireProgramInfo programInfo)
        {
            if (programInfo == null)
                throw new ArgumentNullException(nameof(programInfo));

            try
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
            catch (Exception ex)
            {
                throw new DataException("Error updating AbsolvireProgram", ex);
            }
        }

        public void AbsolvireProgramDeleteBySpecializare(long idSpecializare)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireProgramDeleteBySpecializare", idSpecializare);
            }
            catch (Exception ex)
            {
                throw new DataException("Error deleting AbsolvireProgram by Specializare", ex);
            }
        }
    }
}
