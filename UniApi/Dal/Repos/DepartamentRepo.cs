using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public class DepartamentRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public DepartamentInfo DepartamentGet(long idDepartament)
        {
            return CBO.FillObject<DepartamentInfo>(SqlHelper.ExecuteReader(_ConnectionString, "DepartamentGet", idDepartament));
        }

        public List<DepartamentInfo> DepartamentList()
        {
            return CBO.FillCollection<DepartamentInfo>(SqlHelper.ExecuteReader(_ConnectionString, "DepartamentList"));
        }

        public int DepartamentAdd(DepartamentInfo objDepartament)
        {
            object obj = SqlHelper.ExecuteScalar(_ConnectionString, "DepartamentAdd",
                objDepartament.DenumireDepartament, objDepartament.DenumireScurtaDepartament);
            return Convert.ToInt32(obj);
        }

        public void DepartamentUpdate(DepartamentInfo objDepartament)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "DepartamentUpdate",
                objDepartament.ID_Departament, objDepartament.DenumireDepartament,
                objDepartament.DenumireScurtaDepartament);
        }

        public void DepartamentDelete(long idDepartament)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "DepartamentDelete", idDepartament);
        }
    }
}
