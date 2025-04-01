using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;

using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class PropunereCandidatRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public PropunereCandidatInfo PropunereCandidatGet(long idPropunereCandidat)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<PropunereCandidatInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PropunereCandidatGet", idPropunereCandidat));
        }

        public List<PropunereCandidatInfo> PropunereCandidatListByStudentGet(long idStudent, long idAnUniv)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<PropunereCandidatInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PropunereCandidatListByStudent", idStudent, idAnUniv));
        }

        public List<PropunereCandidatInfo> PropunereCandidatListByAnUniversitarGet(long idAnUniv)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<PropunereCandidatInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PropunereCandidatListByAnUniversitar", idAnUniv));
        }

        public List<PropunereCandidatInfo> PropunereCandidatListByFacultateGet(long idFacultate, long idAnUniv)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<PropunereCandidatInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PropunereCandidatListByFacultate", idFacultate, idAnUniv));
        }

        public List<PropunereCandidatInfo> PropunereCandidatListByJudetGet(long idJudet, long idAnUniv)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<PropunereCandidatInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PropunereCandidatListByN_Judet", idJudet, idAnUniv));
        }

        public List<PropunereCandidatInfo> PropunereCandidatListByOrasGet(long idOras, long idAnUniv)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<PropunereCandidatInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PropunereCandidatListByN_Oras", idOras, idAnUniv));
        }

        public List<PropunereCandidatInfo> PropunereCandidatListByLiceuGet(long idLiceu, long idAnUniv)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<PropunereCandidatInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PropunereCandidatListByN_LICEU", idLiceu, idAnUniv));
        }

        public long PropunereCandidatAdd(PropunereCandidatInfo propunereCandidat)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "PropunereCandidatAdd",
                propunereCandidat.NumeCandidat,
                propunereCandidat.PrenumeCandidat,
                propunereCandidat.Strada,
                propunereCandidat.Numar,
                propunereCandidat.Bloc,
                propunereCandidat.Scara,
                propunereCandidat.Etaj,
                propunereCandidat.Apartament,
                propunereCandidat.DenumireLiceu,
                propunereCandidat.ID_FacultatePotrivitaCandidat,
                propunereCandidat.ID_StudentPropunere,
                propunereCandidat.ID_AnUniv,
                propunereCandidat.AnUnivAdmitere,
                propunereCandidat.UserIDPortal);

            return Convert.ToInt64(id);
        }

        public void PropunereCandidatUpdate(PropunereCandidatInfo propunereCandidat)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "PropunereCandidatUpdate",
                propunereCandidat.Id_PropunereCandidat,
                propunereCandidat.NumeCandidat,
                propunereCandidat.PrenumeCandidat,
                propunereCandidat.Strada,
                propunereCandidat.Numar,
                propunereCandidat.Bloc,
                propunereCandidat.Scara,
                propunereCandidat.Etaj,
                propunereCandidat.Apartament,
                propunereCandidat.DenumireLiceu,
                propunereCandidat.ID_FacultatePotrivitaCandidat,
                propunereCandidat.ID_StudentPropunere,
                propunereCandidat.ID_AnUniv,
                propunereCandidat.AnUnivAdmitere,
                propunereCandidat.UserIDPortal);
        }

        public void PropunereCandidatDelete(long idPropunereCandidat)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "PropunereCandidatDelete", idPropunereCandidat);
        }
    }
}
