using BusinessLogic;
using Entities;

public class Program 
{

    public static void Main(string[] args)
    {
        var option = 0;

        do
        {
            Console.WriteLine("Bienvenido al gestor de productos Graci");
            Console.WriteLine("\nOpciones:");
            Console.WriteLine("1. Agregar un producto");
            Console.WriteLine("2. Consultar listado de producto");
            Console.WriteLine("3. Salir");
            Console.Write("Digite la opción deseada: ");

            option = Int32.Parse(Console.ReadLine());
            var pa = new ProductManager();

            switch (option)
            {
                case 1:
                    Console.WriteLine("\nDigite la información del producto a continuación:");
                    Console.Write("Indique el id: ");
                    var id = Int32.Parse(Console.ReadLine());
                    Console.Write("Indique el nombre: ");
                    var name = Console.ReadLine();
                    Console.Write("Indique la cantidad disponible: ");
                    var stock = Int32.Parse(Console.ReadLine());
                    Console.Write("Indique el precio: ");
                    var price = Double.Parse(Console.ReadLine());

                    var myProduct = new Product() { Id = id, Name = name, Stock = stock, Price = price };

                    try
                    {
                        pa.AddProduct(myProduct);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    break;

                case 2:
                    Console.WriteLine("Listado de productos existentes: \n");

                    try
                    {
                        pa.GetProducts();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case 3:
                    Console.WriteLine("Saliendo....");
                    break;

                default:
                    Console.WriteLine("Opción incorrecta.");
                    break;

            }
        } while (option != 3);
    }
 }