using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;

using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public class DetaliiStudentRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public List<StudentDatePersonaleInfo> StudentListByIdAndAnUniv(List<long> listaID_Student, long idAnUniv)
        {
            var list = new List<StudentDatePersonaleInfo>();
            foreach (long idStudent in listaID_Student)
            {
                list.AddRange(CBO.FillCollection<StudentDatePersonaleInfo>(
                    SqlHelper.ExecuteReader(_ConnectionString, "StudentTaxeByAnUniversitar", idStudent, idAnUniv)));
            }
            return list;
        }

        public bool UsernameExistent(string username)
        {
            return Convert.ToBoolean(SqlHelper.ExecuteScalar(_ConnectionString, "UsernameTest", username));
        }

        public void StudentUserPassEmailAdd(long idStudent, string user, string pass, string email)
        {
            SqlHelper.ExecuteScalar(_ConnectionString, "StudentUsernameParolaEmailAdd", user, pass, email, idStudent);
        }

        public string StudentUsernameGetByCNP(string cnp)
        {
            object ret = SqlHelper.ExecuteScalar(_ConnectionString, "StudentUsernameGetByCNP", cnp);
            return ret?.ToString() ?? string.Empty;
        }

        public string StudentUsernameGetByNumePrenumeDataN(string nume, string prenume, DateTime data)
        {
            object ret = SqlHelper.ExecuteScalar(_ConnectionString, "StudentUsernameGetByNumePrenumeDataN", nume, prenume, data);
            return ret?.ToString() ?? string.Empty;
        }

        public string StudentParolaGetByUsername(string user)
        {
            object ret = SqlHelper.ExecuteScalar(_ConnectionString, "StudentParolaGetByUsername", user);
            return ret?.ToString() ?? string.Empty;
        }

        public void StudentParolaUpdateByUsername(string username)
        {
            SqlHelper.ExecuteScalar(_ConnectionString, "StudentPasswordUpdateByUsername", username);
        }
    }
}
