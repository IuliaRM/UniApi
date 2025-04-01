using System;
using System.Collections.Generic;
using System.Configuration;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class ValoareTipBursaFacultateRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public long AddValoareTipBursaFacultate(ValoareTipBursaFacultateInfo valoareTipBursa)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "ValoareTipBursaFacultateAdd",
                valoareTipBursa.ID_Facultate,
                valoareTipBursa.ID_TipBursa,
                valoareTipBursa.NumarLuna,
                valoareTipBursa.ValoareTipBursa,
                valoareTipBursa.ID_AnUnivBursa);

            return Convert.ToInt64(id);
        }

        public void UpdateValoareTipBursaFacultate(ValoareTipBursaFacultateInfo valoareTipBursa)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ValoareTipBursaFacultateUpdate",
                valoareTipBursa.ID_ValoareTipBursaFacultate,
                valoareTipBursa.ID_Facultate,
                valoareTipBursa.ID_TipBursa,
                valoareTipBursa.NumarLuna,
                valoareTipBursa.ValoareTipBursa,
                valoareTipBursa.ID_AnUnivBursa);
        }

        public void DeleteValoareTipBursaFacultate(long id)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ValoareTipBursaFacultateDelete", id);
        }

        public ValoareTipBursaFacultateInfo GetValoareTipBursaFacultate(long id)
        {
            return CBO.FillObject<ValoareTipBursaFacultateInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ValoareTipBursaFacultateGet", id));
        }

        public List<ValoareTipBursaFacultateInfo> GetValoareTipBursaFacultateList()
        {
            return CBO.FillCollection<ValoareTipBursaFacultateInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ValoareTipBursaFacultateList"));
        }

        public List<ValoareTipBursaFacultateInfo> GetValoareTipBursaFacultateByTipBursa(long idTipBursa)
        {
            return CBO.FillCollection<ValoareTipBursaFacultateInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ValoareTipBursaFacultateListByTipBursa", idTipBursa));
        }

        public List<ValoareTipBursaFacultateInfo> GetValoareTipBursaFacultateByLuna(int numarLuna)
        {
            return CBO.FillCollection<ValoareTipBursaFacultateInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ValoareTipBursaFacultateListByLuna", numarLuna));
        }

        public List<ValoareTipBursaFacultateInfo> GetValoareTipBursaFacultateByFacultate(long idFacultate)
        {
            return CBO.FillCollection<ValoareTipBursaFacultateInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ValoareTipBursaFacultateListByFacultate", idFacultate));
        }
    }
}
