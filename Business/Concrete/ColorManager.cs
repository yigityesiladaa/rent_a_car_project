﻿using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
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
	public class ColorManager : IColorService
	{

		IColorDal _iColorDal;

		public ColorManager(IColorDal iColorDal)
		{
			_iColorDal = iColorDal;
		}
		[ValidationAspect(typeof(ColorValidator))]
		public IResult Add(Color color)
		{
			if (color.ColorName.Length <= 1)
			{
				return new ErrorResult(Messages.InvalidColorName);
			}
			_iColorDal.Add(color);
			return new SuccessResult(Messages.ColorAddedMessage);
		}

		public IResult Delete(Color color)
		{
			_iColorDal.Delete(color);
			return new SuccessResult(Messages.ColorDeletedMessage);
		}

		public IDataResult<List<Color>> GetAll()
		{
			return new SuccessDataResult<List<Color>>(_iColorDal.GetAll());
		}

		public IDataResult<Color> GetById(int colorId)
		{
			return new SuccessDataResult<Color>(_iColorDal.Get(c => c.ColorID == colorId));
		}

		public IResult Update(Color color)
		{
			_iColorDal.Update(color);
			return new SuccessResult(Messages.ColorUpdatedMessage);
		}
	}
}
