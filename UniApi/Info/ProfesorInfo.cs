namespace UniApi.Info
{
	public partial class ProfesorInfo
	{
		private string _nume;
		private string _prenume;

		#region "Constructors"

		public ProfesorInfo()
		{
		}

		public ProfesorInfo(long iD_Profesor, string marca, string nume, string prenume, string numeScurt, string cNP, string gradDidactic, string email, int moodleUserId, string moodleIdNumber, string moodleUsername, int userID, long iD_TipGradDidactic, long iD_TipTitluStiintific, string parolaInitiala, string username)
		{
			ID_Profesor = iD_Profesor;
			Marca = marca;
			Nume = nume;
			Prenume = prenume;
			NumeScurt = numeScurt;
			CNP = cNP;
			GradDidactic = gradDidactic;
			Email = email;
			MoodleUserId = moodleUserId;
			MoodleIdNumber = moodleIdNumber;
			MoodleUsername = moodleUsername;
			UserID = userID;
			ID_TipGradDidactic = iD_TipGradDidactic;
			ID_TipTitluStiintific = iD_TipTitluStiintific;
			ParolaInitiala = parolaInitiala;
			Username = username;
		}

		#endregion

		#region "Public Properties"

		public long ID_Profesor { get; set; }

		public string Marca { get; set; }

		public string Nume
		{
			get { return _nume; }
			set { _nume = value; }
		}

		public string Prenume
		{
			get { return _prenume; }
			set { _prenume = value; }
		}

		public string NumeScurt { get; set; }

		public string CNP { get; set; }

		public string GradDidactic { get; set; }

		public string Email { get; set; }

		public int MoodleUserId { get; set; }

		public string MoodleIdNumber { get; set; }

		public string MoodleUsername { get; set; }

		public int UserID { get; set; }

		public long ID_TipGradDidactic { get; set; }

		public long ID_TipTitluStiintific { get; set; }

		public string ParolaInitiala { get; set; }

		public string Username { get; set; }

        public string NumeIntreg { get; set; }

        public string NumeCasatorie { get; set; }

		public long ID_CatedraProfesor { get; set; }

		public long ID_Catedra { get; set; }

		public string DenumireCatedra { get; set; }
		public long ID_Facultate { get; set; }
		public string DenumireFacultate { get; set; }
		public bool CatedraProfesorActiv { get; set; }
		public long ID_Departament { get; set; }
		public string DenumireDepartament { get; set; }
		public bool DepartamentProfesorActiv { get; set; }
		//public bool Titlular { get; set; }

		public string DenumireTitluStiintific { get; set; }

		public bool Titular { get; set; }

		public string DenumireGradDidactic { get; set; }

		public string COD_SEC { get; set; }
		public string COD_SUB { get; set; }
		public string COD_FUN { get; set; }

		#endregion

		public long ID_AnUniv { get; set; }

		//ciprian 10.05.2012
		public bool Evaluat{get; set;}

        public string NumeIntreg2 { get { return NumeIntreg; } }
        public string DenumireCatedra2 { get { return DenumireCatedra; } }
    }
}