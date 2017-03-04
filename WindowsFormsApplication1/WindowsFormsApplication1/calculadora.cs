using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public   class calculadora
    {
        private int numeroUno;
        private int numeroDos;
        private  double resultado;


        public calculadora() {

        }
            
            

        public int NumeroUno
        {
            get
            {
                return numeroUno;
            }

            set
            {
                numeroUno = value;
            }
        }

        public int NumeroDos
        {
            get
            {
                return numeroDos;
            }

            set
            {
                numeroDos = value;
            }
        }

        public double Resultado
        {
            get
            {
                return resultado;
            }

            set
            {
                resultado = value;
            }
        }

        public calculadora(int numeroUno, int numeroDos)
        {
            this.NumeroUno = numeroUno;
            this.NumeroDos = numeroDos;
           
        }
        public  double suma() {
            resultado = numeroUno + NumeroDos;
            return resultado;
        }
        public double resta() {
            return resultado = numeroUno - NumeroDos;
        }
        public double multiplicacion() {
            resultado = numeroUno * NumeroDos;
            return resultado;
        }
        
    }
}
