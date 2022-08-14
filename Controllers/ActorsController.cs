using eTicket.Controllers.Data;
using eTicket.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorService _service;

        public ActorsController(IActorService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }
        /// <summary>
        /// Get: Actor/Create
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        }
    }
}
