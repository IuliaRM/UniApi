using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Dal.Repos;


namespace UniApi.Dal.Repos
    public class AbsolvireProgramProbaRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public AbsolvireProgramProbaInfo GetAbsolvireProgramProba(long idAbsolvireProgramProba)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<AbsolvireProgramProbaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "AbsolvireProgramProbaGet", idAbsolvireProgramProba));
        }

        public List<AbsolvireProgramProbaInfo> GetAbsolvireProgramProbaList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<AbsolvireProgramProbaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "AbsolvireProgramProbaList"));
        }

        public List<AbsolvireProgramProbaInfo> GetAbsolvireProgramProbaListByPachetAbsolvire(long idPachetAbsolvire)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<AbsolvireProgramProbaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "AbsolvireProgramProbaListByPachetAbsolvire", idPachetAbsolvire));
        }

        public long AddAbsolvireProgramProba(AbsolvireProgramProbaInfo probaInfo)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "AbsolvireProgramProbaAdd",
                probaInfo.ID_AbsolvireProgram,
                probaInfo.DenumireProba,
                probaInfo.NrCrediteProba,
                probaInfo.NotaMinimaPromovare,
                probaInfo.ID_PachetAbsolvire,
                probaInfo.DenumireSesiuneAbsolvire);

            return Convert.ToInt64(id);
        }

        public void UpdateAbsolvireProgramProba(AbsolvireProgramProbaInfo probaInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireProgramProbaUpdate",
                probaInfo.ID_AbsolvireProgramProba,
                probaInfo.ID_AbsolvireProgram,
                probaInfo.DenumireProba,
                probaInfo.NrCrediteProba,
                probaInfo.NotaMinimaPromovare,
                probaInfo.ID_PachetAbsolvire,
                probaInfo.DenumireSesiuneAbsolvire);
        }

        public void DeleteAbsolvireProgramProba(long idAbsolvireProgramProba)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireProgramProbaDelete", idAbsolvireProgramProba);
        }
    }
}