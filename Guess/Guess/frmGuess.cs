using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess
{
    public partial class frmGuess : Form
    {
        bool reponse = false;
        IDictionary<string, string> Kaaris = new Dictionary<string, string>();
        IDictionary<string, string> SnoopDogg = new Dictionary<string, string>();        
        IDictionary<string, string> ClaudeFrançois = new Dictionary<string, string>();
        IDictionary<string, string> EmmaWatson = new Dictionary<string, string>();        
        IDictionary<string, string> PassePartout = new Dictionary<string, string>();
        IDictionary<string, string> DenisBrogniart = new Dictionary<string, string>();
        IDictionary<string, string> MaitreGims = new Dictionary<string, string>();
        IDictionary<string, string> EmiliaClark = new Dictionary<string, string>();
        IDictionary<string, string> MadsMikkelsen = new Dictionary<string, string>();
        IDictionary<string, string> ScarlettJohansson = new Dictionary<string, string>();
        public frmGuess()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOui_Click(object sender, EventArgs e)
        {
            reponse = true;
        }

        private void btnNon_Click(object sender, EventArgs e)
        {
            reponse = false;

            
        }

        private void NewGame()
        {
            string[] lignes;
            var resources = Properties.Resources.Personnages__Criteres;

            lignes = resources.Split(new[] { Environment.NewLine },
    StringSplitOptions.None);

            foreach (string line in lignes)
            {
                string[] tmp = line.Split('//');
                string nom = tmp[0];

                foreach (string caracteristique in tmp)
                {

                    switch (nom)
                    {
                        case "Kaaris":

                           // Kararis.Add(swdshak,caracteristique);
                            break;
                    }
                
            }
            }
        }
    }
}
