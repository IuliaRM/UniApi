using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IOfertaPracticaRepo
    {
        OfertaPractica OfertaPracticaGet(long idOfertaPractica);
        List<OfertaPractica> OfertaPracticaListGet();
        List<OfertaPractica> OfertaPracticaListByUserIDPortalGet(int idUserPortal);
        long OfertaPracticaAdd(OfertaPractica info);
        void OfertaPracticaUpdate(OfertaPractica info);
        void OfertaPracticaDelete(long idOfertaPractica);
    }

    public class OfertaPracticaRepo : IOfertaPracticaRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public OfertaPractica OfertaPracticaGet(long idOfertaPractica)
        {
            try
            {
                return CBO.FillObject<OfertaPractica>(
                    SqlHelper.ExecuteReader(_connectionString, "OfertaPractica_Get", idOfertaPractica));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la OfertaPracticaGet", ex);
            }
        }

        public List<OfertaPractica> OfertaPracticaListGet()
        {
            try
            {
                return CBO.FillCollection<OfertaPractica>(
                    SqlHelper.ExecuteReader(_connectionString, "OfertaPractica_GetList"));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la OfertaPracticaListGet", ex);
            }
        }

        public List<OfertaPractica> OfertaPracticaListByUserIDPortalGet(int idUserPortal)
        {
            try
            {
                return CBO.FillCollection<OfertaPractica>(
                    SqlHelper.ExecuteReader(_connectionString, "OfertaPractica_GetListByUserIDPortal", idUserPortal));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la OfertaPracticaListByUserIDPortalGet", ex);
            }
        }

        public long OfertaPracticaAdd(OfertaPractica info)
        {
            try
            {
                return Convert.ToInt64(SqlHelper.ExecuteScalar(_connectionString, "OfertaPractica_Add", info));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la OfertaPracticaAdd", ex);
            }
        }

        public void OfertaPracticaUpdate(OfertaPractica info)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "OfertaPractica_Update", info);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la OfertaPracticaUpdate", ex);
            }
        }

        public void OfertaPracticaDelete(long idOfertaPractica)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "OfertaPractica_Delete", idOfertaPractica);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la OfertaPracticaDelete", ex);
            }
        }
    }
}
