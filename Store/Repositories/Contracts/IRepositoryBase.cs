using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
	//T type'ı refer ediyor
	public interface IRepositoryBase<T>
	{
		//sadece listeleme yaptığım için, sorgulanabilir queryable ifadesini kullanıyorum 
		IQueryable<T> FindAll(bool trackChanges);

		T? FindByCondition(Expression<Func<T,bool>> expression, bool trackChanges);

		void Create(T entity);
		void Remove(T entity);
		void Update(T entity);	
	}

}
