using System;
using System.Collections.Generic;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Dal.Repos;
using UniApi.Info; 


namespace UniApi.Dal.Repos
{
    public class AnunturiRepo
    {
        private string _connectionString;

        public AnunturiRepo()
        {
            // Poți să setezi _connectionString în constructor, dacă dorești
            _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;
        }

        // Add a new announcement
        public bool AnunturiAdd(AnunturiInfo anunturiInfo)
        {
            try
            {
                var id = SqlHelper.ExecuteScalar(_connectionString, "AnunturiAdd",
                  anunturiInfo.TitluAnunt,
                    anunturiInfo.MesajAnunt,
                    anunturiInfo.DataPostare,
                    anunturiInfo.DataExpirare,
                    anunturiInfo.AnuntProfesori,
                    anunturiInfo.AnuntStudenti,
                    anunturiInfo.ID_Facultate,
                    anunturiInfo.ID_FC,
                    anunturiInfo.ID_FCForma,
                    anunturiInfo.ID_Catedra,
                    anunturiInfo.ID_AnUniv,
                    anunturiInfo.ID_AnStudiu,
                    anunturiInfo.ID_Domeniu,
                    anunturiInfo.ID_Specializare,
                    anunturiInfo.ID_Grupe,
                    anunturiInfo.PortalID,
                    anunturiInfo.UserID,
                    anunturiInfo.TipFisier,
                    anunturiInfo.CaleFisier);
                return Convert.ToInt64(id) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Get an announcement by its ID
        public AnunturiInfo AnunturiGet(long idAnunt)
        {
            using (var dr = SqlHelper.ExecuteReader(_connectionString, "AnunturiGet", idAnunt))
            {
                return (AnunturiInfo)CBO.FillObject(dr, typeof(AnunturiInfo));
            }
        }

        // Get a list of all announcements
        public List<AnunturiInfo> AnunturiList()
        {
            using (var dr = SqlHelper.ExecuteReader(_connectionString, "AnunturiList"))
            {
                return CBO.FillCollection<AnunturiInfo>(dr);
            }
        }

        // Delete an announcement
        public void AnunturiDelete(long idAnunt)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "AnunturiDelete", idAnunt);
        }

        // Update an existing announcement
        public bool AnunturiUpdate(AnunturiInfo anunturiInfo)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "AnunturiUpdate",
                    anunturiInfo.IdAnunt,
                    anunturiInfo.TitluAnunt,
                    anunturiInfo.MesajAnunt,
                    anunturiInfo.DataPostare,
                    anunturiInfo.DataExpirare,
                    anunturiInfo.AnuntProfesori,
                    anunturiInfo.AnuntStudenti,
                    anunturiInfo.ID_Facultate,
                    anunturiInfo.ID_FC,
                    anunturiInfo.ID_FCForma,
                    anunturiInfo.ID_Catedra,
                    anunturiInfo.ID_AnUniv,
                    anunturiInfo.ID_AnStudiu,
                    anunturiInfo.ID_Domeniu,
                    anunturiInfo.ID_Specializare,
                    anunturiInfo.ID_Grupe,
                    anunturiInfo.PortalID,
                    anunturiInfo.UserID,
                    anunturiInfo.TipFisier,
                    anunturiInfo.CaleFisier);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Get announcements for a specific university year and faculty
        public List<AnunturiInfo> AnunturiListByAnUniv_Facultate(long idAnUniv, long idFacultate)
        {
            using (var dr = SqlHelper.ExecuteReader(_connectionString, "AnunturiListByAnUniv_Facultate", idAnUniv, idFacultate))
            {
                return CBO.FillCollection<AnunturiInfo>(dr);
            }
        }

        // Get announcements for a specific student based on multiple criteria
        public List<AnunturiInfo> AnunturiListByStudent(long idAnUniv, long idAnStudiu, long idFacultate, long idFC, long idFCForma, long idDomeniu, long idSpecializare, long idGrupe)
        {
            using (var dr = SqlHelper.ExecuteReader(_connectionString, "AnunturiListByStudent", idAnUniv, idAnStudiu, idFacultate, idFC, idFCForma, idDomeniu, idSpecializare, idGrupe))
            {
                return CBO.FillCollection<AnunturiInfo>(dr);
            }
        }

        // Get paginated list of announcements
        public List<AnunturiInfo> AnunturiListPaged(int pageIndex, int pageSize, ref int totalRecords)
        {
            using (var dr = SqlHelper.ExecuteReader(_connectionString, "AnunturiListPaged", pageIndex, pageSize))
            {
                totalRecords = Convert.ToInt32(SqlHelper.ExecuteScalar(_connectionString, "AnunturiCount"));
                return CBO.FillCollection<AnunturiInfo>(dr);
            }
        }
    }
}
