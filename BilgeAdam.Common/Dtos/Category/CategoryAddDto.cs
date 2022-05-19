using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Common.Dtos.Category
{
    public class CategoryAddDto
    {
        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
