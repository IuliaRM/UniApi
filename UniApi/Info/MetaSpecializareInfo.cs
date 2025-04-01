using System;
namespace UniApi.Info
{
	public partial class MetaSpecializareInfo
	{
		long _id_metaspecializare;
		string _denumiremetaspecializare;
		long _id_facultate;

		public MetaSpecializareInfo()
		{
		}

		public MetaSpecializareInfo(long id_metaspecializare, string denumiremetaspecializare, long id_facultate)
		{
			this.id_metaspecializare = id_metaspecializare;
			this.denumiremetaspecializare = denumiremetaspecializare;
			this.id_facultate = id_facultate;
		}

		public long id_metaspecializare
		{
			get { return _id_metaspecializare; }
			set { _id_metaspecializare = value; }
		}

		public string denumiremetaspecializare
		{
			get { return _denumiremetaspecializare; }
			set { _denumiremetaspecializare = value; }
		}

		public long id_facultate
		{
			get { return _id_facultate; }
			set { _id_facultate = value; }
		}

		public int NumarSpecializariDinMetaSpecializare { get; set; }
		public long ID_AnUniv { get; set; }
	}
}
