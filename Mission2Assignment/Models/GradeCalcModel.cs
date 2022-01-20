using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission2Assignment.Models
{
    public class GradeCalcModel
    {
        [Required]
        [Range(0, 100)]

        public int assignments { get; set; }

        public int groupProjects { get; set; }

        public int quizzes { get; set; }

        public int exams { get; set; }

        public int intex { get; set; }
    }
}
