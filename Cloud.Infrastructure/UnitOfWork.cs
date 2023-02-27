using Cloud.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.Infrastructure
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly MainDbContext _dbContext;

		public UnitOfWork(MainDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task BeginTransactionAsync()
		{
			await _dbContext.Database.BeginTransactionAsync();
		}

		public async Task CommitAsync()
		{
			await _dbContext.SaveChangesAsync();
			await _dbContext.Database.CurrentTransaction.CommitAsync();
		}

		public async Task RollbackAsync()
		{
			await _dbContext.Database.CurrentTransaction.RollbackAsync();
		}
	}
}
