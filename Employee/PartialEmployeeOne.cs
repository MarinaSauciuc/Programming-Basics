using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee //trebuie sa aibe acelasi namespace cu cealalta clasa partiala
{
    public partial class PartialEmployee //numele clasei trebuie sa fie acelasi cu al celeilalte clase partiale chiar daca fisierele se numesc diferit
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
    }
}
