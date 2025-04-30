using Microsoft.EntityFrameworkCore;

namespace LandscapeApi;

public static class SeedData
{
    public static void MigrateAndSeed(IServiceProvider serviceProvider)
    {
        var context = serviceProvider.GetRequiredService<AppDbContext>();
        context.Database.Migrate();

        // if (!context.Users.Any())
        // {
        //     var users = new List<User>
        //     {
        //         new User
        //         {
        //             Id = new Guid(),
        //             FirstName = "ss",
        //             LastName = "ss",
        //             UserName = "ssss",
        //             Email = "@gmail.com",
        //             BirthDate = new DateOnly(1999, 08, 17),
        //             Gender = Gender.Male,
        //         },
        //     };
        //     
        //     context.Users.AddRange(users);
        //     context.SaveChanges();
        // }

        //
        // if (!context.Benefits.Any())
        // {
        //     var benefits = new List<Benefit>
        //     {
        //         new Benefit { Name = "Health", Description = "Medical, dental, and vision coverage", BaseCost = 100.00m },
        //         new Benefit { Name = "Dental", Description = "Dental coverage", BaseCost = 50.00m },
        //         new Benefit { Name = "Vision", Description = "Vision coverage", BaseCost = 30.00m }
        //     };
        //
        //     context.Benefits.AddRange(benefits);
        //     context.SaveChanges();
        //
        //     //add employee benefits too
        //
        //     var healthBenefit = context.Benefits.Single(b => b.Name == "Health");
        //     var dentalBenefit = context.Benefits.Single(b => b.Name == "Dental");
        //     var visionBenefit = context.Benefits.Single(b => b.Name == "Vision");
        //
        //     var john = context.Employees.Single(e => e.FirstName == "John");
        //     john.Benefits = new List<EmployeeBenefit>
        //     {
        //         new EmployeeBenefit { Benefit = healthBenefit, CostToEmployee = 100m},
        //         new EmployeeBenefit { Benefit = dentalBenefit }
        //     };
        //
        //     var jane = context.Employees.Single(e => e.FirstName == "Jane");
        //     jane.Benefits = new List<EmployeeBenefit>
        //     {
        //         new EmployeeBenefit { Benefit = healthBenefit, CostToEmployee = 120m},
        //         new EmployeeBenefit { Benefit = visionBenefit }
        //     };
        //
        //     context.SaveChanges();
        // }
    }
}