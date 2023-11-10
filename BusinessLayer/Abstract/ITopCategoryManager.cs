using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface ITopCategoryManager
    {
        List<TopCategory> GetList();
        void Add(TopCategory topCategory);
        void Update(TopCategory topCategory);
        void Remove(TopCategory topCategory);
        TopCategory GetByID(int id);
    }
}
