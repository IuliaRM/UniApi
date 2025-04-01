using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class TipTaraRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public TipTaraInfo TipTaraGet(long idTipTara)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<TipTaraInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipTaraGet", idTipTara));
        }

        public TipTaraInfo TipTaraByID_N_TaraGet(long idNTipTara)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<TipTaraInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipTaraGetByID_N_Tara", idNTipTara));
        }

        public TipTaraInfo TipTaraByCodeGet(string codTara)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<TipTaraInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipTaraGetByCode", codTara));
        }

        public List<TipTaraInfo> TipTaraListGet()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<TipTaraInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipTaraList"));
        }

        public long TipTaraAdd(TipTaraInfo tipTaraInfo)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "TipTaraAdd",
                tipTaraInfo.DenumireTara, tipTaraInfo.cod_tara);
            return Convert.ToInt64(id);
        }

        public void TipTaraDelete(long idTipTara)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TipTaraDelete", idTipTara);
        }
    }
}
