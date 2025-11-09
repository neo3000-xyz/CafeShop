using CafeShop.DataAccess.Repository.IRepository;
using CafeShop.Models;
using CafeShop.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CafeShopWeb.Areas.Admin.Controllers
{
    [Area("admin")]


    public class OrderController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            var orderList = _unitOfWork.OrderHeader.GetAll(includeProperties: "ApplicationUser");
            return Json(new { data = orderList });
        }




        #endregion
    }
}
