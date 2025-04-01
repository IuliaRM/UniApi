using System;
using System.Collections.Generic;
using UniApi.Info;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using DotNetNuke.Common.Utilities;

namespace UniApi.Dal.Repos
{
    public class IntervalPunctajBursaRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public List<IntervalPunctajBursaInfo> IntervalPunctajBursaListByTipBursaAnUnivFCFDASGet(long ID_TipBursa, long ID_AnUniv, long ID_AnUnivBursa, long NumarSemestruBursa, long NumarSemestruCalculPunctaj, long ID_FC, long ID_FCForma, long ID_Domeniu, long ID_AnStudiu, long ID_Specializare)
        {
            return CBO.FillCollection<IntervalPunctajBursaInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "IntervalPunctajBursa_GetListByTipBursaAnUnivFCFDAS", ID_TipBursa, ID_AnUniv, ID_AnUnivBursa, NumarSemestruBursa, NumarSemestruCalculPunctaj, ID_FC, ID_FCForma, ID_Domeniu, ID_AnStudiu, ID_Specializare));
        }

        public void IntervalPunctajBursaDelete(IntervalPunctajBursaInfo objIntervalPunctajBursa)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "IntervalPunctajBursa_Delete", objIntervalPunctajBursa);
        }

        public IntervalPunctajBursaInfo IntervalPunctajBursaGet(long ID_IntervalPunctajBursa)
        {
            return CBO.FillObject<IntervalPunctajBursaInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "IntervalPunctajBursa_Get", ID_IntervalPunctajBursa));
        }

        public long IntervalPunctajBursaAddOrUpdate(IntervalPunctajBursaInfo objIntervalPunctajBursa)
        {
            return (long)SqlHelper.ExecuteScalar(_ConnectionString, "IntervalPunctajBursa_AddOrUpdate", objIntervalPunctajBursa);
        }
    }
}
