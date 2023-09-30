using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp7.models;

internal class Employer
{
    int Id { get; set; } = 0;
    public string Name { get; set; }
    public string Surname { get; set; }
    public string City { get; set; }
    public string Phone { get; set; }
    public int Age { get; set; }

    public string Mail { get; set; }
    public string Password { get; set; }
    public List<Worker> Vacancies { get; set; }

    public List<Worker> Liked { get; set; }
    
    public NotificationClass Notification { }
    public Employer(string name, string surname, string city, string phone, int age, string mail,string password)
    {
        
        Name = name;
        Surname = surname;
        City = city;
        Phone = phone;
        Age = age;
        Mail = mail;
        Password = password;
        
 
    }

    
    

    public void Like(Worker worker)
    {
        worker.LikeCount++;
        Liked.Add(worker);
    }

     public void LikeAWorker(Worker worker)
     {
        Menu_1.ShowAllWorkers();
        Console.WriteLine("Enter ID of worker: ");
        int id = Convert.ToInt32(Console.ReadLine());
        string jsontxt = File.ReadAllText("../../../workers.json");

        var list = JsonSerializer.Deserialize<List<Worker>>(jsontxt);
        foreach (var item in list)
        {
            if (item.Id == id)
            {
                this.Like(worker);
                break;
            }
        }
    }
    public void Allvacancies()
    {
        foreach (var item in Vacancies)
        {
            Console.WriteLine(item);
        }
    }

    public void AddVacation(Worker worker)
    {
        Vacancies.Add(worker);
    }

    public void Notify()
    {

    }


}
