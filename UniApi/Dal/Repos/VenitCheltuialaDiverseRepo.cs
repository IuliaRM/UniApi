using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using UniApi.Info;


namespace UniApi.DAL.Repos
{

    public interface IVenitCheltuialaDiverseRepo
    {
        VenitCheltuialaDiverseInfo VenitCheltuialaDiverseGet(long id);
        List<VenitCheltuialaDiverseInfo> VenitCheltuialaDiverseList();
        List<VenitCheltuialaDiverseInfo> VenitCheltuialaDiverseListByAnUniversitar(long idAnUniversitar);
        List<VenitCheltuialaDiverseInfo> VenitCheltuialaDiverseListByFacultateAnUniv(long idFacultate, long idAnUniversitar);
        List<VenitCheltuialaDiverseInfo> VenitCheltuialaDiverseListByCatedraAnUniv(long idCatedra, long idAnUniversitar);
        List<VenitCheltuialaDiverseInfo> VenitCheltuialaDiverseListByTrunchiAnUniv(long idTrunchi, long idAnUniversitar);
        long VenitCheltuialaDiverseAdd(VenitCheltuialaDiverseInfo venitCheltuiala);
        void VenitCheltuialaDiverseUpdate(VenitCheltuialaDiverseInfo venitCheltuiala);
        void VenitCheltuialaDiverseDelete(long id);
    }

    public class VenitCheltuialaDiverseRepo : IVenitCheltuialaDiverseRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public VenitCheltuialaDiverseInfo VenitCheltuialaDiverseGet(long id)
        {
            return CBO.FillObject<VenitCheltuialaDiverseInfo>(
                SqlHelper.ExecuteReader(_connectionString, "VenitCheltuialaDiverseGet", id));
        }

        public List<VenitCheltuialaDiverseInfo> VenitCheltuialaDiverseList()
        {
            return CBO.FillCollection<VenitCheltuialaDiverseInfo>(
                SqlHelper.ExecuteReader(_connectionString, "VenitCheltuialaDiverseList"));
        }

        public List<VenitCheltuialaDiverseInfo> VenitCheltuialaDiverseListByAnUniversitar(long idAnUniversitar)
        {
            return CBO.FillCollection<VenitCheltuialaDiverseInfo>(
                SqlHelper.ExecuteReader(_connectionString, "VenitCheltuialaDiverseListByAnUniversitar", idAnUniversitar));
        }

        public List<VenitCheltuialaDiverseInfo> VenitCheltuialaDiverseListByFacultateAnUniv(long idFacultate, long idAnUniversitar)
        {
            return CBO.FillCollection<VenitCheltuialaDiverseInfo>(
                SqlHelper.ExecuteReader(_connectionString, "VenitCheltuialaDiverseListByFacultateAnUniv", idFacultate, idAnUniversitar));
        }

        public List<VenitCheltuialaDiverseInfo> VenitCheltuialaDiverseListByCatedraAnUniv(long idCatedra, long idAnUniversitar)
        {
            return CBO.FillCollection<VenitCheltuialaDiverseInfo>(
                SqlHelper.ExecuteReader(_connectionString, "VenitCheltuialaDiverseListByCatedraAnUniv", idCatedra, idAnUniversitar));
        }

        public List<VenitCheltuialaDiverseInfo> VenitCheltuialaDiverseListByTrunchiAnUniv(long idTrunchi, long idAnUniversitar)
        {
            return CBO.FillCollection<VenitCheltuialaDiverseInfo>(
                SqlHelper.ExecuteReader(_connectionString, "VenitCheltuialaDiverseListByTrunchiAnUniv", idTrunchi, idAnUniversitar));
        }

        public long VenitCheltuialaDiverseAdd(VenitCheltuialaDiverseInfo venitCheltuiala)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "VenitCheltuialaDiverseAdd",
                venitCheltuiala.ID_AnUniv,
                venitCheltuiala.ID_Facultate,
                venitCheltuiala.ID_Catedra,
                venitCheltuiala.ID_Trunchi,
                venitCheltuiala.TipVenitCheltuialaDiverse,
                venitCheltuiala.ValoareVenitCheltuialaDiverse);
                //venitCheltuiala.Observatii);
            return Convert.ToInt64(id);
        }

        public void VenitCheltuialaDiverseUpdate(VenitCheltuialaDiverseInfo venitCheltuiala)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "VenitCheltuialaDiverseUpdate",
                venitCheltuiala.ID_VenitCheltuialaDiverse,
                venitCheltuiala.ID_AnUniv,
                venitCheltuiala.ID_Facultate,
                venitCheltuiala.ID_Catedra,
                venitCheltuiala.ID_Trunchi,
                venitCheltuiala.TipVenitCheltuialaDiverse,
                venitCheltuiala.ValoareVenitCheltuialaDiverse);
                //venitCheltuiala.Observatii);
        }

        public void VenitCheltuialaDiverseDelete(long id)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "VenitCheltuialaDiverseDelete", id);
        }
    }
}
