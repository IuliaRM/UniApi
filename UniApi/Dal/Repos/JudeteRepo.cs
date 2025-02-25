using System;
using System.Collections.Generic;
using System.Configuration;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;

namespace UniApi.Dal.Repos
{
    public class JudeteRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public JudeteInfo JudeteGet(string iD_Judet)
        {
            return CBO.FillObject<JudeteInfo>(SqlHelper.ExecuteReader(_ConnectionString, "JudeteGet", iD_Judet));
        }

        public JudeteInfo JudeteGetByID_N_Judet(int iD_N_Judet)
        {
            return CBO.FillObject<JudeteInfo>(SqlHelper.ExecuteReader(_ConnectionString, "JudeteGetByID_N_Judet", iD_N_Judet));
        }

        public List<JudeteInfo> JudeteList()
        {
            return CBO.FillCollection<JudeteInfo>(SqlHelper.ExecuteReader(_ConnectionString, "JudeteList"));
        }

        public List<JudeteInfo> JudeteListByCaractere(string Caractere, int TopN)
        {
            return CBO.FillCollection<JudeteInfo>(SqlHelper.ExecuteReader(_ConnectionString, "JudeteListByCaractere", Caractere, TopN));
        }

        public int JudeteAdd(JudeteInfo objJudete)
        {
            return (int)SqlHelper.ExecuteScalar(_ConnectionString, "JudeteAdd", objJudete.Simbol, objJudete.Judet);
        }

        public void JudeteUpdate(JudeteInfo objJudete)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "JudeteUpdate", objJudete.ID_Judet, objJudete.Simbol, objJudete.Judet);
        }

        public void JudeteDelete(JudeteInfo objJudete)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "JudeteDelete", objJudete.ID_Judet);
        }

        public JudeteInfo JudeteGetJudetByDenumire(string denumireJudet)
        {
            return CBO.FillObject<JudeteInfo>(SqlHelper.ExecuteReader(_ConnectionString, "JudeteGetByDenumire", denumireJudet));
        }
    }
}
