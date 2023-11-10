using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
  public class Category:IEntity
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; }

        public string Name { get; set; }

        public decimal? Price { get; set; }

        public bool isActive { get; set; }



        public int TopCattegoryId { get; set; }
        public TopCategory TopCattegory { get; set; }

   


        public List<SubCategoory> SubCategoories { get; set; }
    }
}
