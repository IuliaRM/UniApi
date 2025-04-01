using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class TipReducereRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public TipReducereInfo TipReducereGet(long idTipReducere)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<TipReducereInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipReducereGet", idTipReducere));
        }

        public List<TipReducereInfo> TipReducereListGet()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<TipReducereInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipReducereList"));
        }

        public List<TipReducereInfo> TipReducereListByTaxaGet(long idTaxa)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<TipReducereInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipReducereListByTaxa", idTaxa));
        }

        public List<TipReducereInfo> TipReducereListByTaxaStudentGet(long idTaxaStudent)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<TipReducereInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipReducereListByTaxaStudent", idTaxaStudent));
        }

        public int TipReducereAdd(TipReducereInfo tipReducereInfo)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(_connectionString, "TipReducereAdd",
                tipReducereInfo.DenumireTipReducere,
                tipReducereInfo.ProcentStandardReducere,
                tipReducereInfo.ID_Taxe,
                tipReducereInfo.ID_TipTaxa));
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

        public void TipReducereDelete(TipReducereInfo tipReducereInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TipReducereDelete",
                tipReducereInfo.ID_TipReducere);
        }
    }
}
