using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemistryEducation
{
    public class ChemicalElement
    {
        [Key]
        public string ElementNumber { get; set; }
        public string ElementName { get; set; }
        public string ElementFullname { get; set; }
        public string Description { get; set; }
        public string MetalStatus { get; set; }

        //конструктор по умолчанию необходим для подключения
        public ChemicalElement() { }
    }
}
