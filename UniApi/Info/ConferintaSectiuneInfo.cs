using System;
namespace UniApi.Info
{
    public partial class ConferintaSectiuneInfo
    {
        long _iD_ConferintaSectiune;
        long _iD_Conferinta;
        string _denumireSectiuneConferinta;
        int _numarParticipantiSectiune;
        int _numarLucrariSectiune;

        public ConferintaSectiuneInfo()
        {
        }

        public ConferintaSectiuneInfo(long iD_ConferintaSectiune, long iD_Conferinta, string denumireSectiuneConferinta, int numarParticipantiSectiune, int numarLucrariSectiune)
        {
            this.ID_ConferintaSectiune = iD_ConferintaSectiune;
            this.ID_Conferinta = iD_Conferinta;
            this.DenumireSectiuneConferinta = denumireSectiuneConferinta;
            this.NumarParticipantiSectiune = numarParticipantiSectiune;
            this.NumarLucrariSectiune = numarLucrariSectiune;
        }

        public long ID_ConferintaSectiune
        {
            get { return _iD_ConferintaSectiune; }
            set { _iD_ConferintaSectiune = value; }
        }

        public long ID_Conferinta
        {
            get { return _iD_Conferinta; }
            set { _iD_Conferinta = value; }
        }

        public string DenumireSectiuneConferinta
        {
            get { return _denumireSectiuneConferinta; }
            set { _denumireSectiuneConferinta = value; }
        }

        public int NumarParticipantiSectiune
        {
            get { return _numarParticipantiSectiune; }
            set { _numarParticipantiSectiune = value; }
        }

        public int NumarLucrariSectiune
        {
            get { return _numarLucrariSectiune; }
            set { _numarLucrariSectiune = value; }
        }
    }
}
