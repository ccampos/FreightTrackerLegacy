using Microsoft.AspNetCore.Mvc;
using FreightTrackerLegacy.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FreightTrackerLegacy.Controllers
{
    public class ShipmentController : Controller
    {
        private static List<Shipment> shipments = new List<Shipment>
        {
            new Shipment { Id = 1, Destination = "New York, NY", Status = "In Transit", Date = DateTime.Now.AddDays(-2) },
            new Shipment { Id = 2, Destination = "Chicago, IL", Status = "Delivered", Date = DateTime.Now.AddDays(-1) }
        };

        public IActionResult Index()
        {
            return View(shipments);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Shipment shipment)
        {
            shipment.Id = shipments.Count + 1;
            shipments.Add(shipment);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var shipment = shipments.FirstOrDefault(s => s.Id == id);
            if (shipment != null)
            {
                shipments.Remove(shipment);
            }
            return RedirectToAction("Index");
        }
    }
}
