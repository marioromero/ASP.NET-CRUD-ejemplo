using CrudASPEjemplo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudASPEjemplo.Controllers
{
    public class PagoController : Controller
    {
        // GET: Pago
        public ActionResult Index()
        {
            using (var context = new PagosContext())
            {
                var pagos = context.Pagos.ToList();

                return View(pagos);

            }
        }

        // GET: Pago/Details/5
        public ActionResult Details(int id)
        {
            using (var context = new PagosContext())
            {
                var pagos = context.Pagos.Where(x => x.id == id);

                var pagos2 = (from p in context.Pagos
                              where p.id == id
                              select p).FirstOrDefault();

                return View(pagos);

            }
        }

        // GET: Pago/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pago/Create
        [HttpPost]
        public ActionResult Create(Pago pago)
        {
            try
            {
                using (var context = new PagosContext())
                {
                    context.Pagos.Add(pago);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }

            }
            catch
            {
                return View();
            }
        }

        // GET: Pago/Edit/5
        public ActionResult Edit(int id)
        {
            using (var context = new PagosContext())
            {
                var pagos = context.Pagos.Where(x => x.id == id);

                var pagos2 = (from p in context.Pagos
                              where p.id == id
                              select p).FirstOrDefault();

                return View(pagos);
            }
        }

        // POST: Pago/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Pago pago)
        {
            try
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

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pago/Delete/5
        public ActionResult Delete(int id)
        {

            using (var context = new PagosContext())
            {
                return View(context.Pagos.Where(x => x.id == id).FirstOrDefault());

            }

        }

        // POST: Pago/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (var context = new PagosContext())
                {
                    Pago pago = context.Pagos.Where(x => x.id == id).FirstOrDefault();
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
