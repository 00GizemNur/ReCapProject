using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            _colorDal.Add(color);
         return new ErrorResult(Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new ErrorResult(Messages.ColorDeleted);
        }

        public IDataResult <List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new ErrorResult(Messages.ColorUpdated);
        }

       public IDataResult <Color> GetById(int colorId)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(co => co.ColorId == colorId));
        }
    }
}

