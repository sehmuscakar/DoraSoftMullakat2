using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Dtos;
using DataAccessLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class SubCategoryManager : ISubCategoryManager
    {
        private readonly ISubCategoryDal _subCategoryDal;

        public SubCategoryManager(ISubCategoryDal subCategoryDal)
        {
            _subCategoryDal = subCategoryDal;
        }

        public void Add(SubCategoory subCategoory)
        {
            _subCategoryDal.Add(subCategoory);
        }

        public SubCategoory GetByID(int id)
        {
            return _subCategoryDal.Get(id);
        }

        public List<SubCategoory> GetList()
        {
           return _subCategoryDal.GetAll(); 
        }

        public SubCategoryListDto GetSubCategoryGetByIdManager(int id)
        {
           return _subCategoryDal.GetCtegoryGetByIdDal(id);
        }

        public List<SubCategoryListDto> GetSubCategoryListManager()
        {
            return _subCategoryDal.GetCtegoryListDal();
        }

        public void Remove(SubCategoory subCategoory)
        {
            _subCategoryDal.Delete(subCategoory);
        }

        public void Update(SubCategoory subCategoory)
        {
           _subCategoryDal.Update(subCategoory);
        }
    }
}
