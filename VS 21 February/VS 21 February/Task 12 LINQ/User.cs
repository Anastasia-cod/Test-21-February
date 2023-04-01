using System;
namespace VS_21_February.Task12LINQ
{
    public class User
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public List<User> users;

        public User(List<User> users)
        {
            this.users = users;
        }

        public User(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        /// <summary>
        /// Returns the provided list of users, sorted by LastName in descending order.
        /// </summary>
        public void GetOrderedByDesc()
        {
            var orderedUsers = users.OrderByDescending(u => u.LastName);

            foreach (var u in orderedUsers)
            {
                Console.WriteLine(u.FirstName + " " + u?.MiddleName + " " + u.LastName);
            }
        }

        /// <summary>
        /// Get info about users from List
        /// </summary>
        public void GetInfo()
        {

            var info = from u in users
                       select u.FirstName + " " + u.MiddleName + " " + u.LastName;

            foreach (var i in info)
            {
                Console.WriteLine(i);
            }
        }
    }
}

