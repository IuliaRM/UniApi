using System;
using System.Collections.Generic;
using System.Configuration;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IOfertaPracticaFacultateRepo
    {
        OfertaPracticaFacultate OfertaPracticaFacultateGet(long idOfertaPracticaFacultate);
        List<OfertaPracticaFacultate> OfertaPracticaFacultateList();
        List<OfertaPracticaFacultate> OfertaPracticaFacultateListByFacAnStudSpecializDomFC(long idFacultate, long idAnStudiu, long idSpecializare, long idDomeniu, long idFC, int status, DateTime dataValabilitate);
        List<OfertaPracticaFacultate> OfertaPracticaFacultateListByFacAnStudFC(long idFacultate, long idAnStudiu, long idFC, int status, DateTime dataValabilitate);
        List<OfertaPracticaFacultate> OfertaPracticaFacultateListByIdOfertaPractica(long idOfertaPractica);
        long OfertaPracticaFacultateAdd(OfertaPracticaFacultate info);
        void OfertaPracticaFacultateUpdate(OfertaPracticaFacultate info);
        void OfertaPracticaFacultateDelete(long idOfertaPracticaFacultate);
    }

    public class OfertaPracticaFacultateRepo : IOfertaPracticaFacultateRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public OfertaPracticaFacultate OfertaPracticaFacultateGet(long idOfertaPracticaFacultate)
        {
            try
            {
                return CBO.FillObject<OfertaPracticaFacultate>(
                    SqlHelper.ExecuteReader(_connectionString, "OfertaPracticaFacultate_Get", idOfertaPracticaFacultate));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la OfertaPracticaFacultateGet", ex);
            }
        }

        public List<OfertaPracticaFacultate> OfertaPracticaFacultateList()
        {
            try
            {
                return CBO.FillCollection<OfertaPracticaFacultate>(
                    SqlHelper.ExecuteReader(_connectionString, "OfertaPracticaFacultate_GetList"));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la OfertaPracticaFacultateList", ex);
            }
        }

        public List<OfertaPracticaFacultate> OfertaPracticaFacultateListByFacAnStudSpecializDomFC(long idFacultate, long idAnStudiu, long idSpecializare, long idDomeniu, long idFC, int status, DateTime dataValabilitate)
        {
            try
            {
                return CBO.FillCollection<OfertaPracticaFacultate>(
                    SqlHelper.ExecuteReader(_connectionString, "OfertaPracticaFacultate_GetListByFacAnStudSpecializDomFC", idFacultate, idAnStudiu, idSpecializare, idDomeniu, idFC, status, dataValabilitate));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la OfertaPracticaFacultateListByFacAnStudSpecializDomFC", ex);
            }
        }

        public List<OfertaPracticaFacultate> OfertaPracticaFacultateListByFacAnStudFC(long idFacultate, long idAnStudiu, long idFC, int status, DateTime dataValabilitate)
        {
            try
            {
                return CBO.FillCollection<OfertaPracticaFacultate>(
                    SqlHelper.ExecuteReader(_connectionString, "OfertaPracticaFacultate_GetListByFacAnStudFC", idFacultate, idAnStudiu, idFC, status, dataValabilitate));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la OfertaPracticaFacultateListByFacAnStudFC", ex);
            }
        }

        public List<OfertaPracticaFacultate> OfertaPracticaFacultateListByIdOfertaPractica(long idOfertaPractica)
        {
            try
            {
                return CBO.FillCollection<OfertaPracticaFacultate>(
                    SqlHelper.ExecuteReader(_connectionString, "OfertaPracticaFacultate_GetListByIdOfertaPractica", idOfertaPractica));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la OfertaPracticaFacultateListByIdOfertaPractica", ex);
            }
        }

        public long OfertaPracticaFacultateAdd(OfertaPracticaFacultate info)
        {
            try
            {
                return Convert.ToInt64(SqlHelper.ExecuteScalar(_connectionString, "OfertaPracticaFacultate_Add", info));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la OfertaPracticaFacultateAdd", ex);
            }
        }

        public void OfertaPracticaFacultateUpdate(OfertaPracticaFacultate info)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "OfertaPracticaFacultate_Update", info);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la OfertaPracticaFacultateUpdate", ex);
            }
        }

        public void OfertaPracticaFacultateDelete(long idOfertaPracticaFacultate)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "OfertaPracticaFacultate_Delete", idOfertaPracticaFacultate);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la OfertaPracticaFacultateDelete", ex);
            }
        }
    }
}
