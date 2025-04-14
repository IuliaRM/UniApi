using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IAbsolvireProgramProbaRepo
    {
        AbsolvireProgramProbaInfo AbsolvireProgramProbaGet(long idAbsolvireProgramProba);
        List<AbsolvireProgramProbaInfo> AbsolvireProgramProbaList();
        List<AbsolvireProgramProbaInfo> AbsolvireProgramProbaListByPachetAbsolvire(long idPachetAbsolvire);
        List<AbsolvireProgramProbaInfo> AbsolvireProgramProbaListByPacheteAbsolvireSesiuneAbsolvire(long idPachetAbsolvire, long idSesiune);
        long AbsolvireProgramProbaAdd(AbsolvireProgramProbaInfo probaInfo);
        void AbsolvireProgramProbaUpdate(AbsolvireProgramProbaInfo probaInfo);
        void AbsolvireProgramProbaDelete(long idAbsolvireProgramProba);
    }

    public class AbsolvireProgramProbaRepo : IAbsolvireProgramProbaRepo
    {
        private readonly string _connectionString;

        public AbsolvireProgramProbaRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;

            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found in configuration.");
            }
        }

        public AbsolvireProgramProbaInfo AbsolvireProgramProbaGet(long idAbsolvireProgramProba)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "AbsolvireProgramProbaGet", idAbsolvireProgramProba))
                {
                    return CBO.FillObject<AbsolvireProgramProbaInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving AbsolvireProgramProba", ex);
            }
        }

        public List<AbsolvireProgramProbaInfo> AbsolvireProgramProbaList()
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "AbsolvireProgramProbaList"))
                {
                    return CBO.FillCollection<AbsolvireProgramProbaInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving AbsolvireProgramProba list", ex);
            }
        }

        public List<AbsolvireProgramProbaInfo> AbsolvireProgramProbaListByPachetAbsolvire(long idPachetAbsolvire)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "AbsolvireProgramProbaListByPachetAbsolvire", idPachetAbsolvire))
                {
                    return CBO.FillCollection<AbsolvireProgramProbaInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving AbsolvireProgramProba by PachetAbsolvire", ex);
            }
        }

        public List<AbsolvireProgramProbaInfo> AbsolvireProgramProbaListByPacheteAbsolvireSesiuneAbsolvire(long idPachetAbsolvire, long idSesiune)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "AbsolvireProgramProbaListByPacheteAbsolvireSesiuneAbsolvire", idPachetAbsolvire, idSesiune))
                {
                    return CBO.FillCollection<AbsolvireProgramProbaInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving AbsolvireProgramProba by PachetAbsolvire and SesiuneAbsolvire", ex);
            }
        }

        public long AbsolvireProgramProbaAdd(AbsolvireProgramProbaInfo probaInfo)
        {
            if (probaInfo == null)
                throw new ArgumentNullException(nameof(probaInfo));

            try
            {
                var id = SqlHelper.ExecuteScalar(_connectionString, "AbsolvireProgramProbaAdd",
                    probaInfo.ID_AbsolvireProgramProba,
                    probaInfo.ID_AbsolvireProgram,
                    probaInfo.DenumireProba,
                    probaInfo.NrCrediteProba,
                    probaInfo.NotaMinimaPromovare,
                    probaInfo.ID_PachetAbsolvire,
                    probaInfo.DenumireSesiuneAbsolvire);

                return Convert.ToInt64(id);
            }
            catch (Exception ex)
            {
                throw new DataException("Error adding AbsolvireProgramProba", ex);
            }
        }

        public void AbsolvireProgramProbaUpdate(AbsolvireProgramProbaInfo probaInfo)
        {
            if (probaInfo == null)
                throw new ArgumentNullException(nameof(probaInfo));

            try
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
            catch (Exception ex)
            {
                throw new DataException("Error updating AbsolvireProgramProba", ex);
            }
        }

        public void AbsolvireProgramProbaDelete(long idAbsolvireProgramProba)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireProgramProbaDelete", idAbsolvireProgramProba);
            }
            catch (Exception ex)
            {
                throw new DataException("Error deleting AbsolvireProgramProba", ex);
            }
        }
    }
}
