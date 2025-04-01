using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace UniApi.Info
{
	public partial class DetaliuPlanSemestruInfoComparer : IComparer<DetaliuPlanSemestruInfo>
	{
		public int Compare(DetaliuPlanSemestruInfo x, DetaliuPlanSemestruInfo y)
		{
			int ret = 1;
			if ((x != null) && (y != null))
			{
				ret = x.Ordine.CompareTo(y.Ordine);
			}
			return ret;

		}
	}
}