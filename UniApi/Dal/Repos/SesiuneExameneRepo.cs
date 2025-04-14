using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public interface ISesiuneExameneRepo
    {
        long SesiuneExameneAdd(SesiuneExameneInfo sesiuneExamene);
        void SesiuneExameneDeschidereSpecialaNoteDelete(long id);
        SesiuneExameneInfo SesiuneExameneDeschidereSpecialaNoteGet(long id);
        List<SesiuneExameneInfo> SesiuneExameneDeschidereSpecialaNoteListByProgramareExamenProfesor(long idProgramareExamenProfesor);
        List<SesiuneExameneInfo> SesiuneExameneDeschidereSpecialaNoteListBySesiuneProfesor(long idSesiuneExamene, long idProfesor);
        List<SesiuneExameneInfo> SesiuneExameneDeschidereSpecialaNoteListByPtAprobare(bool ptAprobare);
        List<SesiuneExameneInfo> SesiuneExameneDeschidereSpecialaNoteListByPtAprobareCuStudenti(bool ptAprobare);
        void SesiuneExameneDeschidereSpecialaNoteMerge(SesiuneExameneInfo note);
        void SesiuneExameneDeschidereSpecialaNoteUpdateAprobare(long id, bool ptAprobare);
        void SesiuneExameneDeschidereSpecialaNoteUpdateNoteSalvate(long id, string noteSalvate);
        SesiuneExameneInfo SesiuneExameneGet(long idSesiuneExamene);
        List<SesiuneExameneInfo> SesiuneExameneListByFacultateTipSesiuneExameneAnUniv(long idFacultate, int tipSesiuneExamene, long idAnUniv);
        List<SesiuneExameneInfo> SesiuneExameneListByProfesorAnUniv(long idProfesor, long idAnUniv);
        void SesiuneExameneUpdate(SesiuneExameneInfo sesiuneExamene);
    }

    public class SesiuneExameneRepo : ISesiuneExameneRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public long SesiuneExameneAdd(SesiuneExameneInfo sesiuneExamene)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "SesiuneExameneAdd",
                sesiuneExamene.DataInceput,
                sesiuneExamene.DataSfarsit,
                sesiuneExamene.ID_TipSesiuneExamene,
                sesiuneExamene.DenumireSesiuneExamene);
            return Convert.ToInt64(id);
        }

        public void SesiuneExameneDeschidereSpecialaNoteDelete(long id)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "SesiuneExameneDeschidereSpecialaNoteDelete", id);
        }

        public SesiuneExameneInfo SesiuneExameneDeschidereSpecialaNoteGet(long id)
        {
            return CBO.FillObject<SesiuneExameneInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SesiuneExameneDeschidereSpecialaNoteGet", id));
        }

        public List<SesiuneExameneInfo> SesiuneExameneDeschidereSpecialaNoteListByProgramareExamenProfesor(long idProgramareExamenProfesor)
        {
            return CBO.FillCollection<SesiuneExameneInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SesiuneExameneDeschidereSpecialaNoteListByProgramareExamenProfesor", idProgramareExamenProfesor));
        }

        public List<SesiuneExameneInfo> SesiuneExameneDeschidereSpecialaNoteListBySesiuneProfesor(long idSesiuneExamene, long idProfesor)
        {
            return CBO.FillCollection<SesiuneExameneInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SesiuneExameneDeschidereSpecialaNoteListBySesiuneProfesor", idSesiuneExamene, idProfesor));
        }

        public List<SesiuneExameneInfo> SesiuneExameneDeschidereSpecialaNoteListByPtAprobare(bool ptAprobare)
        {
            return CBO.FillCollection<SesiuneExameneInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SesiuneExameneDeschidereSpecialaNoteListByPtAprobare", ptAprobare));
        }

        public List<SesiuneExameneInfo> SesiuneExameneDeschidereSpecialaNoteListByPtAprobareCuStudenti(bool ptAprobare)
        {
            return CBO.FillCollection<SesiuneExameneInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SesiuneExameneDeschidereSpecialaNoteListByPtAprobareCuStudenti", ptAprobare));
        }

        public void SesiuneExameneDeschidereSpecialaNoteMerge(SesiuneExameneInfo note)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "SesiuneExameneDeschidereSpecialaNoteMerge",
                note.ID_SesiuneExamene,
                note.DataInceput,
                note.DataSfarsit,
                note.ID_TipSesiuneExamene,
                note.DenumireSesiuneExamene);
        }

        public void SesiuneExameneDeschidereSpecialaNoteUpdateAprobare(long id, bool ptAprobare)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "SesiuneExameneDeschidereSpecialaNoteUpdateAprobare", id, ptAprobare);
        }

        public void SesiuneExameneDeschidereSpecialaNoteUpdateNoteSalvate(long id, string noteSalvate)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "SesiuneExameneDeschidereSpecialaNoteUpdateNoteSalvate", id, noteSalvate);
        }

        public SesiuneExameneInfo SesiuneExameneGet(long idSesiuneExamene)
        {
            return CBO.FillObject<SesiuneExameneInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SesiuneExameneGet", idSesiuneExamene));
        }

        public List<SesiuneExameneInfo> SesiuneExameneListByFacultateTipSesiuneExameneAnUniv(long idFacultate, int tipSesiuneExamene, long idAnUniv)
        {
            return CBO.FillCollection<SesiuneExameneInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SesiuneExameneListByFacultateTipSesiuneExameneAnUniv", idFacultate, tipSesiuneExamene, idAnUniv));
        }

        public List<SesiuneExameneInfo> SesiuneExameneListByProfesorAnUniv(long idProfesor, long idAnUniv)
        {
            return CBO.FillCollection<SesiuneExameneInfo>(
                SqlHelper.ExecuteReader(_connectionString, "SesiuneExameneListByProfesorAnUniv", idProfesor, idAnUniv));
        }

        public void SesiuneExameneUpdate(SesiuneExameneInfo sesiuneExamene)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "SesiuneExameneUpdate",
                sesiuneExamene.ID_SesiuneExamene,
                sesiuneExamene.DataInceput,
                sesiuneExamene.DataSfarsit,
                sesiuneExamene.ID_TipSesiuneExamene,
                sesiuneExamene.DenumireSesiuneExamene);
        }
    }
}
