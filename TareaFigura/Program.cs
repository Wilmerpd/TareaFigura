using TareaFigura;

List<Figura> figuras = new List<Figura>();

figuras.Add(new Rectangulo(8, 2));
figuras.Add(new Circulo(6));
figuras.Add(new Triangulo(9, 12));

// Calcular y mostrar el área de cada figura
foreach (Figura figura in figuras)
{
    Console.WriteLine($"Área de la figura: {figura.CalcularArea()}");
}