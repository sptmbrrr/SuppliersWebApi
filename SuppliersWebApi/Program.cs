using Application.Repository;
using Application.UnitOfWork;
using Infrastructure.Persistence;

namespace SuppliersWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers().AddXmlDataContractSerializerFormatters();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<DataContext>();
            builder.Services.AddTransient<IPartRepository, PartRepository>();
            builder.Services.AddTransient<ICarRepository, CarRepository>();
            builder.Services.AddTransient<ICarManufacturerRepository, CarManufacturerRepository>();
            builder.Services.AddTransient<IPartLevelRepository, PartLevelRepository>();
            builder.Services.AddTransient<IPartManufacturerRepository, PartManufacturerRepository>();
            builder.Services.AddTransient<IPartTypeRepository, PartTypeRepository>();
            builder.Services.AddTransient<ISupplierRepository, SupplierRepository>();
            builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}