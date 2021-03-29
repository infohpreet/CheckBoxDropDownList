using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class IndexViewModel
    {
        public string SelectedLanguagesCsv { get; set; }

        public CheckBoxDropDownListViewModel SpokenLanguageViewModel { get; set; }
    }
}
