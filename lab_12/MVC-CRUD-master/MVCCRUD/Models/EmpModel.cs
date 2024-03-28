using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCRUD.Models
{
    public class EmpModel
    {
		/// <summary>
		/// Employee id
		/// </summary>
        public int Id { get; set; }

		/// <summary>
		/// Employee name
		/// </summary>
		[Required]
        public string Name { get; set; }

		/// <summary>
		/// Employee age
		/// </summary>
        public int Age { get; set; }
    }
}
