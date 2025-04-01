using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class ProfesorGradDidacticRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public ProfesorGradDidacticInfo GradDidacticActivGet(long idProfesor)
        {
            return CBO.FillObject<ProfesorGradDidacticInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ProfesorGradDidacticGetGradDidacticActiv", idProfesor));
        }

        public ProfesorGradDidacticInfo GradDidacticActivAnUnivGet(long idProfesor, long idAnUniv)
        {
            return CBO.FillObject<ProfesorGradDidacticInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ProfesorGradDidacticGetGradDidacticActivAnUniv", idProfesor, idAnUniv));
        }

        public List<ProfesorGradDidacticInfo> GradDidacticListByProfesorGet(long idProfesor)
        {
            return CBO.FillCollection<ProfesorGradDidacticInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ProfesorGradDidacticListByProfesor", idProfesor));
        }

        public List<ProfesorGradDidacticInfo> GradDidacticListByTipGradDidacticGet(long idTipGradDidactic)
        {
            return CBO.FillCollection<ProfesorGradDidacticInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ProfesorGradDidacticListByTipGradDidactic", idTipGradDidactic));
        }

        public int ProfesorGradDidacticAdd(ProfesorGradDidacticInfo profesorGradDidactic)
        {
            return (int)SqlHelper.ExecuteScalar(_connectionString, "ProfesorGradDidacticAdd",
                profesorGradDidactic.ID_TipGradDidactic, profesorGradDidactic.ID_Profesor, profesorGradDidactic.DataDeCand,
                profesorGradDidactic.DataPanaCand, profesorGradDidactic.GradDidacticActiv, profesorGradDidactic.Titular,
                profesorGradDidactic.ID_AnUniv);
        }

        public void ProfesorGradDidacticUpdate(ProfesorGradDidacticInfo profesorGradDidactic)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ProfesorGradDidacticUpdate",
                profesorGradDidactic.ID_ProfesorGradDidactic, profesorGradDidactic.ID_TipGradDidactic,
                profesorGradDidactic.ID_Profesor, profesorGradDidactic.DataDeCand, profesorGradDidactic.DataPanaCand,
                profesorGradDidactic.GradDidacticActiv, profesorGradDidactic.Titular, profesorGradDidactic.ID_AnUniv);
        }

        public void ProfesorGradDidacticDelete(ProfesorGradDidacticInfo profesorGradDidactic)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ProfesorGradDidacticDelete", profesorGradDidactic.ID_ProfesorGradDidactic);
        }
    }
}
