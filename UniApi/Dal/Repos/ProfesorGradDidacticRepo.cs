using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using UniApi.Info;
namespace UniApi.DAL.Repos
{

    public interface IProfesorGradDidacticRepo
    {
        ProfesorGradDidacticInfo ProfesorGradDidacticGet(long idProfesorGradDidactic);
        ProfesorGradDidacticInfo ProfesorGradDidacticGetGradDidacticActiv(long idProfesor);
        ProfesorGradDidacticInfo ProfesorGradDidacticGetGradDidacticActivAnUniv(long idProfesor, long idAnUniv);
        List<ProfesorGradDidacticInfo> ProfesorGradDidacticList();
        List<ProfesorGradDidacticInfo> ProfesorGradDidacticListByProfesor(long idProfesor);
        List<ProfesorGradDidacticInfo> ProfesorGradDidacticListByTipGradDidactic(long idTipGradDidactic);
        int ProfesorGradDidacticAdd(ProfesorGradDidacticInfo profesorGradDidactic);
        void ProfesorGradDidacticUpdate(ProfesorGradDidacticInfo profesorGradDidactic);
        void ProfesorGradDidacticDelete(long idProfesorGradDidactic);
    }

    public class ProfesorGradDidacticRepo : IProfesorGradDidacticRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public ProfesorGradDidacticInfo ProfesorGradDidacticGet(long idProfesorGradDidactic)
        {
            return CBO.FillObject<ProfesorGradDidacticInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ProfesorGradDidacticGet", idProfesorGradDidactic));
        }

        public ProfesorGradDidacticInfo ProfesorGradDidacticGetGradDidacticActiv(long idProfesor)
        {
            return CBO.FillObject<ProfesorGradDidacticInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ProfesorGradDidacticGetGradDidacticActiv", idProfesor));
        }

        public ProfesorGradDidacticInfo ProfesorGradDidacticGetGradDidacticActivAnUniv(long idProfesor, long idAnUniv)
        {
            return CBO.FillObject<ProfesorGradDidacticInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ProfesorGradDidacticGetGradDidacticActivAnUniv", idProfesor, idAnUniv));
        }

        public List<ProfesorGradDidacticInfo> ProfesorGradDidacticList()
        {
            return CBO.FillCollection<ProfesorGradDidacticInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ProfesorGradDidacticList"));
        }

        public List<ProfesorGradDidacticInfo> ProfesorGradDidacticListByProfesor(long idProfesor)
        {
            return CBO.FillCollection<ProfesorGradDidacticInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ProfesorGradDidacticListByProfesor", idProfesor));
        }

        public List<ProfesorGradDidacticInfo> ProfesorGradDidacticListByTipGradDidactic(long idTipGradDidactic)
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

        public void ProfesorGradDidacticDelete(long idProfesorGradDidactic)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ProfesorGradDidacticDelete", idProfesorGradDidactic);
        }
    }
}
