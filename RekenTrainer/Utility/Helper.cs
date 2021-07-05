using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RekenTrainer.Utility
{
    public class Helper
    {
        public static string Leerling = "Leerling";
        public static string Leraar = "Leraar";

        public static List<SelectListItem> GetRoleForDropDown()
        {
            return new List<SelectListItem>
            {
                new SelectListItem { Value = Helper.Leerling, Text = Helper.Leerling },
                new SelectListItem { Value = Helper.Leraar, Text = Helper.Leraar }
            };
        }
    }
}
