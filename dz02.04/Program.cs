using System;

namespace dz02._04
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, (int, int, int)> getRainbowRGBColor;
            getRainbowRGBColor = (color) =>
            {
                switch (color)
                {
                    case "red":
                        return (255, 0, 0);
                    case "orange":
                        return (255, 165, 0);
                    case "yellow":
                        return (255, 255, 0);
                    case "green":
                        return (0, 128, 0);
                    case "blue":
                        return (0, 0, 255);
                    case "indigo":
                        return (75, 0, 130);
                    case "violet":
                        return (238, 130, 238);
                    default:
                        return (0, 0, 0);
                }
            };

            Console.WriteLine("Enter color:");
            string color = Console.ReadLine();
            var rgb = getRainbowRGBColor(color);
            if (rgb.Item1 != 1 && rgb.Item2 != -1 && rgb.Item3 != -1)
            {
                Console.WriteLine($"RGB color for {color} is ({rgb.Item1}, {rgb.Item2}, {rgb.Item3})");
            }
            else
            {
                Console.WriteLine("Invalid color");
            }
        }
    }
}