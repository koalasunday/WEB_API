using Electronic.DataAccess.Models;
using Electronic.DataAccess.Params;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Electronic.Client.Controllers
{
    public class DetailsController : Controller
    {
        MyContext db = new MyContext();
        // GET: Details
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Create(TransactionParam param)
        {
            try
            {
                Transaction trans = new Transaction();
                trans.TransactionCode = param.TransactionCode;
                trans.TransactionDate = DateTimeOffset.UtcNow.LocalDateTime;
                //trans.IsDeleted = false;

                db.Transactions.Add(trans);
                db.SaveChanges();
                
                try
                {
                    //get id of transaction/master of transaction to object(getId)//
                    var getId = db.Transactions.SingleOrDefault(x => x.Id.Equals(trans.Id));
                    var menu = db.Items.SingleOrDefault(x => x.Id.Equals(param.Items_Id));


                    DetailTransaction detail = new DetailTransaction();
                    detail.Quantity = param.DetailTransactions_Quantity;
                    detail.Price = param.DetailTransactions_Price;
                    detail.Item = menu; //object to object//
                    detail.Transaction = getId; //object to object//

                    db.DetailTransactions.Add(detail);
                    db.SaveChanges();

                }
                catch (Exception ex)
                {
                    Console.Write(ex.InnerException);
                    Console.Write(ex.StackTrace);
                }

            }
            catch (Exception ex)
            {
                Console.Write(ex.InnerException);
                Console.Write(ex.StackTrace);
            }

            return Json(param, JsonRequestBehavior.AllowGet);

            //bool status = false;
            //DateTimeKind dateOrg;
            //var isValidDate = DateTime.TryParseExact(order.OrderDateString, "mm-dd-yyyy", null, System.Globalization.DateTimeStyles.None, out dateOrg);
            //if (isValidDate)
            //{
            //    order.OrderDate = dateOrg;
            //}

            //var isValidModel = TryUpdateModel(param);
            //if (isValidModel)
            //{
            //    using (MyContext db = new MyContext())
            //    {
            //        db.Transactions.Add(order);
            //        db.SaveChanges();
            //        status = true;
            //    }
            //}
            //return new JsonResult { Data = new { status = status } };
            //return Json(JsonRequestBehavior.AllowGet);
        }
    }
}