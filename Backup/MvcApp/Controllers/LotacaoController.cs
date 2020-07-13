namespace MvcApp.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using Treinamento2013Curso03.ModelData.Logic.Curso2013Turma03.Model;
    using Treinamento2013Curso03.Repository.Logic;

    using System.Data.Objects.DataClasses;

    public class LotacaoController : Controller
    {
        private LotacoesRepository repositorio;

        public LotacaoController()
        {
            if (this.repositorio == null)
                this.repositorio = new LotacoesRepository();
        }

        //
        // GET: /Lotacao/

        public ActionResult Index()
        {
            IQueryable<Lotacao> query = this.repositorio.Obter();
            return View(query);
        }

        //
        // GET: /Lotacao/Details/5

        public ActionResult Details(int id)
        {
            Lotacao query = this.repositorio.Obter(id);
            return View(query);
        }

        //
        // GET: /Lotacao/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Lotacao/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Lotacao/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Lotacao/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Lotacao/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Lotacao/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
