using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Confech;
    public class Universidad
    {
        public string Nombre { get; set; }
        public int Aceptar { get; set; }
        public int Rechazar { get; set; }
        public int Nulo { get; set; }
        public int Blanco { get; set; }

        public  Universidad(string nombre)
        {
            Nombre=nombre;
            Aceptar=0;
            Rechazar=0;
            Nulo=0;
            Blanco=0;
        }
        public void RegistrarVoto(string voto){
            switch(voto)
            {
                case "A":
                Aceptar++;
                break;
                case "R":
                Rechazar++;
                break;
                case "N":
                Nulo++;
                break;
                case"B":
                Blanco++;
                break;
            }
        }
        public void MostrarTotalesVotos(){
            Console.WriteLine($"Aceptar:{Aceptar}");
            Console.WriteLine($"Rechazar:{Rechazar}");
            Console.WriteLine($"Nulo:{Nulo}");
            Console.WriteLine($"Blanco:{Blanco}");

        }
    }

class Program{
public static void Main(){

    static Universidad RegistrarUniversidad(){
        Console.Write("Ingrese el nombre de la universidad:");
        string nombre=Console.ReadLine();

        Universidad universidad =new Universidad(nombre);
        Console.WriteLine("Ingrese los votos de los alumnos(A:aceptar, R:rechazar, N:nulo, B:blanco).Terminar con X");
        while(true)
        {
            Console.Write("Voto:");
            string voto= Console.ReadLine().ToUpper();
            if(voto=="X"){
                break;
            }
            universidad.RegistrarVoto(voto);
        }
        Console.WriteLine("Totales de votos para la universidad:");
        universidad.MostrarTotalesVotos();
        return universidad;
    }
    static void MostrarResultados(List<Universidad> universidades)
    {
        int universidadesAceptar = 0;
        int universidadesRechazar = 0;
        int universidadesEmpate = 0;

        Console.WriteLine("Resultados de la votación por universidades:");

        foreach (var universidad in universidades)
        {
            if (universidad.Aceptar > universidad.Rechazar)
            {
                Console.WriteLine($"{universidad.Nombre}: Aceptar ({universidad.Aceptar}) - Rechazar ({universidad.Rechazar}) - Empate (0)");
                universidadesAceptar++;
            }
            else if (universidad.Aceptar < universidad.Rechazar)
            {
                Console.WriteLine($"{universidad.Nombre}: Aceptar ({universidad.Aceptar}) - Rechazar ({universidad.Rechazar}) - Empate (0)");
                universidadesRechazar++;
            }
            else
            {
                Console.WriteLine($"{universidad.Nombre}: Aceptar ({universidad.Aceptar}) - Rechazar ({universidad.Rechazar}) - Empate (1)");
                universidadesEmpate++;
            }
        }

        Console.WriteLine($"Total de universidades que aceptan: {universidadesAceptar}");
        Console.WriteLine($"Total de universidades que rechazan: {universidadesRechazar}");
        Console.WriteLine($"Total de universidades con empate: {universidadesEmpate}");
    }
    {
        Console.Write("Ingrese la cantidad de universidades que participan en el proceso: ");
        int cantidadUniversidades = int.Parse(Console.ReadLine());

        List<Universidad> universidades = new List<Universidad>();

        for (int i = 0; i < cantidadUniversidades; i++)
        {
            Universidad universidad = RegistrarUniversidad();
            universidades.Add(universidad);
        }

        MostrarResultados(universidades);
    } 

}
}