using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Espacio de nombre
namespace division
{
    //Clase
    internal class cldivision
    {
        //Atributos, caractersiticas, campos
        private double n1;
        private double n2;

        public cldivision(double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        //Constructor
        public cldivision(double n1)
        {
            this.n1 = n1;
        }

        //Método
        public double division()
        {
            return (n1 / n2);
        }
    }
}
//Aqui termina el espacio de nombre