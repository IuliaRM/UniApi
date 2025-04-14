using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public interface ITipLimbaRepo
    {
        TipLimbaInfo TipLimbaGet(long idTipLimba);
        List<TipLimbaInfo> TipLimbaListGet();
        int TipLimbaAdd(TipLimbaInfo tipLimbaInfo);
        void TipLimbaUpdate(TipLimbaInfo tipLimbaInfo);
        void TipLimbaDelete(long idTipLimba);
    }

    public class TipLimbaRepo : ITipLimbaRepo
    {
        private readonly string _connectionString;

        public TipLimbaRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;

            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found in configuration.");
            }
        }

        public TipLimbaInfo TipLimbaGet(long idTipLimba)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "TipLimbaGet", idTipLimba))
                {
                    return CBO.FillObject<TipLimbaInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                // Log error here
                throw new DataException("Error retrieving TipLimba", ex);
            }
        }

        public List<TipLimbaInfo> TipLimbaListGet()
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "TipLimbaList"))
                {
                    return CBO.FillCollection<TipLimbaInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                // Log error here
                throw new DataException("Error retrieving TipLimba list", ex);
            }
        }

        public int TipLimbaAdd(TipLimbaInfo tipLimbaInfo)
        {
            if (tipLimbaInfo == null)
                throw new ArgumentNullException(nameof(tipLimbaInfo));

            try
            {
                var result = SqlHelper.ExecuteScalar(_connectionString, "TipLimbaAdd",
                    tipLimbaInfo.Denumire,
                    tipLimbaInfo.ID_Utilizator,
                    tipLimbaInfo.DataModificare,
                    tipLimbaInfo.Status);

                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                // Log error here
                throw new DataException("Error adding TipLimba", ex);
            }
        }

        public void TipLimbaUpdate(TipLimbaInfo tipLimbaInfo)
        {
            if (tipLimbaInfo == null)
                throw new ArgumentNullException(nameof(tipLimbaInfo));

            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "TipLimbaUpdate",
                    tipLimbaInfo.ID_TipLimba,
                    tipLimbaInfo.Denumire,
                    tipLimbaInfo.ID_Utilizator,
                    tipLimbaInfo.DataModificare,
                    tipLimbaInfo.Status);
            }
            catch (Exception ex)
            {
                // Log error here
                throw new DataException("Error updating TipLimba", ex);
            }
        }

        public void TipLimbaDelete(long idTipLimba)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "TipLimbaDelete", idTipLimba);
            }
            catch (Exception ex)
            {
                // Log error here
                throw new DataException("Error deleting TipLimba", ex);
            }
        }
    }
}