﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VetAppointment.Domain.Models;
using VetAppointment.Infrastructure.Generics;
using VetAppointment.Infrastructure.Generics.GenericRepositories;

namespace VetAppointment.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IRepository<Appointment>, AppointmentRepository>();
            services.AddScoped<IRepository<Bill>, BillRepository>();
            services.AddScoped<IRepository<Client>, ClientRepository>();
            services.AddScoped<IRepository<Medicine>, MedicineRepository>();
            services.AddScoped<IRepository<Medic>, MedicRepository>();
            services.AddScoped<IRepository<Nurse>, NurseRepository>();
            services.AddScoped<IRepository<Patient>, PatientRepository>();
            services.AddScoped<IRepository<Room>, RoomRepository>();
            services.AddDbContext<DatabaseContext>(options => options.UseSqlite(
                configuration.GetConnectionString("VetAppointmentDB")), ServiceLifetime.Singleton);
            return services;
        }
    }
}
