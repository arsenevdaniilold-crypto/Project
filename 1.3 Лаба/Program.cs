
public class Circle
{
    public double x;
    public double y;
    public double radius;
    public Circle()
    {
        Console.WriteLine("Введите координаты и радиус окружности:");
        string[] arr = Console.ReadLine().Split();
        this.x = double.Parse(arr[0]);
        this.y = double.Parse(arr[1]);
        this.radius = double.Parse(arr[2]);
    }
    public Circle(double x, double y, double radius)
    {
        this.x = x;
        this.y = y;
        this.radius = radius;
    }

    public Circle(double radius)
    {
        Random randomm = new Random();
        this.radius = radius;
        this.x = randomm.Next(-100, 100);
        this.y = randomm.Next(-100, 100);
    }
    public double CalculateCircumference()
    {
        return 2 * Math.PI * this.radius;
    }

    public void MoveToRandomPoint()
    {
        Random random = new Random();
        this.x = random.Next(-99, 100);
        this.y = random.Next(-99, 100);
        Console.WriteLine($"Новый центр: ({this.x}, {this.y})");
    }

    public double DistanceToCenter(double otherX, double otherY)
    {
        return Math.Sqrt(Math.Pow(this.x - otherX, 2) + Math.Pow(this.y - otherY, 2));
    }

    public void CheckIntersection(double otherX, double otherY, double otherRadius)
    {
        double distance = DistanceToCenter(otherX, otherY);
        double sumRadii = this.radius + otherRadius;

        if (distance == sumRadii)
            Console.WriteLine("Есть 1 точка пересечения");
        else if (distance > sumRadii)
            Console.WriteLine("Нет точек пересечения");
        else
            Console.WriteLine("Есть больше 1 точки пересечения");
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Радиус: {this.radius}");
        Console.WriteLine($"Центр: ({this.x}, {this.y})");
        Console.WriteLine($"Длина окружности: {CalculateCircumference():F2}");
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Создание первой окружности");
        Circle circle1 = new Circle();
        circle1.PrintInfo();

        Console.WriteLine("\nСоздание второй окружности (только радиус)");
        Console.Write("Введите радиус: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        Circle circle2 = new Circle(radius);
        circle2.PrintInfo();

        Console.WriteLine("\n Проверка пересечения окружностей");
        circle1.CheckIntersection(circle2.x, circle2.y, circle2.radius);

        Console.WriteLine("\nПеремещение центра первой окружности");
        circle1.MoveToRandomPoint();

        Console.WriteLine("\nПроверка расстояния между центрами");
        double distance = circle1.DistanceToCenter(circle2.x, circle2.y);
        Console.WriteLine($"Расстояние между центрами: {distance:F2}");

        Console.WriteLine("\nПроверка пересечения после перемещения");
        circle1.CheckIntersection(circle2.x, circle2.y, circle2.radius);

    }
}