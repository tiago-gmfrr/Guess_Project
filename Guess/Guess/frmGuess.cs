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
        public string randomKey;
        //Point de chaque perrsonnage (sert a döfinir quand un perrsonnage ä "gaganer")
        int PointKaaris = 0;
        int PointSnoopDogg = 0;
        int PointClaudeFrançois = 0;
        int PointEmmaWatson = 0;
        int PointPassePartout = 0;
        int PointDenisBrogniart = 0;
        int PointMaitreGims = 0;
        int PointEmiliaClark = 0;
        int PointMadsMikkelsen = 0;
        int PointScarlettJohansson = 0;


        IDictionary<string, string> QuestionsPrincipales = new Dictionary<string, string>()
        {
            {"Masculin", "Votre personnage est-il de sexe masculin ?"},
            {"PlusDe35Ans", "Votre personnage a-t'il plus de 35 ans ?"},
            {"CheveuxLongs", "Votre personnage a-t'il les cheveux longs ?"},
            {"EnVie", "Votre personnage est-il encore en vie ?"},
            {"NoirDePeau", "Votre personnage est-il noir de peau ?"},
            {"Barbe", "Votre personnage a-t'il de la barbe ?"},
        };

        //Chaque dictionnaire correspond à  un personnage et à ses critères
        IDictionary<string, bool> Kaaris = new Dictionary<string, bool>()
        {
            {"Masculin", true},
            {"PlusDe35Ans", true},
            {"CheveuxLongs", false},
            {"EnVie", true},
            {"NoirDePeau", true},
            {"Barbe", true},
            //Question spécifique (unique pour chaque personnages)
            {"Bagarre", true}
        };
        IDictionary<string, bool> SnoopDogg = new Dictionary<string, bool>()
        {
            {"Masculin", true},
            {"PlusDe35Ans", true},
            {"CheveuxLongs", true},
            {"EnVie", true},
            {"NoirDePeau", true},
            {"Barbe", true},
            //Question spécifique (unique pour chaque personnages)
            {"Fumeur", true}
        };        
        IDictionary<string, bool> ClaudeFrançois = new Dictionary<string, bool>()
        {
            {"Masculin", true},
            {"PlusDe35Ans", true},
            {"CheveuxLongs", true},
            {"EnVie", false},
            {"NoirDePeau", false},
            {"Barbe", false},
            //Question spécifique (unique pour chaque personnages)
            {"ChanteurFrancais", true}
        };
        IDictionary<string, bool> EmmaWatson = new Dictionary<string, bool>()
        {
            {"Masculin", false},
            {"PlusDe35Ans", false},
            {"CheveuxLongs", true},
            {"EnVie", true},
            {"NoirDePeau", false},
            {"Barbe", false},
            //Question spécifique (unique pour chaque personnages)
            {"Magie", true}
        };        
        IDictionary<string, bool> PassePartout = new Dictionary<string, bool>()
        {
            {"Masculin", true},
            {"PlusDe35Ans", true},
            {"CheveuxLongs", false},
            {"EnVie", true},
            {"NoirDePeau", false},
            {"Barbe", false},
            //Question spécifique (unique pour chaque personnages)
            {"CompteLesCles", true}
        };
        IDictionary<string, bool> DenisBrogniart = new Dictionary<string, bool>()
        {
            {"Masculin", true},
            {"PlusDe35Ans", true},
            {"CheveuxLongs", false},
            {"EnVie", true},
            {"NoirDePeau", false},
            {"Barbe", true},
            //Question spécifique (unique pour chaque personnages)
            {"ConnaisMoundir", true}
        };
        IDictionary<string, bool> MaitreGims = new Dictionary<string, bool>()
        {
            {"Masculin", true},
            {"PlusDe35Ans", false},
            {"CheveuxLongs", false},
            {"EnVie", true},
            {"NoirDePeau", true},
            {"Barbe", true},
            //Question spécifique (unique pour chaque personnages)
            {"SexionDassaut", true}
        };
        IDictionary<string, bool> EmiliaClark = new Dictionary<string, bool>()
        {
            {"Masculin", false},
            {"PlusDe35Ans", false},
            {"CheveuxLongs", true},
            {"EnVie", true},
            {"NoirDePeau", false},
            {"Barbe", false},
            //Question spécifique (unique pour chaque personnages)
            {"GameOfThrones", true}
        };
        IDictionary<string, bool> MadsMikkelsen = new Dictionary<string, bool>()
        {
            {"Masculin", true},
            {"PlusDe35Ans", true},
            {"CheveuxLongs", false},
            {"EnVie", true},
            {"NoirDePeau", false},
            {"Barbe", true},
            //Question spécifique (unique pour chaque personnages)
            {"Witcher", true}
        };
        IDictionary<string, bool> ScarlettJohansson = new Dictionary<string, bool>()
        {
            {"Masculin", false},
            {"PlusDe35Ans", false},
            {"CheveuxLongs", true},
            {"EnVie", true},
            {"NoirDePeau", false},
            {"Barbe", false},
            //Question spécifique (unique pour chaque personnages)
            {"Tanos", true}
        };



        public frmGuess()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            NewGame();
        }

        private void btnOui_Click(object sender, EventArgs e)
        {
            
            if (Kaaris[randomKey] == true)
            {
                PointKaaris++;
            }
            if (SnoopDogg[randomKey] == true)
            {
                PointSnoopDogg++;
            }
            if (ClaudeFrançois[randomKey] == true)
            {
                PointClaudeFrançois++;
            }
            if (EmmaWatson[randomKey] == true)
            {
                PointEmmaWatson++;
            }
            if (PassePartout[randomKey] == true)
            {
                PointPassePartout++;
            }
            if (DenisBrogniart[randomKey] == true)
            {
                PointDenisBrogniart++;
            }
            if (MaitreGims[randomKey] == true)
            {
                PointMaitreGims++;
            }
            if (EmiliaClark[randomKey] == true)
            {
                PointEmiliaClark++;
            }
            if (MadsMikkelsen[randomKey] == true)
            {
                PointMadsMikkelsen++;
            }
            if (ScarlettJohansson[randomKey] == true)
            {
                PointScarlettJohansson++;
            }
            lblQuestion.Text += PointClaudeFrançois;
            NewGame();

        }

        private void btnNon_Click(object sender, EventArgs e)
        {
            if (Kaaris[randomKey] == false)
            {
                PointKaaris++;
            }
            if (SnoopDogg[randomKey] == false)
            {
                PointSnoopDogg++;
            }
            if (ClaudeFrançois[randomKey] == false)
            {
                PointClaudeFrançois++;
            }
            if (EmmaWatson[randomKey] == false)
            {
                PointEmmaWatson++;
            }
            if (PassePartout[randomKey] == false)
            {
                PointPassePartout++;
            }
            if (DenisBrogniart[randomKey] == false)
            {
                PointDenisBrogniart++;
            }
            if (MaitreGims[randomKey] == false)
            {
                PointMaitreGims++;
            }
            if (EmiliaClark[randomKey] == false)
            {
                PointEmiliaClark++;
            }
            if (MadsMikkelsen[randomKey] == false)
            {
                PointMadsMikkelsen++;
            }
            if (ScarlettJohansson[randomKey] == false)
            {
                PointScarlettJohansson++;
            }
            lblQuestion.Text += PointClaudeFrançois;
            NewGame();

        }


        public void NewGame()
        {
            //RANDOM QUESTIONS

            //Variable random
            Random question = new Random();
            //Création d'une liste des clés du dictionnaire des questions car dictionnaire ne contient pas d'index
            List<string> questionList = new List<string>(QuestionsPrincipales.Keys);

            //Traitement + affichage de la question
            //La question    = index x de questionList;
            randomKey = questionList[question.Next(questionList.Count)];
            //print dans le label la question
            lblQuestion.Text = QuestionsPrincipales[randomKey];






            //string[] lignes;
            //var resources = Properties.Resources.Personnages__Criteres;

            //lignes = resources.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            //foreach (string line in lignes)
            //{
            //    string[] tmp = line.Split('/');
            //    string nom = tmp[0];

            //    foreach (string caracteristique in tmp)
            //    {

            //        switch (nom)
            //        {
            //            case "Kaaris":

            //               // Kararis.Add(swdshak,caracteristique);
            //                break;
            //        }

            //}
            //}
        }
    }
}
