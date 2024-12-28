using WebApi.ServiceStartup;

namespace ToDoListAppApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.SetupAutoMapper(builder.Configuration);
            builder.Services.SetupDataAccess(builder.Configuration);
            builder.Services.SetupBusinessLogic(builder.Configuration);


            //builder.Services.AddAutoMapper(typeof(DomainToEntityMappingProfile), typeof(EntityToDomainMappingProfile));
            //builder.Services.AddScoped<IAssignmentRepository, AssignmentRepository>();
            //builder.Services.AddScoped<IAssignmentService, AssignmentService>();

            //builder.Services.AddDbContext<ToDoListContext>(options =>
            //{
            //    options.UseSqlServer(@Environment.GetEnvironmentVariable("ToDoListDbConnectionString")).UseLazyLoadingProxies();
            //});

            var app = builder.Build();

            //using (var scope = app.Services.CreateScope())
            //{
            //    var assignmentService = scope.ServiceProvider.GetRequiredService<IAssignmentService>();

            //    var newAssign = new Assignment
            //    {
            //        Title = "Do Some Work",
            //        StatusId = 1,
            //        Description = "Do some work also",
            //        CreatedAt = DateTime.Now
            //    };

            //    assignmentService.CreateAssignmentAsync(newAssign).GetAwaiter().GetResult();
            //}

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