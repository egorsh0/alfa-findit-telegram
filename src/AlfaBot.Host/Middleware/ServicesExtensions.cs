using System.Diagnostics.CodeAnalysis;
using AlfaBot.Core.Data;
using AlfaBot.Core.Data.Interfaces;
using AlfaBot.Core.Factories.Commands;
using AlfaBot.Core.Services;
using AlfaBot.Core.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
#pragma warning disable 1591

namespace AlfaBot.Host.Middleware
{
    [ExcludeFromCodeCoverage]
    public static class ServicesExtensions
    {
        public static IServiceCollection AddRepositoryAndServices(this IServiceCollection services)
        {
            services
                .AddSingleton<IUserRepository, UserRepository>()
                .AddSingleton<IQuestionRepository, QuestionRepository>()
                .AddSingleton<IQuizResultRepository, QuizResultRepository>()
                .AddSingleton<IQueueService, MongoQueueService>()
                .AddSingleton<ILogRepository, LogRepository>()
                .AddSingleton<IGeneralCommandsFactory, GeneralCommandsFactory>()
                .AddSingleton<IQuestionCommandFactory, QuestionCommandFactory>();

            return services;
        }
    }
}