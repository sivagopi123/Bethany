﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace BethanysPieShop.Controllers
{
    [Route("api/[controller]")]
    public class PieDataController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public PieDataController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }
        [HttpGet]
        public IEnumerable<PieViewModel> LoadMorePies()
        {
            IEnumerable<Pie> dbPies = null;
            dbPies = _pieRepository.Pies.OrderBy(p => p.PieId).Take(10);

            List<PieViewModel> pies = new List<PieViewModel>();

            foreach(var dbpie in dbPies)
            {
                pies.Add(MapdbPieToPieViewModel(dbpie));
            }
            return pies;
        }

        private PieViewModel MapdbPieToPieViewModel(Pie dbPie)
        {
            return new PieViewModel()
            {
                PieId = dbPie.PieId,
                Name = dbPie.Name,
                Price = dbPie.Price,
                ShortDescription = dbPie.ShortDescription,
                ImageThumbnailUrl = dbPie.ImageThumbnailUrl
            };
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}