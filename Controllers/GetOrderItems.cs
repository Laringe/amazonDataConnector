using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace AmazonDataConnector.Controllers {
    public class GetOrderItems :Controller {
        // GET: GetOrderItems
        public ActionResult Index() {
            return View();
        }

        // GET: GetOrderItems/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: GetOrderItems/Create
        public ActionResult Create() {
            return View();
        }

        // POST: GetOrderItems/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: GetOrderItems/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: GetOrderItems/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: GetOrderItems/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: GetOrderItems/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }
    }
}
