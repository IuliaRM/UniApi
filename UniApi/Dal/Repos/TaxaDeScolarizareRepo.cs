using System;
using System.Collections.Generic;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{

    public interface ITaxaDeScolarizareRepo
    {
        List<TaxaStudentInfo> TaxaScolaiareListByFacultateCicluForma(long idFacultate, long idCicluStudiu, long idFormaInvatamant, long idAnUniversitar);
    }

    public class TaxaDeScolarizareRepo : ITaxaDeScolarizareRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public List<TaxaStudentInfo> TaxaScolaiareListByFacultateCicluForma(long idFacultate, long idCicluStudiu, long idFormaInvatamant, long idAnUniversitar)
        {
            return CBO.FillCollection<TaxaStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TaxaScolaiareListByFacultateCicluForma", idFacultate, idCicluStudiu, idFormaInvatamant, idAnUniversitar));
        }
    }
}
