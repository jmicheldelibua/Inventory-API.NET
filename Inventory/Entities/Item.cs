using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Inventory.Entities
{
    public class Item
    {
        
        
        public int ItemId { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        
        public int InStock { get; set; }
        public string Image { get; set; }

        [IgnoreDataMember]
        public bool Erased { get; set; }
        [IgnoreDataMember]
        public DateTime CreatedAt { get; set; }
        [IgnoreDataMember]
        public DateTime ModifiedAt { get; set; }
        [IgnoreDataMember]
        public DateTime ErasedAt { get; set; }

        
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
