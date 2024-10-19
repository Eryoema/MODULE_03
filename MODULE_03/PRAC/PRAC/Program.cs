using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAC
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        public User(string name, string email, string role)
        {
            Name = name;
            Email = email;
            Role = role;
        }
    }

    public class UserManager
    {
        private List<User> _users = new List<User>();

        public void AddUser(string name, string email, string role)
        {
            var user = new User(name, email, role);
            _users.Add(user);
            Console.WriteLine($"User {name} added.");
        }

        public void RemoveUser(string email)
        {
            var user = _users.Find(u => u.Email == email);
            if (user != null)
            {
                _users.Remove(user);
                Console.WriteLine($"User {user.Name} removed.");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        public void UpdateUser(string email, string newName, string newRole)
        {
            var user = _users.Find(u => u.Email == email);
            if (user != null)
            {
                user.Name = newName;
                user.Role = newRole;
                Console.WriteLine($"User {email} updated.");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        public void DisplayUsers()
        {
            foreach (var user in _users)
            {
                Console.WriteLine($"Name: {user.Name}, Email: {user.Email}, Role: {user.Role}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager();
            userManager.AddUser("Ernar", "ernar@icloud.com", "Admin");
            userManager.AddUser("Damir", "damir@icloud.com", "User");

            userManager.DisplayUsers();

            userManager.UpdateUser("ernar@icloud.com", "Ernar Smith", "SuperAdmin");
            userManager.RemoveUser("damir@icloud.com");

            userManager.DisplayUsers();
        }
    }
}
