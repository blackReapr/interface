using Task2.Interfaces;

namespace Task2.Models
{
    internal class User : IAccount
    {
        public User(string email, string password)
        {
            Email = email;
            _password = password;
        }
        public int Id { get; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Password 
        { 
            get => _password; 
            set 
            {
                if (!PasswordChecker(value)) return;
                _password = value;
            } 
        }

        private string _password;

        public bool PasswordChecker(string password)
        {
            password = password.Trim();
            if (password.Length < 8 || !ContainsDigit(password) || !ContainsLowerCaseLetter(password) || !ContainsUpperCaseLetter(password)) return false;
            return true;
        }

        private bool ContainsUpperCaseLetter(string input)
        {
            foreach (char c in input)
            {
                if (char.IsUpper(c)) return true;
            }
            return false;
        }

        private bool ContainsLowerCaseLetter(string input)
        {
            foreach (char c in input)
            {
                if (char.IsLower(c)) return true;
            }
            return false;
        }

        private bool ContainsDigit(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c)) return true;
            }
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}, Fullname: {FullName}, Email: {Email}");
        }
    }
}
