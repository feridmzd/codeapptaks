namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User
            {
                Passwordd="Ferid1233",
                Fullname="Ferid Memmedzade",
                Email ="frdm60@GAMIL.COM"

                
            };
            user.Showinfo();
          bool IsvalidPassword=  user.PasswordChecker(user.Passwordd);
            if (IsvalidPassword)
            {
                Console.WriteLine("Sifre qebul olundu");
            }
            else
            {
                Console.WriteLine("Sifre sehvdi");
            }
            
        }

    }
}