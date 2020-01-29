using System;
using System.Collections.Generic;
using System.Text;

namespace _09_ListesStructures
{
    public class Facture
    {
        public List<LigneFacture> LignesFacture { get; set; }
        public decimal SousTotal { get; set; }
        public decimal Taxes { get; set; }
        public decimal Total { get; set; }
        public bool EstCalculee { get; set; }
    }
}
