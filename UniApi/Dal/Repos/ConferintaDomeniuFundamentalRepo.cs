using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IConferintaDomeniuFundamentalRepo
    {
        long ConferintaDomeniuFundamentalAdd(ConferintaDomeniuFundamentalInfo info);
        void ConferintaDomeniuFundamentalUpdate(ConferintaDomeniuFundamentalInfo info);
        void ConferintaDomeniuFundamentalDelete(long id);
        ConferintaDomeniuFundamentalInfo ConferintaDomeniuFundamentalGet(long id);
        List<ConferintaDomeniuFundamentalInfo> ConferintaDomeniuFundamentalList();
        List<ConferintaDomeniuFundamentalInfo> ConferintaDomeniuFundamentalListByConferinta(long idConferinta);
        List<ConferintaDomeniuFundamentalInfo> ConferintaDomeniuFundamentalListByDomeniuFundamental(long idDomeniuFundamental);
        void ConferintaDomeniuFundamentalDeleteByConferintaDomeniu(long idConferinta, long idDomeniuFundamental);
    }

    public class ConferintaDomeniuFundamentalRepo : IConferintaDomeniuFundamentalRepo
    {
        private readonly string _connectionString;

        public ConferintaDomeniuFundamentalRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;
            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found.");
        }

        public long ConferintaDomeniuFundamentalAdd(ConferintaDomeniuFundamentalInfo info)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            try
            {
                return Convert.ToInt64(SqlHelper.ExecuteScalar(_connectionString, "ConferintaDomeniuFundamentalAdd",
                    info.ID_Conferinta,
                    info.ID_N_DomeniuFundamental));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la adaugarea domeniului fundamental conferinta.", ex);
            }
        }

        public void ConferintaDomeniuFundamentalUpdate(ConferintaDomeniuFundamentalInfo info)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "ConferintaDomeniuFundamentalUpdate",
                    info.ID_ConferintaDomeniuFundamental,
                    info.ID_Conferinta,
                    info.ID_N_DomeniuFundamental);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la actualizarea domeniului fundamental conferinta.", ex);
            }
        }

        public void ConferintaDomeniuFundamentalDelete(long id)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "ConferintaDomeniuFundamentalDelete", id);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la stergerea domeniului fundamental conferinta.", ex);
            }
        }

        public ConferintaDomeniuFundamentalInfo ConferintaDomeniuFundamentalGet(long id)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "ConferintaDomeniuFundamentalGet", id))
                {
                    return CBO.FillObject<ConferintaDomeniuFundamentalInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obtinerea domeniului fundamental conferinta.", ex);
            }
        }

        public List<ConferintaDomeniuFundamentalInfo> ConferintaDomeniuFundamentalList()
        {
            try
            {
                return CBO.FillCollection<ConferintaDomeniuFundamentalInfo>(SqlHelper.ExecuteReader(_connectionString, "ConferintaDomeniuFundamentalList"));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea domeniilor fundamentale conferinta.", ex);
            }
        }

        public List<ConferintaDomeniuFundamentalInfo> ConferintaDomeniuFundamentalListByConferinta(long idConferinta)
        {
            try
            {
                return CBO.FillCollection<ConferintaDomeniuFundamentalInfo>(SqlHelper.ExecuteReader(_connectionString, "ConferintaDomeniuFundamentalListByConferinta", idConferinta));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea domeniilor fundamentale dupa conferinta.", ex);
            }
        }

        public List<ConferintaDomeniuFundamentalInfo> ConferintaDomeniuFundamentalListByDomeniuFundamental(long idDomeniuFundamental)
        {
            try
            {
                return CBO.FillCollection<ConferintaDomeniuFundamentalInfo>(SqlHelper.ExecuteReader(_connectionString, "ConferintaDomeniuFundamentalListByDomeniuFundamental", idDomeniuFundamental));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea conferintelor dupa domeniul fundamental.", ex);
            }
        }

        public void ConferintaDomeniuFundamentalDeleteByConferintaDomeniu(long idConferinta, long idDomeniuFundamental)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "ConferintaDomeniuFundamentalDeleteByConferintaDomeniu", idConferinta, idDomeniuFundamental);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la stergerea domeniului fundamental dupa conferinta.", ex);
            }
        }
    }
}
