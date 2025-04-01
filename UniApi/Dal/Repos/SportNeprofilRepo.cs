using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class SportNeprofilRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public SportNeprofilInfo SportNeprofilGet(long idSportNeprofil)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<SportNeprofilInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SportNeprofilGet", idSportNeprofil));
        }

        public List<SportNeprofilInfo> SportNeprofilListByAnUniversitarGet(long idAnUniv, int nrSemestru)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<SportNeprofilInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SportNeprofilListByAnUniversitar", idAnUniv, nrSemestru));
        }

        public List<SportNeprofilInfo> SportNeprofilListByAnUniversitarFacultateGet(long idAnUniv, long idFacultate, int nrSemestru)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<SportNeprofilInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SportNeprofilListByAnUniversitarFacultate", idAnUniv, idFacultate, nrSemestru));
        }

        public List<SportNeprofilInfo> SportNeprofilListByFacultateGet(long idFacultate)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<SportNeprofilInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SportNeprofilListByFacultate", idFacultate));
        }

        public long SportNeprofilAdd(SportNeprofilInfo sportNeprofilInfo)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "SportNeprofilAdd",
                sportNeprofilInfo.ID_AnUniv, sportNeprofilInfo.ID_Facultate, sportNeprofilInfo.Zi,
                sportNeprofilInfo.Interval, sportNeprofilInfo.Disciplina, sportNeprofilInfo.Locatie,
                sportNeprofilInfo.CadruDidactic, sportNeprofilInfo.NrLocuri, sportNeprofilInfo.LocIntilnire);
            return Convert.ToInt64(id);
        }

        public void SportNeprofilUpdate(SportNeprofilInfo sportNeprofilInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "SportNeprofilUpdate",
                sportNeprofilInfo.ID_SportNeprofil, sportNeprofilInfo.ID_AnUniv, sportNeprofilInfo.ID_Facultate,
                sportNeprofilInfo.Zi, sportNeprofilInfo.Interval, sportNeprofilInfo.Disciplina,
                sportNeprofilInfo.Locatie, sportNeprofilInfo.CadruDidactic, sportNeprofilInfo.NrLocuri,
                sportNeprofilInfo.LocIntilnire);
        }

        public void SportNeprofilDelete(long idSportNeprofil)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "SportNeprofilDelete", idSportNeprofil);
        }
    }
}
