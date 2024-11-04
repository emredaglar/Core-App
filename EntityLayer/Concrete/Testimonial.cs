using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Testimonial
	{
		[Key]
		public int TestimonialID { get; set; }
        public int ClientName { get; set; }
        public int Company { get; set; }
        public int Comment { get; set; }
        public int ImageUrl { get; set; }
    }
}
