


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static string NameVal()
        {
            Console.WriteLine("Hello user, what shall i call you?(Input name please in title case With a maximum of 30 letters)");
            string name = Console.ReadLine();
            string[] nameArr = name.Split(' ');
            while (!Regex.IsMatch(name, @"^[A-Z][a-z]{2,}(?: [A-Z][a-z]*)*$"))
            {
                
                Console.WriteLine("I am sorry user, the input you entered is not correct. please try again. ");
                name = Console.ReadLine();
              
            }
            Console.WriteLine($"Execellent {name}; Lets Continue.");
            return name;
        }

        static string EmailVal(string name)
        {
            Console.WriteLine($"Ok {name}, Please enter your email address");
            string email = Console.ReadLine();
            while (!Regex.IsMatch(email, @"^[0-9a-zA-Z.]{5,30}@[0-9a-zA-Z]{5,10}.[0-9a-zA-Z]{2,3}$"))
            {
                Console.WriteLine($"Oops I'm sorry {name}, you must have entered it incorrectly, please try again.");
                email = Console.ReadLine();
            }
            Console.WriteLine($"Ah; Thank you {name}, I see you can be reached at {email}.");
            return email;
        }


        static string PhoneNumVal(string name)
        {
            Console.WriteLine($"So {name}, i am going to need your phone number:(In the format of XXX-XXX-XXXX)");
            string phoneNumber = Console.ReadLine();
            while(!Regex.IsMatch(phoneNumber, @"^[0-9]{3}-[0-9]{3}-[0-9]{4}$"))
            {
                Console.WriteLine($"Hmmm, {name} i don't understand this format, please try again.(Remeber format of XXX-XXX-XXXX)");
                phoneNumber = Console.ReadLine();
            }
            Console.WriteLine($"Amazing!!!!!!!! I can now save {phoneNumber} under {name}");
            return phoneNumber;
        }

        static string DateVal(string name)
        {
            Console.WriteLine($"Alright {name}, now for the last bit of info. Please enter your birthday Month, Day, Year.(Formatted XX/XX/XXXX");
            string date = Console.ReadLine();
            while(!Regex.IsMatch(date, @"^[0-9]{2}/[0-9]{2}/[0-9]{4}$"))
            {
                Console.WriteLine($"{name} that was incorrect, try again please.");
               date = Console.ReadLine();
            }
            Console.WriteLine($"All done {name}, Thank you for information, now i will steal your identity");
            return date;
        }

        static void Main(string[] args)
        {
           string name = NameVal();
            Console.WriteLine();
           string email = EmailVal(name);
            Console.WriteLine();
           string phoneNumber = PhoneNumVal(name);
            Console.WriteLine();
            string date = DateVal(name);
            Console.WriteLine();

        }
    }
}
