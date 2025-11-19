using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Nomdes
{
    public partial class WindowMain : Form
    {
        public enum Väri
        {vihreä,keltainen,punainen,violetti,syaani}

        readonly Syllables syl = new Syllables();
        readonly Random rand = new Random();
        string path = string.Empty;
        int sanoja, min, max;

        public WindowMain()
        {
            syl.InitialisoiTiedosto();
            InitializeComponent();
        }

        public int SatunnaisLuku(int minimi, int maksimi)
        {
            return rand.Next(minimi, maksimi);
        }

        public static string IsoAlkukirjain(string s)
        {
            // Check for empty string.  
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.  
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        private void LuoTavut(object sender, EventArgs e)
        {
            PäivitäArvot(this, e);
            TB_OUT.Text = string.Empty;
            for (int i = 0; i < sanoja; i++)
            {
                LuoSana(SatunnaisLuku(min, max +1));
            }
        }
        private void Muodosta(Väri[] v)
        {
            string s = string.Empty;
            char c = (char)0;
            for (int i = 0; i < v.Length; i++)
            {
                switch (v[i])
                {
                    case Väri.vihreä:
                        string g = syl.vih[rand.Next(syl.vih.Length)] + ';';
                        if (CHECK_CAPITAL.Checked)
                            g = IsoAlkukirjain(g);
                        s += "[Green]" + g;
                        break;
                    case Väri.violetti:
                        s += "[Purple]" + syl.vio[rand.Next(syl.vio.Length)] + ';';
                        break;
                    case Väri.syaani:
                        s += "[DarkCyan]" + syl.sya[rand.Next(syl.sya.Length)] + ';';
                        break;
                    case Väri.keltainen:
                        string k = syl.kel[rand.Next(syl.kel.Length)];
                        c = k.Last();
                        s += "[Yellow]" + k.Remove(k.Length - 1) + ';';
                        break;
                    case Väri.punainen:
                        string p;
                        if (c != (char)0)
                        {
                            bool hasSuffix = false;
                            foreach (string str in syl.pun)
                            {
                                if (str.StartsWith(c.ToString()))
                                    hasSuffix = true;
                            }
                            if (hasSuffix)
                            {
                                do
                                {
                                    p = syl.pun[rand.Next(syl.pun.Length)];
                                } while (!p.StartsWith(c.ToString()));
                                s += "[Red]" + p + ';';
                                break;
                            }
                            else
                            {
                                Muodosta(v);
                                break;
                            }
                        }
                        else
                            s += "[Red]" + syl.pun[rand.Next(syl.pun.Length)] + ';';
                            break;

                    default:
                        break;
                }
            }
            TulostaSanat(s);
        }
        private void LuoSana(int type)
        {
            Väri[] v = new Väri[] { };
            switch (type)
            {
                case 2:
                    v = new Väri[] {Väri.vihreä, Väri.punainen};
                    break;
                case 3:
                    int x = rand.Next(3);
                    switch (x)
                    {
                        case 0:
                            v = new Väri[] { Väri.vihreä, Väri.punainen, Väri.syaani }; //vihreä, punainen, syaani
                            break;
                        case 1:
                            v = new Väri[] { Väri.vihreä, Väri.keltainen, Väri.punainen }; //vihreä, keltainen, punainen
                            break;
                        case 2:
                            v = new Väri[] { Väri.vihreä, Väri.violetti, Väri.punainen }; //vihreä, violetti, punainen
                            break;
                        default:
                            break;
                    }
                    break;
                case 4:
                    int y = rand.Next(3);
                    switch (y)
                    {
                        case 0:
                            v = new Väri[] { Väri.vihreä, Väri.violetti, Väri.punainen, Väri.syaani }; //vihreä, violetti, punainen, syaani
                            break;
                        case 1:
                            v = new Väri[] { Väri.vihreä, Väri.keltainen, Väri.punainen, Väri.syaani }; //vihreä, keltainen, punainen, syaani
                            break;
                        case 2:
                            v = new Väri[] { Väri.vihreä, Väri.violetti, Väri.keltainen, Väri.punainen }; //vihreä, violetti, keltainen, punainen
                            break;
                        default:
                            break;
                    }
                    break;
                case 5:
                    v = new Väri[] { Väri.vihreä, Väri.violetti, Väri.keltainen, Väri.punainen, Väri.syaani }; //vihreä, violetti, keltainen, punainen, syyani
                    break;
                default:
                    Console.WriteLine("Miten helvetissä?");
                    break;
            }
            Muodosta(v);
        }

        private void PäivitäArvot(object sender, EventArgs e)
        {
            sanoja = decimal.ToInt32(WORDS_TOTAL.Value);

            if (WORDS_LENGTH_MAX.Value < WORDS_LENGTH_MIN.Value)
                WORDS_LENGTH_MAX.Value = WORDS_LENGTH_MIN.Value;
            min = decimal.ToInt32(WORDS_LENGTH_MIN.Value);
            max = decimal.ToInt32(WORDS_LENGTH_MAX.Value);
            TB_OUT.Font = new Font("Microsoft Sans Serif", (float)FONT_SCALE.Value, FontStyle.Regular);
        }

        private void Poistu(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Info(object sender, EventArgs e)
        {
            Tietoa t = new Tietoa();
            t.Show();
        }

        private void BTN_CLEAR_Click(object sender, EventArgs e)
        {
            TB_OUT.Text = string.Empty;
        }

        private void Tallenna(object sender, EventArgs e)
        {
            if (path != string.Empty)
            {
                TextWriter txt = new StreamWriter(path);
                txt.Write(TB_OUT.Text);
                txt.Close();
            }
            else
                TallennaNimellä(this, e);
        }

        private void BTN_CPY_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TB_OUT.Text);
        }

        private void TallennaNimellä(object sender, EventArgs e)
        {
            if (SaveAsDiag.ShowDialog() == DialogResult.OK)
            {
                path = SaveAsDiag.FileName;
                Tallenna(this, e);
            }
        }

        private void TulostaSanat(string s)
        {
            string[] syllables = s.Split(';');
            foreach (string str in syllables)
            {
                if (str.Length > 0)
                {
                    string output = str.Split('[',']')[1];
                    string final = str.Substring(str.IndexOf(']') + 1);
                    if(!CHECK_COLOR.Checked)
                        TB_OUT.AppendText(final, Color.White);
                    else
                        TB_OUT.AppendText(final, Color.FromName(output));
                }
                else
                    TB_OUT.AppendText(Environment.NewLine);
            }
        }
    }
    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionBackColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
