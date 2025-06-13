namespace ConsoleApp2.Models;
            
            public class User
            {
                public string Name { get; }
                public int Age { get; }
                public string Email { get; private set; }
                public bool IsActive { get; private set; }
                public List<string> Roles { get; }
                public UserAddress Address { get; }
                public DateTime CreatedAt { get; }
            
                public User(string name, int age, string email, UserAddress address, IEnumerable<string> roles = null)
                {
                    Name = name;
                    Age = age;
                    Email = email;
                    Address = address;
                    Roles = roles != null ? new List<string>(roles) : new List<string>();
                    IsActive = true;
                    CreatedAt = DateTime.UtcNow;
                }
            
                public void Deactivate()
                {
                    IsActive = false;
                }
            
                public void AddRole(string role)
                {
                    if (!Roles.Contains(role))
                        Roles.Add(role);
                }
            
                public void RemoveRole(string role)
                {
                    Roles.Remove(role);
                }
            
                public void UpdateEmail(string newEmail)
                {
                    Email = newEmail;
                }
            
                public class UserAddress
                {
                    public string Street { get; }
                    public string City { get; }
                    public string Country { get; }
            
                    public UserAddress(string street, string city, string country)
                    {
                        Street = street;
                        City = city;
                        Country = country;
                    }
                }
            }