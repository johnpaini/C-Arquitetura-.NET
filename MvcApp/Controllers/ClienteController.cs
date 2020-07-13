using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Treinamento2013Curso03.ModelData.Logic.Curso2013Turma03.Model;

namespace MvcApp.Controllers
{ 
    public class ClienteController : Controller
    {
        private Curso2013Turma03Entities db = new Curso2013Turma03Entities();

        //
        // GET: /Cliente/

        public ViewResult Index()
        {
            return View(db.Clientes.ToList());
        }

        //
        // GET: /Cliente/Details/5

        public ViewResult Details(int id)
        {
            Cliente cliente = db.Clientes.Single(c => c.ID == id);
            return View(cliente);
        }

        //
        // GET: /Cliente/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Cliente/Create

        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                db.Clientes.AddObject(cliente);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(cliente);
        }
        
        //
        // GET: /Cliente/Edit/5
 
        public ActionResult Edit(int id)
        {
            Cliente cliente = db.Clientes.Single(c => c.ID == id);
            return View(cliente);
        }

        //
        // POST: /Cliente/Edit/5

        [HttpPost]
        public ActionResult Edit(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                db.Clientes.Attach(cliente);
                db.ObjectStateManager.ChangeObjectState(cliente, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        //
        // GET: /Cliente/Delete/5
 
        public ActionResult Delete(int id)
        {
            Cliente cliente = db.Clientes.Single(c => c.ID == id);
            return View(cliente);
        }

        //
        // POST: /Cliente/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Cliente cliente = db.Clientes.Single(c => c.ID == id);
            db.Clientes.DeleteObject(cliente);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}