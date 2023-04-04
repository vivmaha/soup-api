
namespace SoupApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            const string corsPolicyName = "allow-all";
            builder.Services.AddCors(options =>
            {
                options.AddPolicy(corsPolicyName, policy => { policy.WithOrigins("*"); });
            });

            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors(corsPolicyName);
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}