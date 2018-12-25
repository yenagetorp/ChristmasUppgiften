using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Christmas.Models.ViewModels
{
    public class ChristmasIndexVM
    {
        public ChristmasIndexItemVM[] People{ get; set; }
        public ChristmasPeopleCreateVM CreateFormVM { get; set; }
    }
}
