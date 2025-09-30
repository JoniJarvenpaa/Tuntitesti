using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented_Template
{
    public class Vastaus
    {
        public string teksti { get; set; } = string.Empty; // vastausteksti
        public bool onkoOikein { get; set; } // Onko kysymys oikein vai ei
    
        public Vastaus(string? teksti, string? onkoOikeinTeksti)
        {
            if(teksti != null)
                this.teksti = teksti;
            if (onkoOikeinTeksti == "1") {  
                this.onkoOikein = true;
            }
        }
        public Vastaus() { }
    }
}
