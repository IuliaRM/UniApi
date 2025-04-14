using System;
using System.Collections.Generic;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{

    public interface ISportNeprofilRepo
    {
        SportNeprofilInfo SportNeprofilGet(long idSportNeprofil);
        List<SportNeprofilInfo> SportNeprofilListByAnUniversitarFacultate(long idAnUniv, long idFacultate);
        List<SportNeprofilInfo> SportNeprofilListByFacultate(long idFacultate);
        long SportNeprofilAdd(SportNeprofilInfo sportNeprofilInfo);
        void SportNeprofilUpdate(SportNeprofilInfo sportNeprofilInfo);
        void SportNeprofilDelete(long idSportNeprofil);
        void SportNeprofilUpdateAsistentExamen(long idSportNeprofil, long? idAsistentExamen);
    }

    public class SportNeprofilRepo : ISportNeprofilRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public SportNeprofilInfo SportNeprofilGet(long idSportNeprofil)
        {
            return CBO.FillObject<SportNeprofilInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SportNeprofilGet", idSportNeprofil));
        }

        public List<SportNeprofilInfo> SportNeprofilListByAnUniversitarFacultate(long idAnUniv, long idFacultate)
        {
            return CBO.FillCollection<SportNeprofilInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SportNeprofilListByAnUniversitarFacultate", idAnUniv, idFacultate));
        }

        public List<SportNeprofilInfo> SportNeprofilListByFacultate(long idFacultate)
        {
            return CBO.FillCollection<SportNeprofilInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SportNeprofilListBYFacultate", idFacultate));
        }

        public long SportNeprofilAdd(SportNeprofilInfo sportNeprofilInfo)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "SportNeprofilAdd",
                sportNeprofilInfo.ID_AnUniv,
                sportNeprofilInfo.ID_Facultate,
                sportNeprofilInfo.Zi,
                sportNeprofilInfo.Interval,
                sportNeprofilInfo.Disciplina,
                sportNeprofilInfo.Locatie,
                sportNeprofilInfo.CadruDidactic,
                sportNeprofilInfo.NrLocuri,
                sportNeprofilInfo.LocIntilnire);
            return Convert.ToInt64(id);
        }

        public void SportNeprofilUpdate(SportNeprofilInfo sportNeprofilInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "SportNeprofilUpdate",
                sportNeprofilInfo.ID_SportNeprofil,
                sportNeprofilInfo.ID_AnUniv,
                sportNeprofilInfo.ID_Facultate,
                sportNeprofilInfo.Zi,
                sportNeprofilInfo.Interval,
                sportNeprofilInfo.Disciplina,
                sportNeprofilInfo.Locatie,
                sportNeprofilInfo.CadruDidactic,
                sportNeprofilInfo.NrLocuri,
                sportNeprofilInfo.LocIntilnire);
        }

        public void SportNeprofilDelete(long idSportNeprofil)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "SportNeprofilDelete", idSportNeprofil);
        }

        public void SportNeprofilUpdateAsistentExamen(long idSportNeprofil, long? idAsistentExamen)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "SportNeprofilUpdateAsistentExamen", idSportNeprofil, idAsistentExamen);
        }
    }
}
