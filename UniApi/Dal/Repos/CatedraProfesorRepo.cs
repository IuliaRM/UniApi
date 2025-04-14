using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface ICatedraProfesorRepo
    {
        long CatedraProfesorAdd(CatedraProfesorInfo info);
        void CatedraProfesorUpdate(CatedraProfesorInfo info);
        void CatedraProfesorDelete(long idCatedraProfesor);
        CatedraProfesorInfo CatedraProfesorGet(long idCatedraProfesor);
        List<CatedraProfesorInfo> CatedraProfesorGetByProfesor(long idProfesor);
        List<CatedraProfesorInfo> CatedraProfesorGetByProfesorAnUniv(long idProfesor, long idAnUniv);
        List<CatedraProfesorInfo> CatedraProfesorListByCatedra(long idCatedra);
        List<CatedraProfesorInfo> CatedraProfesorListByCatedraAnUniv(long idCatedra, long idAnUniv);
        List<CatedraProfesorInfo> CatedraProfesorListByCatedraAnCalendaristicFRACSActiv(long idCatedra, long idAnCalendaristic);
        List<CatedraProfesorInfo> CatedraProfesorListByCatedraCercetator(long idCatedra);
        List<CatedraProfesorInfo> CatedraProfesorListByCatedraProfesorActiv(long idCatedra);
        List<CatedraProfesorInfo> CatedraProfesorListByCatedraProfesorInactiv(long idCatedra);
        List<CatedraProfesorInfo> CatedraProfesorListByCatedraProfesorTitularByAnUniv(long idCatedra, long idAnUniv);
        List<CatedraProfesorInfo> CatedraProfesorListbyProfesor(long idProfesor);
    }

    public class CatedraProfesorRepo : ICatedraProfesorRepo
    {
        private readonly string _connectionString;

        public CatedraProfesorRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;
            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found.");
        }

        public long CatedraProfesorAdd(CatedraProfesorInfo info)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            try
            {
                return Convert.ToInt64(SqlHelper.ExecuteScalar(_connectionString, "CatedraProfesorAdd",
                    info.ID_Catedra, info.ID_Profesor, info.DataDeCand, info.DataPanaCand,
                    info.CatedraProfesorActiv, info.ID_AnUniv));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la adăugarea profesorului în catedră.", ex);
            }
        }

        public void CatedraProfesorUpdate(CatedraProfesorInfo info)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "CatedraProfesorUpdate",
                    info.ID_CatedraProfesor, info.ID_Catedra, info.ID_Profesor, info.DataDeCand,
                    info.DataPanaCand, info.CatedraProfesorActiv, info.ID_AnUniv);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la actualizarea profesorului în catedră.", ex);
            }
        }

        public void CatedraProfesorDelete(long idCatedraProfesor)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "CatedraProfesorDelete", idCatedraProfesor);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la ștergerea profesorului din catedră.", ex);
            }
        }

        public CatedraProfesorInfo CatedraProfesorGet(long idCatedraProfesor)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "CatedraProfesorGet", idCatedraProfesor))
                {
                    return CBO.FillObject<CatedraProfesorInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obținerea informațiilor profesorului din catedră.", ex);
            }
        }

        public List<CatedraProfesorInfo> CatedraProfesorGetByProfesor(long idProfesor)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "CatedraProfesorGetByProfesor", idProfesor))
                {
                    return CBO.FillCollection<CatedraProfesorInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obținerea catedrelor pentru profesor.", ex);
            }
        }

        public List<CatedraProfesorInfo> CatedraProfesorGetByProfesorAnUniv(long idProfesor, long idAnUniv)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "CatedraProfesorGetByProfesorAnUniv", idProfesor, idAnUniv))
                {
                    return CBO.FillCollection<CatedraProfesorInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obținerea catedrelor pentru profesor în anul universitar.", ex);
            }
        }

        public List<CatedraProfesorInfo> CatedraProfesorListByCatedra(long idCatedra)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "CatedraProfesorListByCatedra", idCatedra))
                {
                    return CBO.FillCollection<CatedraProfesorInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea profesorilor din catedră.", ex);
            }
        }

        public List<CatedraProfesorInfo> CatedraProfesorListByCatedraAnUniv(long idCatedra, long idAnUniv)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "CatedraProfesorListByCatedraAnUniv", idCatedra, idAnUniv))
                {
                    return CBO.FillCollection<CatedraProfesorInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea profesorilor din catedră pentru anul universitar.", ex);
            }
        }

        public List<CatedraProfesorInfo> CatedraProfesorListByCatedraAnCalendaristicFRACSActiv(long idCatedra, long idAnCalendaristic)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "CatedraProfesorListByCatedraAnCalendaristicFRACSActiv", idCatedra, idAnCalendaristic))
                {
                    return CBO.FillCollection<CatedraProfesorInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea profesorilor FRACS activi.", ex);
            }
        }

        public List<CatedraProfesorInfo> CatedraProfesorListByCatedraCercetator(long idCatedra)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "CatedraProfesorListByCatedraCercetator", idCatedra))
                {
                    return CBO.FillCollection<CatedraProfesorInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea cercetătorilor din catedră.", ex);
            }
        }

        public List<CatedraProfesorInfo> CatedraProfesorListByCatedraProfesorActiv(long idCatedra)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "CatedraProfesorListByCatedraProfesorActiv", idCatedra))
                {
                    return CBO.FillCollection<CatedraProfesorInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea profesorilor activi.", ex);
            }
        }

        public List<CatedraProfesorInfo> CatedraProfesorListByCatedraProfesorInactiv(long idCatedra)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "CatedraProfesorListByCatedraProfesorInactiv", idCatedra))
                {
                    return CBO.FillCollection<CatedraProfesorInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea profesorilor inactivi.", ex);
            }
        }

        public List<CatedraProfesorInfo> CatedraProfesorListByCatedraProfesorTitularByAnUniv(long idCatedra, long idAnUniv)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "CatedraProfesorListByCatedraProfesorTitularByAnUniv", idCatedra, idAnUniv))
                {
                    return CBO.FillCollection<CatedraProfesorInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea titularilor pe catedră în anul universitar.", ex);
            }
        }

        public List<CatedraProfesorInfo> CatedraProfesorListbyProfesor(long idProfesor)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "CatedraProfesorListbyProfesor", idProfesor))
                {
                    return CBO.FillCollection<CatedraProfesorInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea tuturor catedrelor unui profesor.", ex);
            }
        }
    }
}