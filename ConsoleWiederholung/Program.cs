namespace ConsoleWiederholung
{
    class Program
    {
        static double BerechneVolumen(double breite, double länge, double höhe)
        {
            return breite * länge * höhe;
        }

        static double BerechneVerbrauch(double gefahreneKilometer, double getankteLiter)
        {
            return (getankteLiter / gefahreneKilometer) * 100;
        }

        static string GetDatum()
        {
            return DateTime.Now.ToString("dd.MM.yyyy");
        }

        static void Main(string[] args)
        {
            double volumen1 = BerechneVolumen(5.0, 10.0, 2.0);
            double volumen2 = BerechneVolumen(7.5, 3.5, 4.0);

            Console.WriteLine($"Volumen 1: {volumen1}");
            Console.WriteLine($"Volumen 2: {volumen2}");

            double verbrauch1 = BerechneVerbrauch(500.0, 30.0);
            double verbrauch2 = BerechneVerbrauch(750.0, 50.0);

            Console.WriteLine($"Verbrauch vom VW: {verbrauch1:F2} Liter alle 100km");
            Console.WriteLine($"Verbrauch vom Audi: {verbrauch2:F2} Liter alle 100km");

            string aktuellesDatum = GetDatum();
            Console.WriteLine($"Heute ist der {aktuellesDatum}");
        }
    }
}
