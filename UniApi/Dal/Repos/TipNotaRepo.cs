using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class TipNotaRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public TipNotaInfo TipNotaGet(int idTipNota)
        {
            return CBO.FillObject<TipNotaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipNotaGet", idTipNota));
        }

        public List<TipNotaInfo> TipNotaListGet()
        {
            return CBO.FillCollection<TipNotaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipNotaList"));
        }

        public int TipNotaAdd(TipNotaInfo tipNota)
        {
            return (int)SqlHelper.ExecuteScalar(
                _connectionString,
                "TipNotaAdd",
                tipNota.Nota,
                tipNota.Promovat);
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
