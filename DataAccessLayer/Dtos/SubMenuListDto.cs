using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dtos
{
   public class SubMenuListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string HomeMenuName { get; set; }

        public string Link { get; set; }
     
    }
}
