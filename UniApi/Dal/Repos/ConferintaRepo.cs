using System.Collections.Generic;
using System.Configuration;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Dal.Repos;


namespace UniApi.Dal.Repos
{
    public class ConferintaRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public ConferintaInfo ConferintaGet(long idConferinta)
        {
            return CBO.FillObject<ConferintaInfo>(SqlHelper.ExecuteReader(_ConnectionString, "ConferintaGet", idConferinta));
        }

        public List<ConferintaInfo> ConferintaList()
        {
            return CBO.FillCollection<ConferintaInfo>(SqlHelper.ExecuteReader(_ConnectionString, "ConferintaList"));
        }

        public List<ConferintaInfo> ConferintaListByAnCalendaristic(int anCalendaristic)
        {
            return CBO.FillCollection<ConferintaInfo>(SqlHelper.ExecuteReader(_ConnectionString, "ConferintaListByAnCalendaristic", anCalendaristic));
        }

        public List<ConferintaInfo> ConferintaListByTipConferinta(long idTipConferinta)
        {
            return CBO.FillCollection<ConferintaInfo>(SqlHelper.ExecuteReader(_ConnectionString, "ConferintaListByTipConferinta", idTipConferinta));
        }

        public long ConferintaAdd(ConferintaInfo objConferinta)
        {
            object o = SqlHelper.ExecuteScalar(_ConnectionString, "ConferintaAdd", objConferinta.AnConferinta, objConferinta.DenumireConferinta, objConferinta.URLConferinta, objConferinta.DataStartConferinta, objConferinta.DataEndConferinta, objConferinta.LocatieConferinta, objConferinta.NumarParticipanti, objConferinta.NumarLucrari, objConferinta.ID_TipConferinta, objConferinta.ID_FacultateOrganizatoare);
            return System.Convert.ToInt64(o);
        }

        public void ConferintaUpdate(ConferintaInfo objConferinta)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "ConferintaUpdate", objConferinta.ID_Conferinta, objConferinta.AnConferinta, objConferinta.DenumireConferinta, objConferinta.URLConferinta, objConferinta.DataStartConferinta, objConferinta.DataEndConferinta, objConferinta.LocatieConferinta, objConferinta.NumarParticipanti, objConferinta.NumarLucrari, objConferinta.ID_TipConferinta, objConferinta.ID_FacultateOrganizatoare);
        }

        public void ConferintaDelete(long idConferinta)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "ConferintaDelete", idConferinta);
        }
    }
}
