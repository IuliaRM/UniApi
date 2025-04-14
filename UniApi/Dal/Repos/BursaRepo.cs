using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IBursaRepo
    {
        BursaInfo BursaGet(long idBursa);
        List<BursaInfo> BursaList();
        List<BursaInfo> BursaListByStudent(long idStudent);
        List<BursaInfo> BursaListByAnUniv(long idAnUniv);
        List<BursaInfo> BursaListByTipBursa(long idTipBursa);
        List<BursaInfo> BursaListByDSG(long idDSG);
        int BursaVizibileAddOrUpdate(BursaInfo bursa);
        List<BursaInfo> BursaVizibileGetByFacultate(long idFacultate);
        bool BursaDelete(long idBursa);
        bool BursaDeleteByStudentAnSemestru(long idStudent, long idAnUniv, long numarSemestru);
        bool BursaDeleteByStudentAnSemestruStatusNegativ(long idStudent, long idAnUniv, long numarSemestru);
    }

    public class BursaRepo : IBursaRepo
    {
        private readonly string _connectionString;

        public BursaRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;

            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found.");
        }

        public BursaInfo BursaGet(long idBursa)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "BursaGet", idBursa))
                {
                    return CBO.FillObject<BursaInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obținerea bursei.", ex);
            }
        }

        public List<BursaInfo> BursaList()
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "BursaList"))
                {
                    return CBO.FillCollection<BursaInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea burselor.", ex);
            }
        }

        public List<BursaInfo> BursaListByStudent(long idStudent)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "BursaListByStudent", idStudent))
                {
                    return CBO.FillCollection<BursaInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea burselor studentului.", ex);
            }
        }

        public List<BursaInfo> BursaListByAnUniv(long idAnUniv)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "BursaListByAnUniv", idAnUniv))
                {
                    return CBO.FillCollection<BursaInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea burselor după an universitar.", ex);
            }
        }

        public List<BursaInfo> BursaListByTipBursa(long idTipBursa)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "BursaListByTipBursa", idTipBursa))
                {
                    return CBO.FillCollection<BursaInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea burselor după tip.", ex);
            }
        }

        public List<BursaInfo> BursaListByDSG(long idDSG)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "BursaListbyDSG", idDSG))
                {
                    return CBO.FillCollection<BursaInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea burselor după DSG.", ex);
            }
        }

        public int BursaVizibileAddOrUpdate(BursaInfo bursa)
        {
            if (bursa == null)
                throw new ArgumentNullException(nameof(bursa));

            try
            {
                return Convert.ToInt32(SqlHelper.ExecuteScalar(_connectionString, "BursaVizibileAddOrUpdate",
                    bursa.ID_Bursa,
                    bursa.ID_AnUniv,
                    bursa.ID_TipBursa,
                    bursa.NumarSemestruBursa,
                    bursa.BugetBursaDisponibil,
                    bursa.TipBursa
                ));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la adăugarea sau actualizarea bursei vizibile.", ex);
            }
        }

        public List<BursaInfo> BursaVizibileGetByFacultate(long idFacultate)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "BursaVizibileGetByFacultate", idFacultate))
                {
                    return CBO.FillCollection<BursaInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obținerea burselor vizibile după facultate.", ex);
            }
        }

        public bool BursaDelete(long idBursa)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "BursaDelete", idBursa);
                return true;
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la ștergerea bursei.", ex);
            }
        }

        public bool BursaDeleteByStudentAnSemestru(long idStudent, long idAnUniv, long numarSemestru)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "BursaDeleteBystudentAnSemestru", idStudent, idAnUniv, numarSemestru);
                return true;
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la ștergerea bursei după student și semestru.", ex);
            }
        }

        public bool BursaDeleteByStudentAnSemestruStatusNegativ(long idStudent, long idAnUniv, long numarSemestru)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "BursaDeleteByStudnetAnSemestruStatusNegativ", idStudent, idAnUniv, numarSemestru);
                return true;
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la ștergerea bursei cu status negativ.", ex);
            }
        }
    }
}
