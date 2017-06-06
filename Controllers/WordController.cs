using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetcoretest.Repositories;
using dotnetcoretest.Models;

namespace dotnetcoretest.Controllers
{
    public class WordController : Controller
    {
        private readonly WordRepository wordRepository;

        public WordController()
        : base()
        {
            wordRepository = WordRepository.Instance;
            wordRepository.Add(new Word(1));
            wordRepository.Add(new Word(2));
        }

        public IActionResult Index()
        {
            ViewData["Words"] = wordRepository.GetAll();
            return View();
        }

        public IActionResult Add()
        {
            wordRepository.Add(new Word(11));
            
            return RedirectToAction("Index");

        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
