using CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD.Controllers
{
    public class AulaMDController : Controller
    {
        // GET: AulaMD
        public ActionResult Index()
        {
            AULA_MDEntities ctx = new AULA_MDEntities();
            var listaAula = ctx.AULA_MD.ToList();
            return View(listaAula);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AULA_MD aula)
        {
            if (ModelState.IsValid)
            {
                AULA_MDEntities ctx = new AULA_MDEntities();
                ctx.AULA_MD.Add(aula);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        
        public ActionResult Delete(int id)
        {
            AULA_MDEntities ctx = new AULA_MDEntities();
            var excluirAula = ctx.AULA_MD.Find(id);
            return View(excluirAula);
        }

        [HttpPost]
        public ActionResult Delete(AULA_MD aula)
        {
            AULA_MDEntities ctx = new AULA_MDEntities();
            var excluirAula = ctx.AULA_MD.Find(aula.AulaId);
            ctx.AULA_MD.Remove(excluirAula);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            AULA_MDEntities ctx = new AULA_MDEntities();
            var editarAula = ctx.AULA_MD.Find(id);
            return View(editarAula);
        }

        [HttpPost]
        public ActionResult Edit(AULA_MD aula)
        {
            if (ModelState.IsValid)
            {
                AULA_MDEntities ctx = new AULA_MDEntities();
                ctx.Entry(aula).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Details(int id)
        {
            AULA_MDEntities ctx = new AULA_MDEntities();
            var detalheAula = ctx.AULA_MD.Find(id);
            return View(detalheAula);
        }


    }
}