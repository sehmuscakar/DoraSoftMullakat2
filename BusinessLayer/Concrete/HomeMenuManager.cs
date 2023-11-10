using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class HomeMenuManager : IHomeMenuManager
    {
        private readonly IHomeMenuDal _homeMenuDal;

        public HomeMenuManager(IHomeMenuDal homeMenuDal)
        {
            _homeMenuDal = homeMenuDal;
        }

        public void Add(HomeMenu homeMenu)
        {
           _homeMenuDal.Add(homeMenu);
        }

        public HomeMenu GetByID(int id)
        {
           return _homeMenuDal.Get(id);
        }

        public List<HomeMenu> GetList()
        {
            return _homeMenuDal.GetAll();
        }

        public void Remove(HomeMenu homeMenu)
        {
            _homeMenuDal.Delete(homeMenu);
        }

        public void Update(HomeMenu homeMenu)
        {
          _homeMenuDal.Update(homeMenu);    
        }
    }
}
