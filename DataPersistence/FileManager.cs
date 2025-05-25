using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataPersistence
{
    public class FileManager
    {
        //Metodo retorna una lista de productos tomada del archivo de texto/.
        public List<Product> ReadProducts()
       {
            //----DESARROLLAR POR EL ESTUDIANTE----
            // Leer la lista de productos de un txt y cargarlo en la lista.
        var products = new List<Product>();
            return products;
       }
        public void SaveProduct(Product product) 
        {
            //----DESARROLLAR POR EL ESTUDIANTE----
            // Guardar el producto en un txt
        }
    }
}
