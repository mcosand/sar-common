namespace Sar.Web
{
  using System.Web.Http;
  using System.Web.Http.ExceptionHandling;
  using Newtonsoft.Json.Serialization;
  using Ninject;
  using Ninject.Web.WebApi;
  using Owin;

  public static class WebSetup
  {
    public static void SetupWebApi(IAppBuilder app, IKernel kernel)
    {
      var config = new HttpConfiguration();
      config.MapHttpAttributeRoutes();
      config.Services.Replace(typeof(IExceptionHandler), new ApiUserExceptionHandler());
      config.Services.Add(typeof(IExceptionLogger), kernel.Get<ApiExceptionLogger>());

      var formatter = config.Formatters.JsonFormatter;
      formatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

      config.DependencyResolver = new NinjectDependencyResolver(kernel);

      config.EnableCors();

      app.UseWebApi(config);
    }
  }
}
