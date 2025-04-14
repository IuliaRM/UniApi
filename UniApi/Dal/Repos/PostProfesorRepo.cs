using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.DAL.Repos
{

    public interface IPostProfesorRepo
    {
        PostProfesorInfo PostProfesorGet(long idPostProfesor);
        List<PostProfesorInfo> PostProfesorListGet();
        List<PostProfesorInfo> PostProfesorListByDetaliuPlanSemestruGet(long idDetaliuPlanSemestru);
        List<PostProfesorInfo> PostProfesorListByDetaliuPlanSemestruProfesorGet(long idDetaliuPlanSemestruProfesor);
        List<PostProfesorInfo> PostProfesorListByPostGet(long idPost);
        List<PostProfesorInfo> PostProfesorListByProfesorGet(long idProfesor);
        long PostProfesorAdd(PostProfesorInfo postProfesorInfo);
        void PostProfesorUpdate(PostProfesorInfo postProfesorInfo);
        void PostProfesorDelete(long idPostProfesor);
    }

    public class PostProfesorRepo : IPostProfesorRepo
    {
        private readonly string _connectionString;

        public PostProfesorRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;

            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found in configuration.");
            }
        }

        public PostProfesorInfo PostProfesorGet(long idPostProfesor)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "PostProfesorGet", idPostProfesor))
                {
                    return CBO.FillObject<PostProfesorInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving PostProfesor", ex);
            }
        }

        public List<PostProfesorInfo> PostProfesorListGet()
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "PostProfesorList"))
                {
                    return CBO.FillCollection<PostProfesorInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving PostProfesor list", ex);
            }
        }

        public List<PostProfesorInfo> PostProfesorListByDetaliuPlanSemestruGet(long idDetaliuPlanSemestru)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "PostProfesorListByDetaliuPlanSemestru", idDetaliuPlanSemestru))
                {
                    return CBO.FillCollection<PostProfesorInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException($"Error retrieving PostProfesor list by DetaliuPlanSemestru (ID: {idDetaliuPlanSemestru})", ex);
            }
        }

        public List<PostProfesorInfo> PostProfesorListByDetaliuPlanSemestruProfesorGet(long idDetaliuPlanSemestruProfesor)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "PostProfesorListByDetaliuPlanSemestruProfesor", idDetaliuPlanSemestruProfesor))
                {
                    return CBO.FillCollection<PostProfesorInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException($"Error retrieving PostProfesor list by DetaliuPlanSemestruProfesor (ID: {idDetaliuPlanSemestruProfesor})", ex);
            }
        }

        public List<PostProfesorInfo> PostProfesorListByPostGet(long idPost)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "PostProfesorListByPost", idPost))
                {
                    return CBO.FillCollection<PostProfesorInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException($"Error retrieving PostProfesor list by Post (ID: {idPost})", ex);
            }
        }

        public List<PostProfesorInfo> PostProfesorListByProfesorGet(long idProfesor)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "PostProfesorListByProfesor", idProfesor))
                {
                    return CBO.FillCollection<PostProfesorInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException($"Error retrieving PostProfesor list by Profesor (ID: {idProfesor})", ex);
            }
        }

        public long PostProfesorAdd(PostProfesorInfo postProfesorInfo)
        {
            if (postProfesorInfo == null)
                throw new ArgumentNullException(nameof(postProfesorInfo));

            try
            {
                var result = SqlHelper.ExecuteScalar(_connectionString, "PostProfesorAdd",
                    postProfesorInfo.ID_Post,
                    postProfesorInfo.ID_DetaliuPlanSemestru,
                    postProfesorInfo.ID_Profesor,
                    postProfesorInfo.NrOrePredateCurs,
                    postProfesorInfo.NrOrePredateSeminar,
                    postProfesorInfo.NrOrePredateLaborator,
                    postProfesorInfo.NrOrePredateProiect,
                    postProfesorInfo.ID_Cuplaj,
                    postProfesorInfo.ID_Scenariu);

                return Convert.ToInt64(result);
            }
            catch (Exception ex)
            {
                throw new DataException("Error adding PostProfesor", ex);
            }
        }

        public void PostProfesorUpdate(PostProfesorInfo postProfesorInfo)
        {
            if (postProfesorInfo == null)
                throw new ArgumentNullException(nameof(postProfesorInfo));

            try
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
            catch (Exception ex)
            {
                throw new DataException("Error updating PostProfesor", ex);
            }
        }

        public void PostProfesorDelete(long idPostProfesor)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "PostProfesorDelete", idPostProfesor);
            }
            catch (Exception ex)
            {
                throw new DataException("Error deleting PostProfesor", ex);
            }
        }
    }
}
