using Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace DataPersistence
{
    public class FileManager
    {
        //Metodo retorna una lista de productos tomada del archivo de texto/.
        public List<Product> ReadProducts()
        {
            //----DESARROLLAR POR EL ESTUDIANTE----
            // Leer la lista de productos de un txt y cargarlo en la lista.
            string rutaArchivo = "C:\\Users\\graci\\source\\repos\\Products\\productos.txt";

            //Declaración de variables necesarias para la construcción de los productos que se van a agregar a la lista retornada.
            int idActual = 0;
            string nameActual = "";
            double priceActual = 0;
            int stockActual = 0;

            // Verifica si el archivo existe
            if (File.Exists(rutaArchivo))
            {
                // Lee el archivo línea por línea
                string[] lineas = File.ReadAllLines(rutaArchivo);

                foreach (string linea in lineas)
                {
                    // Divide cada línea por comas
                    string[] campos = linea.Split(',');
                    Int16 contador = 0;

                    // Muestra los campos y los asigna a la variable correspondiente para preparar la construcción del producto.
                    foreach (string campo in campos)
                    {
                        switch (contador)
                        {
                            case 0:
                                idActual = Int32.Parse(campo);
                                Console.Write("Id: " + campo + ", ");
                                break;
                            case 1:
                                nameActual = campo;
                                Console.Write("Nombre: " + campo + ", ");
                                break;
                            case 2:
                                priceActual = Double.Parse(campo);
                                Console.Write("Precio: " + campo + ", ");
                                break;
                            case 3:
                                stockActual = Int32.Parse(campo);
                                Console.Write("Stock: " + campo);
                                break;
                            default:
                                break;
                        }
                        contador++;
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
            }
            else
            {
                throw new Exception("El archivo de productos está vacío.");
            }
            var productoActual = new Product() { Id = idActual, Name = nameActual, Stock = stockActual, Price = priceActual };
            var products = new List<Product>();
            return products;
        }
        public void SaveProduct(Product product) 
        {
            //----DESARROLLAR POR EL ESTUDIANTE----
            // Guardar el producto en un txt
            string rutaArchivo = "C:\\Users\\graci\\source\\repos\\Products\\productos.txt";
            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                writer.WriteLine($"{product.Id},{product.Name},{product.Price},{product.Stock}");
            }
        }
    }
}
