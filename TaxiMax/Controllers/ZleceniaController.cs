using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net;
using TaxiMax.Data;
using TaxiMax.Models;

namespace TaxiMax.Controllers
{
    public class ZleceniaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ZleceniaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult ZamowTaxiForm(Zlecenie model)
        {
            model.Status = "Nowe";         
            _context.Zlecenia.Add(model);  
            _context.SaveChanges();        

            return RedirectToAction("Index", "Home");  
        }

        public IActionResult Zlecenia()
        {
            var lista = _context.Zlecenia.OrderBy(Zlecenie => Zlecenie.Status).ToList();
            return View(lista);
        }

        public IActionResult ZacznijZlecenie(int id)
        {
            var zlecenie = _context.Zlecenia.SingleOrDefault(x => x.Id == id);
            if (zlecenie != null)
            {
                zlecenie.Status = "W trakcie";
                _context.SaveChanges();
            }
            return RedirectToAction("Zlecenia");
        }

        public IActionResult ZakonczZlecenie(int id)
        {
            var zlecenie = _context.Zlecenia.SingleOrDefault(x => x.Id == id);
            if (zlecenie != null)
            {
                zlecenie.Status = "Zakończono";
                _context.SaveChanges();
            }
            return RedirectToAction("Zlecenia");
        }
    }
}