using System;

public class Student
{
    private string name;
    private int studentId;
    private string group;

    public Student(string name, int studentId, string group)
    {
        this.name = name;
        this.studentId = studentId;
        this.group = group;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int StudentId
    {
        get { return studentId; }
        set
        {
            if (value > 0)
            {
                studentId = value;
            }
            else
            {
                Console.WriteLine("Ошибка: ID студента должен быть больше 0");
            }
        }
    }

    public string Group
    {
        get { return group; }
        set { group = value; }
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Студент: {Name}, ID: {StudentId}, Группа: {Group}");
    }
}

public class BankAccount
{
    private string accountNumber;
    private decimal balance;

    public static string BankName = "Народный Банк";

    public BankAccount(string accountNumber, decimal initialBalance)
    {
        this.accountNumber = accountNumber;
        this.balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Счет пополнен на {amount} руб. Новый баланс: {balance} руб.");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Недостаточно средств");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"Со счета снято {amount} руб. Новый баланс: {balance} руб.");
        }
    }

    public void PrintStatement()
    {
        Console.WriteLine($"Банк: {BankName}, Счет: {accountNumber}, Баланс: {balance} руб.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== ЗАДАНИЕ 1: БАЗОВЫЙ КЛАСС И СОЗДАНИЕ ОБЪЕКТА ===");

        // Задание 1: Создание объекта с прямым доступом к полям (до модификации)
        Student studentBasic = new Student("Иван Иванов", 12345, "ИТ-21");
        studentBasic.PrintInfo();

        Console.WriteLine("\n=== ЗАДАНИЕ 2: КОНСТРУКТОР И ИНКАПСУЛЯЦИЯ ===");

        // Задание 2: Создание двух объектов через конструктор
        Student student1 = new Student("Петр Петров", 1001, "ИТ-21");
        Student student2 = new Student("Мария Сидорова", 1002, "ЭК-22");

        Console.WriteLine("\nИсходная информация о студентах:");
        student1.PrintInfo();
        student2.PrintInfo();

        // Демонстрация изменения группы через свойство
        Console.WriteLine("\nИзменяем группу первого студента:");
        student1.Group = "ИТ-22";
        student1.PrintInfo();

        // Демонстрация недопустимого ID
        Console.WriteLine("\nПопытка установить недопустимый ID:");
        student1.StudentId = -5;

        Console.WriteLine("\nФинальная информация о студентах:");
        student1.PrintInfo();
        student2.PrintInfo();

        Console.WriteLine("\n=== ЗАДАНИЕ 3: МЕТОДЫ ЭКЗЕМПЛЯРА И СТАТИЧЕСКИЕ ПОЛЯ ===");

        // Задание 3: Работа с банковским счетом
        BankAccount.BankName = "Сберегательный Банк";
        BankAccount account = new BankAccount("40817810099910004321", 10000m);

        Console.WriteLine("\nНачальное состояние счета:");
        account.PrintStatement();

        // Операции со счетом
        Console.WriteLine("\nПополнение счета на 5000 руб:");
        account.Deposit(5000m);

        Console.WriteLine("\nСнятие 3000 руб со счета:");
        account.Withdraw(3000m);

        Console.WriteLine("\nПопытка снять 20000 руб (больше баланса):");
        account.Withdraw(20000m);

        Console.WriteLine("\nИтоговое состояние счета:");
        account.PrintStatement();
    }
}