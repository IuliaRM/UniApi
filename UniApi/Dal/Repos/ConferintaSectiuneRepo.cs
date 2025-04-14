using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IConferintaSectiuneRepo
    {
        ConferintaSectiuneInfo ConferintaSectiuneGet(long idConferintaSectiune);
        List<ConferintaSectiuneInfo> ConferintaSectiuneList();
        List<ConferintaSectiuneInfo> ConferintaSectiuneListByConferinta(long idConferinta);
        long ConferintaSectiuneAdd(ConferintaSectiuneInfo info);
        void ConferintaSectiuneUpdate(ConferintaSectiuneInfo info);
        void ConferintaSectiuneDelete(long idConferintaSectiune);
    }

    public class ConferintaSectiuneRepo : IConferintaSectiuneRepo
    {
        private readonly string _connectionString;

        public ConferintaSectiuneRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;
            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found.");
        }

        public ConferintaSectiuneInfo ConferintaSectiuneGet(long idConferintaSectiune)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "ConferintaSectiuneGet", idConferintaSectiune))
                {
                    return CBO.FillObject<ConferintaSectiuneInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obținerea secțiunii conferinței.", ex);
            }
        }

        public List<ConferintaSectiuneInfo> ConferintaSectiuneList()
        {
            try
            {
                return CBO.FillCollection<ConferintaSectiuneInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "ConferintaSectiuneList"));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea secțiunilor conferinței.", ex);
            }
        }

        public List<ConferintaSectiuneInfo> ConferintaSectiuneListByConferinta(long idConferinta)
        {
            try
            {
                return CBO.FillCollection<ConferintaSectiuneInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "ConferintaSectiuneListByConferinta", idConferinta));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea secțiunilor după conferință.", ex);
            }
        }

        public long ConferintaSectiuneAdd(ConferintaSectiuneInfo info)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            try
            {
                return Convert.ToInt64(SqlHelper.ExecuteScalar(_connectionString, "ConferintaSectiuneAdd",
                    info.ID_Conferinta,
                    info.DenumireSectiuneConferinta,
                    info.NumarParticipantiSectiune,
                    info.NumarLucrariSectiune));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la adăugarea secțiunii conferinței.", ex);
            }
        }

        public void ConferintaSectiuneUpdate(ConferintaSectiuneInfo info)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "ConferintaSectiuneUpdate",
                    info.ID_ConferintaSectiune,
                    info.ID_Conferinta,
                    info.DenumireSectiuneConferinta,
                    info.NumarParticipantiSectiune,
                    info.NumarLucrariSectiune);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la actualizarea secțiunii conferinței.", ex);
            }
        }

        public void ConferintaSectiuneDelete(long idConferintaSectiune)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "ConferintaSectiuneDelete", idConferintaSectiune);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la ștergerea secțiunii conferinței.", ex);
            }
        }
    }
}
