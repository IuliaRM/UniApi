using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IDetaliuPlanSemestruStudentRepo
    {
        DetaliuPlanSemestruStudentInfo DetaliuPlanSemestruStudentGet(long id);
        List<DetaliuPlanSemestruStudentInfo> DetaliuPlanSemestruStudentListByStudent(long idStudent, long idAnUniv);
        long DetaliuPlanSemestruStudentAddOrUpdate(DetaliuPlanSemestruStudentInfo info);
        void DetaliuPlanSemestruStudentDelete(long id);
    }

    public class DetaliuPlanSemestruStudentRepo : IDetaliuPlanSemestruStudentRepo
    {
        private readonly string _connectionString;

        public DetaliuPlanSemestruStudentRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;
            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found.");
        }

        public DetaliuPlanSemestruStudentInfo DetaliuPlanSemestruStudentGet(long id)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemetruGet", id))
                {
                    return CBO.FillObject<DetaliuPlanSemestruStudentInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obtinerea detaliului planului semestrial pentru student.", ex);
            }
        }

        public List<DetaliuPlanSemestruStudentInfo> DetaliuPlanSemestruStudentListByStudent(long idStudent, long idAnUniv)
        {
            try
            {
                return CBO.FillCollection<DetaliuPlanSemestruStudentInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemetruListByStudentGet", idStudent, idAnUniv));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea detaliilor planului semestrial pentru student.", ex);
            }
        }

        public long DetaliuPlanSemestruStudentAddOrUpdate(DetaliuPlanSemestruStudentInfo info)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            try
            {
                return Convert.ToInt64(SqlHelper.ExecuteScalar(_connectionString, "DetaliuPlanSemetruAddOrUpdatePost",
                    info.ID_AnUniv,
                    info.ID_FC,
                    info.ID_FCForma,
                    info.ID_Specializare,
                    info.ID_Materie,
                    info.NumarSemestru,
                    info.TipDisciplinaCriteriul1,
                    info.TipDisciplinaCriteriul2,
                    info.NrOreCurs,
                    info.NrOreSeminar,
                    info.NrOreLaborator,
                    info.NrOreProiect,
                    info.TipVerificare,
                    info.OrdineDetaliuPlanSemestru,
                    info.NrCredite,
                    info.CodificareDisciplina,
                    info.ID_Student,
                    info.ID_DetaliuPlanSemestruInlocuit,
                    info.ID_TipNota,
                    DateTime.Parse("1900-01-01"),
                    info.ID_AnStud,
                    info.MaterieStearsa,
                    info.ID_DetaliuPlanSemestruStudent));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la adaugarea sau actualizarea detaliului studentului in planul semestrial.", ex);
            }
        }

        public void DetaliuPlanSemestruStudentDelete(long id)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "DetaliuPlanSemestruStudentDelete", id);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la stergerea detaliului planului semestrial pentru student.", ex);
            }
        }
    }
}
