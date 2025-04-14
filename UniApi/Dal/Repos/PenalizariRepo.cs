using System;
using System.Configuration;
using System.Data;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.DAL.Repos
{

    public interface IPenalizariRepo
    {
        PenalizariInfo PenalizariGet(long id);
        int PenalizariAdd(PenalizariInfo penalizare);
        void PenalizariUpdate(PenalizariInfo penalizare);
    }

    public class PenalizariRepo : IPenalizariRepo
    {
        private readonly string _connectionString;

        public PenalizariRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;

            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found in configuration.");
            }
        }

        public PenalizariInfo PenalizariGet(long id)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "PenalizariGet", id))
                {
                    return CBO.FillObject<PenalizariInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving Penalizare", ex);
            }
        }

        public int PenalizariAdd(PenalizariInfo penalizare)
        {
            if (penalizare == null)
                throw new ArgumentNullException(nameof(penalizare));

            try
            {
                var result = SqlHelper.ExecuteScalar(_connectionString, "PenalizariAdd",
                    penalizare.Procent,
                    penalizare.SumaFixa,
                    penalizare.ID_Utilizator,
                    DateTime.Now,
                    penalizare.Status);

                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                throw new DataException("Error adding Penalizare", ex);
            }
        }

        public void PenalizariUpdate(PenalizariInfo penalizare)
        {
            if (penalizare == null)
                throw new ArgumentNullException(nameof(penalizare));

            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "PenalizariUpdate",
                    penalizare.Id,
                    penalizare.Procent,
                    penalizare.SumaFixa,
                    penalizare.ID_Utilizator,
                    DateTime.Now,
                    penalizare.Status);
            }
            catch (Exception ex)
            {
                throw new DataException("Error updating Penalizare", ex);
            }
        }
    }
}