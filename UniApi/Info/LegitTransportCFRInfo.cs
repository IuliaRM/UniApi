using System;
    namespace UniApi.Info
{
	public partial class LegitTransportCFRInfo: StudentInfo
    {
		public LegitTransportCFRInfo()
		{
		}

        public LegitTransportCFRInfo(long iD_StudentAnUniv, string serieLegitimatie, string numarLegitimatie)
		{
            ID_StudentAnUniv = iD_StudentAnUniv;
            SerieLegitimatie = serieLegitimatie;
            NumarLegitimatie = numarLegitimatie;
        }
        public long ID_StudentAnUniv { get; set; }

        public string SerieLegitimatie { get; set; }

        public string NumarLegitimatie { get; set; }
    }
}