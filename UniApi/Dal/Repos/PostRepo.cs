using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using System.Data;
using UniApi.Info;

namespace UniApi.DAL.Repos
{

    public interface IPostRepo
    {
        // Basic CRUD operations
        PostInfo PostGet(long idPost);
        int PostAdd(PostInfo postInfo);
        void PostUpdate(PostInfo postInfo);
        void PostDelete(PostInfo postInfo);

        // List operations
        List<PostInfo> PostList();
        List<PostInfo> PostListByAnUniversitar(long idAnUniv, long idScenariu);
        List<PostInfo> PostListByCatedra(long idCatedra, long idAnUniv, long idScenariu);
        List<PostInfo> PostListByCuplaj(long idCuplaj, long idAnUniv, long idScenariu);

        // Calculation operations
        decimal PostCalculProcentOreConventionaleByPostProfesor(long idPost);
        decimal PostCalculProcentOreConventionaleByProfesor(long idProfesor, long idAnUniv);
        decimal PostCalculProcentOreConventionaleByProfesorSemestru(long idProfesor, long idAnUniv, int semestru);
    }

    public class PostRepo : IPostRepo
    {
        private readonly string _connectionString;

        public PostRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;

            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found.");
        }

        public PostInfo PostGet(long idPost)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "PostGet", idPost))
                {
                    return CBO.FillObject<PostInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error in PostGet", ex);
            }
        }

        public int PostAdd(PostInfo postInfo)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(_connectionString, "PostAdd",
                    postInfo.ID_AnUniv,
                    postInfo.NrPozitie,
                    postInfo.TotalOreConventionale,
                    postInfo.TipPost,
                    postInfo.ModPlata,
                    postInfo.ID_Catedra,
                    postInfo.OwnerID,
                    postInfo.Status,
                    postInfo.ID_Scenariu);

                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                throw new DataException("Error in PostAdd", ex);
            }
        }

        public void PostUpdate(PostInfo postInfo)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "PostUpdate",
                    postInfo.ID_Post,
                    postInfo.ID_AnUniv,
                    postInfo.NrPozitie,
                    postInfo.TotalOreConventionale,
                    postInfo.TipPost,
                    postInfo.ModPlata,
                    postInfo.ID_Catedra,
                    postInfo.OwnerID,
                    postInfo.Status,
                    postInfo.ID_Scenariu);
            }
            catch (Exception ex)
            {
                throw new DataException("Error in PostUpdate", ex);
            }
        }

        public void PostDelete(PostInfo postInfo)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "PostDelete", postInfo.ID_Post);
            }
            catch (Exception ex)
            {
                throw new DataException("Error in PostDelete", ex);
            }
        }

        public List<PostInfo> PostList()
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "PostList"))
                {
                    return CBO.FillCollection<PostInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error in PostList", ex);
            }
        }

        public List<PostInfo> PostListByAnUniversitar(long idAnUniv, long idScenariu)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "PostListByAnUniversitar", idAnUniv, idScenariu))
                {
                    return CBO.FillCollection<PostInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error in PostListByAnUniversitar", ex);
            }
        }

        public List<PostInfo> PostListByCatedra(long idCatedra, long idAnUniv, long idScenariu)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "PostListByCatedra", idCatedra, idAnUniv, idScenariu))
                {
                    return CBO.FillCollection<PostInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error in PostListByCatedra", ex);
            }
        }

        public List<PostInfo> PostListByCuplaj(long idCuplaj, long idAnUniv, long idScenariu)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "PostListByCuplaj", idCuplaj, idAnUniv, idScenariu))
                {
                    return CBO.FillCollection<PostInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error in PostListByCuplaj", ex);
            }
        }

        public decimal PostCalculProcentOreConventionaleByPostProfesor(long idPost)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(_connectionString, "PostCalculProcentOreConventionaleByPostProfesor", idPost);
                return result == DBNull.Value ? -1 : Convert.ToDecimal(result);
            }
            catch (Exception ex)
            {
                throw new DataException("Error in PostCalculProcentOreConventionaleByPostProfesor", ex);
            }
        }

        public decimal PostCalculProcentOreConventionaleByProfesor(long idProfesor, long idAnUniv)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(_connectionString, "PostCalculProcentOreConventionaleByProfesor", idProfesor, idAnUniv);
                return result == DBNull.Value ? -1 : Convert.ToDecimal(result);
            }
            catch (Exception ex)
            {
                throw new DataException("Error in PostCalculProcentOreConventionaleByProfesor", ex);
            }
        }

        public decimal PostCalculProcentOreConventionaleByProfesorSemestru(long idProfesor, long idAnUniv, int semestru)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(_connectionString, "PostCalculProcentOreConventionaleByProfesorSemestru", idProfesor, idAnUniv, semestru);
                return result == DBNull.Value ? -1 : Convert.ToDecimal(result);
            }
            catch (Exception ex)
            {
                throw new DataException("Error in PostCalculProcentOreConventionaleByProfesorsemestru", ex);
            }
        }
    }
}
