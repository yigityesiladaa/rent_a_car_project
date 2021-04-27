using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface IColorService
	{
		public IResult Add(Color color);
		public IResult Update(Color color);
		public IResult Delete(Color color);
		IDataResult<List<Color>> GetAll();
		IDataResult<Color> GetById(int colorId);
	}
}
