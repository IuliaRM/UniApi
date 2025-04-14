using System;
using System.Collections.Generic;
using System.Configuration;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;


namespace UniApi.DAL.Repos
{

    public interface ITipReducereRepo
    {
        TipReducereInfo TipReducereGet(long idTipReducere);
        List<TipReducereInfo> TipReducereList();
        List<TipReducereInfo> TipReducereListByTaxa(long idTaxa);
        List<TipReducereInfo> TipReducereListByTaxaStudent(long idTaxaStudent);
        int TipReducereAdd(TipReducereInfo tipReducereInfo);
        void TipReducereUpdate(TipReducereInfo tipReducereInfo);
        void TipReducereDelete(long idTipReducere);
    }

    public class TipReducereRepo : ITipReducereRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public TipReducereInfo TipReducereGet(long idTipReducere)
        {
            return CBO.FillObject<TipReducereInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipReducereGet", idTipReducere));
        }

        public List<TipReducereInfo> TipReducereList()
        {
            return CBO.FillCollection<TipReducereInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipReducereList"));
        }

        public List<TipReducereInfo> TipReducereListByTaxa(long idTaxa)
        {
            return CBO.FillCollection<TipReducereInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipReducereListByTaxa", idTaxa));
        }

        public List<TipReducereInfo> TipReducereListByTaxaStudent(long idTaxaStudent)
        {
            return CBO.FillCollection<TipReducereInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipReducereListByTaxaStudent", idTaxaStudent));
        }

        public int TipReducereAdd(TipReducereInfo tipReducereInfo)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "TipReducereAdd",
                tipReducereInfo.DenumireTipReducere,
                tipReducereInfo.ProcentStandardReducere,
                tipReducereInfo.ID_Taxe,
                tipReducereInfo.ID_TipTaxa);
            return Convert.ToInt32(id);
        }

        public void TipReducereUpdate(TipReducereInfo tipReducereInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TipReducereUpdate",
                tipReducereInfo.ID_TipReducere,
                tipReducereInfo.DenumireTipReducere,
                tipReducereInfo.ProcentStandardReducere,
                tipReducereInfo.ID_Taxe,
                tipReducereInfo.ID_TipTaxa);
        }

        public void TipReducereDelete(long idTipReducere)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TipReducereDelete", idTipReducere);
        }
    }
}
