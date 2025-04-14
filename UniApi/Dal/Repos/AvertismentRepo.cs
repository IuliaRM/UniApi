using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IAvertismentRepo
    {
        int AvertismentAdd(AvertismentInfo avertisment);
        bool AvertismentUpdate(AvertismentInfo avertisment);
        bool AvertismentDelete(long idAvertisment);
        AvertismentInfo AvertismentGet(long idAvertisment);
        List<AvertismentInfo> AvertismentList();
        List<AvertismentInfo> AvertismentListByCazare(long idCazare);
        List<AvertismentInfo> AvertismentListByTipAvertisment(long idTipAvertisment);
    }

    public class AvertismentRepo : IAvertismentRepo
    {
        private readonly string _connectionString;

        public AvertismentRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;

            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found.");
        }

        public int AvertismentAdd(AvertismentInfo avertisment)
        {
            if (avertisment == null)
                throw new ArgumentNullException(nameof(avertisment));

            try
            {
                var id = SqlHelper.ExecuteScalar(_connectionString, "AvertismentAdd",
                    avertisment.ID_TipAvertisment,
                    avertisment.ID_Cazare,
                    avertisment.DataAvertisment,
                    avertisment.Motiv,
                    avertisment.ID_AnUniv
                );

                return Convert.ToInt32(id);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la adăugarea avertismentului.", ex);
            }
        }

        public bool AvertismentUpdate(AvertismentInfo avertisment)
        {
            if (avertisment == null)
                throw new ArgumentNullException(nameof(avertisment));

            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "AvertismentUpdate",
                    avertisment.ID_Avertisment,
                    avertisment.ID_TipAvertisment,
                    avertisment.ID_Cazare,
                    avertisment.DataAvertisment,
                    avertisment.Motiv,
                    avertisment.ID_AnUniv
                );

                return true;
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la actualizarea avertismentului.", ex);
            }
        }

        public bool AvertismentDelete(long idAvertisment)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "AvertisemnDelete", idAvertisment);
                return true;
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la ștergerea avertismentului.", ex);
            }
        }

        public AvertismentInfo AvertismentGet(long idAvertisment)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "AvertismentGet", idAvertisment))
                {
                    return CBO.FillObject<AvertismentInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obținerea avertismentului.", ex);
            }
        }

        public List<AvertismentInfo> AvertismentList()
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "AvertismentList"))
                {
                    return CBO.FillCollection<AvertismentInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea avertismentelor.", ex);
            }
        }

        public List<AvertismentInfo> AvertismentListByCazare(long idCazare)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "AvertisemntListByCazare", idCazare))
                {
                    return CBO.FillCollection<AvertismentInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea avertismentelor pentru cazare.", ex);
            }
        }

        public List<AvertismentInfo> AvertismentListByTipAvertisment(long idTipAvertisment)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "AvertismentListByTipAvertisment", idTipAvertisment))
                {
                    return CBO.FillCollection<AvertismentInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea avertismentelor după tip.", ex);
            }
        }
    }
}
