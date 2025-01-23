namespace _01_FirstWebProject.Models.SeedData
{
    public class Galeri
    {
        public static List<Person> people = new List<Person>()
        {
            new Person(){Id=1,Age=34,FirstName="Ali",LastName="Mutlu",
                Cars= new List<Car>()
                {
                    new Car(){Id=1,Brand="Bmw",Model="i5",Price=500000,Power=600},
                    new Car(){Id=1,Brand="Mercedes",Model="E200",Price=400000,Power=450}
                }
                },
            new Person(){Id=12,Age=23,FirstName="Emir",LastName="Cihan",
                Cars= new List<Car>()
                {
                    new Car(){Id=1,Brand="Mercedes",Model="E200",Price=400000,Power=450},
                    new Car(){Id=1,Brand="Audi",Model="RS6",Price=900000,Power=700}
                }
                },
            new Person(){Id=3,Age=23,FirstName="Serra",LastName="Şenocak",
                Cars= new List<Car>()
                {
                    new Car(){Id=1,Brand="Bmw",Model="i5",Price=500000,Power=600},
                    new Car(){Id=1,Brand="Audi",Model="RS6",Price=900000,Power=700}
                }
                },
        };
    }
}