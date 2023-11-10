using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class ContactCompanyController : Controller
    {
        // GET: ContactCompanyController
        private readonly IContactCompanyManager _contactCompanyManager;

        public ContactCompanyController(IContactCompanyManager contactCompanyManager)
        {
            _contactCompanyManager = contactCompanyManager;
        }

        public ActionResult Index()
        {
            var listele = _contactCompanyManager.GetList();
            return View(listele);
        }

        // GET: ContactCompanyController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactCompanyController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ContactCompany contactCompany, IFormFile? ImageUrlLogo)
        {
            try
            {
                if (!ModelState.IsValid)
                {

                    if (ImageUrlLogo is not null)
                    {
                        string klasor1 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + ImageUrlLogo.FileName;
                        using var stream1 = new FileStream(klasor1, FileMode.Create);
                        ImageUrlLogo.CopyTo(stream1);
                       contactCompany.ImageUrlLogo = ImageUrlLogo.FileName;
                    }

                    _contactCompanyManager.Add(contactCompany);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ContactCompanyController/Edit/5
        public ActionResult Edit(int id)
        {
            var datagetir = _contactCompanyManager.GetByID(id);
            return View(datagetir);
        }

        // POST: ContactCompanyController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ContactCompany contactCompany, IFormFile? ImageUrlLogo)
        {
            try
            {
                if (!ModelState.IsValid)
                {

                    if (ImageUrlLogo is not null)
                    {
                        string klasor1 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + ImageUrlLogo.FileName;
                        using var stream1 = new FileStream(klasor1, FileMode.Create);
                        ImageUrlLogo.CopyTo(stream1);
                        contactCompany.ImageUrlLogo = ImageUrlLogo.FileName;
                    }

                    _contactCompanyManager.Update(contactCompany);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ContactCompanyController/Delete/5
        public ActionResult Delete(int id)
        {
            var datagetir = _contactCompanyManager.GetByID(id);
            return View(datagetir);
        }

        // POST: ContactCompanyController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ContactCompany contactCompany, IFormFile? ImageUrlLogo)
        {
            try
            {
                _contactCompanyManager.Remove(contactCompany);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
