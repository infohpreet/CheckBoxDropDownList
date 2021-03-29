using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class CheckBoxDropDownListViewModel
    {
        public Dictionary<string,string> Items { get; set; }

        public string SelectedItemsCsv { get; set; }

        public string ControlName { get; set; }

        public List<string> SelectedItems
        {
            get
            {
                return SelectedItemsCsv.FromCsvToStringList();
            }
        }
    }
}
