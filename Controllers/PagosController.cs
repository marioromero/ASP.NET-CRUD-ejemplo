using CrudASPEjemplo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudASPEjemplo.Controllers
{
    public class PagosController : Controller
    {
        // GET: Pagos
        //lista de pagos
        public ActionResult Index()
        {
            using (var context = new PagosContext())
            {
                return View(context.Pagos.ToList());
            }
        }

        // GET: Pagos/Details/5
        //detalles de un pago por su id
        public ActionResult Details(int id)
        {
            using (var context = new PagosContext())
            {
                return View(context.Pagos.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // GET: Pagos/Create
        //no lo usamos
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pagos/Create
        //crea un pago
        [HttpPost]
        public ActionResult Create(Pago pago)
        {
            try
            {
                using (var context = new PagosContext())
                {
                    context.Pagos.Add(pago);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pagos/Edit/5
        public ActionResult Edit(int id)
        {
            using (var context = new PagosContext())
            {
                return View(context.Pagos.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Pagos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Pago pago)
        {
            try
            {
              using (var context = new PagosContext())
                {
                    context.Entry(pago).State = EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pagos/Delete/5
        public ActionResult Delete(int id)
        {
            using (var context = new PagosContext())
            {
                return View(context.Pagos.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Pagos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (var context = new PagosContext())
                {
                    Pago pago = context.Pagos.Where(x => x.Id == id).FirstOrDefault();
                    context.Pagos.Remove(pago);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
