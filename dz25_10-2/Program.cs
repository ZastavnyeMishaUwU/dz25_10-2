namespace dz25_10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введіть кількість реалізованих проектів: ");
            int project = int.Parse(Console.ReadLine());
            Console.Write("Введіть рівень якості : ");
            double vidcotok = double.Parse(Console.ReadLine());
            string result = (project > 10 && vidcotok >= 80) ? "Бонус" : "Немає бонусу";
            Console.WriteLine(result);
        }
    }
}
