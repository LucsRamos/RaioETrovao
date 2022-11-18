Console.WriteLine("Raio e Travão\n");
Console.WriteLine($"trovão a {30} segundos ==> raio caiu a {DistanciaDoRaioKm(30):N5} quilômetros");
Console.WriteLine($"trovão a {40} segundos ==> raio caiu a {DistanciaDoRaioKm(40):N5} quilômetros");
double DistanciaDoRaioKm(double segundos)
{
    const double VelocidadeDoSomKmS = 340.29 / 1000;
    return segundos * VelocidadeDoSomKmS;
}