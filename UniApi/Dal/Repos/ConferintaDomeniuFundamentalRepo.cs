using System.Collections.Generic;
using System.Configuration;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Dal.Repos;
using UniApi.Info;


namespace UniApi.Dal.Repos
{
    public class ConferintaDomeniuFundamentalRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public ConferintaDomeniuFundamentalInfo ConferintaDomeniuFundamentalGet(long idConferintaDomeniuFundamental)
        {
            return CBO.FillObject<ConferintaDomeniuFundamentalInfo>(SqlHelper.ExecuteReader(_ConnectionString, "ConferintaDomeniuFundamentalGet", idConferintaDomeniuFundamental));
        }

        public List<ConferintaDomeniuFundamentalInfo> ConferintaDomeniuFundamentalList()
        {
            return CBO.FillCollection<ConferintaDomeniuFundamentalInfo>(SqlHelper.ExecuteReader(_ConnectionString, "ConferintaDomeniuFundamentalList"));
        }

        public List<ConferintaDomeniuFundamentalInfo> ConferintaDomeniuFundamentalListByConferinta(long idConferinta)
        {
            return CBO.FillCollection<ConferintaDomeniuFundamentalInfo>(SqlHelper.ExecuteReader(_ConnectionString, "ConferintaDomeniuFundamentalListByConferinta", idConferinta));
        }

        public List<ConferintaDomeniuFundamentalInfo> ConferintaDomeniuFundamentalListByDomeniuFundamental(long idDomeniuFundamental)
        {
            return CBO.FillCollection<ConferintaDomeniuFundamentalInfo>(SqlHelper.ExecuteReader(_ConnectionString, "ConferintaDomeniuFundamentalListByDomeniuFundamental", idDomeniuFundamental));
        }

        public long ConferintaDomeniuFundamentalAdd(ConferintaDomeniuFundamentalInfo objConferintaDomeniuFundamental)
        {
            object o = SqlHelper.ExecuteScalar(_ConnectionString, "ConferintaDomeniuFundamentalAdd", objConferintaDomeniuFundamental.ID_Conferinta, objConferintaDomeniuFundamental.ID_N_DomeniuFundamental);
            return System.Convert.ToInt64(o);
        }

        public void ConferintaDomeniuFundamentalUpdate(ConferintaDomeniuFundamentalInfo objConferintaDomeniuFundamental)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "ConferintaDomeniuFundamentalUpdate", objConferintaDomeniuFundamental.ID_ConferintaDomeniuFundamental, objConferintaDomeniuFundamental.ID_Conferinta, objConferintaDomeniuFundamental.ID_N_DomeniuFundamental);
        }

        public void ConferintaDomeniuFundamentalDelete(long idConferintaDomeniuFundamental)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "ConferintaDomeniuFundamentalDelete", idConferintaDomeniuFundamental);
        }

        public void ConferintaDomeniuFundamentalDeleteByConferintaDomeniu(long idConferinta, long idDomeniuFundamental)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "ConferintaDomeniuFundamentalDeleteByConferintaDomeniu", idConferinta, idDomeniuFundamental);
        }
    }
}
