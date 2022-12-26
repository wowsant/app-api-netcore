using Microsoft.Extensions.DependencyInjection;

namespace app.CrossCutting.IoC
{
    public static class DependencyResolver
    {
        public static void AddDependencyResolver(this IServiceCollection services)
        {
            RegisterApplications(services);
            //RegisterRepositories(services);
            RegisterAdapters(services);
            RegisterApis(services);
            RegisterPublishers(services);
        }
        private static void RegisterApplications(IServiceCollection services)
        {
            //services.AddSingleton<ITitleApplication, TitleApplication>();
        }
        private static void RegisterAdapters(IServiceCollection services)
        {
            //services.AddTransient(provider => new SqlConnection(Configurations.PagerDbConnectionString));
            //services.AddTransient<ITitlePort, TitleAdapter>();
        }

        /*

        private static void RegisterRepositories(IServiceCollection services)
        {

        }
 
        */
        private static void RegisterApis(IServiceCollection services)
        {
            //services.AddSingleton<IEmail, Email>();
            //services.AddSingleton<IEmailCampaign, EmailCampaign>();
            //services.AddSingleton<IEmailAttribute, EmailAttribute>();

        }
        private static void RegisterPublishers(IServiceCollection services)
        {
            //services.AddSingleton<ITitlePublisher, TitlePublisher>();
        }
    }
}
