using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHomeMenuManager
    {
        List<HomeMenu> GetList();
        void Add(HomeMenu homeMenu);
        void Update(HomeMenu homeMenu);
        void Remove(HomeMenu homeMenu);
       HomeMenu GetByID(int id);
    }
}
