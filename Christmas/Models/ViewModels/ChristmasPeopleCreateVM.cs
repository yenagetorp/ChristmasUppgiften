using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Christmas.Models.ViewModels
{
    [Bind(Prefix = nameof(ChristmasIndexVM.CreateFormVM))]
    public class ChristmasPeopleCreateVM
    {
        [Display(Name="First Name")]
        [Required(ErrorMessage ="Enter your name please")]
        public string Name { get; set; }
    }
}
