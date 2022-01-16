using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void genera_Click(object sender, EventArgs e) //al click del bottone genera
        {
            int charProb = 3, numbProb = 1; //probabilita' di estrazione: normalmente 10% numeri e 90% altri caratteri
            int randMVal = -1;    //valore random massimo per la selezione dell'array
            int masMin, masMai, masNum, masSpe;
            int randChar;
            string password = "";   //istanza classe string - dimensione non specificata
            Random ran = new Random();  //istanza randomizzatore
            char[] lettMin = "abcdefghijklmnopqrstuvwxyz".ToCharArray();    //assegnazione di una stringa (soggetta a casting ad array di char) ad un array
            char[] lettMai = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] lettNum = "0123456789".ToCharArray();
            char[] lettSpe = "!#$%\'()*+_,-./:;<=>?@[\\]^_`{|}~".ToCharArray();

            //controllo dell'estrazione di un tipo di carattere
            bool isMin = false;
            bool isMai = false;
            bool isNum = false;
            bool isSpe = false;

            double secondo = 10000000000 / 0.4;  //controllo sicurezza con 10 miliardi di chiavi al secondo considerando 0.4 come fattore casuale
            double totLettere = 0;
            double tempo = 1;
            

            //controllo dei checkbox: se nessuno è selezionato verrà automaticamente inserito il tick per le minuscole
            if (Maiuscole.Checked == false && Minuscole.Checked == false && Numeri.Checked == false && Speciali.Checked == false)
            {
                Minuscole.Checked = true;
            }

            //distribuzione della probabilità dei caratteri
            if (Numeri.Checked == true)
            {
                randMVal += numbProb;
                if (trackBar1.Value == 3)
                    randMVal += numbProb*2; //triplica la probabilta' di estrazione
                masNum = randMVal;
            }
            else
                masNum = -1;
         

            if (Minuscole.Checked == true)
            {
                randMVal += charProb;
                if (trackBar1.Value == 1)
                    randMVal += charProb*2;
                masMin = randMVal;
            }
            else
                masMin = -1;


            if (Maiuscole.Checked == true)
            {
                randMVal += charProb;
                if (trackBar1.Value == 2)
                    randMVal += charProb*2;
                masMai = randMVal;
            }
            else
                masMai = -1;


            if (Speciali.Checked == true)
            {
                randMVal += charProb;
                if (trackBar1.Value == 4)
                    randMVal += charProb*2;
                masSpe = randMVal;
            }
            else
                masSpe = -1;


            for (int n = 0; n < trackBar2.Value; n++)
            {
                randChar = ran.Next(0, randMVal + 1);

                if (randChar > -1 && randChar <= masNum)
                {
                    password += lettNum[ran.Next(0, 9)].ToString();
                    isNum = true;
                }


                else if (randChar > masNum && randChar <= masMin)
                {
                    password += lettMin[ran.Next(0, 25)].ToString();
                    isMin = true;
                }


                else if (randChar > masMin && randChar <= masMai)
                {
                    password += lettMai[ran.Next(0, 25)].ToString();
                    isMai = true;
                }


                else if (randChar > masMai && randChar <= masSpe)
                {
                    password += lettSpe[ran.Next(0, 30)].ToString();
                    isSpe = true;
                }
                //+= append  :  inserisci una lettera in cella casuale dell'array scelto alla coda della stringa password
            }
            this.Txt_InOut.Text = password;   //assegno alla proprietà Text della casella "generato" la stringa della password

            if (isNum == true)
                totLettere += 10;
            if (isMin == true)
                totLettere += 26;
            if (isMai == true)
                totLettere += 26;
            if (isSpe == true)
                totLettere += 31;

            for (int i = 0; i < trackBar2.Value; i++)
            {
                tempo *= totLettere;
            }

            //MessageBox.Show(tempo.ToString());
            tempo /= secondo;

            if (tempo <= 1) //entro il secondo
                checktext.Text = "Sicurezza:  Molto scarsa";
            else if (tempo <= 30)   //entro 30 secondi
                checktext.Text = "Sicurezza:  Scarsa";
            else if (tempo <= 1800) //entro mezz'ora
                checktext.Text = "Sicurezza:  Insufficiente";
            else if (tempo <= 86400)//entro un giorno
                checktext.Text = "Sicurezza:  Sufficiente";
            else if (tempo <= 86400*30)//entro un mese
                checktext.Text = "Sicurezza:  Discreta";
            else if (tempo <= 86400*180)//entro sei mesi
                checktext.Text = "Sicurezza:  Buona";
            else if (tempo <= 86400*1461)//entro quattro anni
                checktext.Text = "Sicurezza:  Ottima";
            else if (tempo <= 86400*365*50)//entro mezzo secolo
                checktext.Text = "Sicurezza:  Eccellente";
            else
                checktext.Text = "Sicurezza:  ti sfido a ricordarla";
        }


        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            ncarat.Text = trackBar2.Value.ToString();
        }


        private void genCas_Click(object sender, EventArgs e)
        {
            Random ran = new Random();  //istanza randomizzatore

            //reset checkbox
            Minuscole.Checked = false;
            Maiuscole.Checked = false;
            Numeri.Checked = false;
            Speciali.Checked = false;

            //randomizzazione checkbox
            if (ran.Next(0, 2) == 1)
                Minuscole.Checked = true;
            if (ran.Next(0, 2) == 1)
                Maiuscole.Checked = true;
            if (ran.Next(0, 2) == 1)
                Numeri.Checked = true;
            if (ran.Next(0, 2) == 1)
                Speciali.Checked = true;


            trackBar2.Value = ran.Next(8, 19);  //rand. numero caratteri da 8 a 18
            trackBar1.Value = ran.Next(0, 5);   //rand. priorita'
            ncarat.Text = trackBar2.Value.ToString();

            genera_Click(sender, e);
        }

        private void versioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versione: 1.2\n\nCreato da: GioCupp");
        }

        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/GioCupp");
        }

        private void progettoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/GioCupp/GenPass-v1.2");
        }

    }
}
