using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class ProgramareExamenRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public long ProgramareExamenMerge(long ID_ProgramareExamen, long ID_DetaliuPlanSemestru, long ID_SesiuneExameneSpecializare, long ID_Grupa, DateTime Data, string Sala, int ID_TipExaminare,  long ID_ProfesorTitularCurs)
        {
            object o = SqlHelper.ExecuteScalar(_connectionString, "PE.ProgramareExamenMerge", ID_ProgramareExamen, ID_DetaliuPlanSemestru, ID_SesiuneExameneSpecializare, ID_Grupa, Data, Sala,  ID_TipExaminare,  ID_ProfesorTitularCurs);

            long ID_ProgramareExamenBD = -1;
            if (o != null && long.TryParse(o.ToString(), out ID_ProgramareExamenBD))
            {
                return ID_ProgramareExamenBD;
            }
            return ID_ProgramareExamenBD;
        }

        public void ProgramareExamenStudentMerge(long ID_ProgramareExamen, long ID_DetaliuPlanSemestru, long ID_DetaliuPlanSemestruStudent, long ID_SesiuneExameneSpecializare, long ID_Student, long ID_Grupa)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "PE.ProgramareExamenStudentMerge", ID_ProgramareExamen, ID_DetaliuPlanSemestru, ID_DetaliuPlanSemestruStudent, ID_SesiuneExameneSpecializare, ID_Student, ID_Grupa);
        }

        public void ProgramareExameneTiparitUpdate(long ID_ProgramareExamen, bool Tiparit, DateTime data, string username)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "PE.ProgramareExameneUpdateTiparit", ID_ProgramareExamen, Tiparit, data, username);
        }

        public void ProgramareExameneTitularSemnatUpdate(long ID_ProgramareExamen, bool semnat, DateTime data, string username)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "PE.ProgramareExameneUpdateTitularSemnat", ID_ProgramareExamen, semnat, data, username);
        }

        public void ProgramareExameneAsistentExamenSemnatUpdate(long ID_ProgramareExamen, bool semnat, DateTime data, string username)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "PE.ProgramareExameneUpdateAsistentExamenSemnat", ID_ProgramareExamen, semnat, data, username);
        }

        public ProgramareExamenInfo ProgramareExamenGet(long ID_ProgramareExamen)
        {
            return CBO.FillObject<ProgramareExamenInfo>(SqlHelper.ExecuteReader(_connectionString, "PE.ProgramareExamenGet", ID_ProgramareExamen));
        }

        public List<SalaInfo> SalaListCaractereGet(string Caractere)
        {
            return CBO.FillCollection<SalaInfo>(SqlHelper.ExecuteReader(_connectionString, "[sali].[SalaListCaractere]", Caractere));
        }

        public SalaInfo SalaGet(long ID_Sala)
        {
            return CBO.FillObject<SalaInfo>(SqlHelper.ExecuteReader(_connectionString, "[sali].[SalaGet]", ID_Sala));
        }

        public void ProgramareExamenFinalizareNote(long ID_ProgramareExamen, int userid)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "PE.ProgramareExamenFinalizareNote", ID_ProgramareExamen, userid);
        }

        public void ProgramareExamenMarcheazaNoteSalvate(long ID_ProgramareExamen, int userid, bool valoare)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "PE.ProgramareExamenUpdateNoteSalvate", ID_ProgramareExamen, userid, valoare);
        }
    }
}
