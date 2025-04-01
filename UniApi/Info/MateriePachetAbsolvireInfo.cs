namespace UniApi.Info
{
	public partial class MateriePachetAbsolvireInfo
	{
		#region "Constructors"

		public MateriePachetAbsolvireInfo()
		{
		}

		public MateriePachetAbsolvireInfo(long iD_Materie, long iD_PachetAbsolvire)
		{
			//this.ID_MateriePachetAbsolvire = iD_MateriePachetAbsolvire;
			ID_Materie = iD_Materie;
			ID_PachetAbsolvire = iD_PachetAbsolvire;
		}

		#endregion

		#region "Public Properties"

		public long ID_MateriePachetAbsolvire { get; set; }

		public long ID_Materie { get; set; }

		public long ID_PachetAbsolvire { get; set; }

		#endregion
	}
}