using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class HomeMenu:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Link { get; set; }
    }
}
