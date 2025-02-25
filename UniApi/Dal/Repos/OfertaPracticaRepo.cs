using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace UniTBv.AGSIS.Dal.Repos
{
    public class OfertaPracticaRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public OfertaPractica OfertaPracticaGet(long iD_OfertaPractica)
        {
            return CBO.FillObject<OfertaPractica>(SqlHelper.ExecuteReader(_connectionString, "OfertaPracticaGet", iD_OfertaPractica));
        }

        public List<OfertaPractica> OfertaPracticaGetList()
        {
            return CBO.FillCollection<OfertaPractica>(SqlHelper.ExecuteReader(_connectionString, "OfertaPracticaList"));
        }

        public List<OfertaPractica> OfertaPracticaGetListByUserIDPortal(int iD_UserPortal)
        {
            return CBO.FillCollection<OfertaPractica>(SqlHelper.ExecuteReader(_connectionString, "OfertaPracticaListByUserIDPortal", iD_UserPortal));
        }

        public void OfertaPracticaAdd(OfertaPractica objOfertaPractica)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "OfertaPracticaAdd",
              objOfertaPractica.ID_Firma, objOfertaPractica.DescriereOfertaPractica, objOfertaPractica.PerioadaValabilitateStart, objOfertaPractica.PerioadaValabilitateStop, objOfertaPractica.AdresaImagine,
              objOfertaPractica.NrLocuri, objOfertaPractica.ID_TipPractica, objOfertaPractica.ID_AnUniv, objOfertaPractica.DataModificare, objOfertaPractica.Status, objOfertaPractica.DataValabilitate, objOfertaPractica.NumeOferta);
        }

        public void OfertaPracticaUpdate(OfertaPractica objOfertaPractica)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "OfertaPracticaUpdate", objOfertaPractica.ID_OfertaPractica, objOfertaPractica.ID_Firma, objOfertaPractica.DescriereOfertaPractica, objOfertaPractica.PerioadaValabilitateStart, objOfertaPractica.PerioadaValabilitateStop, objOfertaPractica.AdresaImagine, objOfertaPractica.NrLocuri, objOfertaPractica.ID_TipPractica, objOfertaPractica.ID_AnUniv, objOfertaPractica.DataModificare, objOfertaPractica.Status, objOfertaPractica.DataValabilitate, objOfertaPractica.NumeOferta);
        }

        public void OfertaPracticaDelete(long iD_OfertaPractica)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "OfertaPracticaDelete", iD_OfertaPractica);
        }
    }
}
