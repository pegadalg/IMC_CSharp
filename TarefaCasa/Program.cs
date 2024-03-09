
using TarefaCasa;

float peso, altura;
bool prossiga;
prossiga = true;

do
{
    try
    {
        Console.WriteLine("Digite o peso: ");
        peso = float.Parse(Console.ReadLine());
        if (peso < 0 )
        {
            Console.WriteLine("O peso deve ser positivo");
            continue;
        }
        Console.WriteLine("Digite a altura: ");
        altura = float.Parse(Console.ReadLine());
        if (altura < 0)
        {
            Console.WriteLine("A altura deve ser positiva");
            continue;
        }
        
        var calculadoraIMC = new CalculadoraIMC();
      
        Console.WriteLine($"Seu IMC é: {calculadoraIMC.Calcular(peso, altura)}");
        Console.WriteLine(calculadoraIMC.ObterStatus(calculadoraIMC.Calcular(peso,altura)));

        prossiga = false;
    }
    catch (FormatException)
    {
        Console.WriteLine("Formato Inválido. Digite apenas números");
    }
}
while (prossiga);