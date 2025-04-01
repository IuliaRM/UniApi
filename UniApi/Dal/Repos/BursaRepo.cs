using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using UniApi;
using UniApi.Dal.Repos;
using UniApi.Info;


namespace UniApi.Dal.Repos
{
    public class BursaRepo
    {
        public BursaInfo BursaGet(long idBursa)
        {
            using (var dr = SqlHelper.ExecuteReader(
                ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString,
                "BursaGet",
                idBursa))
            {
                return CBO.FillObject<BursaInfo>(dr);
            }
        }

        public List<BursaInfo> BursaList()
        {
            using (var dr = SqlHelper.ExecuteReader(
                ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString,
                "BursaList"))
            {
                return CBO.FillCollection<BursaInfo>(dr);
            }
        }

        public List<BursaInfo> BursaListByStudent(long idStudent)
        {
            using (var dr = SqlHelper.ExecuteReader(
                ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString,
                "BursaListByStudent",
                idStudent))
            {
                return CBO.FillCollection<BursaInfo>(dr);
            }
        }

        public int BursaAddOrUpdate(BursaInfo bursa)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(
                ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString,
                "BursaAddOrUpdate",
                bursa.ID_TipBursa, // Updated from ID_Bursa
               // bursa.ID_Student, am eroare 
                bursa.ID_AnUnivBursa, // Updated from ID_AnUniv
                bursa.NumarSemestruBursa, // Updated from NumarSemestru
                bursa.BugetBursaDisponibil, // Updated from Valoare
                bursa.TipBursa // Updated from Tip
            ));
        }


        public void BursaDelete(long idBursa)
        {
            SqlHelper.ExecuteNonQuery(
                ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString,
                "BursaDelete",
                idBursa);
        }

        public void BursaDeleteByStudentAnSemestru(long idStudent, long idAnUniv, long numarSemestru)
        {
            SqlHelper.ExecuteNonQuery(
                ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString,
                "BursaDeleteByStudentAnSemestru",
                idStudent,
                idAnUniv,
                numarSemestru);
        }
    }
}
