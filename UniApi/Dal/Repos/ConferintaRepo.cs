using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IConferintaRepo
    {
        ConferintaInfo ConferintaGet(long idConferinta);
        List<ConferintaInfo> ConferintaList();
        List<ConferintaInfo> ConferintaListByAnCalendaristic(int anCalendaristic);
        List<ConferintaInfo> ConferintaListByFacultate(long idFacultate);
        List<ConferintaInfo> ConferintaListByTipConferinta(long idTipConferinta);
        long ConferintaAdd(ConferintaInfo info);
        void ConferintaUpdate(ConferintaInfo info);
        void ConferintaDelete(long idConferinta);
    }

    public class ConferintaRepo : IConferintaRepo
    {
        private readonly string _connectionString;

        public ConferintaRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;
            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found.");
        }

        public ConferintaInfo ConferintaGet(long idConferinta)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "ConferintaGet", idConferinta))
                {
                    return CBO.FillObject<ConferintaInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obtinerea conferinței.", ex);
            }
        }

        public List<ConferintaInfo> ConferintaList()
        {
            try
            {
                return CBO.FillCollection<ConferintaInfo>(SqlHelper.ExecuteReader(_connectionString, "ConferintaList"));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea conferințelor.", ex);
            }
        }

        public List<ConferintaInfo> ConferintaListByAnCalendaristic(int anCalendaristic)
        {
            try
            {
                return CBO.FillCollection<ConferintaInfo>(SqlHelper.ExecuteReader(_connectionString, "ConferintaListByAnCalendaristic", anCalendaristic));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea conferințelor după an calendaristic.", ex);
            }
        }

        public List<ConferintaInfo> ConferintaListByFacultate(long idFacultate)
        {
            try
            {
                return CBO.FillCollection<ConferintaInfo>(SqlHelper.ExecuteReader(_connectionString, "ConferintaListByFacultate", idFacultate));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea conferințelor după facultate.", ex);
            }
        }

        public List<ConferintaInfo> ConferintaListByTipConferinta(long idTipConferinta)
        {
            try
            {
                return CBO.FillCollection<ConferintaInfo>(SqlHelper.ExecuteReader(_connectionString, "ConferintaListByTipConferinta", idTipConferinta));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea conferințelor după tip conferință.", ex);
            }
        }

        public long ConferintaAdd(ConferintaInfo info)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            try
            {
                return Convert.ToInt64(SqlHelper.ExecuteScalar(_connectionString, "ConferintaAdd",
                    info.AnConferinta,
                    info.DenumireConferinta,
                    info.URLConferinta,
                    info.DataStartConferinta,
                    info.DataEndConferinta,
                    info.LocatieConferinta,
                    info.NumarParticipanti,
                    info.NumarLucrari,
                    info.ID_TipConferinta,
                    info.ID_FacultateOrganizatoare));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la adăugarea conferinței.", ex);
            }
        }

        public void ConferintaUpdate(ConferintaInfo info)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "ConferintaUpdate",
                    info.ID_Conferinta,
                    info.AnConferinta,
                    info.DenumireConferinta,
                    info.URLConferinta,
                    info.DataStartConferinta,
                    info.DataEndConferinta,
                    info.LocatieConferinta,
                    info.NumarParticipanti,
                    info.NumarLucrari,
                    info.ID_TipConferinta,
                    info.ID_FacultateOrganizatoare);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la actualizarea conferinței.", ex);
            }
        }

        public void ConferintaDelete(long idConferinta)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "ConferintaDelete", idConferinta);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la ștergerea conferinței.", ex);
            }
        }
    }
}
