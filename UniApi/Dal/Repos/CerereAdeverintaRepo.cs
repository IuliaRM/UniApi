using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using System.Xml;
using System.Configuration;
using UniApi;
using UniApi.Dal.Repos;


namespace UniApi.Dal.Repos
{
    public class CerereAdeverintaRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public long CerereAdeverintaAdd(CerereAdeverintaInfo cerereAdevInfo)
        {
            object obj;
            if (cerereAdevInfo.ID_MotivCerereAdeverinta != 0)
            {
                obj = SqlHelper.ExecuteScalar(_connectionString, "CerereAdeverintaAdd", cerereAdevInfo.ID_Student, cerereAdevInfo.ID_AnUniv, cerereAdevInfo.ID_Grupe, cerereAdevInfo.ID_MotivCerereAdeverinta, cerereAdevInfo.ID_NumarInregistrare, cerereAdevInfo.ID_TipCerereAdeverinta, cerereAdevInfo.DescriereMotivStudent, cerereAdevInfo.DataCerere, cerereAdevInfo.Aprobat);
            }
            else
            {
                obj = SqlHelper.ExecuteScalar(_connectionString, "CerereAdeverintaAdd", cerereAdevInfo.ID_Student, cerereAdevInfo.ID_AnUniv, cerereAdevInfo.ID_Grupe, null, cerereAdevInfo.ID_NumarInregistrare, cerereAdevInfo.ID_TipCerereAdeverinta, cerereAdevInfo.DescriereMotivStudent, cerereAdevInfo.DataCerere, cerereAdevInfo.Aprobat);
            }
            return obj != null ? Convert.ToInt64(obj) : 0;
        }

        public List<CerereAdeverintaInfo> CerereAdeverintaList(List<long> ID_Student, long ID_AnUniv)
        {
            var listAdev = new List<CerereAdeverintaInfo>();

            foreach (long ID_Stud in ID_Student)
            {
                listAdev.AddRange(CBO.FillCollection<CerereAdeverintaInfo>(SqlHelper.ExecuteReader(_connectionString, "CerereAdeverintaList", ID_Stud, ID_AnUniv)));
            }

            return listAdev;
        }

        public List<MotivCerereAdevInfo> MotivCerereAdevList()
        {
            return CBO.FillCollection<MotivCerereAdevInfo>(SqlHelper.ExecuteReader(_connectionString, "MotivCerereAdevList"));
        }

    }
}
