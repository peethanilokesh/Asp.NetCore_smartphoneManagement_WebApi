using ASP.NETCOREWebAPI_assessment.Model;
using ASP.NETCOREWebAPI_assessment.Repository;
using ASP.NETCOREWebAPI_assessment.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCOREWebAPI_assessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmartPhoneController : ControllerBase
    {
        ISmartPhoneRepository _smartPhoneRepository;
        public SmartPhoneController(ISmartPhoneRepository repository)
        {
            _smartPhoneRepository = repository;
        }
        [HttpGet]
        [Route("/api/smartphone")]
        public IActionResult Get()
        {
            var All = _smartPhoneRepository.GetPhones();
            return Ok(All);
        }
        [HttpGet]
        [Route("/api/smartphone/{id}")]
        public IActionResult GetById(int id)
        {
            var entityById = _smartPhoneRepository.GetPhoneById(id);
            if ( entityById== null)
            {
                return NotFound($"phone with Id = {id} is not found");
            }
            return Ok(entityById);
        }
        [HttpPost]
        [Authorize]
        [Route("/api/smartphone")]
        public IActionResult AddPhone([FromBody] AddViewModel addViewModel)
        {
            SmartPhone phone = new SmartPhone { Model=addViewModel.Model ,Name=addViewModel.Name,Feature=addViewModel.Feature,Price=addViewModel.Price };
            _smartPhoneRepository.AddPhone(phone);
            return Ok(phone);
        }
        [HttpPut]
        [Authorize]
        [Route("/api/smartphone/{id}")]
        public IActionResult EditEmployee(int id, [FromBody] EditViewModel editViewModel)
        {
            SmartPhone phone = _smartPhoneRepository.GetPhoneById(id);
            if (phone == null)
            {
                return NotFound($"Phone with Id = {id} is not found");
            }
            phone.Name = editViewModel.Name;
            phone.Model = editViewModel.Model;
            phone.Feature = editViewModel.Feature;
            phone.Price = editViewModel.Price;
            
            _smartPhoneRepository.UpdatePhone(phone);
            return Ok(phone);
        }
        [HttpDelete]
        [Authorize]
        [Route("/api/smartphone/{id}")]
        public IActionResult DeletePhone(int id)
        {
            SmartPhone phone = _smartPhoneRepository.GetPhoneById(id);
            if (phone == null)
            {
                return NotFound($"Phone with Id = {id} is not found");
            }
            _smartPhoneRepository.DeletePhone(id);
            return Ok();
        }
        [HttpGet]
        [Route ("/api/smartphoneMinAvg")]
        public IActionResult MinAvgOfPhonesByprice()
        {
            List<double> phones = _smartPhoneRepository.MinAndAveragePrice();
            return Ok(new { Minimum_Phone_price= phones[0],Average_Phone_Price=phones[1]});
        }
        [HttpPost]
        [Route("/api/phoneBymodel,price")]
        public IActionResult GetPhonesByModelAndPrice([FromBody] ModelAndPriceViewModel ViewModel)
        {
            return Ok(_smartPhoneRepository.GetPhonesByModelAndPrice(ViewModel));
        }
    }
}
