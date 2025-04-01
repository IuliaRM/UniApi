using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public class AbsolvireProgramProbaRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public AbsolvireProgramProbaInfo AbsolvireProgramProbaGet(long idAbsolvireProgramProba)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<AbsolvireProgramProbaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "AbsolvireProgramProbaGet", idAbsolvireProgramProba));
        }

        public List<AbsolvireProgramProbaInfo> AbsolvireProgramProbaList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<AbsolvireProgramProbaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "AbsolvireProgramProbaList"));
        }

        public List<AbsolvireProgramProbaInfo> AbsolvireProgramProbaListByPachetAbsolvire(long idPachetAbsolvire)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<AbsolvireProgramProbaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "AbsolvireProgramProbaListByPachetAbsolvire", idPachetAbsolvire));
        }

        public long AbsolvireProgramProbaAdd(AbsolvireProgramProbaInfo probaInfo)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "AbsolvireProgramProbaAdd",
                probaInfo.ID_AbsolvireProgramProba,
                probaInfo.ID_AbsolvireProgram,
                probaInfo.DenumireProba,
                probaInfo.NrCrediteProba,
                probaInfo.NotaMinimaPromovare,
                probaInfo.ID_PachetAbsolvire,
                probaInfo.DenumireSesiuneAbsolvire);

            return Convert.ToInt64(id);
        }

        public void AbsolvireProgramProbaUpdate(AbsolvireProgramProbaInfo probaInfo)
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

        public void AbsolvireProgramProbaDelete(long idAbsolvireProgramProba)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireProgramProbaDelete", idAbsolvireProgramProba);
        }
    }
}
