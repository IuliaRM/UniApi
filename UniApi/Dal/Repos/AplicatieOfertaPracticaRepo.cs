using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IAplicatieOfertaPracticaRepo
    {
        bool AplicatieOfertaPracticaAdd(AplicatieOfertaPractica aplicatie);
        bool AplicatieOfertaPracticaUpdate(AplicatieOfertaPractica aplicatie);
        bool AplicatieOfertaPracticaDelete(long idAplicatie);
        AplicatieOfertaPractica AplicatieOfertaPracticaGet(long idAplicatie);
        int AplicatieOfertaPracticaGetTotalCountByIDOPracticaFac(long idOfertaPracticaFacultate);
        List<AplicatieOfertaPractica> AplicatieOfertaPracticaList();
        List<AplicatieOfertaPractica> AplicatieOfertaPracticaListByIDFirma(long idFirma);
        List<AplicatieOfertaPractica> AplicatieOfertaPracticaListIDOfPracFac(long idOfertaPracticaFacultate);
        List<AplicatieOfertaPractica> AplicatieOfertaPracticaListByStudent(long idStudent);
    }

    public class AplicatieOfertaPracticaRepo : IAplicatieOfertaPracticaRepo
    {
        private readonly string _connectionString;

        public AplicatieOfertaPracticaRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;

            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found.");
        }

        public bool AplicatieOfertaPracticaAdd(AplicatieOfertaPractica aplicatie)
        {
            if (aplicatie == null)
                throw new ArgumentNullException(nameof(aplicatie));

            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "AplicatieOfertaPractica_Add",
                    aplicatie.ID_Student,
                    aplicatie.ID_OfertaPracticaFacultate,
                    aplicatie.AdresaFisier,
                    aplicatie.DataAplicatieStudent,
                    aplicatie.AcceptatFacultate,
                    aplicatie.AcceptatFacultateData,
                    aplicatie.AcceptatFirma,
                    aplicatie.AcceptatFirmaData,
                    aplicatie.ConfirmareStagiuFirma,
                    aplicatie.TitluProiectPractica,
                    aplicatie.ID_TipCalificativPractica,
                    aplicatie.DataModificareCalificativ,
                    aplicatie.ID_MentorPracticaFirma
                );

                return true;
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la adăugarea aplicației de practică.", ex);
            }
        }

        public bool AplicatieOfertaPracticaUpdate(AplicatieOfertaPractica aplicatie)
        {
            if (aplicatie == null)
                throw new ArgumentNullException(nameof(aplicatie));

            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "AplicatieOfertaPractica_Update",
                    aplicatie.ID_AplicatieOfertaPractica,
                    aplicatie.AcceptatFacultate,
                    aplicatie.AcceptatFacultateData,
                    aplicatie.AcceptatFirma,
                    aplicatie.AcceptatFirmaData,
                    aplicatie.ConfirmareStagiuFirma,
                    aplicatie.TitluProiectPractica,
                    aplicatie.ID_TipCalificativPractica,
                    aplicatie.DataModificareCalificativ,
                    aplicatie.ID_MentorPracticaFirma
                );

                return true;
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la actualizarea aplicației de practică.", ex);
            }
        }

        public bool AplicatieOfertaPracticaDelete(long idAplicatie)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "AplicatieOfertaPractica_Delete", idAplicatie);
                return true;
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la ștergerea aplicației de practică.", ex);
            }
        }

        public AplicatieOfertaPractica AplicatieOfertaPracticaGet(long idAplicatie)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "AplicatieOfertaPractica_Get", idAplicatie))
                {
                    return CBO.FillObject<AplicatieOfertaPractica>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obținerea aplicației de practică.", ex);
            }
        }

        public int AplicatieOfertaPracticaGetTotalCountByIDOPracticaFac(long idOfertaPracticaFacultate)
        {
            try
            {
                return Convert.ToInt32(SqlHelper.ExecuteScalar(
                    _connectionString,
                    "AplicatieOfertaPractica_GetTotalCountByIDOfPracticaFac",
                    idOfertaPracticaFacultate));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obținerea numărului total de aplicații pentru ofertă.", ex);
            }
        }

        public List<AplicatieOfertaPractica> AplicatieOfertaPracticaList()
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "AplicatieOfertaPractica_List"))
                {
                    return CBO.FillCollection<AplicatieOfertaPractica>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea aplicațiilor de practică.", ex);
            }
        }

        public List<AplicatieOfertaPractica> AplicatieOfertaPracticaListByIDFirma(long idFirma)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "AplicatieOfertaPractica_ListByIDFirma", idFirma))
                {
                    return CBO.FillCollection<AplicatieOfertaPractica>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea aplicațiilor după firmă.", ex);
            }
        }

        public List<AplicatieOfertaPractica> AplicatieOfertaPracticaListIDOfPracFac(long idOfertaPracticaFacultate)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "AplicatieOfertaPractica_ListByIDOfPracFac", idOfertaPracticaFacultate))
                {
                    return CBO.FillCollection<AplicatieOfertaPractica>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea aplicațiilor după ofertă facultate.", ex);
            }
        }

        public List<AplicatieOfertaPractica> AplicatieOfertaPracticaListByStudent(long idStudent)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "AplicatieOfertaPractica_ListByStudent", idStudent))
                {
                    return CBO.FillCollection<AplicatieOfertaPractica>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea aplicațiilor studentului.", ex);
            }
        }
    }
}
