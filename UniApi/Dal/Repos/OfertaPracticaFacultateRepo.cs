using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace UniTBv.AGSIS.Dal.Repos
{
    public class OfertaPracticaFacultateRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public OfertaPracticaFacultate OfertaPracticaFacultateGet(long iD_OfertaPracticaFacultate)
        {
            return CBO.FillObject<OfertaPracticaFacultate>(SqlHelper.ExecuteReader(_connectionString, "OfertaPracticaFacultateGet", iD_OfertaPracticaFacultate));
        }

        public List<OfertaPracticaFacultate> OfertaPracticaFacultateGetList()
        {
            return CBO.FillCollection<OfertaPracticaFacultate>(SqlHelper.ExecuteReader(_connectionString, "OfertaPracticaFacultateList"));
        }

        public List<OfertaPracticaFacultate> OfertaPracticaFacultateGetListByFacAnStudSpecializDomFC(long iD_Facultate, long iD_AnStudiu, long iD_Specializare, long iD_Domeniu, long iD_FC, int status, DateTime dataValabilitate)
        {
            return CBO.FillCollection<OfertaPracticaFacultate>(SqlHelper.ExecuteReader(_connectionString, "OfertaPracticaFacultateListByFacAnStudSpecializDomFC", iD_Facultate, iD_AnStudiu, iD_Specializare, iD_Domeniu, iD_FC, status, dataValabilitate));
        }

        public List<OfertaPracticaFacultate> OfertaPracticaFacultateGetListByFacAnStudFC(long iD_Facultate, long iD_AnStudiu, long iD_FC, int status, DateTime dataValabilitate)
        {
            return CBO.FillCollection<OfertaPracticaFacultate>(SqlHelper.ExecuteReader(_connectionString, "OfertaPracticaFacultateListByFacAnStudFC", iD_Facultate, iD_AnStudiu, iD_FC, status, dataValabilitate));
        }

        public List<OfertaPracticaFacultate> OfertaPracticaFacultateGetListByIdOfertaPractica(long iD_OfertaPractica)
        {
            return CBO.FillCollection<OfertaPracticaFacultate>(SqlHelper.ExecuteReader(_connectionString, "OfertaPracticaFacultateListByIdOfertaPractica", iD_OfertaPractica));
        }

        public void OfertaPracticaFacultateAdd(OfertaPracticaFacultate objOfertaPracticaFacultate)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "OfertaPracticaFacultateAdd",
              objOfertaPracticaFacultate.ID_OfertaPractica, objOfertaPracticaFacultate.ID_Facultate, objOfertaPracticaFacultate.ID_AnStudiu, objOfertaPracticaFacultate.ID_Specializare, objOfertaPracticaFacultate.ID_Domeniu, objOfertaPracticaFacultate.ID_FC, objOfertaPracticaFacultate.ID_FCForma, objOfertaPracticaFacultate.DataModificare, objOfertaPracticaFacultate.Status, objOfertaPracticaFacultate.NrLocuri);
        }

        public void OfertaPracticaFacultateUpdate(OfertaPracticaFacultate objOfertaPracticaFacultate)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "OfertaPracticaFacultateUpdate",
              objOfertaPracticaFacultate.ID_OfertaPracticaFacultate, objOfertaPracticaFacultate.ID_OfertaPractica, objOfertaPracticaFacultate.ID_Facultate, objOfertaPracticaFacultate.ID_AnStudiu, objOfertaPracticaFacultate.ID_Specializare,
              objOfertaPracticaFacultate.ID_Domeniu, objOfertaPracticaFacultate.ID_FC, objOfertaPracticaFacultate.ID_FCForma, objOfertaPracticaFacultate.DataModificare, objOfertaPracticaFacultate.Status, objOfertaPracticaFacultate.NrLocuri);
        }

        public void OfertaPracticaFacultateDelete(long iD_OfertaPracticaFacultate)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "OfertaPracticaFacultateDelete", iD_OfertaPracticaFacultate);
        }
    }
}
