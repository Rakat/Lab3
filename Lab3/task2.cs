using System;

public class Student
{
    // Закриті поля
    private string name;
    private int age;
    private int course;
    private double rating;

    // Конструктор з параметрами
    public Student(string name, int age, int course, double rating)
    {
        this.name = name;
        this.age = age;
        this.course = course;
        this.rating = rating;
    }

    // Властивості для доступу до полів
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public int Course
    {
        get { return course; }
        set { course = value; }
    }

    public double Rating
    {
        get { return rating; }
        set { rating = value; }
    }

    // Метод для редагування даних студента
    public void EditStudent(string name, int age, double rating)
    {
        this.name = name;
        this.age = age;
        this.rating = rating;
    }

    // Метод для виведення рейтингу студента
    public void StudentRating()
    {
        Console.WriteLine($"Рейтинг студента: {rating}");
    }

    // Метод для отримання ролі студента
    public string GetRole()
    {
        return course < 5 ? "Бакалавр" : "Магістр";
    }
}

public class Animal
{
    // Закриті поля
    private string name;
    private double weight;
    private int age;
    private string species;

    // Властивості для доступу до полів
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Species
    {
        get { return species; }
        set { species = value; }
    }

    // Конструктор без параметрів
    public Animal()
    {
        Name = "Невідоме";
        Weight = 0.0;
        Age = 0;
        Species = "Невідомий";
    }

    // Метод для виведення ваги тварини
    public void ShowWeight()
    {
        Console.WriteLine($"Вага тварини: {weight} кг");
    }

    // Метод для виведення інформації про тварину
    public void WhatIsThisAnimal()
    {
        Console.WriteLine($"Це тварина {species} {name}");
    }

    // Перевизначений метод для виведення імені, віку і ваги тварини
    public void ShowFullInfo()
    {
        Console.WriteLine($"Ім'я: {name}, Вік: {age} років, Вага: {weight} кг");
    }

    // Другий перевизначений метод для виведення тільки ваги і віку тварини
    public void ShowWeightAndAge()
    {
        Console.WriteLine($"Вік: {age} років, Вага: {weight} кг");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Приклад використання класу Student
        Student student = new Student("Олексій", 20, 3, 4.5);
        student.StudentRating(); // Виведе рейтинг студента
        Console.WriteLine(student.GetRole()); // Виведе бакалавр або магістр
        student.EditStudent("Ольга", 21, 4.8); // Редагує дані студента

        // Приклад використання класу Animal
        Animal cat = new Animal();
        cat.Name = "Мурка";
        cat.Weight = 4.2;
        cat.Age = 3;
        cat.Species = "Кішка";

        cat.ShowWeight(); // Виведе вагу тварини
        cat.WhatIsThisAnimal(); // Виведе інформацію про тварину: Це тварина кішка Мурка

        // Виклик нових перевизначених методів
        cat.ShowFullInfo(); // Виведе ім'я, вік і вагу тварини
        cat.ShowWeightAndAge(); // Виведе тільки вік і вагу тварини
    }
}
