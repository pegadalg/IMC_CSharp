using TarefaCasa;

namespace TesteConceitosBasicos
{
    [TestClass]
    public class CalculadoraIMCTeste
    {
        [TestMethod]
        public void CalcularTeste()
        {
            //cenario
            float peso = 70f;
            float altura = 1.7f;
            CalculadoraIMC calculadora = new CalculadoraIMC();

            //a��o

            float imc = calculadora.Calcular(peso, altura);

            //verifica��o
        }
    }
}