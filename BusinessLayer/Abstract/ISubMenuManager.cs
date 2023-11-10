using DataAccessLayer.Dtos;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface ISubMenuManager
    {
        List<SubMenuListDto> GetSubMenuListManager();
        List<SubMenu> GetList();
        void Add(SubMenu subMenu);
        void Update(SubMenu subMenu);
        void Remove(SubMenu subMenu);
        SubMenu GetByID(int id);
     
    }
}
