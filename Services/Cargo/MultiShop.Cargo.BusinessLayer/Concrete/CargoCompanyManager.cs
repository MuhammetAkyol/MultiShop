using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DataAccessLayer.Abstract;
using MultiShop.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.BusinessLayer.Concrete
{
    public class CargoCompanyManager : ICargoCompanyService
    {
        private readonly ICargoCompanyDal _cargoCompanyDal;

        public CargoCompanyManager(ICargoCompanyDal cargoCompanyDal)
        {
            _cargoCompanyDal = cargoCompanyDal;
        }

        public void TDelete(int id)
        {
           _cargoCompanyDal.Delete(id);
        }

        public List<CargoCompony> TGetAll()
        {
            return _cargoCompanyDal.GetAll();
        }

        public CargoCompony TGetById(int id)
        {
            return _cargoCompanyDal.GetById(id);
        }

        public void TInsert(CargoCompony entity)
        {
            _cargoCompanyDal.Insert(entity);
        }

        public void TUpdate(CargoCompony entity)
        {
           _cargoCompanyDal.Update(entity);
        }
    }
}
