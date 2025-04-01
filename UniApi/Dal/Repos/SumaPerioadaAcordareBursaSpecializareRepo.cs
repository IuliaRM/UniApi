using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class SumaPerioadaAcordareBursaSpecializareRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public List<SumaPerioadaAcordareBursaSpecializareInfo> SumaPerioadaAcordareBursaSpecializareListByTipPerioadaSpecializareGet(long idAnUniv, long idTipPerioadaAcordareBursa, long idSpecializare)
        {
            return CBO.FillCollection<SumaPerioadaAcordareBursaSpecializareInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SumaPerioadaAcordareBursaSpecializareListByTipPerioadaSpecializare", idAnUniv, idTipPerioadaAcordareBursa, idSpecializare));
        }

        public void SumaPerioadaAcordareBursaSpecializareMerge(SumaPerioadaAcordareBursaSpecializareInfo obj)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "SumaPerioadaAcordareBursaSpecializareMerge", obj.ID_Specializare, obj.ID_TipPerioadaAcordareBursa, obj.NrZile, obj.NrZileAniTerminali, obj.DataModificare, obj.OwnerID);
        }
    }
}
