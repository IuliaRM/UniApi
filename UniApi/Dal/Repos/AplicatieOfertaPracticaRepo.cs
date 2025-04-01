using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public class AplicatieOfertaPracticaRepo
    {
        public void AplicatieOfertaPracticaAdd(AplicatieOfertaPractica aplicatie)
        {
            SqlHelper.ExecuteNonQuery(
                ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString,
                "AplicatieOfertaPractica_Add",
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
        }

        public AplicatieOfertaPractica AplicatieOfertaPracticaGet(long idAplicatie)
        {
            using (var dr = SqlHelper.ExecuteReader(
                ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString,
                "AplicatieOfertaPractica_Get",
                idAplicatie))
            {
                return CBO.FillObject<AplicatieOfertaPractica>(dr);
            }
        }

        public List<AplicatieOfertaPractica> AplicatieOfertaPracticaList()
        {
            using (var dr = SqlHelper.ExecuteReader(
                ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString,
                "AplicatieOfertaPractica_List"))
            {
                return CBO.FillCollection<AplicatieOfertaPractica>(dr);
            }
        }

        public List<AplicatieOfertaPractica> AplicatieOfertaPracticaListByIDOfPracFac(long idOfertaPracticaFacultate)
        {
            using (var dr = SqlHelper.ExecuteReader(
                ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString,
                "AplicatieOfertaPractica_ListByIDOfPracFac",
                idOfertaPracticaFacultate))
            {
                return CBO.FillCollection<AplicatieOfertaPractica>(dr);
            }
        }

        public List<AplicatieOfertaPractica> AplicatieOfertaPracticaListByStudent(long idStudent)
        {
            using (var dr = SqlHelper.ExecuteReader(
                ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString,
                "AplicatieOfertaPractica_ListByStudent",
                idStudent))
            {
                return CBO.FillCollection<AplicatieOfertaPractica>(dr);
            }
        }

        public void AplicatieOfertaPracticaUpdate(AplicatieOfertaPractica aplicatie)
        {
            SqlHelper.ExecuteNonQuery(
                ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString,
                "AplicatieOfertaPractica_Update",
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
        }

        public void AplicatieOfertaPracticaDelete(long idAplicatie)
        {
            SqlHelper.ExecuteNonQuery(
                ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString,
                "AplicatieOfertaPractica_Delete",
                idAplicatie);
        }

        public int AplicatieOfertaPracticaGetTotalCountByIDOfPracticaFac(long idOfertaPracticaFacultate)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(
                ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString,
                "AplicatieOfertaPractica_GetTotalCountByIDOfPracticaFac",
                idOfertaPracticaFacultate));
        }
    }
}
