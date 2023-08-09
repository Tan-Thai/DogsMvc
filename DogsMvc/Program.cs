using System.Security.Cryptography;
namespace BandsMvc
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			builder.Services.AddControllersWithViews();

			var app = builder.Build();

			app.UseRouting();
			app.UseEndpoints(c => c.MapControllers());
			app.UseStaticFiles();
			app.Run();
		}
	}
}