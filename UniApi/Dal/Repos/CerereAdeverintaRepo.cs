using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface ICerereAdeverintaRepo
    {
        long CerereAdeverintaAdd(CerereAdeverintaInfo cerereAdevInfo);
        void CerereAdeverintaAprobareByIdCerereAdeverinta(long idCerere);
        void CerereAdeverintaAprobareByIdCerereIdAnUniv(long idCerere, long idAnUniv);
        CerereAdeverintaInfo CerereAdeverintaDetaliiGetByIdCerereIdAnUniv(long idCerere, long idAnUniv);
        void CerereAdeverintaDetaliiUpdate(CerereAdeverintaInfo info);
        CerereAdeverintaInfo CerereAdeverintaEchivalareGetByIdCerereIdAnUniv(long idCerere, long idAnUniv);
        void CerereAdeverintaEchivalareUpdate(CerereAdeverintaInfo info);
        void CerereAdeverintaStergereUpdate(long idCerere);
        void CerereAdeverintaSergeUpdate(long idCerere);
        void CerereAdeverintaTiparireByIdCerereAdevOdAnUniv(long idCerere, long idAnUniv);
        void CerereAdeverintaTiparireByIdCerereAdevIdAnUnivUpdate(long idCerere, long idAnUniv);
    }

    public class CerereAdeverintaRepo : ICerereAdeverintaRepo
    {
        private readonly string _connectionString;

        public CerereAdeverintaRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;

            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found.");
        }

        public long CerereAdeverintaAdd(CerereAdeverintaInfo info)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            try
            {
                object result = SqlHelper.ExecuteScalar(_connectionString, "CerereAdeverintaAdd",
                    info.ID_Student,
                    info.ID_AnUniv,
                    info.ID_Grupe,
                    info.ID_MotivCerereAdeverinta != 0 ? (object)info.ID_MotivCerereAdeverinta : DBNull.Value,
                    info.ID_NumarInregistrare,
                    info.ID_TipCerereAdeverinta,
                    info.DescriereMotivStudent,
                    info.DataCerere,
                    info.Aprobat);

                return result != null ? Convert.ToInt64(result) : 0;
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la adăugarea cererii de adeverință.", ex);
            }
        }

        public void CerereAdeverintaAprobareByIdCerereAdeverinta(long idCerere)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "CerereAdeverintaAprobareByIdCerereAdeverinta", idCerere);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la aprobarea cererii după ID.", ex);
            }
        }

        public void CerereAdeverintaAprobareByIdCerereIdAnUniv(long idCerere, long idAnUniv)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "CerereAdeverintaAprobareByIdCerereIdAnUniv", idCerere, idAnUniv);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la aprobarea cererii după ID și an universitar.", ex);
            }
        }

        public CerereAdeverintaInfo CerereAdeverintaDetaliiGetByIdCerereIdAnUniv(long idCerere, long idAnUniv)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "CerereAdeverintaDetaliiGetByIdCerereIdAnUniv", idCerere, idAnUniv))
                {
                    return CBO.FillObject<CerereAdeverintaInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obținerea detaliilor cererii.", ex);
            }
        }

        public void CerereAdeverintaDetaliiUpdate(CerereAdeverintaInfo info)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "CerereAdeverintaDetaliiUpdate",
                    info.ID_CerereAdeverinta,
                    info.ID_Grupe,
                    info.ID_MotivCerereAdeverinta,
                    info.DescriereMotivStudent,
                    info.Aprobat);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la actualizarea detaliilor cererii.", ex);
            }
        }

        public CerereAdeverintaInfo CerereAdeverintaEchivalareGetByIdCerereIdAnUniv(long idCerere, long idAnUniv)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "CerereAdeverintaEchivalareGetByIdCerereIdAnUniv", idCerere, idAnUniv))
                {
                    return CBO.FillObject<CerereAdeverintaInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obținerea echivalării cererii.", ex);
            }
        }

        public void CerereAdeverintaEchivalareUpdate(CerereAdeverintaInfo info)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "CerereAdeverintaEchivalareUpdate",
                    info.ID_CerereAdeverinta,
                    info.ID_Grupe);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la actualizarea echivalării cererii.", ex);
            }
        }

        public void CerereAdeverintaStergereUpdate(long idCerere)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "CerereAdeverintaStergereUpdate", idCerere);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la marcarea cererii ca ștearsă.", ex);
            }
        }

        public void CerereAdeverintaSergeUpdate(long idCerere)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "CerereAdeverintaSergeUpdate", idCerere);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la update-ul de tip 'serge'.", ex);
            }
        }

        public void CerereAdeverintaTiparireByIdCerereAdevOdAnUniv(long idCerere, long idAnUniv)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "CerereAdeverintaTiparireByIdCerereAdevOdAnUniv", idCerere, idAnUniv);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la tipărirea cererii.", ex);
            }
        }

        public void CerereAdeverintaTiparireByIdCerereAdevIdAnUnivUpdate(long idCerere, long idAnUniv)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "CerereAdeverintaTiparireByIdCerereAdevIdAnUnivUpdate", idCerere, idAnUniv);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la actualizarea tipăririi cererii.", ex);
            }
        }
    }
}
