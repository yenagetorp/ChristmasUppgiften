using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Christmas.Models.ViewModels
{
    [Bind(Prefix =nameof(ChristmasIndexVM.People))]
    public class ChristmasIndexItemVM
    {
        public int Id { get; set; }

        [Display(Name="First Name")]
        public string Name { get; set; }

        [Display(Name="Rhyme")]
        public  List<string> Rhymes{ get; set; }
    }
}
