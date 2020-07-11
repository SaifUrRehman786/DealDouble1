using DealDouble.Entities;
using DealDouble.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DealDouble.Web.Controllers
{
    public class AuctionsController : Controller
    {
        // GET: Auctions
        public ActionResult Index()
        {
            AuctionService service = new AuctionService();

          var auctions = service.GetAllAuctions();

            if (Request.IsAjaxRequest())
            {
                return PartialView(auctions);
            }
            else
            {
                return View(auctions);
            }
           
        }

        // GET: Auctions
        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(Auction auction)
        {
            AuctionService service = new AuctionService();

            service.SaveAuction(auction);

            return RedirectToAction("Index");
        }

        // GET: Auctions
        public ActionResult Edit(int ID)
        {
            AuctionService service = new AuctionService();

            var auction = service.GetAuctionByID(ID);

            return PartialView(auction);
        }

        [HttpPost]
        public ActionResult Edit(Auction auction)
        {
            AuctionService service = new AuctionService();

            service.UpdateAuction(auction);

            return RedirectToAction("Index");
        }

        // GET: Auctions
        public ActionResult Delete(int ID)
        {
            AuctionService service = new AuctionService();

            var auction = service.GetAuctionByID(ID);

            return View(auction);
        }

        [HttpPost]
        public ActionResult Delete(Auction auction)
        {
            AuctionService service = new AuctionService();

            service.DeleteAuction(auction);

            return RedirectToAction("Index");
        }
    }
}