//Алгоритм нахождения направляющего вектора и нормального вектора прямой, которая задана коэффициентами уравнения прямой.
//Если уравнение прямой задано в виде Ax + By + C = 0, 
//то вектор {B, -A} будет являться направляющим вектором этой прямой, а вектор {A, B} - нормальным вектором этой прямой.
using System.Numerics;

class Programm
{
    public static void Main()
    {
        var coefficients = Console.ReadLine().Split();
        var a = float.Parse(coefficients[0]);
        var b = float.Parse(coefficients[1]);
        var c = float.Parse(coefficients[2]);

        Vector2 normalVector = new Vector2(a, b);

        Vector2 directionVector = new Vector2(b, -a);

        Console.WriteLine("Нормальный вектор прямой = {" + normalVector.X + ";" + normalVector.Y + "}");
        Console.WriteLine("Нормальный вектор прямой = {" + directionVector.X + ";" + directionVector.Y + "}");
    }
}

