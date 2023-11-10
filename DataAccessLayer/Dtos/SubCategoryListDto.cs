using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dtos
{
   public class SubCategoryListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public decimal? Price { get; set; }
        public bool isActive { get; set; }
        public string TopCattegoryName { get; set; }
        public string CattegoryName { get; set; }

    }
}
