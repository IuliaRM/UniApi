using System;
namespace UniApi.Info
{
	public partial class DetaliuPlanSemestruProfesorCuplajInfo : DetaliuPlanSemestruInfo
	{
		public DetaliuPlanSemestruProfesorCuplajInfo()
		{
		}

		public DetaliuPlanSemestruProfesorCuplajInfo(long iD_DetaliuPlanSemestruProfesorCuplaj, long iD_DetaliuPlanSemestruProfesor, long iD_DetaliuCuplaj)
		{
			this.ID_DetaliuPlanSemestruProfesorCuplaj = iD_DetaliuPlanSemestruProfesorCuplaj;
			this.ID_DetaliuPlanSemestruProfesor = iD_DetaliuPlanSemestruProfesor;
			this.ID_DetaliuCuplaj = iD_DetaliuCuplaj;
		}

		public long ID_DetaliuPlanSemestruProfesorCuplaj { get; set; }

		public long ID_DetaliuPlanSemestruProfesor { get; set; }

		public long ID_DetaliuCuplaj { get; set; }

		public string ID_DetaliuPlanSemestru_ID_Cuplaj { get; set; }
	}
}
