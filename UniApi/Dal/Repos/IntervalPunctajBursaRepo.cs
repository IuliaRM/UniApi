using System;
using System.Configuration;
using System.Data;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IIntervalPunctajBursaRepo
    {
        IntervalPunctajBursaInfo IntervalPunctajBursaGet(long id);
        long IntervalPunctajBursaAddOrUpdate(IntervalPunctajBursaInfo info);
        void IntervalPunctajBursaDelete(IntervalPunctajBursaInfo info);
        DataTable IntervalPunctajBursaListByTipBursaAnUnivFCFDAS(long idTipBursa, long idAnUniv, long idAnUnivBursa, long nrSemBursa, long nrSemCalculPunctaj, long idFC, long idFCForma, long idDomeniu, long idAnStudiu, long idSpecializare);
    }

    public class IntervalPunctajBursaRepo : IIntervalPunctajBursaRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public IntervalPunctajBursaInfo IntervalPunctajBursaGet(long id)
        {
            try
            {
                return CBO.FillObject<IntervalPunctajBursaInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "IntervalPunctajBursa_Get", id));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la IntervalPunctajBursaGet", ex);
            }
        }

        public long IntervalPunctajBursaAddOrUpdate(IntervalPunctajBursaInfo info)
        {
            try
            {
                return (long)SqlHelper.ExecuteScalar(_connectionString, "IntervalPunctajBursa_AddOrUpdate", info);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la IntervalPunctajBursaAddOrUpdate", ex);
            }
        }

        public void IntervalPunctajBursaDelete(IntervalPunctajBursaInfo info)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "IntervalPunctajBursa_Delete", info);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la IntervalPunctajBursaDelete", ex);
            }
        }

        public DataTable IntervalPunctajBursaListByTipBursaAnUnivFCFDAS(long idTipBursa, long idAnUniv, long idAnUnivBursa, long nrSemBursa, long nrSemCalculPunctaj, long idFC, long idFCForma, long idDomeniu, long idAnStudiu, long idSpecializare)
        {
            try
            {
                return SqlHelper.ExecuteDataset(_connectionString, "IntervalPunctajBursa_GetListByTipBursaAnUnivFCFDAS",
                    idTipBursa, idAnUniv, idAnUnivBursa, nrSemBursa, nrSemCalculPunctaj, idFC, idFCForma, idDomeniu, idAnStudiu, idSpecializare).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la IntervalPunctajBursaListByTipBursaAnUnivFCFDAS", ex);
            }
        }
    }
}
