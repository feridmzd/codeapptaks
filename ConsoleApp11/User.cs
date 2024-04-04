using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class User:IAccount
    {
        public int Id { get; set; }
        public string Fullname;
        public string Email;
        public string Passwordd;
         



      
        public void Showinfo()
        {
            Console.WriteLine($"FUllname:{Fullname}\nID:{Id}\nEmail:{Email}\nPassword:{Passwordd}");
        }

        public bool PasswordChecker(string password)
        {
          
            
          
            if (password.Length <= 8)
                                    
                return false;
            
            
            if (!password.Any(char.IsUpper))
            
                return false; 
            
             if(!password.Any(char.IsLower))
            
                return false;


            
            if(!password.Any(char.IsDigit))
            
                return false;
            
            return true;
            
        }
    }
}
