using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public interface ITipNotaRepo
    {
        TipNotaInfo TipNotaGet(int idTipNota);
        List<TipNotaInfo> TipNotaList();
        int TipNotaAdd(TipNotaInfo tipNota);
        void TipNotaUpdate(TipNotaInfo tipNota);
        void TipNotaDelete(int idTipNota);
    }

    public class TipNotaRepo : ITipNotaRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public TipNotaInfo TipNotaGet(int idTipNota)
        {
            return CBO.FillObject<TipNotaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipNotaGet", idTipNota));
        }

        public List<TipNotaInfo> TipNotaList()
        {
            return CBO.FillCollection<TipNotaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipNotaList"));
        }

        public int TipNotaAdd(TipNotaInfo tipNota)
        {
            object result = SqlHelper.ExecuteScalar(
                _connectionString,
                "TipNotaAdd",
                tipNota.Nota,
                tipNota.Promovat);
            return result != null ? (int)result : -1; // Sau o altă valoare implicită pentru eroare
        }

        public void TipNotaUpdate(TipNotaInfo tipNota)
        {
            SqlHelper.ExecuteNonQuery(
                _connectionString,
                "TipNotaUpdate",
                tipNota.ID_TipNota,
                tipNota.Nota,
                tipNota.Promovat);
        }

        public void TipNotaDelete(int idTipNota)
        {
            SqlHelper.ExecuteNonQuery(
                _connectionString,
                "TipNotaDelete",
                idTipNota);
        }
    }
}
