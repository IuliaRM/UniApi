using System;
using System.Collections.Generic;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class ProfesorRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public ProfesorInfo ProfesorGet(long idProfesor)
        {
            return CBO.FillObject<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "ProfesorGet", idProfesor));
        }

        public ProfesorInfo ProfesorByEmailGet(string emailProfesor)
        {
            return CBO.FillObject<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "ProfesorGetByEmail", emailProfesor));
        }

        public ProfesorInfo ProfesorByCNPGet(string cnp)
        {
            return CBO.FillObject<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "ProfesorGetByCNP", cnp));
        }

        public ProfesorInfo ProfesorByUsernameGet(string username)
        {
            return CBO.FillObject<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "ProfesorGetByUsername", username));
        }

        public List<ProfesorInfo> ProfesorListGet()
        {
            return CBO.FillCollection<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "ProfesorList"));
        }

        public List<ProfesorInfo> ProfesorListByAnUnivGet(long idAnUniv)
        {
            return CBO.FillCollection<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "ProfesorListByAnUniv", idAnUniv));
        }

        public List<ProfesorInfo> ProfesorListByCatedraGet(long idCatedra)
        {
            return CBO.FillCollection<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "ProfesorListByCatedra", idCatedra));
        }

        public List<ProfesorInfo> ProfesorListByFacultateGet(long idFacultate)
        {
            return CBO.FillCollection<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "ProfesorListByFacultate", idFacultate));
        }

        public long ProfesorAdd(ProfesorInfo profesorInfo)
        {
            SqlParameter paramPK_New_ID_Profesor = new SqlParameter("@PK_New_ID_Profesor", -1)
            {
                Direction = System.Data.ParameterDirection.Output
            };

            object obj = SqlHelper.ExecuteScalar(_connectionString, "ProfesorAdd", profesorInfo.Marca, profesorInfo.Nume, profesorInfo.Prenume, profesorInfo.NumeScurt, profesorInfo.CNP, profesorInfo.Email, profesorInfo.MoodleUserId, profesorInfo.MoodleIdNumber, profesorInfo.MoodleUsername, profesorInfo.UserID, profesorInfo.ID_TipTitluStiintific, profesorInfo.ParolaInitiala, profesorInfo.Username, profesorInfo.NumeCasatorie, profesorInfo.ID_Catedra, profesorInfo.ID_Departament, profesorInfo.ID_TipGradDidactic, profesorInfo.ID_AnUniv, profesorInfo.Titular, profesorInfo.COD_FUN, profesorInfo.COD_SEC, profesorInfo.COD_SUB, paramPK_New_ID_Profesor);

            return Convert.ToInt64(obj);
        }

        public void ProfesorUpdate(ProfesorInfo profesorInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ProfesorUpdate", profesorInfo.ID_Profesor, profesorInfo.Nume, profesorInfo.Prenume, profesorInfo.NumeCasatorie, profesorInfo.Marca, profesorInfo.NumeScurt, profesorInfo.CNP, profesorInfo.ID_TipTitluStiintific, profesorInfo.Email, profesorInfo.MoodleUserId, profesorInfo.MoodleIdNumber, profesorInfo.MoodleUsername, profesorInfo.Username, profesorInfo.UserID, profesorInfo.ParolaInitiala, profesorInfo.ID_Catedra, profesorInfo.ID_Departament, profesorInfo.ID_TipGradDidactic, profesorInfo.ID_AnUniv, profesorInfo.Titular, profesorInfo.COD_FUN, profesorInfo.COD_SEC, profesorInfo.COD_SUB, false);
        }

        public void ProfesorDelete(long idProfesor)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ProfesorDelete", idProfesor);
        }

        public void ProfesorPasswordUpdate(string username, string newPassword)
        {
            SqlHelper.ExecuteScalar(_connectionString, "ProfesorUpdatePasswordByUsername", username, newPassword);
        }
    }
}
