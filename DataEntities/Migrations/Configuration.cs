using System.Collections.Generic;
using DataEntities.Entities.Common;
using DataEntities.Entities.Retail;

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
            
        }
    }
}
