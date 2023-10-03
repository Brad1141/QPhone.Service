using Microsoft.EntityFrameworkCore;
using QPhone.Service.Entities;

namespace QPhone.Service.Context
{
	public class QPhoneContext : DbContext
	{
		private readonly string connectionString;
		public DbSet<Event> Event { get; set; }

		public QPhoneContext(string connectionString)
		{
			this.connectionString = connectionString;
		}
	}
}
