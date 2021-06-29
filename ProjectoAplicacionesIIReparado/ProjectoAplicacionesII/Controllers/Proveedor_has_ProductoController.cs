using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectoAplicacionesII.Models;

namespace ProjectoAplicacionesII.Controllers
{
    public class Proveedor_has_ProductoController : Controller
    {
        private TecnoHardw1Entities1 db = new TecnoHardw1Entities1();

        // GET: Proveedor_has_Producto
        public ActionResult Index()
        {
            var proveedor_has_Producto = db.Proveedor_has_Producto.Include(p => p.Producto).Include(p => p.Proveedor);
            return View(proveedor_has_Producto.ToList());
        }

        // GET: Proveedor_has_Producto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proveedor_has_Producto proveedor_has_Producto = db.Proveedor_has_Producto.Find(id);
            if (proveedor_has_Producto == null)
            {
                return HttpNotFound();
            }
            return View(proveedor_has_Producto);
        }

        // GET: Proveedor_has_Producto/Create
        public ActionResult Create()
        {
            ViewBag.fkpkid_producto = new SelectList(db.Producto, "id_producto", "nombre_producto");
            ViewBag.fkpkid_proveedor = new SelectList(db.Proveedor, "id_proveedor", "nombre");
            return View();
        }

        // POST: Proveedor_has_Producto/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_proveedor_producto,fkpkid_proveedor,fkpkid_producto")] Proveedor_has_Producto proveedor_has_Producto)
        {
            if (ModelState.IsValid)
            {
                db.Proveedor_has_Producto.Add(proveedor_has_Producto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.fkpkid_producto = new SelectList(db.Producto, "id_producto", "nombre_producto", proveedor_has_Producto.fkpkid_producto);
            ViewBag.fkpkid_proveedor = new SelectList(db.Proveedor, "id_proveedor", "nombre", proveedor_has_Producto.fkpkid_proveedor);
            return View(proveedor_has_Producto);
        }

        // GET: Proveedor_has_Producto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proveedor_has_Producto proveedor_has_Producto = db.Proveedor_has_Producto.Find(id);
            if (proveedor_has_Producto == null)
            {
                return HttpNotFound();
            }
            ViewBag.fkpkid_producto = new SelectList(db.Producto, "id_producto", "nombre_producto", proveedor_has_Producto.fkpkid_producto);
            ViewBag.fkpkid_proveedor = new SelectList(db.Proveedor, "id_proveedor", "nombre", proveedor_has_Producto.fkpkid_proveedor);
            return View(proveedor_has_Producto);
        }

        // POST: Proveedor_has_Producto/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_proveedor_producto,fkpkid_proveedor,fkpkid_producto")] Proveedor_has_Producto proveedor_has_Producto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(proveedor_has_Producto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.fkpkid_producto = new SelectList(db.Producto, "id_producto", "nombre_producto", proveedor_has_Producto.fkpkid_producto);
            ViewBag.fkpkid_proveedor = new SelectList(db.Proveedor, "id_proveedor", "nombre", proveedor_has_Producto.fkpkid_proveedor);
            return View(proveedor_has_Producto);
        }

        // GET: Proveedor_has_Producto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proveedor_has_Producto proveedor_has_Producto = db.Proveedor_has_Producto.Find(id);
            if (proveedor_has_Producto == null)
            {
                return HttpNotFound();
            }
            return View(proveedor_has_Producto);
        }

        // POST: Proveedor_has_Producto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Proveedor_has_Producto proveedor_has_Producto = db.Proveedor_has_Producto.Find(id);
            db.Proveedor_has_Producto.Remove(proveedor_has_Producto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
