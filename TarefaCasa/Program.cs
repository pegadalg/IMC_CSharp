
float imc, peso, altura;
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
            imc = peso / (altura * altura);

        if (imc < 18.5)
        { Console.WriteLine($"Seu imc é: {imc} e você está abaixo do peso"); }
        else if(imc >= 18.6 && imc <=24.9) 
        { Console.WriteLine($"Seu imc é: {imc} e você está com o peso ideal"); }
        else if (imc >= 25 && imc <= 29.9)
        { Console.WriteLine($"Seu imc é: {imc} e você está levemente acima do peso"); }
        else if (imc >= 30 && imc <= 34.9)
        { Console.WriteLine($"Seu imc é: {imc} e você está com obesidade grau I"); }
        else if (imc >= 35 && imc <= 39.9)
        { Console.WriteLine($"Seu imc é: {imc} e você está com obesidade grau II (Severa)"); }
        else 
        { Console.WriteLine($"Seu imc é: {imc} e você está com obesidade grau III (Morbida)"); }

        prossiga = false;
    }
    catch (FormatException)
    {
        Console.WriteLine("Formato Inválido. Digite apenas números");
    }
}
while (prossiga);