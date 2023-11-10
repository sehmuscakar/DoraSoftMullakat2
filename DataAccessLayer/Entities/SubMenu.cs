using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class SubMenu: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Link { get; set; }
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
    }
}
