using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Nomdes
{
    class Syllables
    {
        public string[] vih;
        public string[] pun;
        public string[] kel;
        public string[] vio;
        public string[] sya;

        public void InitialisoiTiedosto()
        {
            try
            {
                var fileStream = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "tavut.nom", FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        string output = line.Split('[', ']')[1];
                        string final = line.Substring(line.IndexOf(']') + 1);
                        switch (output)
                        {
                            case "Vihreä":
                                vih = final.Split(',');
                                break;
                            case "Punainen":
                                pun = final.Split(',');
                                break;
                            case "Keltainen":
                                kel = final.Split(',');
                                break;
                            case "Violetti":
                                vio = final.Split(',');
                                break;
                            case "Syaani":
                                sya = final.Split(',');
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("tavut.nom on viallinen tai puuttuu", "Virhe!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
    }
}