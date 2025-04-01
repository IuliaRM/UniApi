using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class VenitCheltuialaDiverseRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public VenitCheltuialaDiverseInfo VenitCheltuialaDiverseGet(long id)
        {
            return CBO.FillObject<VenitCheltuialaDiverseInfo>(
                SqlHelper.ExecuteReader(_connectionString, "VenitCheltuialaDiverseGet", id));
        }

        public List<VenitCheltuialaDiverseInfo> VenitCheltuialaDiverseListGet()
        {
            return CBO.FillCollection<VenitCheltuialaDiverseInfo>(
                SqlHelper.ExecuteReader(_connectionString, "VenitCheltuialaDiverseList"));
        }

        public List<VenitCheltuialaDiverseInfo> VenitCheltuialaDiverseByAnUniversitarGet(long idAnUniversitar)
        {
            return CBO.FillCollection<VenitCheltuialaDiverseInfo>(
                SqlHelper.ExecuteReader(_connectionString, "VenitCheltuialaDiverseByAnUniversitar", idAnUniversitar));
        }

        public List<VenitCheltuialaDiverseInfo> VenitCheltuialaDiverseByFacultateGet(long idFacultate, long idAnUniversitar)
        {
            return CBO.FillCollection<VenitCheltuialaDiverseInfo>(
                SqlHelper.ExecuteReader(_connectionString, "VenitCheltuialaDiverseByFacultate", idFacultate, idAnUniversitar));
        }

        public List<VenitCheltuialaDiverseInfo> VenitCheltuialaDiverseByCatedraGet(long idCatedra, long idAnUniversitar)
        {
            return CBO.FillCollection<VenitCheltuialaDiverseInfo>(
                SqlHelper.ExecuteReader(_connectionString, "VenitCheltuialaDiverseByCatedra", idCatedra, idAnUniversitar));
        }

        public long VenitCheltuialaDiverseAdd(VenitCheltuialaDiverseInfo venitCheltuiala)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "VenitCheltuialaDiverseAdd",
                venitCheltuiala.ID_VenitCheltuialaDiverse,
                venitCheltuiala.ID_AnUniv,
                venitCheltuiala.ID_Facultate,
                venitCheltuiala.ID_Catedra,
                venitCheltuiala.TipVenitCheltuialaDiverse,
                venitCheltuiala.ValoareVenitCheltuialaDiverse);

            return Convert.ToInt64(id);
        }

        public void VenitCheltuialaDiverseUpdate(VenitCheltuialaDiverseInfo venitCheltuiala)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "VenitCheltuialaDiverseUpdate",
                venitCheltuiala.ID_VenitCheltuialaDiverse,
                venitCheltuiala.ID_AnUniv,
                venitCheltuiala.ID_Facultate,
                venitCheltuiala.ID_Catedra,
                venitCheltuiala.TipVenitCheltuialaDiverse,
                venitCheltuiala.ValoareVenitCheltuialaDiverse);
        }

        public void VenitCheltuialaDiverseDelete(long id)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "VenitCheltuialaDiverseDelete", id);
        }
    }
}
