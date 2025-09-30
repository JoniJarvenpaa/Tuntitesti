using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiedonTallennus
{
    class Kysymys
    {
        public string teksti { get; set; } = string.Empty;
        public List<Vastaus> vastausVaihtoehdot { get; set; } = new List<Vastaus>();

        public Kysymys(string kysymysTeksti)
        {
            this.teksti = kysymysTeksti;
        }

        public void LisaaVastausvaihtoehto(Vastaus vastaus)
        {
            vastausVaihtoehdot.Add(vastaus);
        }
    }
}
