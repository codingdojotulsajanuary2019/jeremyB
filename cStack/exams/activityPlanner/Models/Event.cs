using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace activityPlanner.Models
{
    public class ValidateDate: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Event activity = (Event)validationContext.ObjectInstance;
            DateTime now = DateTime.Now;
            DateTime fullTime = activity.date.Date + activity.time.TimeOfDay;
            if (fullTime > now)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Has to be in the future rapscallion.");
            }
        }
    }
    public class Event
    {
        
        [Key]
        public int eventId {get;set;}
        [Required]
        [MinLength(2, ErrorMessage = "Title must be 2 characters or longer!")]
        [Display(Name="Title")]
        public string title {get;set;}

        [Required]
        [MinLength(10, ErrorMessage = "Description must be 2 characters or longer!")]
        [Display(Name="Description")]
        public string desc {get;set;}

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true), Display(Name = "Event Date")]
        [ValidateDate]
        public DateTime date {get;set;}

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true), Display(Name = "Event Time")]
        public DateTime time {get;set;}
        public DateTime fullDT
        {
            get
            {
                return date.Date + time.TimeOfDay;
            }
        }
        [Display(Name="Duration")]
        public int durInt {get;set;}

        [Required]
        public string durVal {get;set;}
        
        public DateTime end
        {
            get
            {
                if(durVal == "Days")
                {
                    DateTime newDT = fullDT;
                    return newDT.AddDays(durInt);
                }
                if(durVal == "Hours")
                {
                    DateTime newDT = fullDT;
                    return newDT.AddHours(durInt);
                }
                if(durVal == "Minutes")
                {
                    DateTime newDT = fullDT;
                    return newDT.AddMinutes(durInt);
                }
                return fullDT;
            }
        }
        public User creator {get;set;}
        public DateTime created_at {get;set;} = DateTime.Now;
        public List<Participant> participants {get;set;}


        public override string ToString()
        {
            System.Console.WriteLine("------------------------------------");
            return $"Event title: {title}";

        }
    }
}