using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Model;

namespace WebApplication3.ViewModels
{
    public class ProductModel
    {
        public List<Product> _products { get; set; }

        public List<Product> findAll()
        {
            _products = new List<Product> {
                new Product()
            {
                    Id="1", Name="Fire", Photo = "image.png", Price = 2.8
            },new Product()
            {
                    Id="2", Name="DNA", Photo = "image.png", Price = 2.8
            },new Product()
            {
                    Id="3", Name="IDOL", Photo = "image.png", Price = 2.8
            },new Product()
            {
                    Id="4", Name="Spring Day", Photo = "image.png", Price = 2.8
            },new Product()
            {
                    Id="5", Name="Dynamite", Photo = "image.png", Price = 2.8
            },new Product()
            {
                    Id="6", Name="Butter", Photo = "image.png", Price = 2.8
            }
                };
            return _products;
        }

        public Product find(string id)
        {
            List<Product> products = findAll();

            var prod = products.Where(a=> a.Id == id).FirstOrDefault();

            return prod;
        }
    }

}
