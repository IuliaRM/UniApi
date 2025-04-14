using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IContUtilizatorRepo
    {
        ContUtilizatorInfo ContUtilizatorGet(long idContUtilizator);
        ContUtilizatorInfo ContUtilizatorGetByCNP(string cnp);
        List<ContUtilizatorInfo> ContUtilizatorList();
        long ContUtilizatorAdd(ContUtilizatorInfo info);
        void ContUtilizatorUpdate(ContUtilizatorInfo info);
        void ContUtilizatorDelete(long idContUtilizator);
        void ContUtilizatorDeleteByCNP(string cnp);
    }

    public class ContUtilizatorRepo : IContUtilizatorRepo
    {
        private readonly string _connectionString;

        public ContUtilizatorRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;
            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found.");
        }

        public ContUtilizatorInfo ContUtilizatorGet(long idContUtilizator)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "ContUtilizatorGet", idContUtilizator))
                {
                    return CBO.FillObject<ContUtilizatorInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obținerea utilizatorului.", ex);
            }
        }

        public ContUtilizatorInfo ContUtilizatorGetByCNP(string cnp)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "ContUtilizatorGetByCNP", cnp))
                {
                    return CBO.FillObject<ContUtilizatorInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la căutarea utilizatorului după CNP.", ex);
            }
        }

        public List<ContUtilizatorInfo> ContUtilizatorList()
        {
            try
            {
                return CBO.FillCollection<ContUtilizatorInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "ContUtilizatorList"));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea utilizatorilor.", ex);
            }
        }

        public long ContUtilizatorAdd(ContUtilizatorInfo info)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            try
            {
                return Convert.ToInt64(SqlHelper.ExecuteScalar(_connectionString, "ContUtilizatorAdd",
                    info.Nume,
                    info.Prenume,
                    info.Username,
                    info.EmailAlternativ,
                    info.CNP,
                    info.Marca,
                    info.TipUtilizator,
                    info.TipIncadrare,
                    info.TipPersonal,
                    info.FacultateServiciu,
                    info.DepartamentCompartiment,
                    info.Functie,
                    info.RolPrincipal));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la adăugarea utilizatorului.", ex);
            }
        }

        public void ContUtilizatorUpdate(ContUtilizatorInfo info)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "ContUtilizatorUpdate",
                    info.ID_ContUtilizator,
                    info.Nume,
                    info.Prenume,
                    info.Username,
                    info.EmailAlternativ,
                    info.CNP,
                    info.Marca,
                    info.TipUtilizator,
                    info.TipIncadrare,
                    info.TipPersonal,
                    info.FacultateServiciu,
                    info.DepartamentCompartiment,
                    info.Functie,
                    info.RolPrincipal);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la actualizarea utilizatorului.", ex);
            }
        }

        public void ContUtilizatorDelete(long idContUtilizator)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "ContUtilizatorDelete", idContUtilizator);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la ștergerea utilizatorului.", ex);
            }
        }

        public void ContUtilizatorDeleteByCNP(string cnp)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "ContUtilizatorDeleteByCNP", cnp);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la ștergerea utilizatorului după CNP.", ex);
            }
        }
    }
}
