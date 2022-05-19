using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Common.Dtos.Customer
{
    public class CustomerAddDto
    {
        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public string CustomerId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public string CustomerName { get; set; }
        public string? ContactName { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
    }
}
