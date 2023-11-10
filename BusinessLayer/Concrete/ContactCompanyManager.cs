using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class ContactCompanyManager : IContactCompanyManager
    {
        private readonly IContactCompanyDal _contactCompanyDal;

        public ContactCompanyManager(IContactCompanyDal contactCompanyDal)
        {
            _contactCompanyDal = contactCompanyDal;
        }

        public void Add(ContactCompany contactCompany)
        {
            _contactCompanyDal.Add(contactCompany);
        }

        public ContactCompany GetByID(int id)
        {
            return _contactCompanyDal.Get(id);
        }

        public List<ContactCompany> GetList()
        {
           return _contactCompanyDal.GetAll();
        }

        public void Remove(ContactCompany contactCompany)
        {
           _contactCompanyDal.Delete(contactCompany);
        }

        public void Update(ContactCompany contactCompany)
        {
           _contactCompanyDal.Update(contactCompany);
        }
    }
}
