using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp7.models;

internal class Worker
{
    public int Id { get; set; } = 0;
    public string Name { get; set; }
    public string Surname { get; set; }
    public string City { get; set; }
    public string Phone { get; set; }
    public int Age { get; set; }
    public CV? Cv { get; set; }
    public string Mail { get; set; }
    public string Password { get; set; }
    public int LikeCount { get; set; }
    public Worker(string name, string surname, string city, string phone, int age,string mail, string password, CV cv)
    {
        Id++;
        Name = name;
        Surname = surname;
        City = city;
        Phone = phone;
        Age = age;
        Cv = cv;

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
                client.Port = 25;
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








    public override string ToString()
    {
        return $@"
Name --> {Name}
Surname --> {Surname}
City --> {City}
Phone --> {Phone}
Age --> {Age}
CV --> {Cv}
";
    }

}
