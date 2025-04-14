using System;
using System.Collections.Generic;
using System.Configuration;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;
using System.Data.SqlClient;
using UniApi.Info;
//using UniApi.Components;
using Microsoft.ApplicationBlocks.Data;

namespace UniApi.DAL.Repos
{
    public class StudentContRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public List<StudentDatePersonaleInfo> StudentListByIdAndAnUnivGet(List<long> listaID_Student, long ID_AnUniv)
        {
            var listTx = new List<StudentDatePersonaleInfo>[10];
            var list = new List<StudentDatePersonaleInfo>();
            int i = 0;
            try
            {
                foreach (long ID_Student in listaID_Student)
                {
                    if (ID_Student != 0)
                    {
                        SqlDataReader datar = SqlHelper.ExecuteReader(_connectionString, "StudentTaxeByAnUniversitar", ID_Student, ID_AnUniv);
                        listTx[i++] = CBO.FillCollection<StudentDatePersonaleInfo>(datar);
                    }
                }
            }
            catch (Exception e)
            {
                // Log the exception
            }

            for (i = 0; i < 10; i++)
            {
                if (listTx[i] != null)
                {
                    for (int j = 0; j < listTx[i].Count; j++)
                    {
                        list.Add(listTx[i][j]);
                    }
                }
            }
            return list;
        }

        public void StudentUserPassEmailAdd(long ID_Student, string user, string pass, string email)
        {
            SqlHelper.ExecuteScalar(_connectionString, "StudentUsernameParolaEmailAdd", user, pass, email, ID_Student);
        }

        public string StudentUsernameByCNPGet(string cnp)
        {
            object ret = SqlHelper.ExecuteScalar(_connectionString, "StudentUsernameGetByCNP", cnp);
            return ret != null ? ret.ToString() : "";
        }

        public List<StudentDatePersonaleInfo> StudentUsernameListByEmailGet(string Email)
        {
            var ret = CBO.FillCollection<StudentDatePersonaleInfo>(SqlHelper.ExecuteReader(_connectionString, "[StudentUsernameListByEmail]", Email));
            return ret;
        }

        public string StudentUsernameByID_StudentGet(long ID_Student)
        {
            object ret = SqlHelper.ExecuteScalar(_connectionString, "StudentUsernameGetByID_Student", ID_Student);
            return ret != null ? ret.ToString() : "";
        }

        public StudentDatePersonaleInfo StudentByFacultateCicluFormaDomeniuSpecializareNumeCNPGet(long ID_Facultate, long ID_FC, long ID_FCF, long ID_Domeniu, long ID_AnStudiu, long ID_Specializare, string Nume, string Prenume, string CNP)
        {
            return CBO.FillObject<StudentDatePersonaleInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentGetByFacultateCicluFormaDomeniuSpecializareNumeCNP", ID_Facultate, ID_FC, ID_FCF, ID_Domeniu, ID_AnStudiu, ID_Specializare, Nume, Prenume, CNP));
        }

        public void ModificaParolaInAGSIS(string username, string ParolaNoua)
        {
            SqlHelper.ExecuteScalar(_connectionString, "StudentUpdatePasswordByUsername", username, ParolaNoua);
        }

        public List<StudentDatePersonaleInfo> StudentListByAnUnivMaiMareDeAnGet(long ID_AnUniv, bool faraUsername)
        {
            var ret = CBO.FillCollection<StudentDatePersonaleInfo>(SqlHelper.ExecuteReader(_connectionString, "[StudentListByAnUnivMaiMareDeAn]", ID_AnUniv, faraUsername));
            return ret;
        }

        public List<StudentDatePersonaleInfo> StudentListByAnUnivLaMaiMulteFacultatiGet(long ID_AnUniv)
        {
            var ret = CBO.FillCollection<StudentDatePersonaleInfo>(SqlHelper.ExecuteReader(_connectionString, "[StudentListByAnUnivLaMaiMulteFacultati]", ID_AnUniv));
            return ret;
        }
    }
}