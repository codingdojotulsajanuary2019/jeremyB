using System;
using System.ComponentModel.DataAnnotations;

namespace dojoSurvey.Models
{
    public class surveyResults
    {
        [Required]
        [MinLength(2, ErrorMessage="TYPE MORE DUMMY")]
       public string name {get;set;}

       [Required]
       [MinLength(1)]
       public string location {get;set;}

       [Required]
       [MinLength(1)]
       public string language {get;set;}

       [MinLength(15, ErrorMessage="TYPE MORE DUMMY")]
       public string comment {get;set;}
    }
}