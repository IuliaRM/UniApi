using System;
using System.Collections.Generic;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.DAL.Repos
{

    public interface ITipTaraRepo
    {
        TipTaraInfo TipTaraGet(long idTipTara);
        TipTaraInfo TipTaraGetById_N_Tara(long idNTipTara);
        TipTaraInfo TipTaraGetByCode(string codTara);
        List<TipTaraInfo> TipTaraList();
    }

    public class TipTaraRepo : ITipTaraRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public TipTaraInfo TipTaraGet(long idTipTara)
        {
            return CBO.FillObject<TipTaraInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipTaraGet", idTipTara));
        }

        public TipTaraInfo TipTaraGetById_N_Tara(long idNTipTara)
        {
            return CBO.FillObject<TipTaraInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipTaraGetById_N_Tara", idNTipTara));
        }

        public TipTaraInfo TipTaraGetByCode(string codTara)
        {
            return CBO.FillObject<TipTaraInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipTaraGetByCode", codTara));
        }

        public List<TipTaraInfo> TipTaraList()
        {
            return CBO.FillCollection<TipTaraInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipTaraList"));
        }
    }
}
