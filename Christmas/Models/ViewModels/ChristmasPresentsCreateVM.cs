using Christmas.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Christmas.Models.ViewModels
{
    public class ChristmasPresentsCreateVM
    {
       // public int Id { get; set; }

        [Display(Name ="Rhyme")]
        public string Rhyme { get; set; }

        [Display(Name = "Sender")]
        public string Sender { get; set; }

        [Display(Name = "From")]
         [Range(1,10)]
        public SelectListItem[] Senders { get; set; }
        // public int SelectedSenderValue { get; set; }

        [Display(Name ="To Person")]
        public List<SelectListItem> People { get; set; }
        public int RecieverId { get; set; }

    }
}
