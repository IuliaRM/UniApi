using System;
using System.Collections.Generic;
using System.Configuration;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class AbsolventAlumniDTORepo
    {
        private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public List<AbsolventAlumniDTO> AbsolventAlumniDTOGetList(long id_facultate, long id_anUniv, long id_specializare, long id_FacultateCiclu, long id_FCForma)
        {
            return CBO.FillCollection<AbsolventAlumniDTO>(SqlHelper.ExecuteReader(_connectionString, "AbsolventiAlumni", id_facultate, id_anUniv, id_specializare, id_FacultateCiclu, id_FCForma));
        }
    }
}
