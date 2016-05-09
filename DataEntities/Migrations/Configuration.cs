using System.Collections.Generic;
using DataEntities.Entities.Common;

namespace DataEntities.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataEntities.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "DataEntities.MyContext";
        }

        protected override void Seed(DataEntities.MyContext context)
        {
            Governorate governorate1 = new Governorate() { GovernorateName = "„Õ«›Ÿ… »Ì—Ê ", Cazas = new List<Caza>() { new Caza() { CazaName = "»Ì—Ê " } } };
            Governorate governorate2 = new Governorate()
            {
                GovernorateName = "„Õ«›Ÿ… Ã»· ·»‰«‰",
                Cazas = new List<Caza>() {
                            new Caza(){CazaName="ﬁ÷«¡ ﬂ”—Ê«‰"},
                            new Caza(){CazaName="ﬁ÷«¡ «·„ ‰"},
                            new Caza(){CazaName="ﬁ÷«¡ »⁄»œ«"},
                            new Caza(){CazaName="ﬁ÷«¡ ⁄«·ÌÂ"},
                            new Caza(){CazaName="ﬁ÷«¡ «·‘Ê›"}
            }

            };
            Governorate governorate3 = new Governorate()
            {
                GovernorateName = "„Õ«›Ÿ… «·‘„«·",
                Cazas = new List<Caza>()
                {
                           new Caza(){CazaName="ﬁ÷«¡ ⁄ﬂ«—"},
                           new Caza(){CazaName="ﬁ÷«¡ ÿ—«»·”"},
                           new Caza(){CazaName="ﬁ÷«¡ “€— «"},
                           new Caza(){CazaName="ﬁ÷«¡ »‘—Ì"},
                           new Caza(){CazaName="ﬁ÷«¡ «·» —Ê‰"},
                           new Caza(){CazaName="ﬁ÷«¡ «·ﬂÊ—…"},
                           new Caza(){CazaName="ﬁ÷«¡ «·÷‰Ì…"}

                }
            };
            Governorate governorate4 = new Governorate()
            {
                GovernorateName = "„Õ«›Ÿ… «·»ﬁ«⁄",
                Cazas = new List<Caza>()
            {
                new Caza(){CazaName="ﬁ÷«¡ «·÷‰Ì…"},
                new Caza(){CazaName="ﬁ÷«¡ «·Â—„·"},
                new Caza(){CazaName="ﬁ÷«¡ »⁄·»ﬂ"},
                new Caza(){CazaName="ﬁ÷«¡ “Õ·…"},
                new Caza(){CazaName="ﬁ÷«¡ «·»ﬁ«⁄ «·€—»Ì"},
                new Caza(){CazaName="ﬁ÷«¡ —«‘Ì«"}
                }
            };
            Governorate governorate5 = new Governorate()
            {
                GovernorateName = "„Õ«›Ÿ… «·‰»ÿÌ…",
                Cazas = new List<Caza>()
            {
                new Caza(){CazaName="ﬁ÷«¡ ’Ìœ«"},
new Caza(){CazaName="ﬁ÷«¡ ’Ê—"},
new Caza(){CazaName="ﬁ÷«¡ Ã“Ì‰"}

            }
            };
            Governorate governorate6 = new Governorate()
            {
                GovernorateName = "„Õ«›Ÿ… «·Ã‰Ê»",
                Cazas = new List<Caza>()
            {
                new Caza(){CazaName="ﬁ÷«¡ «·‰»ÿÌ…"},
new Caza(){CazaName="ﬁ÷«¡ Õ«’»Ì«"},
new Caza(){CazaName="ﬁ÷«¡ „—Ã⁄ÌÊ‰"},
new Caza(){CazaName="ﬁ÷«¡ »‰  Ã»Ì·"}


            }
            };
            context.Governorates.AddOrUpdate(x=>x.GovernorateName,
                governorate1,
                governorate2,
                governorate3,
                governorate4,
                governorate5,
                governorate6
            );


            context.SaveChanges();
            var currency1=new Currency() {Abreviation = "L.L.",CurrencyValueInLocal = 1,Description = "·Ì—… ·»‰«‰Ì…"};
            var currency2 = new Currency() { Abreviation = "USD", CurrencyValueInLocal = 1507, Description = "œÊ·«— «„—ÌﬂÌ" };
            context.Currencies.AddOrUpdate(x=>x.Abreviation,currency1,currency2);
            context.SaveChanges();
            var itemtype1 = new ItemType() {Description = "Retail"};
            var itemtype2 = new ItemType() { Description = "Supply"};
           context.ItemTypes.AddOrUpdate(x=>x.Description,itemtype1,itemtype2);
            context.SaveChanges();

        }
    }
}
