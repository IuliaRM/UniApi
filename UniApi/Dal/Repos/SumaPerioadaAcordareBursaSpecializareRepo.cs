using System;
using System.Collections.Generic;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{

    public interface ISumaPerioadaAcordareBursaSpecializareRepo
    {
        List<SumaPerioadaAcordareBursaSpecializareInfo> SumaPerioadaAcordareBursaSpecializareListByTipPerioadaSpecializare(long idAnUniv, long idTipPerioadaAcordareBursa, long idSpecializare);
        void SumaPerioadaAcordareBursaSpecializareMerge(SumaPerioadaAcordareBursaSpecializareInfo obj);
    }

    public class SumaPerioadaAcordareBursaSpecializareRepo : ISumaPerioadaAcordareBursaSpecializareRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public List<SumaPerioadaAcordareBursaSpecializareInfo> SumaPerioadaAcordareBursaSpecializareListByTipPerioadaSpecializare(long idAnUniv, long idTipPerioadaAcordareBursa, long idSpecializare)
        {
            return CBO.FillCollection<SumaPerioadaAcordareBursaSpecializareInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SumaPerioadaAcordareBursaSpecializareListByTipPerioadaSpecializare", idAnUniv, idTipPerioadaAcordareBursa, idSpecializare));
        }

        public void SumaPerioadaAcordareBursaSpecializareMerge(SumaPerioadaAcordareBursaSpecializareInfo obj)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "SumaPerioadaAcordareBursaSpecializareMerge",
                obj.ID_Specializare,
                obj.ID_TipPerioadaAcordareBursa,
                obj.NrZile,
                obj.NrZileAniTerminali,
                obj.DataModificare,
                obj.OwnerID);
        }
    }
}
