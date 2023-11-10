using CoreLayer.DataAccess.EntityFramwork;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Dtos;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class SubMenuDal : BaseRepository<SubMenu, ProjeContext>, ISubMenuDal
    {
        public List<SubMenuListDto> GetSubMenuListDal()
        {
            using (var context = new ProjeContext()) 
            {
                var a = context.SubMenus.Select(subMenu => new SubMenuListDto()
                {
                    Id = subMenu.Id,
                   Name= subMenu.Name,
                   HomeMenuName=subMenu.Menu.Name,
                  Link=subMenu.Link,
                   
                  
                });
                return a.ToList();
            }
        }
    }
}
