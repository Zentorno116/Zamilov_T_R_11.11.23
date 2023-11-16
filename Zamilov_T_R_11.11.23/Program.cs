using System;

public interface ICipher
{
    string Encode(string input);
    string Decode(string input);
}

public class ACipher : ICipher
{
    public string Encode(string input)
    {
        char[] buffer = input.ToCharArray();
        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];
            letter++;
            buffer[i] = letter;
        }
        return new string(buffer);
    }

    public string Decode(string input)
    {
        char[] buffer = input.ToCharArray();
        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];
            letter--;
            buffer[i] = letter;
        }
        return new string(buffer);
    }
}

public class BCipher : ICipher
{
    public string Encode(string input)
    {
        char[] buffer = input.ToCharArray();
        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];
            if (char.IsUpper(letter))
            {
                letter = (char)('Z' - (letter - 'A'));
            }
            else if (char.IsLower(letter))
            {
                letter = (char)('z' - (letter - 'a'));
            }
            buffer[i] = letter;
        }
        return new string(buffer);
    }

    public string Decode(string input)
    {
        return Encode(input);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Упражнение 10.1. Кодирование и Декодирование. ");
        ICipher aCipher = new ACipher();
        ICipher bCipher = new BCipher();

        string testString = "Wassup ma boy?";

        Console.WriteLine("Оригинальная строка: " + testString);

        string encoded = aCipher.Encode(testString);
        Console.WriteLine("Закодированная с помощью ACipher: " + encoded);
        Console.WriteLine("Декодированная при помощи ACipher: " + aCipher.Decode(encoded));

        encoded = bCipher.Encode(testString);
        Console.WriteLine("Закодированная с помощью BCipher: " + encoded);
        Console.WriteLine("Декодированная при помощи BCipher: " + bCipher.Decode(encoded));

        Console.ReadLine();
        Console.Clear();

        
        
        Console.WriteLine("Домашнее задание 10.1. Фигуры. ");
        
        Circle circle = new Circle
        {
            X = 31,
            Y = 66,
            Radius = 9,
            Color = "Красный",
            IsVisible = true
        };
        Console.WriteLine($"Площадь круга: {circle.CalculateArea()}");

        Rectangle rectangle = new Rectangle
        {
            X = 12,
            Y = 45,
            Width = 7,
            Height = 11,
            Color = "Синий",
            IsVisible = true
        };
        Console.WriteLine($"Площадь прямоугольника: {rectangle.CalculateArea()}");
    }
}

public abstract class Figure
{
    public string Color { get; set; }
    public bool IsVisible { get; set; }

    public abstract void MoveHorizontal(int distance);
    public abstract void MoveVertical(int distance);
    public void ChangeColor(string color)
    {
        Color = color;
    }
}

public class Point : Figure
{
    public int X { get; set; }
    public int Y { get; set; }

    public override void MoveHorizontal(int distance)
    {
        X += distance;
    }

    public override void MoveVertical(int distance)
    {
        Y += distance;
    }
}

public class Circle : Point
{
    public int Radius { get; set; }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

public class Rectangle : Point
{
    public int Width { get; set; }
    public int Height { get; set; }

    public double CalculateArea()
    {
        return Width * Height;
    }
}

