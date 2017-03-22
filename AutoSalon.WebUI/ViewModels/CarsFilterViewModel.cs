using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutoSalon.WebUI.ViewModels
{
    public class CarsFilterViewModel
    {
        public IEnumerable<string> Impororters { get; set; }
      
        public string Importer { get; set; }

        [StringLength(20, MinimumLength = 3,ErrorMessageResourceType = typeof(Strings),
            ErrorMessageResourceName = "Description_Val_Error_Message")]
        public string Description { get; set; }
    }
}