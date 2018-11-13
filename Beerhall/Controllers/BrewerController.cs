using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Beerhall.Data;
using Beerhall.Models.Domain;
using Beerhall.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Beerhall.Controllers
{
    public class BrewerController : Controller
    {
        private readonly IBrewerRepository _brewerRepository;
        public BrewerController(IBrewerRepository brewerRepository) {
            _brewerRepository = brewerRepository;
        }
        public IActionResult Index()
        {
            var brewers = _brewerRepository.GetAll();
            ViewData["TotalTurnover"] = brewers.Sum(b => b.Turnover);       
                return View(brewers);

        }

        public IActionResult Edit(int id) {
            var brewer = _brewerRepository.GetById(id);
            return View(new BrewerEditViewModel(brewer)); //brewerid moet zo gelaten worden
        }
    }
}