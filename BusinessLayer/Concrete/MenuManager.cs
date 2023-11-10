using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class MenuManager : IMenuManager
    {
        private readonly IMenuDal _menuDal;

        public MenuManager(IMenuDal menuDal)
        {
            _menuDal = menuDal;
        }

        public void Add(Menu menu)
        {
          _menuDal.Add(menu);   
        }

        public Menu GetByID(int id)
        {
            return _menuDal.Get(id);
        }

        public List<Menu> GetList()
        {
            return _menuDal.GetAll();
        }

        public void Remove(Menu menu)
        {
            _menuDal.Delete(menu);
        }

        public void Update(Menu menu)
        {
           _menuDal.Update(menu);
        }
    }
}
