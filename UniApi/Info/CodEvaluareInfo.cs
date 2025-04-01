using System;

namespace UniApi.Info
{
	public partial class CodEvaluareInfo
	{
		public CodEvaluareInfo()
		{
		}

		public CodEvaluareInfo(long iD_CodEvaluare, long iD_DetaliuPlanSemestru , long iD_EvaluareProfesor , string tipCursEvaluat , string codEvaluare , int status)
		{
			this.ID_CodEvaluare = iD_CodEvaluare;
			this.ID_DetaliuPlanSemestru = iD_DetaliuPlanSemestru;
			this.ID_EvaluareProfesor = iD_EvaluareProfesor;
			this.TipCursEvaluat = tipCursEvaluat;
			this.CodEvaluare = codEvaluare;
			this.Status = status;
		}

		public long ID_CodEvaluare
		{
			get;set;
		}
		
		public long ID_DetaliuPlanSemestru
		{
			get;set;
		}

		public long ID_EvaluareProfesor
		{
			get;set;
		}

		public string TipCursEvaluat
		{
			get;set;
		}

		public string CodEvaluare
		{
			get;set;
		}

		public int Status
		{
			get;set;
		}
	}
}
