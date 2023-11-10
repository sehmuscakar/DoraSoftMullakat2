using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Dtos;
using DataAccessLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class SubMenuManager : ISubMenuManager
    {
        private readonly ISubMenuDal _subMenuDal;

        public SubMenuManager(ISubMenuDal subMenuDal)
        {
            _subMenuDal = subMenuDal;
        }

        public void Add(SubMenu subMenu)
        {
            _subMenuDal.Add(subMenu);
        }

        public SubMenu GetByID(int id)
        {
            return _subMenuDal.Get(id);
        }

        public List<SubMenu> GetList()
        {
            return _subMenuDal.GetAll();
        }

        public List<SubMenuListDto> GetSubMenuListManager()
        {
            return _subMenuDal.GetSubMenuListDal();
        }

        public void Remove(SubMenu subMenu)
        {
            _subMenuDal.Delete(subMenu);    
        }

        public void Update(SubMenu subMenu)
        {
           _subMenuDal.Update(subMenu);
        }
    }
}
