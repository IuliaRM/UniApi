using System;
using System.Collections.Generic;
using UniApi.Models;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using DotNetNuke.Common.Utilities;

namespace UniApi.Dal.Repos
{
    public class EvaluareRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public List<MaterieStudentInfo> GetMaterieListByUsernameAndIdAnUniv(string username, long ID_AnUniv, int NrSemestruEvaluare)
        {
            return CBO.FillCollection<MaterieStudentInfo>(SqlHelper.ExecuteReader(_ConnectionString,
                "[DetaliuPlanSemestruMaterieListByUsernameAnUniv]", username, ID_AnUniv, NrSemestruEvaluare));
        }

        public MaterieStudentDetaliiInfo GetMaterieStudentDetalii(long ID_CodEvaluare)
        {
            MaterieStudentDetaliiInfo materie = CBO.FillObject<MaterieStudentDetaliiInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "[MaterieDetaliiByIdCodEvaluare]", ID_CodEvaluare));
            materie.Profesor = CBO.FillObject<ProfesorMaterieInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "[ProfesorListByIdCodEvaluare]", ID_CodEvaluare));
            return materie;
        }

        public long InsertChestionarEvaluat(long ID_Chestionar, long ID_CodEvaluare)
        {
            var obj = SqlHelper.ExecuteScalar(_ConnectionString, "ChestionarCompletatInsert", ID_Chestionar, ID_CodEvaluare);
            return obj != null ? Convert.ToInt64(obj) : 0;
        }

        public void InsertEvaluare(CriteriuEvaluareRaspunsInfo ceri)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "CriteriuEvaluareRaspunsInsert", ceri.ID_CriteriuEvaluare,
                ceri.ID_CriteriuEvaluareVarianteRaspuns, ceri.ID_ChestionarEvaluat, ceri.TextRaspuns);
        }

        public List<CriteriuEvaluareInfo> GetCriteriiEvaluareWithVarianteRaspuns(long id_codevaluare)
        {
            List<CriteriuEvaluareInfo> result = CBO.FillCollection<CriteriuEvaluareInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "CriteriuEvaluareListByCodEvaluare", id_codevaluare));

            foreach (var cei in result)
            {
                cei.VarianteRaspuns = CBO.FillCollection<CriteriuEvaluareVarianteRaspunsInfo>(
                    SqlHelper.ExecuteReader(_ConnectionString, "CriteriuEvaluareVarianteRaspunsListByIdCriteriuEvaluare", cei.ID_CriteriuEvaluare));
            }
            return result;
        }

        public CriteriuEvaluareVarianteRaspunsInfo GetCriteriuEvaluareVarianteRaspunsById(long id_CriteriuEvaluareVarianteRaspuns)
        {
            return CBO.FillObject<CriteriuEvaluareVarianteRaspunsInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "CriteriuEvaluareVarianteRaspunsGetById", id_CriteriuEvaluareVarianteRaspuns));
        }

        public List<ProfesorMaterieInfo> GetCodEvaluareListBySpecializareSemestru(long idSpecializare, int nrSemestru)
        {
            return CBO.FillCollection<ProfesorMaterieInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "[CodEvaluareListBySpecializareSemestru]", idSpecializare, nrSemestru));
        }

        public bool TestAdaugareChestionar(long codEvaluare)
        {
            return (bool)SqlHelper.ExecuteScalar(_ConnectionString, "EvaluareTestAdaugareChestionar", codEvaluare);
        }

        public string GetRoleByUserId(int userId)
        {
            return (string)SqlHelper.ExecuteScalar(_ConnectionString, "[EvaluareGetRoleByUserId]", userId);
        }

        public string GetRoleByUsername(string username)
        {
            return (string)SqlHelper.ExecuteScalar(_ConnectionString, "[EvaluareGetRoleByUsername]", username);
        }

        public List<string> GetCodEvaluareListByUsernameRole(string username, string role, long ID_AnUniv)
        {
            List<string> result = new List<string>();
            var sds = SqlHelper.ExecuteReader(_ConnectionString, "CodEvaluareListByUsernameRole", username, role, ID_AnUniv);
            while (sds.Read())
            {
                result.Add(sds.GetInt64(0).ToString());
            }
            return result;
        }

        public List<string> GetSpecializariListByUsernameRole(string username, string role, long idAnUniv)
        {
            List<string> result = new List<string>();
            var sds = SqlHelper.ExecuteReader(_ConnectionString, "SpecializareListByUsernameRole", username, role, idAnUniv);
            while (sds.Read())
            {
                result.Add(sds.GetInt64(0).ToString());
            }
            return result;
        }
    }
}
