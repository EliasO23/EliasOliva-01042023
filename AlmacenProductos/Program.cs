// See https://aka.ms/new-console-template for more information
using AlmacenProductos.DAO;
using AlmacenProductos.Models;

Console.WriteLine("\n---------------------------------------------------------");
Console.WriteLine("            BIENVENIDOS/AS A SU ALMACEN PREFERIDO          ");
Console.WriteLine("              --  Sera un placer atenderte  --             ");
Console.WriteLine("---------------------------------------------------------");


CrudProductos CrudProductos = new CrudProductos();
Producto Producto = new Producto();

bool comprobar = true;
while (comprobar)
{
    Console.WriteLine("\n\n------------------------------------");
    Console.WriteLine("               MENU                 ");
    Console.WriteLine("------------------------------------");
    Console.WriteLine("Pulse para:                         ");
    Console.WriteLine("      1. Insertar Productos         ");
    Console.WriteLine("      2. Actualizar Productos       ");
    Console.WriteLine("      3. Eliminar Productos         ");
    Console.WriteLine("      4. Listado de Productos       ");
    Console.WriteLine("      5. Salir                      ");
    Console.WriteLine("------------------------------------");

    Console.Write("- ¿Que desea hacer? ");
    var Menu = Convert.ToInt32(Console.ReadLine());

    switch (Menu)
    {
        case 1:
            int bucle = 1;
            while (bucle == 1)
            {
                Console.WriteLine("\n\n  AGREGAR PRODUCTOS:");
                Console.WriteLine("------------------------------------");

                Console.WriteLine("- Nombre del producto: ");
                Producto.Nombre = Console.ReadLine();
                Console.WriteLine("- Descripcion:");
                Producto.Descripcion = Console.ReadLine();
                Console.WriteLine("- Precio: ");
                Producto.Precio = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("- Cantidad de productos existentes: ");
                Producto.Stock = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------------------------------\n");
                CrudProductos.AgregarProductos(Producto);

                Console.WriteLine(" - PRODUCTO INGRESADO CORRECTAMENTE \n");

                Console.WriteLine("Coloque: ");
                Console.WriteLine("   1. Continuar ingresando          ");
                Console.WriteLine("      productos                     ");
                Console.WriteLine("   2. Salir                         ");
                Console.Write("- ¿Que desea hacer? ");
                bucle = Convert.ToInt32(Console.ReadLine());

            }
            break;

        case 2:
            int bucle1 = 1;
            while (bucle1 == 1)
            {
                Console.WriteLine("\n\nACTUALIZAR PRODUCTOS");
                Console.WriteLine("------------------------------------");
                Console.Write("Ingrese el ID del producto a actualizar: ");
                var ProductoIndividualU = CrudProductos.ProductoIndividual(Convert.ToInt32(Console.ReadLine()));

                if (ProductoIndividualU == null)
                {
                    Console.WriteLine("\nEl producto no existe");

                    Console.WriteLine("\nColoque: ");
                    Console.WriteLine("   1. Continuar          ");
                    Console.WriteLine("   2. Salir              ");
                    Console.Write("- ¿Que desea hacer? ");
                    bucle1 = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("\nRegistro a actualizar:");
                    Console.WriteLine("\n Id Cant. Producto Descripcion Precio ");
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine($"  {ProductoIndividualU.Id}  {ProductoIndividualU.Stock}    {ProductoIndividualU.Nombre}   {ProductoIndividualU.Descripcion}    {ProductoIndividualU.Precio}  ");
                    
                    Console.WriteLine("\nPara actualizar coloca:       ");
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("   1. Nombre                    ");
                    Console.WriteLine("   2. Descripcion               ");
                    Console.WriteLine("   3. Precio                    ");
                    Console.WriteLine("   4. Stock                     ");
                    Console.WriteLine("-----------------------------------");
                    Console.Write("- ¿Que desea actualizar? ");
                    var Lector = Convert.ToInt32(Console.ReadLine());

                    switch (Lector)
                    {
                        case 1:
                            Console.WriteLine("\nIngrese el nombre del producto:");
                            ProductoIndividualU.Nombre = Console.ReadLine();
                            break;

                        case 2:
                            Console.WriteLine($"\nIngrese la descripcion del producto: {ProductoIndividualU.Nombre}");
                            ProductoIndividualU.Descripcion = Console.ReadLine();
                            break;

                        case 3:
                            Console.WriteLine($"\nIngrese el precio del producto: {ProductoIndividualU.Nombre}");
                            ProductoIndividualU.Precio = Convert.ToDecimal(Console.ReadLine());
                            break;

                        case 4:
                            Console.WriteLine($"\nIngrese la cantidad del producto: {ProductoIndividualU.Nombre}");
                            ProductoIndividualU.Stock = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                    CrudProductos.ActualizarProducto(ProductoIndividualU, Lector);
                    Console.WriteLine("\n - ACTUALIZACIÓN CORRECTA");

                    Console.WriteLine("\nColoque: ");
                    Console.WriteLine("   1. Continuar actualizando        ");
                    Console.WriteLine("      productos                     ");
                    Console.WriteLine("   2. Salir                         ");
                    Console.Write("- ¿Que desea hacer? ");
                    bucle1 = Convert.ToInt32(Console.ReadLine());

                }
                
            }
            break;

        case 3:

            int bucle2 = 1;
            while (bucle2 == 1)
            {
                Console.WriteLine("\n\nELIMINAR PRODUCTOS");
                Console.WriteLine("------------------------------------");
                Console.Write("Ingrese el ID del producto a eliminar: ");
                var ProductoIndividualD = CrudProductos.ProductoIndividual(Convert.ToInt32(Console.ReadLine()));

                if (ProductoIndividualD == null)
                {
                    Console.WriteLine("\nEl producto no existe");

                    Console.WriteLine("\nColoque: ");
                    Console.WriteLine("   1. Continuar          ");
                    Console.WriteLine("   2. Salir              ");
                    Console.Write("- ¿Que desea hacer? ");
                    bucle2 = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("\nRegistro a eliminar:");
                    Console.WriteLine("\n Id Cant. Producto Descripcion Precio ");
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine($"  {ProductoIndividualD.Id}  {ProductoIndividualD.Stock}    {ProductoIndividualD.Nombre}   {ProductoIndividualD.Descripcion}    {ProductoIndividualD.Precio}  ");
                    Console.WriteLine("\n¿Desea eliminar este producto permanentemente?");
                    Console.WriteLine("  1. Si    ");
                    Console.WriteLine("  2. No    ");
                    Console.Write("  - Opcion: ");

                    var Lector = Convert.ToInt32(Console.ReadLine());

                    if (Lector == 1)
                    {
                        var Id = Convert.ToInt32(ProductoIndividualD.Id);
                        Console.WriteLine(CrudProductos.EliminarProducto(Id));
                        
                    }
                    else
                    {
                        Console.WriteLine("\n Inicie nuevamente");

                    }
                    Console.WriteLine("\nColoque: ");
                    Console.WriteLine("   1. Continuar eliminando          ");
                    Console.WriteLine("      productos                     ");
                    Console.WriteLine("   2. Salir                         ");
                    Console.Write("- ¿Que desea hacer? ");
                    bucle2 = Convert.ToInt32(Console.ReadLine());

                }
                

            }
            
            break;

        case 4:
            Console.WriteLine("\n\n  PRODUCTOS REGISTRADOS:");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(" Id Cant. Producto   Descripcion   Precio ");
            Console.WriteLine("-------------------------------------------");


            var ListarProductos = CrudProductos.ListarProductos();
            foreach (var iteracionProducto in ListarProductos)
            {
                Console.WriteLine($"  {iteracionProducto.Id}  {iteracionProducto.Stock}    {iteracionProducto.Nombre}   {iteracionProducto.Descripcion}    {iteracionProducto.Precio}  ");

            }
            Console.Write("\nPulse ENTER para continuar: ");
            var cont = Console.ReadLine();


            break;

        case 5:

            Console.WriteLine("\n\n----------------------------------------------------------");
            Console.WriteLine("           ¡GRACIAS POR VISITAR NUESTRO ALMACEN!           ");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine(" - Vueva pronto");
            Console.WriteLine(" - Lo esperamos\n");

            comprobar = false;

            break;

        default:
            Console.WriteLine("\nOpcion Invalida");
            break;

    }
}


