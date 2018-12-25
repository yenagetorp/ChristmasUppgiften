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

        //public int RecieverId { get; set; }
        [Display(Name ="Rhyme")]
        public string Rhyme { get; set; }

        [Display(Name ="To Person")]
        public List<SelectListItem> People { get; set; }
        // [Range(1,3)]
        // public int SelectedPersonValue { get; set; }
        public int RecieverId { get; set; }

    }
}
