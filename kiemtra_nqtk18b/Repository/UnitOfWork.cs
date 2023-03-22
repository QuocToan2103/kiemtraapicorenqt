using kiemtra_nqtk18b.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace kiemtra_nqtk18b.Repository
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : Context
    {
		private readonly Context dbContext;
		private Repository<Category> categoryRepository;

		public Repository<Category> CategoryRepository
		{
			get
			{
				if (categoryRepository == null)
				{
					categoryRepository = new Repository<Category>((Context)dbContext);
				}
				return categoryRepository;
			}
		}


		public UnitOfWork(Context context)
		{
			dbContext = context;
		}
		public Context _dbContext
		{
			get
			{
				return dbContext;
			}
		}

		

		

		public void RollBack()
		{
			transaction.Rollback();
		}

		public void Save()
		{
			dbContext.SaveChanges();
		}

		private IDbContextTransaction transaction;
		public void Transaction()
		{

		}
		public void CreateTransaction()
		{
			transaction = dbContext.Database.BeginTransaction();
		}

		public void Commit()
		{
			transaction.Commit();
		}

		public void Trasaction()
		{
			throw new NotImplementedException();
		}
	}
}
