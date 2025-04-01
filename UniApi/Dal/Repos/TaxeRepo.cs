using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;
//using UniApi.Components;

namespace UniApi.DAL.Repos
{
    public class TaxeRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString + ";Application Name=TaxeRepo;";

        public int TaxeInsert(TaxeInfo tax)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var cmdWork = new SqlCommand { Connection = conn };
                conn.Open();

                cmdWork.CommandText = "Taxe_Add";
                cmdWork.CommandType = CommandType.StoredProcedure;

                cmdWork.Parameters.Clear();
                var idTax = new SqlParameter("@ID_Taxe", SqlDbType.BigInt) { Direction = ParameterDirection.Output };
                cmdWork.Parameters.Add(idTax);

                cmdWork.Parameters.Add("@ID_Tip", SqlDbType.BigInt).Value = tax.Tip;
                cmdWork.Parameters.Add("@ID_Facultate", SqlDbType.BigInt).Value = tax.ID_Facultate;
                cmdWork.Parameters.Add("@ID_TipCiclu", SqlDbType.BigInt).Value = tax.ID_TipCiclu;
                cmdWork.Parameters.Add("@ID_TipFormaInv", SqlDbType.BigInt).Value = tax.ID_TipFormaInv;
                cmdWork.Parameters.Add("@ID_AnUniv", SqlDbType.BigInt).Value = tax.ID_AnUniv;
                cmdWork.Parameters.Add("@ID_Utilizator", SqlDbType.BigInt).Value = tax.ID_Utilizator;
                cmdWork.Parameters.Add("@DataModificare", SqlDbType.DateTime).Value = DateTime.Now;
                cmdWork.Parameters.Add("@Status", SqlDbType.Int).Value = tax.Status;
                cmdWork.Parameters.Add("@PortalId", SqlDbType.Int).Value = tax.PortalId;
                cmdWork.Parameters.Add("@ID_Camin", SqlDbType.BigInt).Value = tax.ID_Camin;

                cmdWork.ExecuteNonQuery();
                return Convert.ToInt32(idTax.Value);
            }
        }

        public void TaxeUpdate(TaxeInfo tax)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var cmdWork = new SqlCommand { Connection = conn };
                conn.Open();

                cmdWork.CommandText = "Taxe_Update";
                cmdWork.CommandType = CommandType.StoredProcedure;

                cmdWork.Parameters.Clear();
                cmdWork.Parameters.Add("@ID_Taxe", SqlDbType.BigInt).Value = tax.ID;
                cmdWork.Parameters.Add("@ID_Facultate", SqlDbType.BigInt).Value = tax.ID_Facultate;
                cmdWork.Parameters.Add("@ID_Tip", SqlDbType.BigInt).Value = tax.Tip;
                cmdWork.Parameters.Add("@ID_TipCiclu", SqlDbType.BigInt).Value = tax.ID_TipCiclu;
                cmdWork.Parameters.Add("@ID_TipFormaInv", SqlDbType.BigInt).Value = tax.ID_TipFormaInv;
                cmdWork.Parameters.Add("@ID_AnUniv", SqlDbType.BigInt).Value = tax.ID_AnUniv;
                cmdWork.Parameters.Add("@ID_Utilizator", SqlDbType.BigInt).Value = tax.ID_Utilizator;
                cmdWork.Parameters.Add("@DataModificare", SqlDbType.DateTime).Value = DateTime.Now;
                cmdWork.Parameters.Add("@Status", SqlDbType.Int).Value = tax.Status;
                cmdWork.Parameters.Add("@PortalId", SqlDbType.Int).Value = tax.PortalId;
                cmdWork.Parameters.Add("@ID_Camin", SqlDbType.BigInt).Value = tax.ID_Camin;

                cmdWork.ExecuteNonQuery();
            }
        }

        public TaxeInfo TaxaGet(long id)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var cmdWork = new SqlCommand { Connection = conn };
                conn.Open();

                cmdWork.CommandText = "Taxe_Get";
                cmdWork.CommandType = CommandType.StoredProcedure;
                cmdWork.Parameters.Clear();
                cmdWork.Parameters.Add("@ID_Taxe", SqlDbType.BigInt).Value = id;

                var r = cmdWork.ExecuteReader();
                var tax = new TaxeInfo();

                if (r != null && r.Read())
                {
                    tax.ID = id;
                    tax.ID_Facultate = (long)r["ID_Facultate"];
                    tax.Tip = (long)r["ID_Tip"];
                    tax.ID_Utilizator = (long)r["ID_Utilizator"];
                    tax.DataModificare = (DateTime)r["DataModificare"];
                    tax.Status = Convert.ToInt32(r["Status"]);
                    tax.ID_Camin = Convert.ToInt64(r["ID_Camin"]);
                    tax.ID_AnUniv = r["ID_AnUniv"] == DBNull.Value ? -1 : Convert.ToInt64(r["ID_AnUniv"]);
                    tax.ID_TipCiclu = r["ID_TipCiclu"] == DBNull.Value ? -1 : Convert.ToInt64(r["ID_TipCiclu"]);
                    tax.ID_TipFormaInv = r["ID_TipFormaInv"] == DBNull.Value ? -1 : Convert.ToInt64(r["ID_TipFormaInv"]);
                }

                return tax;
            }
        }

        public List<TaxaStudentInfo> TaxeStudentListGet(List<long> listID_Student, long idAnUniv)
        {
            var listTaxe = new List<TaxaStudentInfo>();
            foreach (var ID_Student in listID_Student)
            {
                if (ID_Student > 0)
                {
                    listTaxe.AddRange(CBO.FillCollection<TaxaStudentInfo>(SqlHelper.ExecuteReader(_connectionString, "TaxeStudentListByAnUniversitar", ID_Student, idAnUniv)));
                }
            }
            return listTaxe;
        }

        public List<TaxaStudentInfo> RateTaxeStudentGet(long ID_Student, long ID_AnUniv, bool NumaiTaxeleCuRestDePlata, bool TaxeleDinTotiAnii)
        {
            if (TaxeleDinTotiAnii) ID_AnUniv = -1;
            return CBO.FillCollection<TaxaStudentInfo>(SqlHelper.ExecuteReader(_connectionString, "RateStudent2CuDataPlata", ID_Student, ID_AnUniv, NumaiTaxeleCuRestDePlata));
        }
    }
}
