using ConsoleApp2.Models;
            
            namespace ConsoleApp2.Transformers;
            
            public class Transformer
            {
                public static List<string> TransformUsers(List<User> users)
                {
                    // Name and email for active users over 25
                    return users
                        .Where(u => u.Age > 25 && u.IsActive)
                        .Select(u => $"{u.Name.ToUpper()} <{u.Email}>")
                        .ToList();
                }
            
                public static List<string> TransformUsersWithAge(List<User> users)
                {
                    // Name, age, and email for active users over 25
                    return users
                        .Where(u => u.Age > 25 && u.IsActive)
                        .Select(u => $"{u.Name.ToUpper()} ({u.Age}) <{u.Email}>")
                        .ToList();
                }
            
                public static List<string> TransformUsersWithAgeAndEmail(List<User> users)
                {
                    // Name, age, email, and roles for active users over 25
                    return users
                        .Where(u => u.Age > 25 && u.IsActive)
                        .Select(u => $"{u.Name.ToUpper()} ({u.Age}) <{u.Email}> [Roles: {string.Join(", ", u.Roles)}]")
                        .ToList();
                }
            
                public static List<string> TransformUsersWithEmail(List<User> users)
                {
                    // Name, email, and address for active users over 25
                    return users
                        .Where(u => u.Age > 25 && u.IsActive)
                        .Select(u => $"{u.Name.ToUpper()} <{u.Email}> [{u.Address.Street}, {u.Address.City}, {u.Address.Country}]")
                        .ToList();
                }
            }