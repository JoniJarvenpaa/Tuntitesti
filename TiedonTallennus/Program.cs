using TiedonTallennus;
var kysymysPatteri = new List<Kysymys>();

void MainProgram()
{
    var kyssarit = LuoKysymykset();
}

List<Kysymys> LuoKysymykset() {
    var kysymysLista = new List<Kysymys>();
    string? kayttajasyote = string.Empty;
    int moneskoKysymys = 1;
    while (kayttajasyote != null && kayttajasyote.ToLower() != "valmis")
    {
        Console.WriteLine("Kysymys numero "+moneskoKysymys.ToString());
        Console.WriteLine("Kirjoita kysymyksen nimi, tai 'Valmis' lopettaaksesi");
        kayttajasyote = Console.ReadLine();
        if (kayttajasyote != null && kayttajasyote.Length > 3 && kayttajasyote.ToLower() != "valmis")
        {
            var uusikysymys = new Kysymys(kayttajasyote);
            int vastaustenMaara = 0;
            while(vastaustenMaara < 1) { 
                Console.WriteLine("Montako vastausta laitetaan?");
                string? kayttajaSyoteMaara = Console.ReadLine();
                if(kayttajaSyoteMaara != null)
                {
                    int.TryParse(kayttajaSyoteMaara, out vastaustenMaara);
                }
            }
            for(int i = 0; i < vastaustenMaara; i++)
            {
                Console.WriteLine("Vastaus nro #"+(i+1));
                Console.WriteLine("Anna vastauksen arvo:");
                string? KayttajaSyoteVastausTeksti = Console.ReadLine();
                Console.WriteLine("Onko oikein vai väärin? 1 = oikein, 0 = väärin");
                string? KayttajaSyoteVastausMaara = Console.ReadLine();
                var vastaus = new Vastaus(KayttajaSyoteVastausTeksti, KayttajaSyoteVastausMaara);
                uusikysymys.LisaaVastausvaihtoehto(vastaus);
            }
            moneskoKysymys++;
            kysymysLista.Add(uusikysymys);
        }
    }
    return kysymysLista;
}


MainProgram();