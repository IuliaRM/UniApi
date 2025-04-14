using System;
using System.Collections.Generic;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;


namespace UniApi.DAL.Repos
{

    public interface ITrunchiRepo
    {
        TrunchiInfo TrunchiGet(long idTrunchi);
        List<TrunchiInfo> TrunchiList();
        List<TrunchiInfo> TrunchiListDistinctMin();
        long TrunchiAdd(TrunchiInfo trunchiInfo);
        void TrunchiUpdate(TrunchiInfo trunchiInfo);
        void TrunchiDelete(long idTrunchi);
    }

    public class TrunchiRepo : ITrunchiRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public TrunchiInfo TrunchiGet(long idTrunchi)
        {
            return CBO.FillObject<TrunchiInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TrunchiGet", idTrunchi));
        }

        public List<TrunchiInfo> TrunchiList()
        {
            return CBO.FillCollection<TrunchiInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TrunchiList"));
        }

        public List<TrunchiInfo> TrunchiListDistinctMin()
        {
            return CBO.FillCollection<TrunchiInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TrunchiListDinstinctMin"));
        }

        public long TrunchiAdd(TrunchiInfo trunchiInfo)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "TrunchiAdd",
                trunchiInfo.DenumireTrunchi,
                trunchiInfo.UserID_Coordonator);
            return Convert.ToInt64(id);
        }

        public void TrunchiUpdate(TrunchiInfo trunchiInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TrunchiUpdate",
                trunchiInfo.ID_Trunchi,
                trunchiInfo.DenumireTrunchi,
                trunchiInfo.UserID_Coordonator);
        }

        public void TrunchiDelete(long idTrunchi)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TrunchiDelete", idTrunchi);
        }
    }
}
