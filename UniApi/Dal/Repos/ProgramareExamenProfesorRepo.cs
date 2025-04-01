using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using UniApi.Info;
//using UniApi.Components;

namespace UniApi.DAL.Repos
{
    public class ProgramareExamenProfesorRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public List<ProgramareExamenProfesorInfo> ProgramareExamenProfesorListByAnUnivProfesorActivaGet(long idAnUniv, long idProfesor, int activa, long idProgramareExamen)
        {
            return CBO.FillCollection<ProgramareExamenProfesorInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PE.ProgramareExamenProfesorListByAnUnivProfesorActiva", idAnUniv, idProfesor, activa, idProgramareExamen));
        }

        public List<SportNeprofilStudentInfo> SportNeprofilStudentListByAnUniversitarSemProfesorGet(long idAnUniv, string usernameProfesor)
        {
            return CBO.FillCollection<SportNeprofilStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PE.SportNeprofilStudentListByAnUniversitarSemProfesor", idAnUniv, usernameProfesor));
        }

        public List<ProgramareExamenProfesorInfo> ProgramareExamenProfesorListByProgramareExamenGet(long idProgramareExamen)
        {
            return CBO.FillCollection<ProgramareExamenProfesorInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PE.ProgramareExamenProfesorListByProgramareExamen", idProgramareExamen));
        }

        public void ProgramareExamenProfesorMerge(long idProgramareExamenProfesor, long idProgramareExamen, long idProfesor, long idAnUniv, bool activ, int idTipProfesorAsociere)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "PE.ProgramareExamenProfesorMerge", idProgramareExamenProfesor, idProgramareExamen, idProfesor, idAnUniv, activ, idTipProfesorAsociere);
        }

        public void ProgramareExamenDelete(long idProgramareExamen)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "PE.ProgramareExamenDelete", idProgramareExamen);
        }

        public void ProgramareExamenNoteFinalizateUpdate(long idProgramareExamen, bool noteFinalizate)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "PE.ProgramareExamenUpdateNoteFinalizate", idProgramareExamen, noteFinalizate);
        }

    }
}