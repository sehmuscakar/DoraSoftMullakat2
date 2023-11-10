using DataAccessLayer.Dtos;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISubCategoryManager
    {
        SubCategoryListDto GetSubCategoryGetByIdManager(int id);
        List<SubCategoryListDto> GetSubCategoryListManager();
        List<SubCategoory> GetList();
        void Add(SubCategoory subCategoory);
        void Update(SubCategoory subCategoory);
        void Remove(SubCategoory subCategoory);
        SubCategoory GetByID(int id);
    }
}
