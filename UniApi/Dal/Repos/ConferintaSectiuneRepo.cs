using System;
using System.Collections.Generic;
using System.Configuration;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Dal.Repos;
using UniApi.Info;


namespace UniApi.Dal.Repos
{
    public class ConferintaSectiuneRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public ConferintaSectiuneInfo ConferintaSectiuneGet(long idConferintaSectiune)
        {
            return CBO.FillObject<ConferintaSectiuneInfo>(SqlHelper.ExecuteReader(_ConnectionString, "ConferintaSectiuneGet", idConferintaSectiune));
        }

        public List<ConferintaSectiuneInfo> ConferintaSectiuneList()
        {
            return CBO.FillCollection<ConferintaSectiuneInfo>(SqlHelper.ExecuteReader(_ConnectionString, "ConferintaSectiuneList"));
        }

        public List<ConferintaSectiuneInfo> ConferintaSectiuneListByConferinta(long idConferinta)
        {
            return CBO.FillCollection<ConferintaSectiuneInfo>(SqlHelper.ExecuteReader(_ConnectionString, "ConferintaSectiuneListByConferinta", idConferinta));
        }

        public long ConferintaSectiuneAdd(ConferintaSectiuneInfo objConferintaSectiune)
        {
            object o = SqlHelper.ExecuteScalar(_ConnectionString, "ConferintaSectiuneAdd", objConferintaSectiune.ID_Conferinta, objConferintaSectiune.DenumireSectiuneConferinta, objConferintaSectiune.NumarParticipantiSectiune, objConferintaSectiune.NumarLucrariSectiune);
            return Convert.ToInt64(o);
        }

        public void ConferintaSectiuneUpdate(ConferintaSectiuneInfo objConferintaSectiune)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "ConferintaSectiuneUpdate", objConferintaSectiune.ID_ConferintaSectiune, objConferintaSectiune.ID_Conferinta, objConferintaSectiune.DenumireSectiuneConferinta, objConferintaSectiune.NumarParticipantiSectiune, objConferintaSectiune.NumarLucrariSectiune);
        }

        public void ConferintaSectiuneDelete(long idConferintaSectiune)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "ConferintaSectiuneDelete", idConferintaSectiune);
        }
    }
}
