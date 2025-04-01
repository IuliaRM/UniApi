using System;
using System.Collections.Generic;
using UniApi.Info;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using DotNetNuke.Common.Utilities;

namespace UniApi.Dal.Repos
{
    public class IntervalChitantaRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public IntervalChitantaInfo IntervalChitantaGet(long ID_IntervalChitanta)
        {
            return CBO.FillObject<IntervalChitantaInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "IntervalChitanta_GetIntervalChitanta", ID_IntervalChitanta));
        }

        public IntervalChitantaInfo IntervalChitantaByUtilizatorGet(int ID_Utilizator)
        {
            return CBO.FillObject<IntervalChitantaInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "IntervalChitanta_GetIntervalChitantaByUtilizator", ID_Utilizator));
        }

        public IntervalChitantaInfo UltimulNumarDeChitantaGet(int ID_Utilizator)
        {
            return CBO.FillObject<IntervalChitantaInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "IntervalChitanta_GetUltimulNumarDeChitanta", ID_Utilizator));
        }

        public List<IntervalChitantaInfo> IntervalChitantaListGet()
        {
            return CBO.FillCollection<IntervalChitantaInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "IntervalChitanta_GetIntervalChitantaList"));
        }

        public List<IntervalChitantaInfo> IntervalChitantaListByUtilizatorGet(int ID_Utilizator)
        {
            return CBO.FillCollection<IntervalChitantaInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "IntervalChitanta_GetIntervalChitantaListByUtilizator", ID_Utilizator));
        }

        public long IntervalChitantaAdd(IntervalChitantaInfo objIntervalChitanta)
        {
            return (long)SqlHelper.ExecuteScalar(_ConnectionString, "IntervalChitanta_AddIntervalChitanta", objIntervalChitanta);
        }

        public void IntervalChitantaUpdate(IntervalChitantaInfo objIntervalChitanta)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "IntervalChitanta_UpdateIntervalChitanta", objIntervalChitanta);
        }

        public void IntervalChitantaDelete(IntervalChitantaInfo objIntervalChitanta)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "IntervalChitanta_DeleteIntervalChitanta", objIntervalChitanta);
        }

        public long SeteazaUrmatorulNumarDeChitanta(int ID_Utilizator)
        {
            return (long)SqlHelper.ExecuteScalar(_ConnectionString, "IntervalChitanta_SeteazaUrmatorulNumarDeChitanta", ID_Utilizator);
        }
    }
}
