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
            float peso = 100f;
            float altura = 2f;
            CalculadoraIMC calculadora = new CalculadoraIMC();

            //a��o

            float imc = calculadora.Calcular(peso, altura);

            //verifica��o

            Assert.AreEqual(25, imc);

        }

        [TestMethod]

        public void ObterStatusTeste()
        {
            //Cenario
            float imc = 25;
            CalculadoraIMC calculadora = new CalculadoraIMC();
            //a��o
            string status = calculadora.ObterStatus(imc);
            //verifica��o

            Assert.AreEqual(status,"Sobrepeso");
        }
    }
}