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

    public void SignUp()
    {
        string pattern_mail = @"[a-zA-Z0-9_-]+@[a-zA-Z0-9]+\.[a-zA-Z]{2,}$";
        string pattern_pw = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?\W).{8,16}$";
        Regex regex_mail = new(pattern_mail);
        Regex regex_pw = new(pattern_pw);

        if (regex_mail.IsMatch(pattern_mail))
        {
            if (regex_mail.IsMatch(pattern_pw))

            {
                MailMessage message = new MailMessage();
                SmtpClient client = new SmtpClient();
                client.Credentials = new NetworkCredential("bossazsmtp123@gmail.com", "bossaz123");
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;

                message.To.Add(this.Mail);
                message.Subject = "Sign Up Process";
                message.From = new MailAddress("bossazsmtp123@gmail.com");
                message.Body = Random.Shared.Next(100000, 999999).ToString();

                client.Send(message);
                Console.WriteLine("Verification code sent!");

            }


            else
            {
                Console.WriteLine("Incorrect mail!");
            }
        }

        else
        {
            Console.WriteLine("Incorrect mail!");
        }
      
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


}
