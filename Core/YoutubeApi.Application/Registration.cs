using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using YoutubeApi.Application.Exceptions;
using System.Globalization;
using MediatR;
using YoutubeApi.Application.Behaviours;

namespace YoutubeApi.Application
{
    public static class Registration
    {
        public static void AddApplication(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));

            services.AddTransient<ExceptionMiddleware>();

            services.AddValidatorsFromAssembly(assembly);
            ValidatorOptions.Global.LanguageManager.Culture = new CultureInfo("tr");
            //services.AddValidatorsFromAssemblyContaining();

            services.AddTransient(typeof(IPipelineBehavior<,>),typeof(FluentValidationBehaviour<,>));
        }
    }
}
