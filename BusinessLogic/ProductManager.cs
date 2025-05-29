using DataPersistence;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
  public class ProductManager
    {
        public void AddProduct(Product product)
        {
            //Aplicar validaciones
            if (string.IsNullOrEmpty(product.Name))
            {
                throw new Exception("El nombre del producto no debe estar vacío.");
            }
            if (product.Price <= 0)
            {
                throw new Exception("El precio del producto debe ser mayor que cero.");
            }
            if(product.Stock < 0) 
            {
                throw new Exception("La cantidad disponible no debe ser negativa.");
            }

            //Si pasa las validaciones, lo enviamos a guardar en el txt
            var fm = new FileManager();

            fm.SaveProduct(product);
        }
        public List<Product> GetProducts()
        {
            var listaProductos = new List<Product>();

            var fm = new FileManager();

            listaProductos = fm.ReadProducts();

            return listaProductos;
        }
    }
}
