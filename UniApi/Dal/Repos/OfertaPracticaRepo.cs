using System;
using System.Collections.Generic;
using UniApi.Info;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using DotNetNuke.Common.Utilities;

namespace UniApi.Dal.Repos
{
    public class OfertaPracticaRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public OfertaPractica OfertaPracticaGet(long ID_OfertaPractica)
        {
            return CBO.FillObject<OfertaPractica>(
                SqlHelper.ExecuteReader(_ConnectionString, "OfertaPractica_Get", ID_OfertaPractica));
        }

        public List<OfertaPractica> OfertaPracticaListGet()
        {
            return CBO.FillCollection<OfertaPractica>(
                SqlHelper.ExecuteReader(_ConnectionString, "OfertaPractica_GetList"));
        }

        public List<OfertaPractica> OfertaPracticaListByUserIDPortalGet(int ID_UserPortal)
        {
            return CBO.FillCollection<OfertaPractica>(
                SqlHelper.ExecuteReader(_ConnectionString, "OfertaPractica_GetListByUserIDPortal", ID_UserPortal));
        }

        public void OfertaPracticaAdd(OfertaPractica objOfertaPractica)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "OfertaPractica_Add", objOfertaPractica);
        }

        public void OfertaPracticaUpdate(OfertaPractica objOfertaPractica)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "OfertaPractica_Update", objOfertaPractica);
        }

        public void OfertaPracticaDelete(long ID_OfertaPractica)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "OfertaPractica_Delete", ID_OfertaPractica);
        }
    }
}
