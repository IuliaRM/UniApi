using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public class DetaliuPlanSemestruProfesorCuplajRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public DetaliuPlanSemestruProfesorCuplajInfo IdGet(long ID_DetaliuPlanSemestruProfesorCuplaj)
        {
            return CBO.FillObject<DetaliuPlanSemestruProfesorCuplajInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "DetaliuPlanSemestruProfesorCuplaj_GetById", ID_DetaliuPlanSemestruProfesorCuplaj)
            );
        }

        public List<DetaliuPlanSemestruProfesorCuplajInfo> AllGet()
        {
            return CBO.FillCollection<DetaliuPlanSemestruProfesorCuplajInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "DetaliuPlanSemestruProfesorCuplaj_GetAll")
            );
        }

        public List<DetaliuPlanSemestruProfesorCuplajInfo> DetaliuPlanSemestruProfesorByGet(long ID_DetaliuPlanSemestruProfesor)
        {
            return CBO.FillCollection<DetaliuPlanSemestruProfesorCuplajInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "DetaliuPlanSemestruProfesorCuplaj_GetByDetaliuPlanSemestruProfesor", ID_DetaliuPlanSemestruProfesor)
            );
        }

        public List<DetaliuPlanSemestruProfesorCuplajInfo> DetaliuPlanSemestruProfesorCuplajByGet(long ID_DetaliuPlanSemestruProfesor, long ID_Cuplaj)
        {
            return CBO.FillCollection<DetaliuPlanSemestruProfesorCuplajInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "DetaliuPlanSemestruProfesorCuplaj_GetByDetaliuPlanSemestruProfesorCuplaj", ID_DetaliuPlanSemestruProfesor, ID_Cuplaj)
            );
        }

        public List<DetaliuPlanSemestruProfesorCuplajInfo> DetaliuCuplajByGet(long ID_DetaliuCuplaj)
        {
            return CBO.FillCollection<DetaliuPlanSemestruProfesorCuplajInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "DetaliuPlanSemestruProfesorCuplaj_GetByDetaliuCuplaj", ID_DetaliuCuplaj)
            );
        }

        public int AddPost(DetaliuPlanSemestruProfesorCuplajInfo objDetaliuPlanSemestruProfesorCuplaj)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(_ConnectionString, "DetaliuPlanSemestruProfesorCuplaj_Add",
                objDetaliuPlanSemestruProfesorCuplaj.ID_DetaliuPlanSemestruProfesor,
                objDetaliuPlanSemestruProfesorCuplaj.ID_Cuplaj,
                objDetaliuPlanSemestruProfesorCuplaj.Observatii));
        }

        public void UpdatePut(DetaliuPlanSemestruProfesorCuplajInfo objDetaliuPlanSemestruProfesorCuplaj)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "DetaliuPlanSemestruProfesorCuplaj_Update",
                objDetaliuPlanSemestruProfesorCuplaj.ID_DetaliuPlanSemestruProfesorCuplaj,
                objDetaliuPlanSemestruProfesorCuplaj.ID_DetaliuPlanSemestruProfesor,
                objDetaliuPlanSemestruProfesorCuplaj.ID_Cuplaj,
                objDetaliuPlanSemestruProfesorCuplaj.Observatii);
        }

        public void DeleteDelete(DetaliuPlanSemestruProfesorCuplajInfo objDetaliuPlanSemestruProfesorCuplaj)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "DetaliuPlanSemestruProfesorCuplaj_Delete",
                objDetaliuPlanSemestruProfesorCuplaj.ID_DetaliuPlanSemestruProfesorCuplaj);
        }

        public void DeleteByPostProfesorDelete(long ID_DetaliuPlanSemestruProfesorCuplaj, long ID_PostProfesor)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "DetaliuPlanSemestruProfesorCuplaj_DeleteByPostProfesor",
                ID_DetaliuPlanSemestruProfesorCuplaj, ID_PostProfesor);
        }
    }
}
