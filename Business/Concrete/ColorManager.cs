using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class ColorManager : IColorService
	{

		IColorDal _iColorDal;

		public ColorManager(IColorDal iColorDal)
		{
			_iColorDal = iColorDal;
		}

		public void Add(Color color)
		{
			_iColorDal.Add(color);
		}

		public void Delete(Color color)
		{
			_iColorDal.Delete(color);
		}

		public List<Color> GetAll()
		{
			return _iColorDal.GetAll();
		}

		public List<Color> GetAllByColorId(int colorId)
		{
			return _iColorDal.GetAll(c => c.ColorID == colorId);
		}

		public void Update(Color color)
		{
			_iColorDal.Update(color);
		}
	}
}
