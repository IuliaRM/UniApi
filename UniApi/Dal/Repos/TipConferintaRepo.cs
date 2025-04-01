using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class TipConferintaRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public TipConferintaInfo TipConferintaGet(long idTipConferinta)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<TipConferintaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipConferintaGet", idTipConferinta));
        }

        public List<TipConferintaInfo> TipConferintaListGet()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<TipConferintaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipConferintaList"));
        }

        public long TipConferintaAdd(string denumireTipConferinta)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "TipConferintaAdd", denumireTipConferinta);
            return Convert.ToInt64(id);
        }

        public void TipConferintaUpdate(long idTipConferinta, string denumireTipConferinta)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TipConferintaUpdate", idTipConferinta, denumireTipConferinta);
        }

        public void TipConferintaDelete(long idTipConferinta)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TipConferintaDelete", idTipConferinta);
        }
    }
}
