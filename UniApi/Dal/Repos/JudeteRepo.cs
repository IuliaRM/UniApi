using System;
using System.Collections.Generic;
using UniApi.Info;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using DotNetNuke.Common.Utilities;

namespace UniApi.Dal.Repos
{
    public class JudeteRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public JudeteInfo JudeteGet(string ID_Judet)
        {
            return CBO.FillObject<JudeteInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "Judete_Get", ID_Judet));
        }

        public JudeteInfo JudeteByID_N_JudetGet(int ID_N_Judet)
        {
            return CBO.FillObject<JudeteInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "Judete_GetByID_N_Judet", ID_N_Judet));
        }

        public List<JudeteInfo> JudeteListGet()
        {
            return CBO.FillCollection<JudeteInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "Judete_GetList"));
        }

        public List<JudeteInfo> JudeteListByCaractereGet(string Caractere, int TopN)
        {
            return CBO.FillCollection<JudeteInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "Judete_GetListByCaractere", Caractere, TopN));
        }

        public int JudeteAdd(JudeteInfo objJudete)
        {
            return (int)SqlHelper.ExecuteScalar(_ConnectionString, "Judete_Add", objJudete);
        }

        public void JudeteUpdate(JudeteInfo objJudete)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "Judete_Update", objJudete);
        }

        public void JudeteDelete(JudeteInfo objJudete)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "Judete_Delete", objJudete);
        }

        public JudeteInfo JudeteByDenumireGet(string DenumireJudet)
        {
            return CBO.FillObject<JudeteInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "Judete_GetByDenumire", DenumireJudet));
        }
    }
}
