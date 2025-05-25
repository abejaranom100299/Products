using BusinessLogic;
using Entities;

public class Program 
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al gestor de productos Graci");
        Console.WriteLine("Digite la opción deseada:");
        Console.WriteLine("1.Agregar un producto");
        Console.WriteLine("2.Consultar listado de producto");

        var option = Int32.Parse(Console.ReadLine());

        switch (option)
        {

            case 1:
                Console.WriteLine("Digite la información del producto a continuación");
                Console.WriteLine("Indique el Id:");
                var id = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Indique el nombre");
                var name = Console.ReadLine();
                Console.WriteLine("Indique la cantidad disponible");
                var stock = Int32.Parse (Console.ReadLine());
                Console.WriteLine("Indique el precio");
                var price = Double.Parse(Console.ReadLine());

                var myProduct = new Product() { Id = id, Name = name, Stock = stock, Price = price };

                var pa = new ProductManager();

                try
                {

                    pa.AddProduct(myProduct);
                }
                catch (Exception ex) 
                { 
                    Console.WriteLine (ex.Message);


                }

                break;

            case 2:
                Console.WriteLine("Listado de productos existentes");
                break;
            case 9:
                Console.WriteLine("Saliendo....");
                break;
            default:
                Console.WriteLine("Opción incorrecta");
                break;

        }



    }

 }


