using System.Text.Json;

namespace ObjectOriented_Template.Models.Services
{
    public static class JsonService
    {
        private static string tallennusKansio = "Json";
        private static string kysymysTiedostoNimi = "kysymykset.json";
        public static bool TallennaKysymykset(List<Kysymys> kysymykset)
        {
            try
            {
                if(kysymykset != null && kysymykset.Count() > 0) {
                    string jsonMuoto = JsonSerializer.Serialize(kysymykset);

                    string docPath = Environment.CurrentDirectory;
                    string savePath = Path.Combine(docPath, tallennusKansio);
                    if (CreateDirectoryIfNotExist(savePath))
                    {
                        string fullSavePath = Path.Combine(savePath, kysymysTiedostoNimi);

                        var outputFile = new StreamWriter(fullSavePath);
                        outputFile.WriteLine(jsonMuoto);
                        outputFile.Close();
                    }
                    else return false;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        private static bool CreateDirectoryIfNotExist(string path)
        {
            try
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                return Directory.Exists(path);
            }
            catch
            {
                return false;
            }
        }
    }
}
