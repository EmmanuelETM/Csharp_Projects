using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace FichaPolicial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Eleccion;

            //Instancia de la clase Ciudadano

            Ciudadano vCiudadano = new Ciudadano(1, 19, 0, "Juan Pedro", "Martinez Ramirez", "1234123094871", "Dominicano", 'M', true);

            ArrayList ACiudadano = new ArrayList();
            ACiudadano.Add(vCiudadano);

            //Instancia de la clase OficialPolicia
            OficialPolicia vOficialPolicia = new OficialPolicia(1,246810, 45, "Pakito", "Ramirez", "Tte.", true); 
            ArrayList Aoficial = new ArrayList(); //Arraylist para la clase OficialPolici
            Aoficial.Add(vOficialPolicia);

            //Instancia de la clase Delito
            Delito vDelito = new Delito(1, 0, "Asalto Mano Armada","Robo", "2ndo", true); 
            ArrayList ADelito = new ArrayList(); //Arraylist para la clase delito
            ADelito.Add(vDelito);

            //Instancia de la clase Ficha 
            Ficha vFicha = new Ficha(vCiudadano, vDelito, vOficialPolicia, "12/12/2012", 1); 
            ArrayList AFicha = new ArrayList(); //ArrayList para la clase ficha
            AFicha.Add(vFicha);
            vCiudadano.AgregarFicha(AFicha, vFicha.GetIdFicha());

            do
            { 
                Console.Clear();
                Titulo();
                Menu();
                Marcos(23, 101, 1, 7);
                Eleccion = Opcion();
                MenuChoice(Eleccion, ACiudadano, Aoficial, ADelito, AFicha);
                //Console.ReadKey();

            } while(Eleccion != 0);
            
        }
        public static void Limpiar(int x1, int x2, int y1, int y2)
        {//(1,79,7,35)
            for (int x = x1; x <= x2; x++)
                for (int y = y1; y <= y2; y++)
                {
                    Console.SetCursorPosition(x, y); Console.Write(" ");
                }
        }
        public static void Titulo()
        {
            string e1 ="************************La Vega Police Department************************",
                e2 = "Archivo de Fichas Policiales",
                e3 = "Emmanuel Torres Malena 2021-1097 / William de los Santos 2021-1368",
                e4 = "Carlos Reynoso 2021-1188 / Eddy Leonardo 2021-0942 / Neifi Anibal 2021-0959",
                e5 = "Fecha de Entrega: 13/02/2022";

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition((125 - e1.Length) / 2, 2); Console.Write(e1);
            Console.ResetColor();    

            Console.SetCursorPosition((125 - e2.Length) / 2, 3); Console.Write(e2);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition((125 - e3.Length) / 2, 4); Console.Write(e3);
            Console.ResetColor();

            Console.SetCursorPosition((125 - e4.Length) / 2, 5); Console.Write(e4);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition((125 - e5.Length) / 2, 6); Console.Write(e5);
            Console.ResetColor();
        }

        public static void Marcos(int x1, int x2, int y1, int y2)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            //Horizontales
            for (int x = x1; x <= x2; x++)
            {
                Console.SetCursorPosition(x, y1); Console.Write("─");
                Console.SetCursorPosition(x, y2); Console.Write("─");
            }
            //Verticales
            for (int y = y1; y <= y2; y++)
            {
                Console.SetCursorPosition(x1, y); Console.Write("│");
                Console.SetCursorPosition(x2, y); Console.Write("│");
            }
            
            Console.SetCursorPosition(x1, y1); Console.Write('┌');
            Console.SetCursorPosition(x2, y1); Console.Write('┐');
            Console.SetCursorPosition(x1, y2); Console.Write('└');
            Console.SetCursorPosition(x2, y2); Console.Write('┘');
            Console.ResetColor();
        }

        public static void Menu()
        {
            string t1 = "Menu Principal";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition((125 - t1.Length) / 2, 9); Console.Write(t1);
            Console.ResetColor();

            Console.SetCursorPosition(25, 11); Console.Write("1. Registrar Ciudadano");
            Console.SetCursorPosition(25, 12); Console.Write("2. Registrar Oficial de Policia");
            Console.SetCursorPosition(25, 13); Console.Write("3. Registrar Delito");
            Console.SetCursorPosition(25, 14); Console.Write("4. Registrar Ficha Policial");
            Console.SetCursorPosition(25, 15); Console.Write("5. Consultar Ciudadanos");
            Console.SetCursorPosition(25, 16); Console.Write("6. Consultar Policias");
            Console.SetCursorPosition(25, 17); Console.Write("7. Consultar Delitos");
            Console.SetCursorPosition(25, 18); Console.Write("8. Consultar Fichas por Ciudadano");
            Console.SetCursorPosition(25, 19); Console.Write("9. Archivo de Fichas Policiales");
            Console.SetCursorPosition(25, 20); Console.Write("0. Salir del Programa");
        }
        public static int Opcion()
        {
            int cool = 1;
            do
            {
                try
                {
                    Console.SetCursorPosition(25, 22); Console.Write("Choice: ");
                    cool = Convert.ToInt32(Console.ReadLine());

                    if (cool < 0 || cool > 9)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(25, 25); Console.WriteLine("Esa opcion no esta en nuestro programa. Intente de nuevo!");
                        Console.ResetColor();
                    }
                }
                catch (Exception error)
                {
                    Limpiar(1, 50, 25, 25);
                    
                    Console.SetCursorPosition(25, 25); Console.WriteLine(error.Message);
                    Console.ResetColor();
                }

            } while (cool < 0 || cool > 9);
            return cool;
        }

        public static int Consultar(string head, int x, int y)
        {
            int numero;
            while (true)
            {
                try
                {
                    Console.SetCursorPosition(x, y); Console.Write(head);
                    numero = Convert.ToInt32(Console.ReadLine());

                    if (numero.GetType() == typeof(int))
                    {
                        return numero;

                    }
                }
                catch (Exception error)
                {
                    Limpiar(x, 80, y, y);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(x, (y+3)); Console.WriteLine(error.Message);
                    Console.ResetColor();
                }
            }
            

        }

        public static void MenuChoice(int opcion, ArrayList aciudadano, ArrayList aoficial, ArrayList adelito, ArrayList aficha)
        {
            switch (opcion)
            {
                case 1:
                    RegistrarCiudadano(aciudadano);                    
                    break;
                case 2:
                    RegistrarOficial(aoficial);
                    break;
                case 3:
                    RegistrarDelito(adelito);
                    break;
                case 4:
                    RegistrarFichas(aciudadano, adelito, aoficial, aficha);
                    break;
                case 5:
                    ConsultarCiudadanos(aciudadano);
                    break;
                case 6:
                    ConsultarOficial(aoficial);
                    break;
                case 7:
                    ConsultarDelito(adelito);
                    break;
                case 8:
                    FichasCiudadanos(aciudadano, aficha);
                    break;
                case 9:
                    ConsultarFichas(aficha);
                    break;
            }
        }

        //Consultas del Programa

        //Registrar Ciudadano
        public static void RegistrarCiudadano(ArrayList Aciudadano)
        {
            int vIdCiudadano = 0, vEdad = 0, vCantidadFichas = 0;
            string vNombres = "", vApellidos = "", vCedula = "", vNacionalidad = "";
            char vSexo = 'M';
            bool vActivo=false;
            Limpiar(1, 79, 9, 25);

            Console.SetCursorPosition(51, 9); Console.Write("Registro de Ciudadano");

            Console.SetCursorPosition(30, 13); Console.Write("Nombres...........: ");
            vNombres = Console.ReadLine();

            Console.SetCursorPosition(30, 14); Console.Write("Apellidos.........: ");
            vApellidos = Console.ReadLine();

            vEdad = Consultar("Edad..............: ", 30, 15);
            Limpiar(1, 80, 18, 18);

            Console.SetCursorPosition(30, 16); Console.Write("Sexo (M/F)........: ");
            vSexo = Convert.ToChar(Console.ReadLine());
            

            Console.SetCursorPosition(30, 17); Console.Write("Cedula......: ");
            vCedula = Console.ReadLine();

            Console.SetCursorPosition(30, 18); Console.Write("Nacionalidad......: ");
            vNacionalidad = Console.ReadLine();

            vIdCiudadano = Aciudadano.Count + 1;

            Aciudadano.Add(new Ciudadano(vIdCiudadano, vEdad, vCantidadFichas, vNombres, vApellidos, vCedula, vNacionalidad, vSexo, vActivo));
            Limpiar(1, 79, 7, 25);
        }

        public static void RegistrarOficial(ArrayList aoficial)
        {
            
            int vIdPolicia = 0, vNumeroPlaca = 0, vEdad = 0;
            string vNombre = "", vApellidos = "", vRango = "";
            bool vActivo = false;
            Limpiar(1, 79, 9, 25);

            Console.SetCursorPosition(51, 9); Console.Write("Registro de Delito");

            Console.SetCursorPosition(30, 13); Console.Write("Nombre............: ");
            vNombre = Console.ReadLine();

            Console.SetCursorPosition(30, 14); Console.Write("Apellidos.........: ");
            vApellidos = Console.ReadLine();

            vEdad = Consultar("Edad..............: ", 30, 15);
            Limpiar(1, 80, 18, 18);
            vNumeroPlaca = Consultar("Numero Placa......: ", 30, 16);
            Limpiar(1, 80, 19, 19);

            Console.SetCursorPosition(30, 17); Console.Write("Rango.............: ");
            vRango = Console.ReadLine();

            vIdPolicia = aoficial.Count + 1;

            aoficial.Add(new OficialPolicia(vIdPolicia, vNumeroPlaca, vEdad, vNombre, vApellidos, vRango, vActivo));
            Limpiar(1, 79, 9, 25);
        }


        public static void RegistrarDelito(ArrayList adelito)
        {
            int vIdDelito = 0, vCantidadFichas = 0;
            string vNombreDelito = "", vGradoDelito = "", vTipoDelito="";
            bool vActivo = false;
            Limpiar(1, 79, 9, 25);

            Console.SetCursorPosition(51, 9); Console.Write("Registro de Delito");

            Console.SetCursorPosition(30, 13); Console.Write("Nombre...........: ");
            vNombreDelito = Console.ReadLine();

            Console.SetCursorPosition(30, 14); Console.Write("Tipo de Delito...: ");
            vTipoDelito = Console.ReadLine();

            Console.SetCursorPosition(30, 15); Console.Write("Grado Delito.....: ");
            vGradoDelito = Console.ReadLine();

            vIdDelito = adelito.Count + 1;

            adelito.Add(new Delito(vIdDelito,vCantidadFichas, vNombreDelito, vTipoDelito, vGradoDelito, vActivo));
            Limpiar(1, 79, 9, 25);
        }


        public static void RegistrarFichas(ArrayList aciudadano, ArrayList adelito, ArrayList aoficial, ArrayList aficha)
        {
            int vIdCiudadano=0, vIdDelito=0, vIdOficial=0, vIdFicha=0;
            string vFecha="";

            //Variables para guardar los objetos
            Ciudadano oCiudadano = new Ciudadano();
            Delito oDelito = new Delito();
            OficialPolicia oPolicia = new OficialPolicia();

            Limpiar(1, 79, 9, 25);

            Console.SetCursorPosition(51, 9); Console.Write("Registro de Ficha Policial");

            //Id del ficha
            vIdFicha = aficha.Count + 1;

            Console.SetCursorPosition(30, 13); Console.Write("Fecha (DD/MM/AA)..: ");
            vFecha = Console.ReadLine();
            Limpiar(1, 79, 9, 45);

            ConsultarCiudadanos(aciudadano);
            vIdCiudadano = Consultar("ID Ciudadano.......: ", 30, 20);
            Limpiar(1, 115, 9, 45);

            ConsultarDelito(adelito);
            vIdDelito = Consultar("ID Delito..........: ", 30, 20);
            Limpiar(1, 110, 9, 45);
            
            ConsultarOficial(aoficial);
            vIdOficial = Consultar("ID Oficial........: ", 30, 20);
            Limpiar(1, 110, 9, 45);


            //Bucles para encontrar los objeto por el Id

            //Objeto Ciudadano
            foreach(Ciudadano c in aciudadano)
            {
                int id = c.GetIDCiudadano();

                if (id == vIdCiudadano) 
                { 
                    oCiudadano = c;
                    break;
                }
                else 
                    continue;
            }

            //Objeto Delito
            foreach (Delito d in adelito)
            {
                int id = d.GetIdDelito();

                if (id == vIdDelito) 
                { 
                    oDelito = d;
                    break;
                }
                else 
                    continue;
            }

            //Objeto OficialPolicia
            foreach (OficialPolicia Op in aoficial)
            {
                int id = Op.GetIdPolicia();

                if (id == vIdOficial) 
                {
                    oPolicia = Op; 
                    break;
                }
                else continue;
            }

            Ficha ficha = new Ficha(oCiudadano, oDelito, oPolicia, vFecha, vIdFicha);
            aficha.Add(ficha);

            oCiudadano.AgregarFicha(aficha, vIdFicha); //Agregar ficha al arraylist del objeto. :)
            oCiudadano.SetActivo(true);
            oDelito.SetActivo(true);
            oPolicia.SetActivo(true);
        }



        //archivo de Ciudadanos
        public static void ConsultarCiudadanos(ArrayList aciudadano)
        {
            int fila = 13;
            Limpiar(1, 79, 9, 25);
            Console.SetCursorPosition(51, 10); Console.Write("Archivo de Ciudadanos");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(5, 12); Console.Write(" IdCiudadano |    Nombres    |     Apellidos     | Edad | Sexo |       Cedula       | Nacionalidad |  Estado  ");
            Console.ResetColor();

            foreach(Ciudadano c in aciudadano)
            {
                Console.SetCursorPosition(10, fila); Console.Write(c.GetIDCiudadano());

                Console.SetCursorPosition(21, fila); Console.Write(c.GetNombres());

                Console.SetCursorPosition(35, fila); Console.Write(c.GetApellidos());

                Console.SetCursorPosition(56, fila); Console.Write(c.GetEdad());

                Console.SetCursorPosition(63, fila); Console.Write(c.GetSexo());
                
                Console.SetCursorPosition(71, fila); Console.Write(c.GetCedula());

                Console.SetCursorPosition(91, fila); Console.Write(c.GetNacionalidad());

                Console.SetCursorPosition(106, fila); Console.Write((c.GetActivo()) ? "Activo" : "Inactivo");
                fila++;
            }
            Console.ReadKey();
        }




        //Archivo de Policias
        public static void ConsultarOficial(ArrayList aoficial)
        {
            int fila = 13;
            Limpiar(1, 79, 9, 25);
            Console.SetCursorPosition(51, 9); Console.Write("Archivo de Policias");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            //int idpolicia, int numeroplaca, int edad, string nombre, string apellidos, string rango, bool activo
            Console.SetCursorPosition(18, 12); Console.Write(" IdOficial |    Nombres    |     Apellidos     | Edad | Numero Placa | Rango |  Estado  ");
            Console.ResetColor();

            foreach (OficialPolicia Op in aoficial)
            {
                Console.SetCursorPosition(25, fila); Console.Write(Op.GetIdPolicia());

                Console.SetCursorPosition(32, fila); Console.Write(Op.GetNombre());

                Console.SetCursorPosition(49, fila); Console.Write(Op.GetApellidos());

                Console.SetCursorPosition(68, fila); Console.Write(Op.GetEdad());

                Console.SetCursorPosition(76, fila); Console.Write(Op.GetNumeroPlaca());

                Console.SetCursorPosition(90, fila); Console.Write(Op.GetRango());

                Console.SetCursorPosition(97, fila); Console.Write((Op.GetActivo()) ? "Activo" : "Inactivo");
                fila++;
            }
            Console.ReadKey();
        }




        //Consultar Archivo Delitos
        public static void ConsultarDelito(ArrayList adelito)
        {
            int fila = 13;
            Limpiar(1, 79, 9, 25);
            Console.SetCursorPosition(51, 9); Console.Write("Archivo de Delitos");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(20, 12); Console.Write(" IdDelito |       Nombre        |  Tipo Delito  | Grado | No Fichas |   Estado   ");
            Console.ResetColor();

            foreach (Delito d in adelito)
            {
                Console.SetCursorPosition(25, fila); Console.Write(d.GetIdDelito());

                Console.SetCursorPosition(32, fila); Console.Write(d.GetNombreDelito());

                Console.SetCursorPosition(56, fila); Console.Write(d.GetTipoDelito());

                Console.SetCursorPosition(69, fila); Console.Write(d.GetGradoDelito());

                Console.SetCursorPosition(82, fila); Console.Write(d.GetCantidadFichas());

                Console.SetCursorPosition(91, fila); Console.Write((d.GetActivo()) ? "Activo" : "Inactvo");
                fila++;
            }
            Console.ReadKey();
        }

        public static void FichasCiudadanos(ArrayList aciudadanos, ArrayList aficha)
        {

            int fila = 13;
            Limpiar(1, 79, 9, 25);
            Console.SetCursorPosition(51, 9); Console.Write("Fichas por Ciudadanos");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(33, 12); Console.Write(" IdCiudadano |    Nombres    |     Apellidos     | Fichas ");
            Console.ResetColor();

            foreach (Ciudadano c in aciudadanos)
            {
                Console.SetCursorPosition(40, fila); Console.Write(c.GetIDCiudadano());

                Console.SetCursorPosition(49, fila); Console.Write(c.GetNombres());

                Console.SetCursorPosition(64, fila); Console.Write(c.GetApellidos());

                Console.SetCursorPosition(86, fila); Console.Write(c.ContarFichas(aficha));

                fila++;
            }

            int vIdCiudadano = 0;
            Ciudadano vCiudadano = new Ciudadano();

            Console.SetCursorPosition(51, 20); Console.Write("ID Ciudadano.......: ");
            vIdCiudadano = Convert.ToInt32(Console.ReadLine());

            foreach(Ciudadano c in aciudadanos)
            {
                if(vIdCiudadano == c.GetIDCiudadano())
                {
                    vCiudadano = c; break;
                }
            }

            ArrayList aFichaCiudadano = vCiudadano.GetAficha();


            fila = 13;
            Limpiar(1, 79, 9, 25);
            Console.SetCursorPosition(51,10); Console.Write("Fichas por Ciudadanos");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(10, 12); Console.Write(" IdFicha |        Nombre Ciudadano        |        Delito        |     Dentenido por     |     Fecha     ");
            Console.ResetColor();

            foreach (Ficha f in aFichaCiudadano)
            {
                Console.SetCursorPosition(13, fila); Console.Write(f.GetIdFicha());

                Console.SetCursorPosition(22, fila); Console.Write(f.GetNombreCiudadano());

                Console.SetCursorPosition(55, fila); Console.Write(f.GetNombreDelito());

                Console.SetCursorPosition(81, fila); Console.Write(f.GetNombrePolicia());

                Console.SetCursorPosition(102, fila); Console.Write(f.GetFecha());

                fila++;
            }
            Console.ReadKey();
        }



        public static void ConsultarFichas(ArrayList afichas)
        {
            int fila = 13;
            Limpiar(1, 79, 9, 25);
            Console.SetCursorPosition(51, 9); Console.Write("Archivo de Delitos");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            
            Console.SetCursorPosition(7, 12); Console.Write(" IdFicha |        Nombre Ciudadano        |        Delito        |     Dentenido por     |     Fecha     ");
            Console.ResetColor();

            foreach (Ficha f in afichas)
            {
                Console.SetCursorPosition(12, fila); Console.Write(f.GetIdFicha());

                Console.SetCursorPosition(19, fila); Console.Write(f.GetNombreCiudadano());

                Console.SetCursorPosition(52, fila); Console.Write(f.GetNombreDelito());

                Console.SetCursorPosition(78, fila); Console.Write(f.GetNombrePolicia());

                Console.SetCursorPosition(100, fila); Console.Write(f.GetFecha());
                fila++;
            }
            
            Console.ReadKey();
        }
    }
}
