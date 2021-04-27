using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete.DataResults;
using Core.Utilities.Results.Concrete.VoidResults;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class CustomerManager : ICustomerService
	{
		ICustomerDal _iCustomerDal;

		public CustomerManager(ICustomerDal iCustomerDal)
		{
			_iCustomerDal = iCustomerDal;
		}

		public IResult Add(Customer customer)
		{
			_iCustomerDal.Add(customer);
			return new SuccessResult(Messages.CustomerAddedMessage);
		}

		public IResult Delete(Customer customer)
		{
			_iCustomerDal.Delete(customer);
			return new SuccessResult(Messages.CustomerDeletedMessage);
		}

		public IDataResult<List<Customer>> GetAll()
		{
			return new SuccessDataResult<List<Customer>>(_iCustomerDal.GetAll());
		}

		public IDataResult<Customer> GetById(int customerId)
		{
			return new SuccessDataResult<Customer>(_iCustomerDal.Get(c => c.Id == customerId));
		}

		public IResult Update(Customer customer)
		{
			_iCustomerDal.Update(customer);
			return new SuccessResult(Messages.CustomerUpdatedMessage);
		}
	}
}
