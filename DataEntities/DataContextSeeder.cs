//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Data.Entity.Migrations;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using DataEntities.Entities.Common;
//using DataEntities.Entities.Retail;

//namespace DataEntities
//{
//    public class DataContextSeeder : DropCreateDatabaseAlways<MyContext>
//    {
//        protected override void Seed(MyContext context)
//        {
//            Governorate governorate1 = new Governorate() { GovernorateName = "محافظة بيروت", Cazas = new List<Caza>() { new Caza() { CazaName = "بيروت" } } };
//            Governorate governorate2 = new Governorate()
//            {
//                GovernorateName = "محافظة جبل لبنان",
//                Cazas = new List<Caza>() {
//                            new Caza(){CazaName="قضاء كسروان"},
//                            new Caza(){CazaName="قضاء المتن"},
//                            new Caza(){CazaName="قضاء بعبدا"},
//                            new Caza(){CazaName="قضاء عاليه"},
//                            new Caza(){CazaName="قضاء الشوف"}
//            }

//            };
//            Governorate governorate3 = new Governorate()
//            {
//                GovernorateName = "محافظة الشمال",
//                Cazas = new List<Caza>()
//                {
//                           new Caza(){CazaName="قضاء عكار"},
//                           new Caza(){CazaName="قضاء طرابلس"},
//                           new Caza(){CazaName="قضاء زغرتا"},
//                           new Caza(){CazaName="قضاء بشري"},
//                           new Caza(){CazaName="قضاء البترون"},
//                           new Caza(){CazaName="قضاء الكورة"},
//                           new Caza(){CazaName="قضاء الضنية"}

//                }
//            };
//            Governorate governorate4 = new Governorate()
//            {
//                GovernorateName = "محافظة البقاع",
//                Cazas = new List<Caza>()
//            {
//                new Caza(){CazaName="قضاء الضنية"},
//                new Caza(){CazaName="قضاء الهرمل"},
//                new Caza(){CazaName="قضاء بعلبك"},
//                new Caza(){CazaName="قضاء زحلة"},
//                new Caza(){CazaName="قضاء البقاع الغربي"},
//                new Caza(){CazaName="قضاء راشيا"}
//                }
//            };
//            Governorate governorate5 = new Governorate()
//            {
//                GovernorateName = "محافظة النبطية",
//                Cazas = new List<Caza>()
//            {
//                new Caza(){CazaName="قضاء صيدا"},
//new Caza(){CazaName="قضاء صور"},
//new Caza(){CazaName="قضاء جزين"}

//            }
//            };
//            Governorate governorate6 = new Governorate()
//            {
//                GovernorateName = "محافظة الجنوب",
//                Cazas = new List<Caza>()
//            {
//                new Caza(){CazaName="قضاء النبطية"},
//new Caza(){CazaName="قضاء حاصبيا"},
//new Caza(){CazaName="قضاء مرجعيون"},
//new Caza(){CazaName="قضاء بنت جبيل"}


//            }
//            };
//            context.Governorates.AddRange(new List<Governorate>()
//            {
//                governorate1,
//                governorate2,
//                governorate3,
//                governorate4,
//                governorate5,
//                governorate6
//            });
//            context.SaveChanges();
          
//        }
//    }
//}
