using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IAnunturiRepo
    {
        bool AnunturiAdd(AnunturiInfo anunturiInfo);
        bool AnunturiUpdate(AnunturiInfo anunturiInfo);
        bool AnunturiDelete(long idAnunt);
        AnunturiInfo AnunturiGet(long idAnunt);
        AnunturiInfo AnunturiGetByIdStudentAnUniv(long idStudent, long idAnUniv);
        List<AnunturiInfo> AnunturiList();
        List<AnunturiInfo> AnunturiListByIdStudnetAnUniv(long idStudent, long idAnUniv);
        List<AnunturiInfo> AnunturiListByStudentAnUniv(long idStudent, long idAnUniv);
        List<AnunturiInfo> AnunturiListByUsernameStudentAnUniv(string username, long idAnUniv);
    }

    public class AnunturiRepo : IAnunturiRepo
    {
        private readonly string _connectionString;

        public AnunturiRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;

            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found.");
        }

        public bool AnunturiAdd(AnunturiInfo anunturiInfo)
        {
            if (anunturiInfo == null)
                throw new ArgumentNullException(nameof(anunturiInfo));

            try
            {
                var id = SqlHelper.ExecuteScalar(_connectionString, "AnunturiAdd",
                    anunturiInfo.TitluAnunt,
                    anunturiInfo.MesajAnunt,
                    anunturiInfo.DataPostare,
                    anunturiInfo.DataExpirare,
                    anunturiInfo.AnuntProfesori,
                    anunturiInfo.AnuntStudenti,
                    anunturiInfo.ID_Facultate,
                    anunturiInfo.ID_FC,
                    anunturiInfo.ID_FCForma,
                    anunturiInfo.ID_Catedra,
                    anunturiInfo.ID_AnUniv,
                    anunturiInfo.ID_AnStudiu,
                    anunturiInfo.ID_Domeniu,
                    anunturiInfo.ID_Specializare,
                    anunturiInfo.ID_Grupe,
                    anunturiInfo.PortalID,
                    anunturiInfo.UserID,
                    anunturiInfo.TipFisier,
                    anunturiInfo.CaleFisier
                );

                return Convert.ToInt64(id) > 0;
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la adăugarea anunțului.", ex);
            }
        }

        public bool AnunturiUpdate(AnunturiInfo anunturiInfo)
        {
            if (anunturiInfo == null)
                throw new ArgumentNullException(nameof(anunturiInfo));

            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "AnunturiUpdate",
                    anunturiInfo.IdAnunt,
                    anunturiInfo.TitluAnunt,
                    anunturiInfo.MesajAnunt,
                    anunturiInfo.DataPostare,
                    anunturiInfo.DataExpirare,
                    anunturiInfo.AnuntProfesori,
                    anunturiInfo.AnuntStudenti,
                    anunturiInfo.ID_Facultate,
                    anunturiInfo.ID_FC,
                    anunturiInfo.ID_FCForma,
                    anunturiInfo.ID_Catedra,
                    anunturiInfo.ID_AnUniv,
                    anunturiInfo.ID_AnStudiu,
                    anunturiInfo.ID_Domeniu,
                    anunturiInfo.ID_Specializare,
                    anunturiInfo.ID_Grupe,
                    anunturiInfo.PortalID,
                    anunturiInfo.UserID,
                    anunturiInfo.TipFisier,
                    anunturiInfo.CaleFisier
                );

                return true;
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la actualizarea anunțului.", ex);
            }
        }

        public bool AnunturiDelete(long idAnunt)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "AnunturiDelete", idAnunt);
                return true;
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la ștergerea anunțului.", ex);
            }
        }

        public AnunturiInfo AnunturiGet(long idAnunt)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "AnunturiGet", idAnunt))
                {
                    return CBO.FillObject<AnunturiInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obținerea anunțului.", ex);
            }
        }

        public AnunturiInfo AnunturiGetByIdStudentAnUniv(long idStudent, long idAnUniv)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "AnunturiGetByIdStudentAnUniv", idStudent, idAnUniv))
                {
                    return CBO.FillObject<AnunturiInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obținerea anunțului pentru student.", ex);
            }
        }

        public List<AnunturiInfo> AnunturiList()
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "AnunturiList"))
                {
                    return CBO.FillCollection<AnunturiInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea anunțurilor.", ex);
            }
        }

        public List<AnunturiInfo> AnunturiListByIdStudnetAnUniv(long idStudent, long idAnUniv)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "AnunturiListByIdStudnetAnUniv", idStudent, idAnUniv))
                {
                    return CBO.FillCollection<AnunturiInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea anunțurilor după ID student și an univ.", ex);
            }
        }

        public List<AnunturiInfo> AnunturiListByStudentAnUniv(long idStudent, long idAnUniv)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "AnunturiListByStudentAnUniv", idStudent, idAnUniv))
                {
                    return CBO.FillCollection<AnunturiInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea anunțurilor pentru student și an universitar.", ex);
            }
        }

        public List<AnunturiInfo> AnunturiListByUsernameStudentAnUniv(string username, long idAnUniv)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "AnunturiListByUsernameStudentAnUniv", username, idAnUniv))
                {
                    return CBO.FillCollection<AnunturiInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea anunțurilor după username și an universitar.", ex);
            }
        }
    }
}
