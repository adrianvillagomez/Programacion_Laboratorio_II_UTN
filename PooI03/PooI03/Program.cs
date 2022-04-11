using System;
using Entidades;
namespace PooI03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante alunmoUno = new Estudiante("Juan", "Perez", "AAA");
            Estudiante alunmoDos = new Estudiante("Franco", "rodrigez", "BBB");
            Estudiante alunmoTres = new Estudiante("Fio", "fernandez", "CCC");
            alunmoUno.SetNotaPrimerParcial(3);
            alunmoUno.SetNotaSegundoParcial(3);
            alunmoDos.SetNotaPrimerParcial(10);
            alunmoDos.SetNotaSegundoParcial(10);
            alunmoTres.SetNotaPrimerParcial(9);
            alunmoTres.SetNotaSegundoParcial(8);
            alunmoUno.Mostrar();
            alunmoDos.Mostrar();
            alunmoTres.Mostrar();
        }
    }
}
