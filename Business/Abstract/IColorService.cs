using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface IColorService
	{
		public void Add(Color color);
		public void Update(Color color);
		public void Delete(Color color);
		List<Color> GetAll();
		List<Color> GetAllByColorId(int colorId);
	}
}
