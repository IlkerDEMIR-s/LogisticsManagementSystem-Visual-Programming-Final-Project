using FluentValidation;
using Logistics.Business.Abstract;
using Logistics.Business.Utilities;
using Logistics.DataAccess.Abstract;
using Logistics.DataAccess.Concrete.EntityFramework;
using Logistics.Entities.Concrete;
using Northwind.Business.ValidationRules.FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal; //Dependency Injection

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            var validator = new ProductValidator();
            var context = new ValidationContext<Product>(product);
            ValidationTool.Validate(validator, context);
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch
            {
                throw new Exception("Delete failed!");
            }
        }

        public List<Product> GetAll()
        {
            //Business Code
            return _productDal.GetAll();
        }

        public List<Product> GetByCategory(int categoryId, int factoryId)
        {
            return _productDal.GetAll(p => p.CategoryID == categoryId && p.FactoryID == factoryId);
        }

        public List<Product> GetByProductName(string searchKey, int factoryId)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(searchKey.ToLower()) && p.FactoryID == factoryId);

        }

        public void Update(Product product)
        {
            var validator = new ProductValidator();
            var context = new ValidationContext<Product>(product);
            ValidationTool.Validate(validator, context);
            try
            {
                _productDal.Update(product);
            }
            catch
            {
                throw new Exception("Delete failed!");
            }

        }

        public int GetCurrentStock(int productId)
        {
            return _productDal.GetCurrentStock(productId);
        }

        public void UpdateStockQuantity(int productId, int newStockQuantity)
        {
            _productDal.UpdateStockQuantity(productId, newStockQuantity);
        }

        public List<Product> GetAllWithNames()
        {
            return _productDal.GetAllWithNames();
        }

        public List<Product> GetByFactoryId(int factoryId)
        {
            return _productDal.GetAll(p => p.FactoryID == factoryId);
        }
    }
}