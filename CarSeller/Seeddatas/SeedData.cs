using CarSeller.Entities;
using System.Diagnostics;
using System.Net;
using System.Xml.Linq;

namespace CarSeller.Seeddatas
{
    public class SeedData
    {


        public static List<Seller> Sellers = new List<Seller>()
                {
                    new Seller() {Id=1, Name="Borusan",ContactEmail="Levent@mail.com",
                        Cars=new List<Car>
                        {
                        new Car(){Id=1,Brand="Mercedes",Model="Cla",ImageUrl="wwwroot/img/ferrari.jpg"},
                        new Car(){Id=2,Brand="Bmw",Model="Cla",ImageUrl="İmg"},
                        new Car(){Id=3,Brand="Audi",Model="Rs6",ImageUrl="İmg" }
                        }
                    },

                    new Seller() {Id=2, Name="Doğuş",ContactEmail="Kartal@mail.com",
                        Cars=new List<Car>
                        {
                            new Car(){Id=3,Brand="Audi",Model="Rs6",ImageUrl="İmg",},
                            new Car(){Id=4,Brand="Audi",Model="Rsq8",ImageUrl="İmg",},
                            new Car(){Id=5,Brand="Porsche",Model="911",ImageUrl="İmg",}

                        }
                    },


                    new Seller() {Id=3, Name="Ali",ContactEmail="Ali@mail.com",
                        Cars=new List<Car>
                        {
                            new Car(){Id=5,Brand="Porsche",Model="911",ImageUrl="img/ferrari.jpg",}

                        }
                    },
                };
        public static List<Car> Cars = new List<Car>()
                {
                    new Car(){Id=1,Brand="Mercedes",Model="Cla",ImageUrl="img/ferrari.jpg",Seller = new Seller(){Id=1}},
                    new Car(){Id=2,Brand="Bmw",Model="M5",ImageUrl="İmg",Seller = new Seller(){Id=1}},
                    new Car(){Id=3,Brand="Audi",Model="Rs6",ImageUrl="İmg",Seller = new Seller(){Id=2}},
                    new Car(){Id=4,Brand="Audi",Model="Rsq8",ImageUrl="İmg",Seller = new Seller(){Id=2}},
                    new Car(){Id=5,Brand="Porsche",Model="911",ImageUrl="İmg",Seller = new Seller(){Id=2}},
                    new Car(){Id=6,Brand="Lamborgini",Model="Aventador",ImageUrl="İmg",Seller = new Seller(){Id = 1}},
                };

    }
}
