using System;
namespace UniApi.Info
{
	public partial class TipGradDidacticInfo
	{
		long _iD_TipGradDidactic;
		string _denumireGradDidactic;

		public TipGradDidacticInfo()
		{
		}

		public TipGradDidacticInfo(long iD_TipGradDidactic, string denumireGradDidactic)
		{
			this.ID_TipGradDidactic = iD_TipGradDidactic;
			this.DenumireGradDidactic = denumireGradDidactic;
		}

		public long ID_TipGradDidactic
		{
			get { return _iD_TipGradDidactic; }
			set { _iD_TipGradDidactic = value; }
		}

		public string DenumireGradDidactic
		{
			get { return _denumireGradDidactic; }
			set { _denumireGradDidactic = value; }
		}
	}
}
