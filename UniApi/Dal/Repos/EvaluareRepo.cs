using System;
using System.Collections.Generic;
using UniApi.Info;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using DotNetNuke.Common.Utilities;

namespace UniApi.Dal.Repos
{
    public class EvaluareRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public List<MaterieStudentInfo> MaterieListByUsernameAndIdAnUnivGet(string Username, long ID_AnUniv, int NrSemestruEvaluare)
        {
            return CBO.FillCollection<MaterieStudentInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "Evaluare_GetMaterieListByUsernameAndIdAnUniv", Username, ID_AnUniv, NrSemestruEvaluare));
        }

        public MaterieStudentDetaliiInfo MaterieStudentDetaliiGet(long ID_CodEvaluare)
        {
            return CBO.FillObject<MaterieStudentDetaliiInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "Evaluare_GetMaterieStudentDetalii", ID_CodEvaluare));
        }

        public long ChestionarEvaluatInsert(long ID_Chestionar, long ID_CodEvaluare)
        {
            return (long)SqlHelper.ExecuteScalar(_ConnectionString, "Evaluare_InsertChestionarEvaluat", ID_Chestionar, ID_CodEvaluare);
        }

        public void EvaluareInsert(CriteriuEvaluareRaspunsInfo Ceri)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "Evaluare_InsertEvaluare", Ceri);
        }

        public List<CriteriuEvaluareInfo> CriteriiEvaluareWithVarianteRaspunsGet(long ID_CodEvaluare)
        {
            return CBO.FillCollection<CriteriuEvaluareInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "Evaluare_GetCriteriiEvaluareWithVarianteRaspuns", ID_CodEvaluare));
        }

        public CriteriuEvaluareVarianteRaspunsInfo CriteriuEvaluareVarianteRaspunsByIdGet(long ID_CriteriuEvaluareVarianteRaspuns)
        {
            return CBO.FillObject<CriteriuEvaluareVarianteRaspunsInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "Evaluare_GetCriteriuEvaluareVarianteRaspunsById", ID_CriteriuEvaluareVarianteRaspuns));
        }

        public List<ProfesorMaterieInfo> CodEvaluareListBySpecializareSemestruGet(long ID_Specializare, int NrSemestru)
        {
            return CBO.FillCollection<ProfesorMaterieInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "Evaluare_GetCodEvaluareListBySpecializareSemestru", ID_Specializare, NrSemestru));
        }

        public bool ChestionarAdaugareTest(long CodEvaluare)
        {
            return (bool)SqlHelper.ExecuteScalar(_ConnectionString, "Evaluare_TestAdaugareChestionar", CodEvaluare);
        }

        public string RoleByUserIdGet(int UserId)
        {
            return (string)SqlHelper.ExecuteScalar(_ConnectionString, "Evaluare_GetRoleByUserId", UserId);
        }

        public string RoleByUsernameGet(string Username)
        {
            return (string)SqlHelper.ExecuteScalar(_ConnectionString, "Evaluare_GetRoleByUsername", Username);
        }

        public List<string> CodEvaluareListByUsernameRoleGet(string Username, string Role, long ID_AnUniv)
        {
            return CBO.FillCollection<string>(
                SqlHelper.ExecuteReader(_ConnectionString, "Evaluare_GetCodEvaluareListByUsernameRole", Username, Role, ID_AnUniv));
        }

        public List<string> SpecializariListByUsernameRoleGet(string Username, string Role, long ID_AnUniv)
        {
            return CBO.FillCollection<string>(
                SqlHelper.ExecuteReader(_ConnectionString, "Evaluare_GetSpecializariListByUsernameRole", Username, Role, ID_AnUniv));
        }
    }
}
