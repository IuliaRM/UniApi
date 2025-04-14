using System;
using System.Collections.Generic;
using System.Configuration;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;


namespace UniApi.DAL.Repos
{

    public interface IValoareTipBursaFacultateRepo
    {
        ValoareTipBursaFacultateInfo ValoareTipBursaFacultateGet(long id);
        List<ValoareTipBursaFacultateInfo> ValoareTipBursaFacultateList();
        List<ValoareTipBursaFacultateInfo> ValoareTipBursaFacultateGetByFTL(long idFacultate, long idTipBursa, long idAnUnivBursa);
        long ValoareTipBursaFacultateAdd(ValoareTipBursaFacultateInfo valoareTipBursa);
        void ValoareTipBursaFacultateUpdate(ValoareTipBursaFacultateInfo valoareTipBursa);
        void ValoareTipBursaFacultateDelete(long id);
    }

    public class ValoareTipBursaFacultateRepo : IValoareTipBursaFacultateRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public ValoareTipBursaFacultateInfo ValoareTipBursaFacultateGet(long id)
        {
            return CBO.FillObject<ValoareTipBursaFacultateInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ValoareTipBursaFacultateGet", id));
        }

        public List<ValoareTipBursaFacultateInfo> ValoareTipBursaFacultateList()
        {
            return CBO.FillCollection<ValoareTipBursaFacultateInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ValoareTipBursaFacultateList"));
        }

        public List<ValoareTipBursaFacultateInfo> ValoareTipBursaFacultateGetByFTL(long idFacultate, long idTipBursa, long idAnUnivBursa)
        {
            return CBO.FillCollection<ValoareTipBursaFacultateInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ValoareTipBursaFacultateGetByFTL", idFacultate, idTipBursa, idAnUnivBursa));
        }

        public long ValoareTipBursaFacultateAdd(ValoareTipBursaFacultateInfo valoareTipBursa)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "ValoareTipBursaFacultateAdd",
                valoareTipBursa.ID_Facultate,
                valoareTipBursa.ID_TipBursa,
                valoareTipBursa.NumarLuna,
                valoareTipBursa.ValoareTipBursa,
                valoareTipBursa.ID_AnUnivBursa);
            return Convert.ToInt64(id);
        }

        public void ValoareTipBursaFacultateUpdate(ValoareTipBursaFacultateInfo valoareTipBursa)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ValoareTipBursaFacultateUpdate",
                valoareTipBursa.ID_ValoareTipBursaFacultate,
                valoareTipBursa.ID_Facultate,
                valoareTipBursa.ID_TipBursa,
                valoareTipBursa.NumarLuna,
                valoareTipBursa.ValoareTipBursa,
                valoareTipBursa.ID_AnUnivBursa);
        }

        public void ValoareTipBursaFacultateDelete(long id)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ValoareTipBursaFacultateDelete", id);
        }
    }
}
