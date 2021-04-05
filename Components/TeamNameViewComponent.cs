using Assignment10GrandFinale.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment10GrandFinale.Components
{
    public class TeamNameViewComponent : ViewComponent 
    {
        private BowlingLeagueContext context;
        public TeamNameViewComponent(BowlingLeagueContext ctx)
        {
            context = ctx;
        }
        public IViewComponentResult Invoke()
        {


            return View(context.Teams
                .Distinct()
                .OrderBy(x => x)
                );
        }
    }
}
