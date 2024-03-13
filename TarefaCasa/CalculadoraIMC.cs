using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefaCasa
{
    public class CalculadoraIMC
    {
        public float Calcular(float peso, float altura)
        {
             float imc = peso / (altura * altura);
            return imc;



        }
        public string ObterStatus(float imc)
        {
            string status = string.Empty;
            if (imc < 16)
                status = "Magreza Grave";
            else if (imc <= 16.9)
                status = "Magreza Moderada";
            else if (imc <= 18.5)
                status = "Magreza Leve";
            else if (imc <= 24.9)
                status = "Peso Ideal";
            else if (imc <= 29.9)
                status = "Sobrepeso";
            else if (imc <= 34.9)
                status = "Obesidade I";
            else if (imc <= 39.9)
                status = "Obesidade II";
            else
                status = "Obesidade III";

            return status;
        }

    }
}
