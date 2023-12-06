using BodyMassIndex.Console.Models;

string? nombre; 
double peso; 
double estatura; 
double imc; 
Persona persona; 
string estadoNutricional;

Console.WriteLine("Programa que calcula el índice de masa corporal de una persona.");


try
{
    // Entrada de datos
 Console.Write("Proporcione el nombre de la persona: ");nombre = Console.ReadLine();
    peso = ReadDouble("Peso de la persona en kilogramos: ");
    estatura = ReadDouble("Estatura de la persona en metros: ");
    
    // Procesamiento
    persona = new Persona(nombre, peso, estatura);imc = CalculadoraIMC.IndiceDeMasaCorporal(persona.Peso, persona.Estatura);estadoNutricional = SituacionNutricionalComoTexto(imc);
    // Salida de datos
     Console.WriteLine();
    Console.WriteLine($"{persona.Nombre} pesa {persona.Peso} kilogramos y mide {persona.Estatura} metros.\n");
    Console.WriteLine($"{persona.Nombre} tiene un índice de masa corporal de {imc} kg/m2.");
    Console.WriteLine($"La situación nutricional de {persona.Nombre} es {estadoNutricional}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");}
double ReadDouble(string s) 
{
    double numero; 
    Console.Write(s); 
    string? entrada = Console.ReadLine(); 
    if (!double.TryParse(entrada, out numero)) 
    { 
        throw new FormatException("El valor proporcionado no es un número."); 
    }
    return numero;
}
string SituacionNutricionalComoTexto(double imc) 
{ 
        CalculadoraIMC.EstadoNutricional estadoNutricional = CalculadoraIMC.SituacionNutricional(imc); 
    switch (estadoNutricional) { 
        case CalculadoraIMC.EstadoNutricional.PesoBajo:
            return "Peso Bajo";
        case CalculadoraIMC.EstadoNutricional.PesoNormal: 
            return "Peso Normal"; 
        case CalculadoraIMC.EstadoNutricional.Sobrepeso: 
            return "Sobrepeso"; 
        case CalculadoraIMC.EstadoNutricional.Obesidad: 
            return "Obesidad"; 
        case CalculadoraIMC.EstadoNutricional.ObesidadExtrema:
            return "Obesidad extrema"; 
        default: return string.Empty; } }



