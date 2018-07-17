using System.Web;
using System.Web.Mvc;

namespace MVC_Forms_vs_ModelBinding
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
