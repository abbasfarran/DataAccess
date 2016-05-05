using System;

namespace DataEntities.Entities.Common
{
    public class Option
    {
        public int Id { get; set; }
        public String Description { get; set; }
        public int OptionCategoryId { get; set; }
        public OptionCategory OptionCategory { get; set; }

    }
}
