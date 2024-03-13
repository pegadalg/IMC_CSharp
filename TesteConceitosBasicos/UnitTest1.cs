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

            //ação

            float imc = calculadora.Calcular(peso, altura);

            //verificação

            Assert.AreEqual(25, imc);

        }

        [TestMethod]

        public void ObterStatusTeste()
        {
            //Cenario
            float imc = 25;
            CalculadoraIMC calculadora = new CalculadoraIMC();
            //ação
            string status = calculadora.ObterStatus(imc);
            //verificação

            Assert.AreEqual(status,"Sobrepeso");
        }
    }
}