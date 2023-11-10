using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
   public class ContactCompany:IEntity
    {
        public int Id { get; set; }

        public string ImageUrlLogo { get; set; }
        public string CompanyName { get; set; }
        public string Twiter { get; set; }
        public string Facebook { get; set; }
        public string Instegram { get; set; }
        public string Linkedin { get; set; }
        public string Skype { get; set; }
    }
}
