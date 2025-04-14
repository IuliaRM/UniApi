using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface ICatedraRepo
    {
        long CatedraAdd(CatedraInfo catedra);
        void CatedraUpdate(CatedraInfo catedra);
        void CatedraDelete(long idCatedra);
        CatedraInfo CatedraGet(long idCatedra);
        CatedraInfo CatedraGetByUsernameSecretarAnUniv(string username, long idAnUniv);
        List<CatedraInfo> CatedraList();
        List<CatedraInfo> CatedraListByAnUniv(long idAnUniv);
        List<CatedraInfo> CatedraListByFacultate(long idFacultate);
        List<CatedraInfo> CatedraListByFacultateAnUniv(long idFacultate, long idAnUniv);
    }

    public class CatedraRepo : ICatedraRepo
    {
        private readonly string _connectionString;

        public CatedraRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;

            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found.");
        }

        public long CatedraAdd(CatedraInfo catedra)
        {
            if (catedra == null)
                throw new ArgumentNullException(nameof(catedra));

            try
            {
                return Convert.ToInt64(SqlHelper.ExecuteScalar(_connectionString, "CatedraAdd",
                    catedra.DenumireCatedra,
                    catedra.DenumireScurtaCatedra,
                    catedra.ID_Facultate,
                    catedra.ID_AnUniv));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la adăugarea catedrei.", ex);
            }
        }

        public void CatedraUpdate(CatedraInfo catedra)
        {
            if (catedra == null)
                throw new ArgumentNullException(nameof(catedra));

            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "CatedraUpdate",
                    catedra.ID_Catedra,
                    catedra.DenumireCatedra,
                    catedra.DenumireScurtaCatedra,
                    catedra.ID_Facultate,
                    catedra.ID_ProfesorSefCatedra,
                    catedra.UsernameCoordonatorCEAC,
                    catedra.UsernameSecretar);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la actualizarea catedrei.", ex);
            }
        }

        public void CatedraDelete(long idCatedra)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "CatedraDelete", idCatedra);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la ștergerea catedrei.", ex);
            }
        }

        public CatedraInfo CatedraGet(long idCatedra)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "CatedraGet", idCatedra))
                {
                    return CBO.FillObject<CatedraInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obținerea catedrei.", ex);
            }
        }

        public CatedraInfo CatedraGetByUsernameSecretarAnUniv(string username, long idAnUniv)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "CatedraGetByUsernameSecretarAnUniv", username, idAnUniv))
                {
                    return CBO.FillObject<CatedraInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obținerea catedrei după secretar și an universitar.", ex);
            }
        }

        public List<CatedraInfo> CatedraList()
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "CatedraList"))
                {
                    return CBO.FillCollection<CatedraInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea catedrelor.", ex);
            }
        }

        public List<CatedraInfo> CatedraListByAnUniv(long idAnUniv)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "CatedraListByAnUniv", idAnUniv))
                {
                    return CBO.FillCollection<CatedraInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea catedrelor după an universitar.", ex);
            }
        }

        public List<CatedraInfo> CatedraListByFacultate(long idFacultate)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "CatedraListByFacultate", idFacultate))
                {
                    return CBO.FillCollection<CatedraInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea catedrelor după facultate.", ex);
            }
        }

        public List<CatedraInfo> CatedraListByFacultateAnUniv(long idFacultate, long idAnUniv)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "CatedraListByFacultateAnUniv", idFacultate, idAnUniv))
                {
                    return CBO.FillCollection<CatedraInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea catedrelor după facultate și an universitar.", ex);
            }
        }
    }
}
