using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HelloAngularApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			
			
			CreateHostBuilder(args).Build().Run();

		}

		public void Post()
		{
			string connectString = "Data Source=ADMIN-RGKN0U0YD;Initial Catalog=Support;Integrated Security=True";

			SqlConnection myConnection = new SqlConnection(connectString);

			myConnection.Open();

			string query = "INSERT INTO Contact values (1, 'saf', 'sfaf', 'asfa'";

			SqlCommand command = new SqlCommand(query, myConnection);
			command.ExecuteNonQuery();
			myConnection.Close();
		}
		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				});
	}
}
