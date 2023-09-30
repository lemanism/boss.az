using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp7.models;

static class Menu_1
{
    



    static public void Start()
    {

        Console.WriteLine("   _____      _          _       _     ");
        Console.WriteLine("  / ____|    | |        | |     | |    ");
        Console.WriteLine(" | |  __  ___| |_       | | ___ | |__  ");
        Console.WriteLine(" | | |_ |/ _ \\ __|  _   | |/ _ \\| '_ \\ ");
        Console.WriteLine(" | |__| |  __/ |_  | |__| | (_) | |_) |");
        Console.WriteLine("  \\_____|\\___|\\__|  \\____/ \\___/|_.__/ ");



        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
        int selectedOption = 0;
        string[] menuOptions = { "Sign In", "Sign Up", "Guest", "Exit" };

        Console.CursorVisible = false;

        while (true)
        {
            Console.Clear();

            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t");
            for (int i = 0; i < menuOptions.Length; i++)
            {
                if (i == selectedOption)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                
                
                Console.Write("\n\t\t\t\t\t\t\t");
                Console.Write(menuOptions[i]);
            }

            
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    if (selectedOption > 0)
                        selectedOption--;
                    break;
                case ConsoleKey.DownArrow:
                    if (selectedOption < menuOptions.Length - 1)
                        selectedOption++;
                    break;
                case ConsoleKey.Enter:

                    if (selectedOption == menuOptions.Length - 1)
                    {
                        
                        Environment.Exit(0);
                    }
                    // buraya lazimi funksiyalari duz
                    else if (menuOptions[selectedOption] == "Sign In")
                    {

                        Console.Clear();
                        Menu3();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey(true);
                    }
                    else if (menuOptions[selectedOption] == "Sign Up")
                    {

                        Console.Clear();
                        Menu2();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey(true);
                    }
                    else if (menuOptions[selectedOption] == "Guest")
                    {

                        Console.Clear();
                        Console.WriteLine($"You selected: {menuOptions[selectedOption]}");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey(true);
                    }
                    break;
            }
        }



    }
    static public void GetJobLogo()
    {

        //Console.Write("\t\t\t\t\t\t\t\t");
        Console.Write(
            @"
   _____      _          _       _     
  / ____|    | |        | |     | |    
 | |  __  ___| |_       | | ___ | |__  
 | | |_ |/ _ \ __|  _   | |/ _ \| '_ \ 
 | |__| |  __/ |_  | |__| | (_) | |_) |
  \_____|\___|\__|  \____/ \___/|_.__/                                       
");
    }

    public static void Menu2()
    {


        int selectedOption = 0;
        string[] menuOptions = { "Worker", "Employer", "Exit", "Back" };

        Console.CursorVisible = false;

        while (true)
        {
            Console.Clear();


            for (int i = 0; i < menuOptions.Length; i++)
            {
                if (i == selectedOption)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.WriteLine(menuOptions[i]);
            }


            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    if (selectedOption > 0)
                        selectedOption--;
                    break;
                case ConsoleKey.DownArrow:
                    if (selectedOption < menuOptions.Length - 1)
                        selectedOption++;
                    break;
                case ConsoleKey.Enter:

                    if (selectedOption == menuOptions.Length - 1)
                    {

                        Environment.Exit(0);
                    }
                    // buraya lazimi funksiyalari duz
                    else if (menuOptions[selectedOption] == "Worker")
                    {

                        Console.Clear();
                        SignUpMenuForWorker();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey(true);
                    }
                    else if (menuOptions[selectedOption] == "Employer")
                    {

                        Console.Clear();
                        SignUpMenuForEmployers();
                        Console.ReadKey(true);
                    }

                    else if (menuOptions[selectedOption] == "Back")
                    {

                        Console.Clear();
                        Start();

                        Console.ReadKey(true);
                    }
                    break;
            }
        }

    }


        // sign in ucun
         static public void Menu3()
         {

            int selectedOption = 0;
            string[] menuOptions = { "Worker", "Employer", "Exit", "Back" };

            Console.CursorVisible = false;

            while (true)
            {
                Console.Clear();


                for (int i = 0; i < menuOptions.Length; i++)
                {
                    if (i == selectedOption)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Console.WriteLine(menuOptions[i]);
                }


                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (selectedOption > 0)
                            selectedOption--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (selectedOption < menuOptions.Length - 1)
                            selectedOption++;
                        break;
                    case ConsoleKey.Enter:

                        if (selectedOption == menuOptions.Length - 1)
                        {

                            Environment.Exit(0);
                        }
                        // buraya lazimi funksiyalari duz
                        else if (menuOptions[selectedOption] == "Worker")
                        {

                            Console.Clear();
                            SignInMenuForWorker();
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey(true);
                        }
                        else if (menuOptions[selectedOption] == "Employer")
                        {
                            Console.Clear();
                            SignInMenuForEmployer();

                            Console.ReadKey(true);
                        }
                        

                        else if (menuOptions[selectedOption] == "Back")
                        {

                            Console.Clear();
                            Start();

                            Console.ReadKey(true);
                        }
                        break;
                }
            }








         }

        public static void SignInMenuForWorker()
        {
            Console.WriteLine("Enter mail: ");
            string mail = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();
            

            string pattern_mail = @"[a-zA-Z0-9_-]+@[a-zA-Z0-9]+\.[a-zA-Z]{2,}$";
            string patter_pw = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?\W).{8,16}$";
            Regex regex_mail = new(pattern_mail);
            Regex regex_pw = new(patter_pw);
            if (regex_mail.IsMatch(mail))
            {
                if (regex_pw.IsMatch(password))
                {
                    string jsontxt = File.ReadAllText("../../../workers.json");

                    var list = JsonSerializer.Deserialize<List<Worker>>(jsontxt);
                    foreach (var item in list)
                    {
                        if (mail == item.Mail)
                        {
                            if (password == item.Password)
                            {
                                Console.WriteLine($"Welcome {item.Name}!");
                            }
                            else { Console.WriteLine("Incorrect Password!"); }
                        }



                        else { Console.WriteLine("Incorrect Mail!"); }
                    }
                }

                else { Console.WriteLine("Incorrect Password!"); }

            }
            else { Console.WriteLine("Incorrect Mail Format!"); }
            
        }




        public static void SignUpMenuForWorker()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter phone: ");
            string phone = Console.ReadLine();
            Console.Write("Enter city: ");
            string city = Console.ReadLine();
        Console.WriteLine("Enter mail: ");
        string mail = Console.ReadLine();
        Console.WriteLine("Enter password: ");
        string pw = Console.ReadLine();


            Console.WriteLine("-- ABOUT CV -- ");
            Console.Write("Enter profession: ");
            string profession = Console.ReadLine();
            Console.Write("Enter school: ");
            string school = Console.ReadLine();
            Console.Write("Enter exam result: ");
            double uniexam = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your skills: ");
            string skills = Console.ReadLine();
            Console.Write("Enter companies: ");
            string companies = Console.ReadLine();
            Console.Write("Enter languages: ");
            string languages = Console.ReadLine();
            Console.Write("Enter certification: ");
            string certification = Console.ReadLine();
            Console.Write("Enter github link: ");
            string gitlink = Console.ReadLine();
            Console.Write("Enter LinkedIn: ");
            string linkedin = Console.ReadLine();


            CV cv = new CV(profession, school, uniexam, skills, companies, languages, certification, gitlink, linkedin);
            Worker worker = new(name, surname, city, phone, age,mail,pw, cv);
            worker.SignUp();


            string jsonstr = JsonSerializer.Serialize(worker);
            Console.WriteLine(jsonstr);

            File.WriteAllText("../../../workers.json", jsonstr);
        }

       public static void SignUpMenuForEmployers() // duzelt
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter phone: ");
            string phone = Console.ReadLine();
            Console.Write("Enter city: ");
            string city = Console.ReadLine();
            Console.Write("Enter mail: ");
            string mail = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();

            
        bool check = false;
        string pattern_mail = @"[a-zA-Z0-9_-]+@[a-zA-Z0-9]+\.[a-zA-Z]{2,}$";
        string pattern_pw = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?\W).{8,16}$";
        Regex regex_mail = new(pattern_mail);
        Regex regex_pw = new(pattern_pw);

        if (regex_mail.IsMatch(pattern_mail))
        {
            if (regex_mail.IsMatch(pattern_pw))

            {
                foreach (var item in DATABASE.employers)
                {
                    if (item.Mail == mail)
                    {
                        Console.WriteLine("Incorrect mail!");
                        check = true;
                        break;
                    }

                }
                if (check == false)
                {
                    Employer emp = new(name, surname, city, phone, age, mail, password);
                    string jsonstr = JsonSerializer.Serialize(emp);
                    Console.WriteLine(jsonstr);

                    File.WriteAllText("../../../employers.json", jsonstr);
                    DATABASE.employers.Add(emp);
                    Console.WriteLine("Sign in process ended succesfully!");


                    SignInMenuForEmployer();

                }

            }


            else
            {
                Console.WriteLine("Incorrect password!");
            }
        }

        else
        {
            Console.WriteLine("Incorrect mail!");
        }

        


        }

        public static void SignInMenuForEmployer()
        {

            Console.WriteLine("Enter mail: ");
            string mail = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();


            string pattern_mail = @"[a-zA-Z0-9_-]+@[a-zA-Z0-9]+\.[a-zA-Z]{2,}$";
            string pattern_pw = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?\W).{8,16}$";
            Regex regex_mail = new(pattern_mail);
            Regex regex_pw = new(pattern_pw);
            if (regex_mail.IsMatch(mail))
            {
                if (regex_pw.IsMatch(password))
                {
                    string jsontxt = File.ReadAllText("../../../employers.json");

                    var list = JsonSerializer.Deserialize<List<Employer>>(jsontxt);
                    foreach (var item in list)
                    {
                        if (mail == item.Mail)
                        {
                            if (password == item.Password)
                            {
                                Console.WriteLine($"Welcome {item.Name}!");

                                MenuForEmployer(item);


                            }
                            else { Console.WriteLine("Incorrect Password!"); }
                        }

                        else { Console.WriteLine("Incorrect Mail!"); }
                    }
                }

                else { Console.WriteLine("Incorrect Password!"); }

            }
            else { Console.WriteLine("Incorrect Mail!"); }
        }
    
    
    public static void ShowAllLikesForEmp(Employer emp)
    {
        foreach (var item in emp.Liked)
        {
            Console.WriteLine(item);
        }
    }

     public static void ShowAllWorkers()
     {
        string jsontxt = File.ReadAllText("../../../workers.json");

        var list = JsonSerializer.Deserialize<List<Worker>>(jsontxt);

        foreach (var item in list)
            Console.WriteLine(item);
     }

    public static void MenuForEmployer(Employer emp)
    {
        int selectedOption = 0;
        string[] menuOptions = { "Show All Workers", "Notifications","See Liked Workers", "Exit" };

        Console.CursorVisible = false;

        while (true)
        {
            Console.Clear();


            for (int i = 0; i < menuOptions.Length; i++)
            {
                if (i == selectedOption)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.WriteLine(menuOptions[i]);
            }


            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    if (selectedOption > 0)
                        selectedOption--;
                    break;
                case ConsoleKey.DownArrow:
                    if (selectedOption < menuOptions.Length - 1)
                        selectedOption++;
                    break;
                case ConsoleKey.Enter:

                    if (selectedOption == menuOptions.Length - 1)
                    {

                        Environment.Exit(0);
                    }
                    // buraya lazimi funksiyalari duz
                    else if (menuOptions[selectedOption] == "Show All Workers")
                    {

                        Console.Clear();
                        ShowAllWorkers();
                        
                        Console.WriteLine("Do you want to like any worker? (1 - yes, 2 - no)");
                        string choice = Console.ReadLine();
                        if (choice == "1")
                        {
                            int id = Convert.ToInt32(Console.ReadLine);
                            foreach (var item in DATABASE.workers)
                            {
                                if (item.Id == id)
                                {
                                    item.LikeCount++;
                                }
                            }
                        }
                        

                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey(true);
                    }
                    else if (menuOptions[selectedOption] == "Notifications") // classi duzelt
                    {
                        Console.Clear();
                        

                        Console.ReadKey(true);
                    }

                    else if (menuOptions[selectedOption] == "See Liked Workers")
                    {

                        Console.Clear();
                        ShowAllLikesForEmp(emp);

                        Console.ReadKey(true);
                    }
                    break;
            }
        }



    }
}

    
