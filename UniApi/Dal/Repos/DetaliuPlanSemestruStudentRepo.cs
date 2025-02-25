using System;
using System.Collections.Generic;
using UniApi.Models;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using DotNetNuke.Common.Utilities;

namespace UniApi.Dal.Repos
{
    public class DetaliuPlanSemestruStudentRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public DetaliuPlanSemestruStudentInfo GetById(long iD_DetaliuPlanSemestru)
        {
            return CBO.FillObject<DetaliuPlanSemestruStudentInfo>(SqlHelper.ExecuteReader(_ConnectionString, "DetaliuPlanSemestruStudentGet", iD_DetaliuPlanSemestru));
        }

        public List<DetaliuPlanSemestruStudentInfo> GetListByStudent(long ID_Student, long ID_AnUniv)
        {
            return CBO.FillCollection<DetaliuPlanSemestruStudentInfo>(SqlHelper.ExecuteReader(_ConnectionString, "DetaliuPlanSemestruListByStudent", ID_Student, ID_AnUniv));
        }

        public List<DetaliuPlanSemestruInfo> GetRestanteListByStudentFacultate(long id_student, long id_facultate, long id_tipCicluInv, long id_tipFormaInv, long id_specializare)
        {
            return CBO.FillCollection<DetaliuPlanSemestruInfo>(SqlHelper.ExecuteReader(_ConnectionString, "ListaMateriiRestanteByStudentFacultate", id_student, id_facultate, id_tipCicluInv, id_tipFormaInv, id_specializare));
        }

        public List<DetaliuPlanSemestruStudentInfo> GetRestanteListBySpecializare(long ID_AnUniv, long ID_Specializare, long ID_Grupa, long ID_AnStudiu, string FiltruTipIntrareIesire, bool ExcludeAnUnivCurent)
        {
            return CBO.FillCollection<DetaliuPlanSemestruStudentInfo>(SqlHelper.ExecuteReader(_ConnectionString, "RAP_Studenti_DisciplineCreditate", -1, -1, ID_AnStudiu, -1, ID_Specializare, ID_Grupa, ID_AnUniv, FiltruTipIntrareIesire, ExcludeAnUnivCurent));
        }

        public long AddOrUpdate(DetaliuPlanSemestruStudentInfo obj)
        {
            return Convert.ToInt64(SqlHelper.ExecuteScalar(_ConnectionString, "DetaliuPlanSemestruStudentAddOrUpdate", obj.ID_AnUniv, obj.ID_FC, obj.ID_FCForma, obj.ID_Specializare, obj.ID_Materie, obj.NumarSemestru, obj.TipDisciplinaCriteriul1, obj.TipDisciplinaCriteriul2, obj.NrOreCurs, obj.NrOreSeminar, obj.NrOreLaborator, obj.NrOreProiect, obj.TipVerificare, obj.OrdineDetaliuPlanSemestru, obj.NrCredite, obj.CodificareDisciplina, obj.ID_Student, obj.ID_DetaliuPlanSemestruInlocuit, obj.ID_TipNota, DateTime.Parse("1900-01-01"), obj.ID_AnStud, obj.MaterieStearsa, obj.ID_DetaliuPlanSemestruStudent));
        }
    }
}
