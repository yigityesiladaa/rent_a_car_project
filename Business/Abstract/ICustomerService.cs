using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface ICustomerService
	{
		public IResult Add(Customer customer);
		public IResult Update(Customer customer);
		public IResult Delete(Customer customer);
		IDataResult<List<Customer>> GetAll();
		IDataResult<List<Customer>> GetAllByCustomerId(int customerId);
	}
}
