Console.WriteLine("Bem vindo à Calculadora de IMC");
Console.WriteLine("Qual a sua altura?");
double altura = double.Parse(Console.ReadLine());
Console.WriteLine("Qual o seu peso?");
double peso = double.Parse(Console.ReadLine());
double imc = CalcularIMC(peso, altura);
Console.WriteLine("O seu IMC se encontra entre: ");
Console.WriteLine(Math.Round(imc, 2));



static double CalcularIMC(double peso, double altura)
{
    double imc = peso / (altura*altura); 
    return imc;
}