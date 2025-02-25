using DotNetNuke.Web.Api;
//using Swashbuckle.Swagger;


namespace UniApi

{
    public class RouteMapper : IServiceRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapHttpRoute("UniApi.API", "default", "{controller}/{action}", new[] { "UniApi.Controllers" });
        }
    }
}