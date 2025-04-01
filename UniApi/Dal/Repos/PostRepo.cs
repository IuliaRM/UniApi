using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class PostRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public PostInfo PostGet(long idPost)
        {
            return CBO.FillObject<PostInfo>(SqlHelper.ExecuteReader(_connectionString, "PostGet", idPost));
        }

        public List<PostInfo> PostListGet()
        {
            return CBO.FillCollection<PostInfo>(SqlHelper.ExecuteReader(_connectionString, "PostList"));
        }

        public List<PostInfo> PostListByAnUniversitarGet(long idAnUniv, long idScenariu)
        {
            return CBO.FillCollection<PostInfo>(SqlHelper.ExecuteReader(_connectionString, "PostListByAnUniversitar", idAnUniv, idScenariu));
        }

        public List<PostInfo> PostListByCatedraGet(long idCatedra, long idAnUniv, long idScenariu)
        {
            return CBO.FillCollection<PostInfo>(SqlHelper.ExecuteReader(_connectionString, "PostListByCatedra", idCatedra, idAnUniv, idScenariu));
        }

        public int PostAdd(PostInfo postInfo)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(_connectionString, "PostAdd",
                postInfo.ID_AnUniv,
                postInfo.NrPozitie,
                postInfo.TotalOreConventionale,
                postInfo.TipPost,
                postInfo.ModPlata,
                postInfo.ID_Catedra,
                postInfo.OwnerID,
                postInfo.Status,
                postInfo.ID_Scenariu));
        }

        public void PostUpdate(PostInfo postInfo)
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

        public void PostDelete(PostInfo postInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "PostDelete", postInfo.ID_Post);
        }

        public decimal PostCalculOreConventionale(long idPost)
        {
            object result = SqlHelper.ExecuteScalar(_connectionString, "OreConventionaleByPost", idPost);
            return result == DBNull.Value ? -1 : Convert.ToDecimal(result);
        }
    }
}
