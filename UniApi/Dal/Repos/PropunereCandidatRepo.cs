using System;
using System.Collections.Generic;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{

    public interface IPropunereCandidatRepo
    {
        PropunereCandidatInfo PropunereCandidatGet(long idPropunereCandidat);
        List<PropunereCandidatInfo> PropunereCandidatListByStudent(long idStudent, long idAnUniv);
        List<PropunereCandidatInfo> PropunereCandidatListByAnUniversitar(long idAnUniv);
        List<PropunereCandidatInfo> PropunereCandidatListByFacultate(long idFacultate, long idAnUniv);
        List<PropunereCandidatInfo> PropunereCandidatListByJudete(long idJudet, long idAnUniv);
        List<PropunereCandidatInfo> PropunereCandidatListByLocalitati(long idOras, long idAnUniv);
        List<PropunereCandidatInfo> PropunereCandidatListByN_Judet(long idJudet, long idAnUniv);
        List<PropunereCandidatInfo> PropunereCandidatListByN_Oras(long idOras, long idAnUniv);
        List<PropunereCandidatInfo> PropunereCandidatListByStudent(long idStudent); // Redundant, dar îl includ conform cerin?ei
        long PropunereCandidatAdd(PropunereCandidatInfo propunereCandidat);
        void PropunereCandidatUpdate(PropunereCandidatInfo propunereCandidat);
        void PropunereCandidatDelete(long idPropunereCandidat);
    }

    public class PropunereCandidatRepo : IPropunereCandidatRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public PropunereCandidatInfo PropunereCandidatGet(long idPropunereCandidat)
        {
            return CBO.FillObject<PropunereCandidatInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PropunereCandidatGet", idPropunereCandidat));
        }

        public List<PropunereCandidatInfo> PropunereCandidatListByStudent(long idStudent, long idAnUniv)
        {
            return CBO.FillCollection<PropunereCandidatInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PropunereCandidatListByStudent", idStudent, idAnUniv));
        }

        public List<PropunereCandidatInfo> PropunereCandidatListByAnUniversitar(long idAnUniv)
        {
            return CBO.FillCollection<PropunereCandidatInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PropunereCandidatListByAnUniversitar", idAnUniv));
        }

        public List<PropunereCandidatInfo> PropunereCandidatListByFacultate(long idFacultate, long idAnUniv)
        {
            return CBO.FillCollection<PropunereCandidatInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PropunereCandidatListByFacultate", idFacultate, idAnUniv));
        }

        public List<PropunereCandidatInfo> PropunereCandidatListByJudete(long idJudet, long idAnUniv)
        {
            return CBO.FillCollection<PropunereCandidatInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PropunereCandidatListByJudete", idJudet, idAnUniv));
        }

        public List<PropunereCandidatInfo> PropunereCandidatListByLocalitati(long idOras, long idAnUniv)
        {
            return CBO.FillCollection<PropunereCandidatInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PropunereCandidatListByLocalitati", idOras, idAnUniv));
        }

        public List<PropunereCandidatInfo> PropunereCandidatListByN_Judet(long idJudet, long idAnUniv)
        {
            return CBO.FillCollection<PropunereCandidatInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PropunereCandidatListByN_judet", idJudet, idAnUniv));
        }

        public List<PropunereCandidatInfo> PropunereCandidatListByN_Oras(long idOras, long idAnUniv)
        {
            return CBO.FillCollection<PropunereCandidatInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PropunereCandidatListByN_Oras", idOras, idAnUniv));
        }

        public List<PropunereCandidatInfo> PropunereCandidatListByStudent(long idStudent) // Redundant, dar îl includ conform cerin?ei
        {
            return CBO.FillCollection<PropunereCandidatInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PropunereCandidatListByStudent", idStudent));
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
