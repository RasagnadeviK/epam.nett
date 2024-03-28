using MVCCRUD.DAL;
using MVCCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCRUD.Controllers
{
	public class EmployeeController : BaseController
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        #region CRUD
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Creates user details
        /// </summary>
        /// <param name="empModel">Gets empModel</param>
        /// <returns>Returns read</returns>
        [HttpPost]
        public ActionResult Create(EmpModel empModel)
        {
			EmpDal.Create(empModel);
            return RedirectToAction("Read");
        }

        /// <summary>
        /// Edits the employee details for the given id
        /// </summary>
        /// <param name="id">Employee id</param>
        /// <returns>Returns the read</returns>
        [HttpGet]
        public ActionResult Edit(int id)
        {
			EmpModel.Id = id;
			EmpModel = EmpDal.GetEmployee(EmpModel);
			return View("Create", EmpModel);
        }

		/// <summary>
		/// Displays details for the given employee id
		/// </summary>
		/// <param name="id">Employee id</param>
		/// <returns>Returns Employee details for the given id</returns>
        [HttpGet]
        public ActionResult Details(int id)
        {
			EmpModel.Id = id;
			EmpModel = EmpDal.GetEmployee(EmpModel);
			return View(EmpModel);
        }

		/// <summary>
		/// Edit Employee details for the given id
		/// </summary>
		/// <param name="empModel">EmpModel object</param>
		/// <returns>After successful updation redirects to Read method</returns>
        public ActionResult Edit(EmpModel empModel)
        {
			EmpDal.Update(empModel);
            return RedirectToAction("Read");
        }

		/// <summary>
		/// Read all employee details
		/// </summary>
		/// <returns>Returns List of employees</returns>
        public ActionResult Read()
        {
            List<EmpModel> empList = new List<EmpModel>();
			empList = EmpDal.Read();
            return View(empList);
        }

		/// <summary>
		/// Deletes employee details for the given id
		/// </summary>
		/// <param name="id">Employee id</param>
		/// <returns>Returns View with employee details for delete</returns>
        [HttpGet]
        public ActionResult Delete(int id)
        {
			EmpModel.Id = id;
			EmpModel = EmpDal.GetEmployee(EmpModel);
			return View(EmpModel);
        }

		/// <summary>
		/// Deletes the employee for the given model
		/// </summary>
		/// <param name="empModel">Employee object</param>
		/// <returns>After deleting the records redirects to Read method </returns>
        [HttpPost]
        public ActionResult Delete(EmpModel empModel)
        {
			EmpDal.Delete(empModel);
            return RedirectToAction("Read");
        }
        #endregion
    }
}