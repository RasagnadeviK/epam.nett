using MVCCRUD.DAL;
using MVCCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCRUD.Controllers
{
    public class BaseController : Controller
	{
		#region Instance Creation
		/// <summary>
		/// Instance for EmpDAL
		/// </summary>
		private EmpDAL _empDal;
		public EmpDAL EmpDal
		{
			get
			{
				if (_empDal == null)
				{
					_empDal = new EmpDAL();
					return _empDal;
				}
				else
				{
					return _empDal;
				}
			}
		}

		/// <summary>
		/// Instance for EmpModel
		/// </summary>
		private EmpModel _empModel;
		public EmpModel EmpModel
		{
			get
			{
				if (_empModel == null)
				{
					_empModel = new EmpModel();
					return _empModel;
				}
				else
				{
					return _empModel;
				}
			}
			set
			{
				_empModel = value;
			}
		}
		#endregion
	}
}