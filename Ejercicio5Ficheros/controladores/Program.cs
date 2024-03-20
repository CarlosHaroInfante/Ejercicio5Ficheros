using Ejercicio5Ficheros.servicios;
using System;

namespace Ejercicio5Ficheros.controladores
{
    class Program
    {
        public static void Main(string[] args)
        {

            string ruta = "C:\\Users\\Carlos\\Desktop\\PruebaFicheros.txt";
            int linea;
            string textoNuevo;
            
            
                MenuInterfaz menu = new MenuImplementacion();

                
                bool cerrarMenu = false;

                while (!cerrarMenu)
                {
                    int opcion = menu.menu(); 
                    string[] lineas = File.ReadAllLines(ruta);
                    switch (opcion)
                    {
                        case 0:
                            cerrarMenu = true;
                            break;
                        case 1:

                            try { 
                                Console.WriteLine("Modificar línea específica");

                                Console.WriteLine("Dame el número de la línea que quieres editar (entre el (1-10))");
                                linea = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Dame lo que deseas escribir en esa línea");
                                textoNuevo = Console.ReadLine();

                                if (linea >= 0 && linea <= lineas.Length)
                                {

                                    lineas[linea - 1] = textoNuevo;

                                    File.WriteAllLines(ruta, lineas);

                                    Console.WriteLine("La línea del texto elegida ya ha sido modificada");
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Fallo en el número de línea elegido");
                                }
                                break;
                                
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error tipo IO en la opción 1: " + ex.Message);
                            }
                        break;
                        case 2:

                        try
                        {
                            Console.WriteLine("Modificar texto por posición");

                            Console.WriteLine("Dame el número de la línea que quieres editar (entre el (1-10))");
                            linea = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Dame el número de la posición que quieres editar");
                            int posicion = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Dame lo que deseas escribir en esa línea");
                            textoNuevo = Console.ReadLine();

                            if (linea >= 1 && linea <= lineas.Length)
                            {
                                string lineasN = lineas[linea - 1];

                                if (posicion >= 0 && posicion <= lineas.Length)
                                {
                                    string textoN = lineasN.Insert(posicion, textoNuevo);

                                    lineas[linea - 1] = textoN;

                                    File.WriteAllLines(ruta, lineas);

                                    Console.WriteLine("La línea del texto elegida ya ha sido modificada");
                                }
                                else
                                {
                                    Console.WriteLine("Fallo en el número de posición elegido");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Fallo en el número de línea elegido");
                            }

                            }
                            catch (Exception ex)
                            {
                            Console.WriteLine("Error tipo IO en la opción 2: " + ex.Message);
                            }

                        break;
                    }
                }  

        }
    }
}
