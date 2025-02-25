
using System;
using System.Collections.Generic;
using UniTBv.AGSIS;
using Microsoft.ApplicationBlocks.Data;

namespace UniApi.Dal.Repos
{
    public class DetaliuPlanSemestruProfesorCuplajRepo
    {
        private readonly string _connectionString;

        public DetaliuPlanSemestruProfesorCuplajRepo()
        {
            _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;
        }

        public DetaliuPlanSemestruProfesorCuplajInfo GetById(long ID_DetaliuPlanSemestruProfesorCuplaj)
        {
            return CBO.FillObject<DetaliuPlanSemestruProfesorCuplajInfo>(
                SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruProfesorCuplajGet", ID_DetaliuPlanSemestruProfesorCuplaj)
            );
        }

        public List<DetaliuPlanSemestruProfesorCuplajInfo> GetAll()
        {
            return CBO.FillCollection<DetaliuPlanSemestruProfesorCuplajInfo>(
                SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruProfesorCuplajList")
            );
        }

        public List<DetaliuPlanSemestruProfesorCuplajInfo> GetByDetaliuPlanSemestruProfesor(long ID_DetaliuPlanSemestruProfesor)
        {
            return CBO.FillCollection<DetaliuPlanSemestruProfesorCuplajInfo>(
                SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruProfesorCuplajListByDetaliuPlanSemestruProfesor", ID_DetaliuPlanSemestruProfesor)
            );
        }

        public List<DetaliuPlanSemestruProfesorCuplajInfo> GetByDetaliuPlanSemestruProfesor(long ID_DetaliuPlanSemestruProfesor, long ID_Cuplaj)
        {
            return CBO.FillCollection<DetaliuPlanSemestruProfesorCuplajInfo>(
                SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruProfesorCuplajListByDetaliuPlanSemestruProfesor", ID_DetaliuPlanSemestruProfesor, ID_Cuplaj)
            );
        }

        public List<
