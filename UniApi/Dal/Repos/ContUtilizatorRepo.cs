using System;
using System.Collections.Generic;
using System.Configuration;
using UniApi.Models;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Dal.Repos;
using DotNetNuke.Common.Utilities;

namespace UniApi.Dal.Repos
{
    public class ContUtilizatorRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public ContUtilizatorInfo ContUtilizatorGet(long idContUtilizator)
        {
            return CBO.FillObject<ContUtilizatorInfo>(SqlHelper.ExecuteReader(_ConnectionString, "ContUtilizatorGet", idContUtilizator));
        }

        public List<ContUtilizatorInfo> ContUtilizatorList()
        {
            return CBO.FillCollection<ContUtilizatorInfo>(SqlHelper.ExecuteReader(_ConnectionString, "ContUtilizatorList"));
        }

        public ContUtilizatorInfo ContUtilizatorGetByCNP(string cnp)
        {
            return CBO.FillObject<ContUtilizatorInfo>(SqlHelper.ExecuteReader(_ConnectionString, "ContUtilizatorGetByCNP", cnp));
        }

        public long ContUtilizatorAdd(ContUtilizatorInfo objContUtilizator)
        {
            object o = SqlHelper.ExecuteScalar(_ConnectionString, "ContUtilizatorAdd",
                objContUtilizator.Nume, objContUtilizator.Prenume, objContUtilizator.Username,
                objContUtilizator.EmailAlternativ, objContUtilizator.CNP, objContUtilizator.Marca,
                objContUtilizator.TipUtilizator, objContUtilizator.TipIncadrare, objContUtilizator.TipPersonal,
                objContUtilizator.FacultateServiciu, objContUtilizator.DepartamentCompartiment,
                objContUtilizator.Functie, objContUtilizator.RolPrincipal);
            return Convert.ToInt64(o);
        }

        public void ContUtilizatorUpdate(ContUtilizatorInfo objContUtilizator)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "ContUtilizatorUpdate",
                objContUtilizator.ID_ContUtilizator, objContUtilizator.Nume, objContUtilizator.Prenume,
                objContUtilizator.Username, objContUtilizator.EmailAlternativ, objContUtilizator.CNP,
                objContUtilizator.Marca, objContUtilizator.TipUtilizator, objContUtilizator.TipIncadrare,
                objContUtilizator.TipPersonal, objContUtilizator.FacultateServiciu,
                objContUtilizator.DepartamentCompartiment, objContUtilizator.Functie,
                objContUtilizator.RolPrincipal);
        }

        public void ContUtilizatorDelete(long idContUtilizator)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "ContUtilizatorDelete", idContUtilizator);
        }

        public void ContUtilizatorDeleteByCNP(string cnp)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "ContUtilizatorDeleteByCNP", cnp);
        }
    }
}
