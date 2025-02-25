using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using DotNetNuke.Common.Utilities;

namespace UniApi.Dal.Repos
{
    public class LichidareRepo
    {
        private readonly string _ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public void LichidareSecretariatMerge(long ID_Lichidare, long ID_Absolvent, long ID_Student, long ID_AnUniv, long ID_Specializare, string usernameInitiere)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "LichidareSecretariatMerge", ID_Lichidare, ID_Absolvent, ID_Student, ID_AnUniv, ID_Specializare, usernameInitiere);
        }

        public void LichidareInitiereAutomata()
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "LichidareInitiereAutomata");
        }

        public void LichidareSecretariatDeselecteaza(long ID_Lichidare, string username, string coloanaDebifata)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "LichidareSecretariatDeselecteaza", ID_Lichidare, username, coloanaDebifata);
        }

        public LichidareInfo LichidareStudentGetByID_Lichidare(long ID_Lichidare)
        {
            return CBO.FillObject<LichidareInfo>(SqlHelper.ExecuteReader(_ConnectionString, "LichidareStudentGetByID_Lichidare", ID_Lichidare));
        }
    }
}
