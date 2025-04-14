using System;
using System.Collections.Generic;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using UniApi.Info;
namespace UniApi.DAL.Repos
{

    public interface IProfesorRepo
    {
        ProfesorInfo ProfesorGet(long idProfesor);
        ProfesorInfo ProfesorGetByEmail(string emailProfesor);
        ProfesorInfo ProfesorGetByCNP(string cnp);
        ProfesorInfo ProfesorGetByUsername(string username);
        ProfesorInfo ProfesorGetByUserID(int userId);
        ProfesorInfo ProfesorGetByUsernameAnUniv(string username, long idAnUniv);
        ProfesorInfo ProfesorGetByUsernameSimplu(string username);
        ProfesorInfo ProfesorGetCVByUsername(string username);
        ProfesorInfo ProfesorGetSimplu(long idProfesor);
        List<ProfesorInfo> ProfesorListGet();
        List<ProfesorInfo> ProfesorListByAnUnivGet(long idAnUniv);
        List<ProfesorInfo> ProfesorListByAnUnivExcludeGet(long idAnUniv);
        List<ProfesorInfo> ProfesorListByCaractereGet(string caractere);
        List<ProfesorInfo> ProfesorListByCaractereAnUnivGet(string caractere, long idAnUniv);
        List<ProfesorInfo> ProfesorListByCatedraGet(long idCatedra);
        List<ProfesorInfo> ProfesorListByDetaliuPlanSemestruGet(long idDetaliuPlanSemestru);
        List<ProfesorInfo> ProfesorListByFacultateGet(long idFacultate);
        List<ProfesorInfo> ProfesorListByFacultateAnUnivGet(long idFacultate, long idAnUniv);
        List<ProfesorInfo> ProfesorListByCodEvaluareGet(string codEvaluare);
        List<ProfesorInfo> ProfesorListByDetaliuPlanSemestruProfesorGet(long idDetaliuPlanSemestruProfesor);
        List<ProfesorInfo> ProfesorListByProgramareExamenGet(long idProgramareExamen);
        List<ProfesorInfo> Profesor_ListBySpecializareSemestruGet(long idSpecializare, long idSemestru, long idAnUniv);
        List<ProfesorInfo> Profesor_ListBySpecializareSemestruEvaluareGet(long idSpecializare, long idSemestru, long idAnUniv);
        long ProfesorAdd(ProfesorInfo profesorInfo);
        void ProfesorAddOrUpdate(ProfesorInfo profesorInfo);
        void ProfesorUpdate(ProfesorInfo profesorInfo);
        void ProfesorUpdateCV(long idProfesor, byte[] cv);
        void ProfesorUpdateFisierSemnatura(long idProfesor, byte[] fisierSemnatura);
        void ProfesorDelete(long idProfesor);
        void ProfesorInlocuire(long idProfesor, long idProfesorInlocuitor, long idAnUniv);
        void ProfesorResetareCodSecuritate(long idProfesor, string codSecuritate);
        void ProfesorUpdatePasswordByUsername(string username, string newPassword);
    }

    public class ProfesorRepo : IProfesorRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public ProfesorInfo ProfesorGet(long idProfesor)
        {
            return CBO.FillObject<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "ProfesorGet", idProfesor));
        }

        public ProfesorInfo ProfesorGetByEmail(string emailProfesor)
        {
            return CBO.FillObject<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "ProfesorGetByEmail", emailProfesor));
        }

        public ProfesorInfo ProfesorGetByCNP(string cnp)
        {
            return CBO.FillObject<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "ProfesorGetByCNP", cnp));
        }

        public ProfesorInfo ProfesorGetByUsername(string username)
        {
            return CBO.FillObject<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "ProfesorGetByUsername", username));
        }

        public ProfesorInfo ProfesorGetByUserID(int userId)
        {
            return CBO.FillObject<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "ProfesorGetByUserID", userId));
        }

        public ProfesorInfo ProfesorGetByUsernameAnUniv(string username, long idAnUniv)
        {
            return CBO.FillObject<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "ProfesorGetByUsernameAnUniv", username, idAnUniv));
        }

        public ProfesorInfo ProfesorGetByUsernameSimplu(string username)
        {
            return CBO.FillObject<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "ProfesorGetByUsernameSimplu", username));
        }

        public ProfesorInfo ProfesorGetCVByUsername(string username)
        {
            return CBO.FillObject<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "ProfesorGetCVByUsername", username));
        }

        public ProfesorInfo ProfesorGetSimplu(long idProfesor)
        {
            return CBO.FillObject<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "ProfesorGetSimplu", idProfesor));
        }

        public List<ProfesorInfo> ProfesorListGet()
        {
            return CBO.FillCollection<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "ProfesorList"));
        }

        public List<ProfesorInfo> ProfesorListByAnUnivGet(long idAnUniv)
        {
            return CBO.FillCollection<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "ProfesorListByAnUniv", idAnUniv));
        }

        public List<ProfesorInfo> ProfesorListByAnUnivExcludeGet(long idAnUniv)
        {
            return CBO.FillCollection<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "ProfesorListByAnUnivExclude", idAnUniv));
        }

        public List<ProfesorInfo> ProfesorListByCaractereGet(string caractere)
        {
            return CBO.FillCollection<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "ProfesorListByCaractere", caractere));
        }

        public List<ProfesorInfo> ProfesorListByCaractereAnUnivGet(string caractere, long idAnUniv)
        {
            return CBO.FillCollection<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "ProfesorListByCaractereAnUniv", caractere, idAnUniv));
        }

        public List<ProfesorInfo> ProfesorListByCatedraGet(long idCatedra)
        {
            return CBO.FillCollection<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "ProfesorListByCatedra", idCatedra));
        }

        public List<ProfesorInfo> ProfesorListByDetaliuPlanSemestruGet(long idDetaliuPlanSemestru)
        {
            return CBO.FillCollection<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "ProfesorListByDetaliuPlanSemestru", idDetaliuPlanSemestru));
        }

        public List<ProfesorInfo> ProfesorListByFacultateGet(long idFacultate)
        {
            return CBO.FillCollection<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "ProfesorListByFacultate", idFacultate));
        }

        public List<ProfesorInfo> ProfesorListByFacultateAnUnivGet(long idFacultate, long idAnUniv)
        {
            return CBO.FillCollection<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "ProfesorListByFacultateAnUniv", idFacultate, idAnUniv));
        }

        public List<ProfesorInfo> ProfesorListByCodEvaluareGet(string codEvaluare)
        {
            return CBO.FillCollection<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "ProfesorListByCodEvaluare", codEvaluare));
        }

        public List<ProfesorInfo> ProfesorListByDetaliuPlanSemestruProfesorGet(long idDetaliuPlanSemestruProfesor)
        {
            return CBO.FillCollection<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "ProfesorListByDetaliuPlanSemestruProfesor", idDetaliuPlanSemestruProfesor));
        }

        public List<ProfesorInfo> ProfesorListByProgramareExamenGet(long idProgramareExamen)
        {
            return CBO.FillCollection<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "ProfesorListByProgramareExamen", idProgramareExamen));
        }

        public List<ProfesorInfo> Profesor_ListBySpecializareSemestruGet(long idSpecializare, long idSemestru, long idAnUniv)
        {
            return CBO.FillCollection<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "Profesor_ListBySpecializareSemestru", idSpecializare, idSemestru, idAnUniv));
        }

        public List<ProfesorInfo> Profesor_ListBySpecializareSemestruEvaluareGet(long idSpecializare, long idSemestru, long idAnUniv)
        {
            return CBO.FillCollection<ProfesorInfo>(SqlHelper.ExecuteReader(_connectionString, "Profesor_ListBySpecializareSemestruEvaluare", idSpecializare, idSemestru, idAnUniv));
        }

        public long ProfesorAdd(ProfesorInfo profesorInfo)
        {
            SqlParameter paramPK_New_ID_Profesor = new SqlParameter("@PK_New_ID_Profesor", -1)
            {
                Direction = System.Data.ParameterDirection.Output
            };

            SqlHelper.ExecuteScalar(_connectionString, "PorfesorAdd",
                profesorInfo.Marca, profesorInfo.Nume, profesorInfo.Prenume, profesorInfo.NumeScurt, profesorInfo.CNP,
                profesorInfo.Email, profesorInfo.MoodleUserId, profesorInfo.MoodleIdNumber, profesorInfo.MoodleUsername,
                profesorInfo.UserID, profesorInfo.ID_TipTitluStiintific, profesorInfo.ParolaInitiala, profesorInfo.Username,
                profesorInfo.NumeCasatorie, profesorInfo.ID_Catedra, profesorInfo.ID_Departament, profesorInfo.ID_TipGradDidactic,
                profesorInfo.ID_AnUniv, profesorInfo.Titular, profesorInfo.COD_FUN, profesorInfo.COD_SEC, profesorInfo.COD_SUB,
                paramPK_New_ID_Profesor);

            return Convert.ToInt64(paramPK_New_ID_Profesor.Value);
        }

        public void ProfesorAddOrUpdate(ProfesorInfo profesorInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ProfesorAddOrUpdate",
                profesorInfo.ID_Profesor, profesorInfo.Nume, profesorInfo.Prenume, profesorInfo.NumeCasatorie,
                profesorInfo.Marca, profesorInfo.NumeScurt, profesorInfo.CNP, profesorInfo.ID_TipTitluStiintific,
                profesorInfo.Email, profesorInfo.MoodleUserId, profesorInfo.MoodleIdNumber, profesorInfo.MoodleUsername,
                profesorInfo.Username, profesorInfo.UserID, profesorInfo.ParolaInitiala, profesorInfo.ID_Catedra,
                profesorInfo.ID_Departament, profesorInfo.ID_TipGradDidactic, profesorInfo.ID_AnUniv, profesorInfo.Titular,
                profesorInfo.COD_FUN, profesorInfo.COD_SEC, profesorInfo.COD_SUB, false);
        }

        public void ProfesorUpdate(ProfesorInfo profesorInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ProfesorUpdate",
                profesorInfo.ID_Profesor, profesorInfo.Nume, profesorInfo.Prenume, profesorInfo.NumeCasatorie,
                profesorInfo.Marca, profesorInfo.NumeScurt, profesorInfo.CNP, profesorInfo.ID_TipTitluStiintific,
                profesorInfo.Email, profesorInfo.MoodleUserId, profesorInfo.MoodleIdNumber, profesorInfo.MoodleUsername,
                profesorInfo.Username, profesorInfo.UserID, profesorInfo.ParolaInitiala, profesorInfo.ID_Catedra,
                profesorInfo.ID_Departament, profesorInfo.ID_TipGradDidactic, profesorInfo.ID_AnUniv, profesorInfo.Titular,
                profesorInfo.COD_FUN, profesorInfo.COD_SEC, profesorInfo.COD_SUB, false);
        }

        public void ProfesorUpdateCV(long idProfesor, byte[] cv)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ProfesorUpdateCV", idProfesor, cv);
        }

        public void ProfesorUpdateFisierSemnatura(long idProfesor, byte[] fisierSemnatura)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ProfesorUpdateFisierSemnatura", idProfesor, fisierSemnatura);
        }

        public void ProfesorDelete(long idProfesor)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ProfesorDelete", idProfesor);
        }

        public void ProfesorInlocuire(long idProfesor, long idProfesorInlocuitor, long idAnUniv)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ProfesorInlocuire", idProfesor, idProfesorInlocuitor, idAnUniv);
        }

        public void ProfesorResetareCodSecuritate(long idProfesor, string codSecuritate)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ProfesorResetareCodSecuritate", idProfesor, codSecuritate);
        }

        public void ProfesorUpdatePasswordByUsername(string username, string newPassword)
        {
            SqlHelper.ExecuteScalar(_connectionString, "ProfesorUpdatePasswordByUsername", username, newPassword);
        }
    }
}
