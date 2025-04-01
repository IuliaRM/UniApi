using System;
using UniApi.Info;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using DotNetNuke.Common.Utilities;

namespace UniApi.Dal.Repos
{
    public class LichidareRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public void LichidareSecretariatMerge(long ID_Lichidare, long ID_Absolvent, long ID_Student, long ID_AnUniv, long ID_Specializare, string UsernameInitiere)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "Lichidare_SecretariatMerge", ID_Lichidare, ID_Absolvent, ID_Student, ID_AnUniv, ID_Specializare, UsernameInitiere);
        }

        public void LichidareInitiereAutomata()
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "Lichidare_InitiereAutomata");
        }

        public void LichidareSecretariatDeselecteaza(long ID_Lichidare, string Username, string ColoanaDebifata)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "Lichidare_SecretariatDeselecteaza", ID_Lichidare, Username, ColoanaDebifata);
        }

        public LichidareInfo LichidareStudentByIDGet(long ID_Lichidare)
        {
            return CBO.FillObject<LichidareInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "Lichidare_GetStudentByID", ID_Lichidare));
        }
    }
}
