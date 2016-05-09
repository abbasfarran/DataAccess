using System.Collections.Generic;

namespace DataEntities.Entities.Common
{
    public class OptionCategory
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Option> Options { get; set; }
    }
}
