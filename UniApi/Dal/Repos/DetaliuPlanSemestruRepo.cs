using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IDetaliuPlanSemestruRepo
    {
        DetaliuPlanSemestruInfo DetaliuPlanSemestruGet(long id);
        List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruGetByUserIDProfesor(long userId);
        List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruGetDinCentralizator(long idCentralizator);
        int DetaliuPlanSemestruImportDinIntranetPlanMaterie_Prestator();
        List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruListByAnUnivCicluForma(long idAnUniv, long idCiclu, long idForma);
        List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruListByMaterie(long idMaterie);
        List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruListByPlanSemestru(long idPlanSemestru);
        List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruListByPlanSemestruCriteriu2(long idPlanSemestru);
        List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruListByPlanSemestruStudent(long idStudent);
        List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruListByPlanSemestruStudentNeNull(long idStudent);
        List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruListByProfesorSemestru(long idProfesor, long idSemestru);
        List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruListByProfesorTitularAnUniv(long idProfesor, long idAnUniv);
        List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruListBySpecializare(long idSpecializare);
        List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruListByStudent(long idStudent);
        List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruListByStudentAnIdAnUniv(long idStudent, long idAnUniv);
        List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruListByStudentShowProfesori(long idStudent);
        long DetaliuPlanSemestruAddOrUpdate(DetaliuPlanSemestruInfo info);
        void DetaliuPlanSemestruDelete(long id);
        void DetaliuPlanSemestruDeleteByMaterieOrdine(long idMaterie, int ordine);
    }

    public class DetaliuPlanSemestruRepo : IDetaliuPlanSemestruRepo
    {
        private readonly string _connectionString;

        public DetaliuPlanSemestruRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;
            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found.");
        }

        public DetaliuPlanSemestruInfo DetaliuPlanSemestruGet(long id)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruGet", id))
                {
                    return CBO.FillObject<DetaliuPlanSemestruInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obtinerea detaliului planului semestrial.", ex);
            }
        }

        public List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruGetByUserIDProfesor(long userId)
        {
            try
            {
                return CBO.FillCollection<DetaliuPlanSemestruInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruGetByUserIDProfesor", userId));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obtinerea detaliilor dupa user profesor.", ex);
            }
        }

        public List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruGetDinCentralizator(long idCentralizator)
        {
            try
            {
                return CBO.FillCollection<DetaliuPlanSemestruInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruGetDinCentralizator", idCentralizator));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obtinerea datelor din centralizator.", ex);
            }
        }

        public int DetaliuPlanSemestruImportDinIntranetPlanMaterie_Prestator()
        {
            try
            {
                return Convert.ToInt32(SqlHelper.ExecuteScalar(_connectionString, "DetaliuPlanSemestruImportDinIntranetPlanMaterie_Prestator"));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la importul din Intranet.", ex);
            }
        }

        public List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruListByAnUnivCicluForma(long idAnUniv, long idCiclu, long idForma)
        {
            try
            {
                return CBO.FillCollection<DetaliuPlanSemestruInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruListByAnUnivCicluForma", idAnUniv, idCiclu, idForma));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea dupa an, ciclu si forma.", ex);
            }
        }

        public List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruListByMaterie(long idMaterie)
        {
            try
            {
                return CBO.FillCollection<DetaliuPlanSemestruInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruListByMaterie", idMaterie));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea dupa materie.", ex);
            }
        }

        public List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruListByPlanSemestru(long idPlanSemestru)
        {
            try
            {
                return CBO.FillCollection<DetaliuPlanSemestruInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruListByPlanSemestru", idPlanSemestru));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea dupa plan semestru.", ex);
            }
        }

        public List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruListByPlanSemestruCriteriu2(long idPlanSemestru)
        {
            try
            {
                return CBO.FillCollection<DetaliuPlanSemestruInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruListByPlanSemestruCriteriu2", idPlanSemestru));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea dupa plan semestru si criteriul 2.", ex);
            }
        }

        public List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruListByPlanSemestruStudent(long idStudent)
        {
            try
            {
                return CBO.FillCollection<DetaliuPlanSemestruInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruListByPlanSemestruStudent", idStudent));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea dupa student (plan semestru).", ex);
            }
        }

        public List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruListByPlanSemestruStudentNeNull(long idStudent)
        {
            try
            {
                return CBO.FillCollection<DetaliuPlanSemestruInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruListByPlanSemestruStudentNeNull", idStudent));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea studentilor cu plan semestru nenull.", ex);
            }
        }

        public List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruListByProfesorSemestru(long idProfesor, long idSemestru)
        {
            try
            {
                return CBO.FillCollection<DetaliuPlanSemestruInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruListByProfesorSemestru", idProfesor, idSemestru));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea dupa profesor si semestru.", ex);
            }
        }

        public List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruListByProfesorTitularAnUniv(long idProfesor, long idAnUniv)
        {
            try
            {
                return CBO.FillCollection<DetaliuPlanSemestruInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruListByProfesorTitularAnUniv", idProfesor, idAnUniv));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea profesorilor titulari pe an universitar.", ex);
            }
        }

        public List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruListBySpecializare(long idSpecializare)
        {
            try
            {
                return CBO.FillCollection<DetaliuPlanSemestruInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruListBySpecializare", idSpecializare));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea dupa specializare.", ex);
            }
        }

        public List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruListByStudent(long idStudent)
        {
            try
            {
                return CBO.FillCollection<DetaliuPlanSemestruInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruListByStudent", idStudent));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea detaliilor dupa student.", ex);
            }
        }

        public List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruListByStudentAnIdAnUniv(long idStudent, long idAnUniv)
        {
            try
            {
                return CBO.FillCollection<DetaliuPlanSemestruInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruListByStudentAnIdAnUniv", idStudent, idAnUniv));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea dupa student si an universitar.", ex);
            }
        }

        public List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruListByStudentShowProfesori(long idStudent)
        {
            try
            {
                return CBO.FillCollection<DetaliuPlanSemestruInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruListByStudentShowProfesori", idStudent));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea profesorilor studentului.", ex);
            }
        }

        public void DetaliuPlanSemestruDelete(long id)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "DetaliuPlanSemestruDelete", id);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la stergerea detaliului planului semestrial.", ex);
            }
        }

        public void DetaliuPlanSemestruDeleteByMaterieOrdine(long idMaterie, int ordine)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "DetaliuPlanSemestruDeleteByMaterieOrdine", idMaterie, ordine);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la stergerea dupa materie si ordine.", ex);
            }
        }

        public long DetaliuPlanSemestruAddOrUpdate(DetaliuPlanSemestruInfo info)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            try
            {
                return Convert.ToInt64(SqlHelper.ExecuteScalar(_connectionString, "DetaliuPlanSemestruAddOrUpdate",
                    info.ID_DetaliuPlanSemestru,
                    info.ID_PlanSemestru,
                    info.ID_Materie,
                    info.NumarPachet,
                    info.TipDisciplinaCriteriul1,
                    info.TipDisciplinaCriteriul2,
                    info.NrOreCurs,
                    info.NrOreSeminar,
                    info.NrOreLaborator,
                    info.NrOreProiect,
                    info.TipVerificare,
                    info.Ordine,
                    info.NrFormatiiCurs,
                    info.NrFormatiiSeminar,
                    info.NrFormatiiLaborator,
                    info.NrFormatiiProiect
                ));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la adaugarea sau actualizarea detaliului planului semestrial.", ex);
            }
        }
    }
}
