﻿namespace MvcApp.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using Treinamento2013Curso03.ModelData.Logic.Curso2013Turma03.Model;
    using Treinamento2013Curso03.Repository.Logic;

    using System.Data.Objects.DataClasses;

    using SGI.Framework.MVC.Architecture.Controller;

    public class CargoController : BaseControllerEntityFramework<CargosRepository>
    {
        public CargoController() : base(false, false) { }

        //
        // GET: /Cargo/

        public ActionResult Index()
        {
            IQueryable<Cargo> query = this.Repositorio.Obter();
            return View(query);
        }

        //
        // GET: /Cargo/Details/5

        public ActionResult Details(int id)
        {
            Cargo query = this.Repositorio.Obter(id);
            return View(query);
        }
        
        // POST: /Lotacao/Create

        [HttpPost]
        public ActionResult Create(Cargo instancia)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    this.Repositorio.Alterar(instancia);

                    return RedirectToAction("Index");
                }
                return View(instancia);
                // TODO: Add insert logic here

              
            }
            catch
            {
                return View();
            }
        }
        //GET
        public ActionResult Edit (int id)
        {
            return this.Details(id);
        }
        [HttpPost]
        public ActionResult Edit(int id, Cargo instancia)
        {
            if (ModelState.IsValid)
            {
                this.Repositorio.Alterar(instancia);

                return RedirectToAction("Index");
            }
            return View(instancia);
        }
        // GET: /Cliente/Delete/5

        public ActionResult Delete(int id)
        {
            return this.Details(id);
            
        }
        // POST: /Cliente/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
       
            Cargo query =this.Repositorio.Obter(id);
            this.Repositorio.Excluir(query);
            return RedirectToAction("Index");
        }


    }
}

        
 
        

