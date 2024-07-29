using ForNovruz.Data;
using ForNovruz.Helpers;
using ForNovruz.Models;

//var bytes = File.ReadAllBytes(@"C:\Users\namiqrasullu\Desktop\slqlogo.png");

//var emp = new Employee
//{
//    FirstName = "Hakuna",
//    LastName = "Matata",
//    Photo = bytes
//};

//using var context = new NorthwindContext();

////context.Add(emp);
////context.SaveChanges();

//var emp = context.Employees.FirstOrDefault(e => e.EmployeeId == 10);

//File.WriteAllBytes(@"C:\Users\namiqrasullu\Desktop\fromDb.png", emp!.Photo!);

while (true)
{

    var str = Console.ReadLine();
    Hasher.CreatePasswordHash(str!, out byte[] hash, out byte[] salt);

    var s = Console.ReadLine();
    if (Hasher.VerifyPasswordHash(s!, hash, salt))
    {
        Console.WriteLine("duzdur");
    }
    else
        Console.WriteLine("sevhdir");

}
