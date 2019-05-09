using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace CMS.Models
{
    public class CallForPapers

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(10)]
        public string Acronym { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime DeadlineAbstract { get; set; }
        [Required]
        public DateTime DeadlineProposal { get; set; }

		[Required(ErrorMessage = "Please select a Topic")]
		public int Topic_Id1 { get; set; }
		public int[] ListOfTopicId { get; set; }

		[StringLength(100)]
		public string Topic_Name { get; set; }
		public IEnumerable<SelectListItem> SelectTopic { get; set; }
    }
}