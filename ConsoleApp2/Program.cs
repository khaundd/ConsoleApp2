Console.WriteLine("Сторона a = ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Сторона b = ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Угол между a и b = ");
int alpha = Convert.ToInt32(Console.ReadLine());
double c;
c = Math.Round(Math.Sqrt(Math.Pow(a, 2)+ Math.Pow(b, 2)-2*a*b*Math.Cos(alpha*(Math.PI/180))), 2);
double powA = Math.Pow(a, 2);
double powB = Math.Pow(b, 2);
double powC = Math.Pow(c, 2);
if ((a == b) && (a == c) && (b == c))
    Console.Write("Треугольник равносторонний"); 
else if ((a == b) || (a == c) || (b == c))
    Console.Write("Треугольник равнобедренный");
else if (powC > powA + powB)
    Console.Write("Треугольник тупоугольный");
else if (powC == powA + powB)
    Console.Write("Треугольник прямоугольный");
else if (powC < powA + powB)
    Console.Write("Треугольник остроугольный");

//Console.WriteLine($"c = {c}");
//Console.WriteLine($"a^2 = {powA}");
//Console.WriteLine($"b^2 = {powB}");
//Console.WriteLine($"c^2 = {powC}");
//Console.WriteLine($"a^2+b^2 = {powA + powB}");