using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using FluentValidation.Results;


namespace AgriculturePresentation.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public IActionResult Index()
        {
            var values = _addressService.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult UpdateAddress(int id)
        {
            var values = _addressService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAddress(Address address)
        {
            _addressService.Update(address);
            return RedirectToAction("Index");
        }
    }
}
