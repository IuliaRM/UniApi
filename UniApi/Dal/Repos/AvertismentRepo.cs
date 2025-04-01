using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Dal.Repos;
using UniApi.Info;


namespace UniApi.Dal.Repos
{
    public class AvertismentRepo
    {
        public AvertismentInfo AvertismentGet(long idAvertisment)
        {
            using (var dr = SqlHelper.ExecuteReader(
                ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString,
                "AvertismentGet",
                idAvertisment))
            {
                return CBO.FillObject<AvertismentInfo>(dr);
            }
        }

        public List<AvertismentInfo> AvertismentList()
        {
            using (var dr = SqlHelper.ExecuteReader(
                ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString,
                "AvertismentList"))
            {
                return CBO.FillCollection<AvertismentInfo>(dr);
            }
        }

        public List<AvertismentInfo> AvertismentListByCazare(long idCazare)
        {
            using (var dr = SqlHelper.ExecuteReader(
                ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString,
                "AvertismentListByCazare",
                idCazare))
            {
                return CBO.FillCollection<AvertismentInfo>(dr);
            }
        }

        public List<AvertismentInfo> AvertismentListByTipAvertisment(long idTipAvertisment)
        {
            using (var dr = SqlHelper.ExecuteReader(
                ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString,
                "AvertismentListByTipAvertisment",
                idTipAvertisment))
            {
                return CBO.FillCollection<AvertismentInfo>(dr);
            }
        }

        public int AvertismentAdd(AvertismentInfo avertisment)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(
                ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString,
                "AvertismentAdd",
                avertisment.ID_Cazare,
                avertisment.ID_TipAvertisment,
                avertisment.Motiv, // Updated from Descriere to Motiv
                avertisment.DataAvertisment, // Updated from Data to DataAvertisment
                avertisment.ID_AnUniv // Added missing field
            ));
        }

        public void AvertismentUpdate(AvertismentInfo avertisment)
        {
            SqlHelper.ExecuteNonQuery(
                ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString,
                "AvertismentUpdate",
                avertisment.ID_Avertisment,
                avertisment.ID_Cazare,
                avertisment.ID_TipAvertisment,
                avertisment.Motiv, // Updated from Descriere to Motiv
                avertisment.DataAvertisment, // Updated from Data to DataAvertisment
                avertisment.ID_AnUniv // Added missing field
            );
        }

        public void AvertismentDelete(long idAvertisment)
        {
            SqlHelper.ExecuteNonQuery(
                ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString,
                "AvertismentDelete",
                idAvertisment);
        }
    }
}
