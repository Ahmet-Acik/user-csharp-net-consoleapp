using ConsoleApp2.Models;
        using ConsoleApp2.Transformers;
        using NUnit.Framework;
        
        namespace ConsoleApp2.Tests;
        
        public class TransformerTest
        {
            [Test]
            public void ShouldTransformUsersCorrectly() {
                var users = new List<User> {
                    new User("Alice", 30, "alice@example.com", new User.UserAddress("123 Main St", "Wonderland", "Dreamland"), new List<string> { "Admin" }),
                    new User("Bob", 22, "bob@example.com", new User.UserAddress("456 Elm St", "Springfield", "USA"), new List<string> { "User" })
                };
        
                var result = Transformer.TransformUsers(users);
                Assert.That(result, Does.Contain("ALICE <alice@example.com>"));
            }
        }