using System;
using System.Collections.Generic;
using UniApi.Info;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using DotNetNuke.Common.Utilities;

namespace UniApi.Dal.Repos
{
    public class OfertaPracticaFacultateRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public OfertaPracticaFacultate OfertaPracticaFacultateGet(long ID_OfertaPracticaFacultate)
        {
            return CBO.FillObject<OfertaPracticaFacultate>(
                SqlHelper.ExecuteReader(_ConnectionString, "OfertaPracticaFacultate_Get", ID_OfertaPracticaFacultate));
        }

        public List<OfertaPracticaFacultate> OfertaPracticaFacultateListGet()
        {
            return CBO.FillCollection<OfertaPracticaFacultate>(
                SqlHelper.ExecuteReader(_ConnectionString, "OfertaPracticaFacultate_GetList"));
        }

        public List<OfertaPracticaFacultate> OfertaPracticaFacultateListByFacAnStudSpecializDomFCGet(long ID_Facultate, long ID_AnStudiu, long ID_Specializare, long ID_Domeniu, long ID_FC, int Status, DateTime DataValabilitate)
        {
            return CBO.FillCollection<OfertaPracticaFacultate>(
                SqlHelper.ExecuteReader(_ConnectionString, "OfertaPracticaFacultate_GetListByFacAnStudSpecializDomFC", ID_Facultate, ID_AnStudiu, ID_Specializare, ID_Domeniu, ID_FC, Status, DataValabilitate));
        }

        public List<OfertaPracticaFacultate> OfertaPracticaFacultateListByFacAnStudFCGet(long ID_Facultate, long ID_AnStudiu, long ID_FC, int Status, DateTime DataValabilitate)
        {
            return CBO.FillCollection<OfertaPracticaFacultate>(
                SqlHelper.ExecuteReader(_ConnectionString, "OfertaPracticaFacultate_GetListByFacAnStudFC", ID_Facultate, ID_AnStudiu, ID_FC, Status, DataValabilitate));
        }

        public List<OfertaPracticaFacultate> OfertaPracticaFacultateListByIdOfertaPracticaGet(long ID_OfertaPractica)
        {
            return CBO.FillCollection<OfertaPracticaFacultate>(
                SqlHelper.ExecuteReader(_ConnectionString, "OfertaPracticaFacultate_GetListByIdOfertaPractica", ID_OfertaPractica));
        }

        public void OfertaPracticaFacultateAdd(OfertaPracticaFacultate objOfertaPracticaFacultate)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "OfertaPracticaFacultate_Add", objOfertaPracticaFacultate);
        }

        public void OfertaPracticaFacultateUpdate(OfertaPracticaFacultate objOfertaPracticaFacultate)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "OfertaPracticaFacultate_Update", objOfertaPracticaFacultate);
        }

        public void OfertaPracticaFacultateDelete(long ID_OfertaPracticaFacultate)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "OfertaPracticaFacultate_Delete", ID_OfertaPracticaFacultate);
        }
    }
}
