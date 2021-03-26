using System;

namespace Programacion_Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
              //Variables
            string dato = "";
            int TamañoPerro;
            int ActividadPerro;
            int opcion;
            int Meses;
            double PesoIdeal;


            do
            {
                //Enunciado

                Console.WriteLine("Bienvenidos a la empresa DogNutrition. JM");
                Console.WriteLine("");
                Console.WriteLine("DogNutrition.JM es el espacio encargado de mantener una nutricion sana y estable de sus mascotas, para que el programa funcione debe saber lo siguiente:");
                Console.WriteLine("");
                //parametros

                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine("* Tamaño de su mascota");
                Console.WriteLine("* Actividad cotidiana de su mascota");
                Console.WriteLine("* Edad de su mascota en meses 1-12");
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine("");

                Console.WriteLine("Indique el tamaño de su perro.");
                Console.WriteLine("");
                Console.WriteLine("1- Miniatura");
                Console.WriteLine("2- Pequeño");
                Console.WriteLine("3- Mediano");
                Console.WriteLine("4- Grande");
                TamañoPerro = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");

                //Actividad cotidiana
                Console.WriteLine("¿Como considera la actividad contidiana de su mascota?");
                Console.WriteLine("");
                Console.WriteLine("1- Actividad Alta");
                Console.WriteLine("2- Actividad Normal");
                Console.WriteLine("3- Actividad Baja");
                ActividadPerro = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");

                //Edad
                Console.WriteLine("¿Cuantos meses tiene su perro?");
                Meses = Convert.ToInt32(Console.ReadLine());


                if (Meses <= 12 && Meses >=1)
                {
              
                //tamaño del perro
                
                switch (TamañoPerro)
                {
                //Tamaño miniatura
                case 1:
                {
                Console.WriteLine("");

                //2 meses o menos
                if (Meses <= 2)
                {
                Console.WriteLine("Su mascota debe consumir 50 gramos de comida");
                }
                // 3 meses
                else if (Meses == 3)
                {

                Console.WriteLine("Su mascota debe consumir  60 gramos de comida");
                }
                //4 meses
                else if (Meses == 4)
                {

                Console.WriteLine("Su mascota debe consumir  60 gramos de comida");
                }
                //5 meses
                else if (Meses == 5)
                {
                Console.WriteLine("Su mascota debe consumir  60 gramos de comida");
                }
                //6 meses o mas 
                else if (Meses >= 6)
                {
                Console.WriteLine("Su mascota debe consumir  55 gramos de comida");
                }
                }
                break;

                case 2:
                {

               // Tamaño cachorro pequeño

                Console.WriteLine("Escriba el peso ideal de su mascota");
                Console.WriteLine("1- 5 kilogramos");
                Console.WriteLine("2- 10 kilogramos");
               PesoIdeal = Convert.ToDouble(Console.ReadLine());

                 // Peso 5 Kilogramos
                 if (PesoIdeal == 1)
                {
                //2 meses 
                 if (Meses <= 2)
                 {
                 Console.WriteLine("Su mascota debe consumir 95 gramos de comida");
                 }
                 // 3 meses
                 else if (Meses == 3)
                 {

                 Console.WriteLine("Su mascota debe consumir  110 gramos de comida");
                 }
                 //4 meses 
                 else if (Meses == 4)
                 {

                 Console.WriteLine("Su mascota debe consumir  115 gramos de comida");
                 }
                 //5 meses
                 else if (Meses == 5)
                {
                 Console.WriteLine("Su mascota debe consumir  115 gramos de comida");
                 }
                 //6 meses
                 else if (Meses >= 6)
                {
                 Console.WriteLine("Su mascota debe consumir  110 gramos de comida");
                }

                }
                else if (PesoIdeal == 2)
                {
                if (Meses <= 2)
                {
                 Console.WriteLine("Su mascota debe consumir 155 gramos de comida");
                }

                else if (Meses == 3)
                {

                Console.WriteLine("Su mascota debe consumir  185 gramos de comida");
                }
                else if (Meses == 4)
                {

                Console.WriteLine("Su mascota debe consumir  195 gramos de comida");
                }
                else if (Meses == 5)
                {
                Console.WriteLine("Su mascota debe consumir  190 gramos de comida");
                }
                else if (Meses >= 6)
                {
                Console.WriteLine("Su mascota debe consumir  185 gramos de comida");
                }

                }

                }
                break;

                // Tamaño cachorro medianos
                
                case 3:
                {
                Console.WriteLine("");

                //2 meses
                if (Meses <= 2)
                {
                Console.WriteLine("Su mascota debe consumir 215 gramos de comida");
                }
                // 3 meses
                else if (Meses == 3)
                {

                Console.WriteLine("Su mascota debe consumir  265 gramos de comida");
                }
                //4 meses
                else if (Meses == 4)
                {

                Console.WriteLine("Su mascota debe consumir  285 gramos de comida");
                }
                //5 meses
                else if (Meses == 5)
                {
                Console.WriteLine("Su mascota debe consumir  285 gramos de comida");
                }
                //6 meses 
                else if (Meses >= 6)
                {
                Console.WriteLine("Su mascota debe consumir  280 gramos de comida");
                }
                }
                break;

                case 4:
                {

                //Tamaño cachorro grandes

                Console.WriteLine("Seleccione el peso ideal de su mascota");
                Console.WriteLine("1- 25 kilogramos");
                Console.WriteLine("2- 32 kilogramos");
                Console.WriteLine("3- 40 kilogramos");
                Console.WriteLine("4- 50 kilogramos");
                Console.WriteLine("5- 60 kilogramos");
                Console.WriteLine("6- 70 kilogramos");
                Console.WriteLine("7- 90 kilogramos");
               
                PesoIdeal = Convert.ToDouble(Console.ReadLine());

                //Peso 25 kilogramos

                if (PesoIdeal == 1)
                {
                //2 meses
                if (Meses <= 2)
                {
                Console.WriteLine("Su mascota debe consumir 270 gramos de comida");
                }
                // 3 meses
                else if (Meses == 3)
                {

                Console.WriteLine("Su mascota debe consumir  350 gramos de comida");
                }
                //4 meses 
                else if (Meses == 4)
                {

                Console.WriteLine("Su mascota debe consumir  375 gramos de comida");
                }
                //5 meses
                else if (Meses == 5)
                {
                Console.WriteLine("Su mascota debe consumir  375 gramos de comida");
                }
                //6 meses 
                else if (Meses >= 6)
                { 
                Console.WriteLine("Su mascota debe consumir  370 gramos de comida");
                }

                }
                //Peso 32 kilogramos

                else if (PesoIdeal == 2)
                {
                if (Meses <= 2)
                {
                Console.WriteLine("Su mascota debe consumir 300 gramos de comida");
                }

                else if (Meses == 3)
                {

                Console.WriteLine("Su mascota debe consumir  400 gramos de comida");
                }
                else if (Meses == 4)
                {

                Console.WriteLine("Su mascota debe consumir  445 gramos de comida");
                }
                else if (Meses == 5)
                {
                Console.WriteLine("Su mascota debe consumir  450 gramos de comida");
                }
                else if (Meses >= 6)
                {
                Console.WriteLine("Su mascota debe consumir  450 gramos de comida");
                }
                }

                //Peso 40 kilogramos

                else if (PesoIdeal == 3)
                {
                if (Meses <= 2)
                {
                Console.WriteLine("Su mascota debe consumir 355 gramos de comida");
                }

                else if (Meses == 3)
                {

                Console.WriteLine("Su mascota debe consumir  475 gramos de comida");
                }
                else if (Meses == 4)
                {

                Console.WriteLine("Su mascota debe consumir  525 gramos de comida");
                }
                else if (Meses == 5)
                {
                Console.WriteLine("Su mascota debe consumir  530 gramos de comida");
                }
                else if (Meses >= 6)
                {
                Console.WriteLine("Su mascota debe consumir  530 gramos de comida");
                }
                }
                //Peso 50 kilogramos

                else if (PesoIdeal == 4)
                {
                if (Meses <= 2)
                {
                Console.WriteLine("Su mascota debe consumir 405 gramos de comida");
                }

                else if (Meses == 3)
                {

                Console.WriteLine("Su mascota debe consumir  445 gramos de comida ");
                }
                else if (Meses == 4)
                {

                Console.WriteLine("Su mascota debe consumir  610 gramos de comida");
                }
                else if (Meses == 5)
                {
                Console.WriteLine("Su mascota debe consumir  625 gramos de comida");
                }

                }
                // peso 60 Kilogramos

                else if (PesoIdeal == 5)
                {
                if (Meses <= 2)
                {
                Console.WriteLine("Su mascota debe consumir 450 gramos de comida ");
                }

                else if (Meses == 3)
                {

                Console.WriteLine("Su mascota debe consumir  605 gramos de comida ");
                }
                else if (Meses == 4)
                {

                Console.WriteLine("Su mascota debe consumir  685 gramos de comida ");
                }

                }
                // Peso 70kilogramos
                else if (PesoIdeal == 6)
                {
                if (Meses <= 2)
                {
                Console.WriteLine("Su mascota debe consumir 485 gramos de comida ");
                }

                else if (Meses == 3)
                {

                Console.WriteLine("Su mascota debe consumir  670 gramos de comida ");
                }
                }
                // Peso 90 kilogramos
                else if (PesoIdeal == 7)
                {
                if (Meses <= 2)
                {
                Console.WriteLine("Su mascota debe consumir 580 gramos de comida ");
                }

                }

                }
                break;
                }
                }

                Console.WriteLine("Si desea continuar escriba 1 de lo contrario escriba 4");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);

                Console.Clear();
                } 
            while (opcion != 4) ;
            
        }
    }
}  