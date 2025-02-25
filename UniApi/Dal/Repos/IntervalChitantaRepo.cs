using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using DotNetNuke.Common.Utilities;

namespace UniApi.Dal.Repos
{
    public class IntervalChitantaRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public IntervalChitantaInfo GetIntervalChitanta(long iD_IntervalChitanta)
        {
            return CBO.FillObject<IntervalChitantaInfo>(SqlHelper.ExecuteReader(_ConnectionString, "IntervalChitantaGet", iD_IntervalChitanta));
        }

        public IntervalChitantaInfo GetIntervalChitantaByUtilizator(int ID_Utilizator)
        {
            return CBO.FillObject<IntervalChitantaInfo>(SqlHelper.ExecuteReader(_ConnectionString, "IntervalChitantaGetIntervalActiv", ID_Utilizator));
        }

        public IntervalChitantaInfo GetUltimulNumarDeChitanta(int ID_Utilizator)
        {
            return CBO.FillObject<IntervalChitantaInfo>(SqlHelper.ExecuteReader(_ConnectionString, "IntervalChitantaGetUltimulNumarDeChitanta", ID_Utilizator));
        }

        public List<IntervalChitantaInfo> GetIntervalChitantaList()
        {
            return CBO.FillCollection<IntervalChitantaInfo>(SqlHelper.ExecuteReader(_ConnectionString, "IntervalChitantaList"));
        }

        public List<IntervalChitantaInfo> GetIntervalChitantaListByUtilizator(int ID_Utilizator)
        {
            return CBO.FillCollection<IntervalChitantaInfo>(SqlHelper.ExecuteReader(_ConnectionString, "IntervalChitantaListByID_Utilizator", ID_Utilizator));
        }

        public long AddIntervalChitanta(IntervalChitantaInfo objIntervalChitanta)
        {
            object o = SqlHelper.ExecuteScalar(_ConnectionString, "IntervalChitantaAdd", objIntervalChitanta.NrInitialInterval, objIntervalChitanta.NrFinalInterval, objIntervalChitanta.ID_UtilizatorAsociat, objIntervalChitanta.UltimulNrChitantaID_Utilizator, objIntervalChitanta.UltimaDataChitantaID_Utilizator, objIntervalChitanta.NrChitantaDeFolosit, objIntervalChitanta.ID_Utilizator, objIntervalChitanta.DataModificare, objIntervalChitanta.Status, objIntervalChitanta.Activ, objIntervalChitanta.Ordine);
            return Convert.ToInt64(o);
        }

        public void UpdateIntervalChitanta(IntervalChitantaInfo objIntervalChitanta)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "IntervalChitantaUpdate", objIntervalChitanta.ID_IntervalChitanta, objIntervalChitanta.NrInitialInterval, objIntervalChitanta.NrFinalInterval, objIntervalChitanta.ID_UtilizatorAsociat, objIntervalChitanta.UltimulNrChitantaID_Utilizator, objIntervalChitanta.UltimaDataChitantaID_Utilizator, objIntervalChitanta.NrChitantaDeFolosit, objIntervalChitanta.ID_Utilizator, objIntervalChitanta.DataModificare, objIntervalChitanta.Status, objIntervalChitanta.Activ, objIntervalChitanta.Ordine);
        }

        public void DeleteIntervalChitanta(IntervalChitantaInfo objIntervalChitanta)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "IntervalChitantaDelete", objIntervalChitanta.ID_IntervalChitanta);
        }

        public long SeteazaUrmatorulNumarDeChitanta(int ID_Utilizator)
        {
            object o = SqlHelper.ExecuteScalar(_ConnectionString, "IntervalChitantaSeteazaUrmatorulNumarDeChitanta", ID_Utilizator);
            return Convert.ToInt64(o);
        }
    }
}
