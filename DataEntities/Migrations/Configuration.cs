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
            Governorate governorate1 = new Governorate() { GovernorateName = "������ �����", Cazas = new List<Caza>() { new Caza() { CazaName = "�����" } } };
            Governorate governorate2 = new Governorate()
            {
                GovernorateName = "������ ��� �����",
                Cazas = new List<Caza>() {
                            new Caza(){CazaName="���� ������"},
                            new Caza(){CazaName="���� �����"},
                            new Caza(){CazaName="���� �����"},
                            new Caza(){CazaName="���� �����"},
                            new Caza(){CazaName="���� �����"}
            }

            };
            Governorate governorate3 = new Governorate()
            {
                GovernorateName = "������ ������",
                Cazas = new List<Caza>()
                {
                           new Caza(){CazaName="���� ����"},
                           new Caza(){CazaName="���� ������"},
                           new Caza(){CazaName="���� �����"},
                           new Caza(){CazaName="���� ����"},
                           new Caza(){CazaName="���� �������"},
                           new Caza(){CazaName="���� ������"},
                           new Caza(){CazaName="���� ������"}

                }
            };
            Governorate governorate4 = new Governorate()
            {
                GovernorateName = "������ ������",
                Cazas = new List<Caza>()
            {
                new Caza(){CazaName="���� ������"},
                new Caza(){CazaName="���� ������"},
                new Caza(){CazaName="���� �����"},
                new Caza(){CazaName="���� ����"},
                new Caza(){CazaName="���� ������ ������"},
                new Caza(){CazaName="���� �����"}
                }
            };
            Governorate governorate5 = new Governorate()
            {
                GovernorateName = "������ �������",
                Cazas = new List<Caza>()
            {
                new Caza(){CazaName="���� ����"},
new Caza(){CazaName="���� ���"},
new Caza(){CazaName="���� ����"}

            }
            };
            Governorate governorate6 = new Governorate()
            {
                GovernorateName = "������ ������",
                Cazas = new List<Caza>()
            {
                new Caza(){CazaName="���� �������"},
new Caza(){CazaName="���� ������"},
new Caza(){CazaName="���� �������"},
new Caza(){CazaName="���� ��� ����"}


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
            var currency1=new Currency() {Abreviation = "L.L.",CurrencyValueInLocal = 1,Description = "���� �������"};
            var currency2 = new Currency() { Abreviation = "USD", CurrencyValueInLocal = 1507, Description = "����� ������" };
            context.Currencies.AddOrUpdate(x=>x.Abreviation,currency1,currency2);
            context.SaveChanges();
            var itemtype1 = new ItemType() {Description = "Retail"};
            var itemtype2 = new ItemType() { Description = "Supply"};
           context.ItemTypes.AddOrUpdate(x=>x.Description,itemtype1,itemtype2);
            context.SaveChanges();

        }
    }
}
