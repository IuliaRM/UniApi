using System;
using System.Collections.Generic;
using UniApi.Models;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public class DetaliuPlanSemestruStudentRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public DetaliuPlanSemestruStudentInfo DetaliuPlanSemetruGet(long ID_DetaliuPlanSemestru)
        {
            return CBO.FillObject<DetaliuPlanSemestruStudentInfo>(SqlHelper.ExecuteReader(_ConnectionString, "DetaliuPlanSemetruGet", ID_DetaliuPlanSemestru));
        }

        public List<DetaliuPlanSemestruStudentInfo> DetaliuPlanSemetruListByStudentGet(long ID_Student, long ID_AnUniv)
        {
            return CBO.FillCollection<DetaliuPlanSemestruStudentInfo>(SqlHelper.ExecuteReader(_ConnectionString, "DetaliuPlanSemetruListByStudentGet", ID_Student, ID_AnUniv));
        }

        public List<DetaliuPlanSemestruInfo> RestanteListByStudentFacultateGet(long ID_Student, long ID_Facultate, long ID_TipCicluInv, long ID_TipFormaInv, long ID_Specializare)
        {
            return CBO.FillCollection<DetaliuPlanSemestruInfo>(SqlHelper.ExecuteReader(_ConnectionString, "RestanteListByStudentFacultateGet", ID_Student, ID_Facultate, ID_TipCicluInv, ID_TipFormaInv, ID_Specializare));
        }

        public List<DetaliuPlanSemestruStudentInfo> RestanteListBySpecializareGet(long ID_AnUniv, long ID_Specializare, long ID_Grupa, long ID_AnStudiu, string FiltruTipIntrareIesire, bool ExcludeAnUnivCurent)
        {
            return CBO.FillCollection<DetaliuPlanSemestruStudentInfo>(SqlHelper.ExecuteReader(_ConnectionString, "RestanteListBySpecializareGet", -1, -1, ID_AnStudiu, -1, ID_Specializare, ID_Grupa, ID_AnUniv, FiltruTipIntrareIesire, ExcludeAnUnivCurent));
        }

        public long AddOrUpdatePost(DetaliuPlanSemestruStudentInfo obj)
        {
            return Convert.ToInt64(SqlHelper.ExecuteScalar(_ConnectionString, "DetaliuPlanSemetruAddOrUpdatePost", obj.ID_AnUniv, obj.ID_FC, obj.ID_FCForma, obj.ID_Specializare, obj.ID_Materie, obj.NumarSemestru, obj.TipDisciplinaCriteriul1, obj.TipDisciplinaCriteriul2, obj.NrOreCurs, obj.NrOreSeminar, obj.NrOreLaborator, obj.NrOreProiect, obj.TipVerificare, obj.OrdineDetaliuPlanSemestru, obj.NrCredite, obj.CodificareDisciplina, obj.ID_Student, obj.ID_DetaliuPlanSemestruInlocuit, obj.ID_TipNota, DateTime.Parse("1900-01-01"), obj.ID_AnStud, obj.MaterieStearsa, obj.ID_DetaliuPlanSemestruStudent));
        }
    }
}
