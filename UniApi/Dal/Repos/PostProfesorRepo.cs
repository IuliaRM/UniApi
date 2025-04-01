using System;
using System.Collections.Generic;
using System.Configuration;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class PostProfesorRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public PostProfesorInfo PostProfesorGet(long idPostProfesor)
        {
            return CBO.FillObject<PostProfesorInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PostProfesorGet", idPostProfesor));
        }

        public List<PostProfesorInfo> PostProfesorListGet()
        {
            return CBO.FillCollection<PostProfesorInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PostProfesorList"));
        }

        public List<PostProfesorInfo> PostProfesorListByDetaliuPlanSemestruProfesorGet(long idDetaliuPlanSemestruProfesor)
        {
            return CBO.FillCollection<PostProfesorInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PostProfesorListByDetaliuPlanSemestruProfesor", idDetaliuPlanSemestruProfesor));
        }

        public List<PostProfesorInfo> PostProfesorListByPostGet(long idPost)
        {
            return CBO.FillCollection<PostProfesorInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PostProfesorListByPost", idPost));
        }

        public long PostProfesorAdd(PostProfesorInfo postProfesorInfo)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "PostProfesorAdd",
                postProfesorInfo.ID_Post,
                postProfesorInfo.ID_DetaliuPlanSemestru,
                postProfesorInfo.ID_Profesor,
                postProfesorInfo.NrOrePredateCurs,
                postProfesorInfo.NrOrePredateSeminar,
                postProfesorInfo.NrOrePredateLaborator,
                postProfesorInfo.NrOrePredateProiect,
                postProfesorInfo.ID_Cuplaj,
                postProfesorInfo.ID_Scenariu);

            return Convert.ToInt64(id);
        }

        public void PostProfesorUpdate(PostProfesorInfo postProfesorInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "PostProfesorUpdate",
                postProfesorInfo.ID_PostProfesor,
                postProfesorInfo.ID_Post,
                postProfesorInfo.ID_DetaliuPlanSemestru,
                postProfesorInfo.ID_Profesor,
                postProfesorInfo.NrOrePredateCurs,
                postProfesorInfo.NrOrePredateSeminar,
                postProfesorInfo.NrOrePredateLaborator,
                postProfesorInfo.NrOrePredateProiect,
                postProfesorInfo.ID_Cuplaj,
                postProfesorInfo.ID_Scenariu);
        }

        public void PostProfesorDelete(long idPostProfesor)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "PostProfesorDelete", idPostProfesor);
        }

        public List<PostProfesorInfo> ProcentOreConventionaleByProfesorGet(long idProfesor, long idAnUniv, long idScenariu)
        {
            return CBO.FillCollection<PostProfesorInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PostCalculProcentOreConventionaleByProfesor", idProfesor, idAnUniv, idScenariu));
        }

        public List<PostProfesorInfo> ProcentOreConventionaleByProfesorSemestruGet(long idProfesor, long idAnUniv, long idScenariu)
        {
            return CBO.FillCollection<PostProfesorInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PostCalculProcentOreConventionaleByProfesorSemestru", idProfesor, idAnUniv, idScenariu));
        }

        public List<PostProfesorInfo> ProcentOreConventionaleByPostProfesorGet(long idPost, long idProfesor, long idAnUniv, long idScenariu)
        {
            return CBO.FillCollection<PostProfesorInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PostCalculProcentOreConventionaleByPostProfesor", idPost, idProfesor, idAnUniv, idScenariu));
        }
    }
}
