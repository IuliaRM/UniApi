using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IDetaliuPlanSemestruProfesorRepo
    {
        DetaliuPlanSemestruProfesorInfo DetaliuPlanSemestruProfesorGet(long id);
        List<DetaliuPlanSemestruProfesorInfo> DetaliuPlanSemestruProfesorList();
        List<DetaliuPlanSemestruProfesorInfo> DetaliuPlanSemestruProfesorListByProfesor(long idProfesor, long idAnUniv, long idScenariu);
        List<DetaliuPlanSemestruProfesorInfo> DetaliuPlanSemestruProfesorListByTipOrePredate(long idTipOrePredate);
        List<DetaliuPlanSemestruProfesorInfo> DetaliuPlanSemestruProfesorListByProfesorComplet(long idProfesor, long idAnUniv, long idScenariu);
        List<DetaliuPlanSemestruProfesorInfo> DetaliuPlanSemestruProfesorListByDetaliuPlanSemestru(long idDetaliuPlanSemestru);
        List<DetaliuPlanSemestruProfesorInfo> DetaliuPlanSemestruProfesorListBySpecializareNrSemestruScenariuActiv(long idDomeniu, long idSpecializare, int nrSemestru);
        List<DetaliuPlanSemestruProfesorInfo> DetaliuPlanSemestruProfesorListByProfesorSpecializare(long idProfesor, long idDomeniu, long idSpecializare, int nrSemestru);
        int DetaliuPlanSemestruProfesorAdd(DetaliuPlanSemestruProfesorInfo info);
        void DetaliuPlanSemestruProfesorUpdate(DetaliuPlanSemestruProfesorInfo info);
        void DetaliuPlanSemestruProfesorDelete(long id);
    }

    public class DetaliuPlanSemestruProfesorRepo : IDetaliuPlanSemestruProfesorRepo
    {
        private readonly string _connectionString;

        public DetaliuPlanSemestruProfesorRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;
            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found.");
        }

        public DetaliuPlanSemestruProfesorInfo DetaliuPlanSemestruProfesorGet(long id)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruProfesorGet", id))
                {
                    return CBO.FillObject<DetaliuPlanSemestruProfesorInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obtinerea detaliului profesorului.", ex);
            }
        }

        public List<DetaliuPlanSemestruProfesorInfo> DetaliuPlanSemestruProfesorList()
        {
            try
            {
                return CBO.FillCollection<DetaliuPlanSemestruProfesorInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruProfesorList"));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea detaliilor profesorilor.", ex);
            }
        }

        public List<DetaliuPlanSemestruProfesorInfo> DetaliuPlanSemestruProfesorListByProfesor(long idProfesor, long idAnUniv, long idScenariu)
        {
            try
            {
                return CBO.FillCollection<DetaliuPlanSemestruProfesorInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruProfesorListByProfesor", idProfesor, idAnUniv, idScenariu));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea dupa profesor.", ex);
            }
        }

        public List<DetaliuPlanSemestruProfesorInfo> DetaliuPlanSemestruProfesorListByTipOrePredate(long idTipOrePredate)
        {
            try
            {
                return CBO.FillCollection<DetaliuPlanSemestruProfesorInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruProfesorListByTipOrePredate", idTipOrePredate));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea dupa tip ore predate.", ex);
            }
        }

        public List<DetaliuPlanSemestruProfesorInfo> DetaliuPlanSemestruProfesorListByProfesorComplet(long idProfesor, long idAnUniv, long idScenariu)
        {
            try
            {
                return CBO.FillCollection<DetaliuPlanSemestruProfesorInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruProfesorListByProfesorComplet", idProfesor, idAnUniv, idScenariu));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea completa dupa profesor.", ex);
            }
        }

        public List<DetaliuPlanSemestruProfesorInfo> DetaliuPlanSemestruProfesorListByDetaliuPlanSemestru(long idDetaliuPlanSemestru)
        {
            try
            {
                return CBO.FillCollection<DetaliuPlanSemestruProfesorInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruProfesorListByDetaliuPlanSemestru", idDetaliuPlanSemestru));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea dupa detaliu plan semestru.", ex);
            }
        }

        public List<DetaliuPlanSemestruProfesorInfo> DetaliuPlanSemestruProfesorListBySpecializareNrSemestruScenariuActiv(long idDomeniu, long idSpecializare, int nrSem)
        {
            try
            {
                return CBO.FillCollection<DetaliuPlanSemestruProfesorInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruProfesorListBySpecializareNrSemestruScenariuActiv", idDomeniu, idSpecializare, nrSem));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea dupa specializare si semestru activ.", ex);
            }
        }

        public List<DetaliuPlanSemestruProfesorInfo> DetaliuPlanSemestruProfesorListByProfesorSpecializare(long idProfesor, long idDomeniu, long idSpecializare, int nrSem)
        {
            try
            {
                return CBO.FillCollection<DetaliuPlanSemestruProfesorInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruProfesorListByProfesorSpecializare", idProfesor, idDomeniu, idSpecializare, nrSem));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea dupa profesor si specializare.", ex);
            }
        }

        public int DetaliuPlanSemestruProfesorAdd(DetaliuPlanSemestruProfesorInfo info)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            try
            {
                return Convert.ToInt32(SqlHelper.ExecuteScalar(_connectionString, "DetaliuPlanSemestruProfesorAdd",
                    info.ID_DetaliuPlanSemestru,
                    info.ID_Profesor,
                    info.ID_TipOrePredate,
                    info.NumarOrePredateFizice));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la adaugarea detaliului profesorului.", ex);
            }
        }

        public void DetaliuPlanSemestruProfesorUpdate(DetaliuPlanSemestruProfesorInfo info)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "DetaliuPlanSemestruProfesorUpdate",
                    info.ID_DetaliuPlanSemestruProfesor,
                    info.ID_DetaliuPlanSemestru,
                    info.ID_Profesor,
                    info.ID_TipOrePredate,
                    info.NumarOrePredateFizice);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la actualizarea detaliului profesorului.", ex);
            }
        }

        public void DetaliuPlanSemestruProfesorDelete(long id)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "DetaliuPlanSemestruProfesorDelete", id);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la stergerea detaliului profesorului.", ex);
            }
        }
    }
}
