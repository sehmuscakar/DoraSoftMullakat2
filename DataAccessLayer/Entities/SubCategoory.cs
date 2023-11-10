using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
   public class SubCategoory:IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public DateTime Date { get; set; }

        public int TopCattegoryId { get; set; }
        public TopCategory TopCattegory { get; set; }

        public int CattegoryId { get; set; }
        public Category Cattegory { get; set; }

   

    }
}
