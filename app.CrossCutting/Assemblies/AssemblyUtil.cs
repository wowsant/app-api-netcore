using System.Reflection;

namespace app.CrossCutting.Assemblies
{
    public static class AssemblyUtil
    {
        public static IEnumerable<Assembly> GetCurrentAssemblies()
        {
            return new Assembly[]
            {
                Assembly.Load("app.Api"),
                Assembly.Load("app.Application"),
                Assembly.Load("app.Domain"),
                Assembly.Load("app.Infrastructure"),
                Assembly.Load("app.CrossCutting"),
                Assembly.Load("app.Util")
            };
        }
    }
}