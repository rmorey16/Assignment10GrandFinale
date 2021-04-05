using Assignment10GrandFinale.Models;
using Assignment10GrandFinale.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment10GrandFinale.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Bowler> Bowlers { get; set; }
        public PageNumberingInfo PageNumberingInfo { get; set; }
        public string TeamName { get; set; }
    }
}
