using System;

public class Student
{
    // Закриті поля
    private string name;
    private int age;
    private int course;
    private double rating;
    private int[] grades; // Масив оцінок

    // Конструктор з параметрами
    public Student(string name, int age, int course, double rating)
    {
        this.name = name;
        this.age = age;
        this.course = course;
        this.rating = rating;
        grades = new int[10]; // Ініціалізація масиву на 10 елементів
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

    // Індексатор для доступу до оцінок за кредити
    public int this[int index]
    {
        get
        {
            if (index >= 0 && index < grades.Length)
                return grades[index];
            else
                throw new IndexOutOfRangeException("Індекс поза межами масиву оцінок.");
        }
        set
        {
            if (index >= 0 && index < grades.Length)
                grades[index] = value;
            else
                throw new IndexOutOfRangeException("Індекс поза межами масиву оцінок.");
        }
    }

    // Метод для розрахунку середнього рейтингу студента (середнє арифметичне оцінок)
    public double CalculateAverageRating()
    {
        double sum = 0;
        int count = 0;

        foreach (int grade in grades)
        {
            sum += grade;
            count++;
        }

        return count > 0 ? sum / count : 0;
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

class Program
{
    private static void Main(string[] args)
    {
        // Приклад використання класу Student
        Student student = new Student("Олексій", 20, 3, 4.5);

        // Заповнення масиву оцінок за допомогою індексатора
        student[0] = 85;
        student[1] = 90;
        student[2] = 78;
        student[3] = 92;
        student[4] = 88;
        student[5] = 76;
        student[6] = 95;
        student[7] = 89;
        student[8] = 91;
        student[9] = 84;

        // Виведення середнього рейтингу студента
        Console.WriteLine("Середній рейтинг студента: " + student.CalculateAverageRating());

        // Виклик інших методів
        student.StudentRating();
        Console.WriteLine(student.GetRole());
    }
}
