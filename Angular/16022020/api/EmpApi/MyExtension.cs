using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeService.Extension {
    public static class MyExtension {

        public static void ConfigureIISIntegration (this IServiceCollection services) {
            services.Configure<IISOptions> (options => {
            });
        }
    }

}