using System;
using System.Collections.Generic;
using System.Configuration;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;

namespace UniApi.Dal.Repos
{
    public class IntervalPunctajBursaRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public IntervalPunctajBursaInfo IntervalPunctajBursaGet(long iD_IntervalPunctajBursa)
        {
            return CBO.FillObject<IntervalPunctajBursaInfo>(SqlHelper.ExecuteReader(_ConnectionString, "IntervalPunctajBursaGet", iD_IntervalPunctajBursa));
        }

        public List<IntervalPunctajBursaInfo> IntervalPunctajBursaListByTipBursaAnUnivFCFDAS(long iD_TipBursa, long ID_AnUniv, long ID_AnUnivBursa, long NumarSemestruBursa, long NumarSemestruCalculPunctaj, long ID_FC, long ID_FCForma, long ID_Domeniu, long ID_AnStudiu, long ID_Specializare)
        {
            return CBO.FillCollection<IntervalPunctajBursaInfo>(SqlHelper.ExecuteReader(_ConnectionString, "IntervalPunctajBursaListByTipBursaAnUnivFCFDAS", iD_TipBursa, ID_AnUniv, ID_AnUnivBursa, NumarSemestruBursa, NumarSemestruCalculPunctaj, ID_FC, ID_FCForma, ID_Domeniu, ID_AnStudiu, ID_Specializare));
        }

        public long IntervalPunctajBursaAddOrUpdate(IntervalPunctajBursaInfo objIntervalPunctajBursa)
        {
            return (long)SqlHelper.ExecuteScalar(_ConnectionString, "IntervalPunctajBursaAddOrUpdate", objIntervalPunctajBursa.ID_TipBursa, objIntervalPunctajBursa.ID_AnUniv, objIntervalPunctajBursa.ID_AnUnivBursa, objIntervalPunctajBursa.NumarSemestruBursa, objIntervalPunctajBursa.NumarSemestruCalculPunctaj, objIntervalPunctajBursa.ID_FC, objIntervalPunctajBursa.ID_FCForma, objIntervalPunctajBursa.ID_Domeniu, objIntervalPunctajBursa.ID_AnStudiu, objIntervalPunctajBursa.ID_Specializare, objIntervalPunctajBursa.ValoareMinPunctaj, objIntervalPunctajBursa.ValoareMaxPunctaj);
        }

        public void IntervalPunctajBursaDelete(IntervalPunctajBursaInfo objIntervalPunctajBursa)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "IntervalPunctajBursaDelete", objIntervalPunctajBursa.ID_IntervalPunctajBursa);
        }
    }
}
