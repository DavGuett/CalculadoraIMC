Console.WriteLine("Bem vindo à Calculadora de IMC");
Console.WriteLine("Qual a sua altura?");
double altura = double.Parse(Console.ReadLine());
Console.WriteLine("Qual o seu peso?");
double peso = double.Parse(Console.ReadLine());
double imc = CalcularIMC(peso, altura);
Console.WriteLine("O seu IMC é: " + Math.Round(imc, 2) + " e se encontra entre: ");

if (imc < 18.5)
{
    Console.WriteLine("Menor que 18,5 - MAGREZA");
} else if (imc > 18.5 && imc < 24.9)
{
    Console.WriteLine("Entre 18,5 e 24,9 - NORMAL");
} else if (imc > 25.0 && imc < 29.9)
{
    Console.WriteLine("Entre 25,0 e 29,9 - SOBREPESO");
} else if (imc > 30.0 && imc < 39.9)
{
    Console.WriteLine("Entre 30,0 e 39,9 - OBESIDADE");
} else
{
    Console.WriteLine("Maior que 40,0 - OBESIDADE GRAVE");

}



static double CalcularIMC(double peso, double altura)
{
    double imc = peso / (altura*altura); 
    return imc;
}