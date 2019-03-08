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


        //RANDOM QUESTIONS

        //Variable random
        public Random question = new Random();
        //Création d'une liste des clés du dictionnaire des questions car dictionnaire ne contient pas d'index
        public List<string> questionList = new List<string>();

        //random pour les questions et les réponses, needed en global plutôt que local dans les méthodes
        public string questionActuelle;
        public string randomKey;



        //Point de chaque perrsonnage (sert a döfinir quand un perrsonnage ä "gaganer")
        int PointKaaris = 0;
        int PointSnoopDogg = 0;
        int PointClaudeFrançois = 0;
        int PointEmmaWatson = 0;
        int PointPassePartout = 0;
        int PointDenisBrogniart = 0;
        int PointMaitreGims = 0;
        int PointEmiliaClark = 12;
        int PointMadsMikkelsen = 0;
        int PointScarlettJohansson = 11;

        
        


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
            //Position boutons
            //Btn quitter (en bas a gauche)
            btnQuitter.Top = 259;
            btnQuitter.Left = 35;

            //Btn lancer partie (en bas a droite)
            btnLancerPartie.Top = 259;
            btnLancerPartie.Left = 35;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnOui_Click(object sender, EventArgs e)
        {
            
            if (Kaaris[questionActuelle] == true)
            {
                PointKaaris++;
            }
            if (SnoopDogg[questionActuelle] == true)
            {
                PointSnoopDogg++;
            }
            if (ClaudeFrançois[questionActuelle] == true)
            {
                PointClaudeFrançois++;
            }
            if (EmmaWatson[questionActuelle] == true)
            {
                PointEmmaWatson++;
            }
            if (PassePartout[questionActuelle] == true)
            {
                PointPassePartout++;
            }
            if (DenisBrogniart[questionActuelle] == true)
            {
                PointDenisBrogniart++;
            }
            if (MaitreGims[questionActuelle] == true)
            {
                PointMaitreGims++;
            }
            if (EmiliaClark[questionActuelle] == true)
            {
                PointEmiliaClark++;
            }
            if (MadsMikkelsen[questionActuelle] == true)
            {
                PointMadsMikkelsen++;
            }
            if (ScarlettJohansson[questionActuelle] == true)
            {
                PointScarlettJohansson++;
            }
            lblQuestion.Text += PointClaudeFrançois;
            NextQuestion();

        }

        private void btnNon_Click(object sender, EventArgs e)
        {
            if (Kaaris[questionActuelle] == false)
            {
                PointKaaris++;
            }
            if (SnoopDogg[questionActuelle] == false)
            {
                PointSnoopDogg++;
            }
            if (ClaudeFrançois[questionActuelle] == false)
            {
                PointClaudeFrançois++;
            }
            if (EmmaWatson[questionActuelle] == false)
            {
                PointEmmaWatson++;
            }
            if (PassePartout[questionActuelle] == false)
            {
                PointPassePartout++;
            }
            if (DenisBrogniart[questionActuelle] == false)
            {
                PointDenisBrogniart++;
            }
            if (MaitreGims[questionActuelle] == false)
            {
                PointMaitreGims++;
            }
            if (EmiliaClark[questionActuelle] == false)
            {
                PointEmiliaClark++;
            }
            if (MadsMikkelsen[questionActuelle] == false)
            {
                PointMadsMikkelsen++;
            }
            if (ScarlettJohansson[questionActuelle] == false)
            {
                PointScarlettJohansson++;
            }
            lblQuestion.Text += PointClaudeFrançois;
<<<<<<< HEAD
            NextQuestion();
=======
            
>>>>>>> 3fe001712effc5a01341de57f002fdcaf024a170

        }

<<<<<<< HEAD
        /// <summary>
        /// Les boutons deviennet invisibles / visibles
        /// Les pints de chaque personne sont mis a 0
        /// La liste de question est initialisé
        /// </summary>
=======
        //Creation d'une nouvelle liste de question
>>>>>>> 69cb03e97a11997f97a13578c469de03fd66bbb3
        public void NewGame()
        {
            btnLancerPartie.Visible = false;
            btnQuitter.Visible = false;

            btnOui.Visible = true;
            btnNon.Visible = true;
            lblQuestion.Visible = true;

            questionList = new List<string>(QuestionsPrincipales.Keys);

            PointKaaris = 0;
            PointSnoopDogg = 0;
            PointClaudeFrançois = 0;
            PointEmmaWatson = 0;
            PointPassePartout = 0;
            PointDenisBrogniart = 0;
            PointMaitreGims = 0;
            PointEmiliaClark = 0;
            PointMadsMikkelsen = 0;
            PointScarlettJohansson = 0;
        }
<<<<<<< HEAD
=======
<<<<<<< HEAD
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
=======
        //Traitement de la liste des questions + Affichage de la question
>>>>>>> acbd561eee749c67427f3f0c9a2ab200d328988b
>>>>>>> 3fe001712effc5a01341de57f002fdcaf024a170
        public void NextQuestion()
        {
            //La question    = index [random] de questionList
            questionActuelle = questionList[question.Next(questionList.Count)]; //Par défaut le random va de 0 à count
            //print dans le label la question
            lblQuestion.Text = QuestionsPrincipales[questionActuelle];
            questionList.Remove(questionActuelle);

        }

<<<<<<< HEAD
        public int KiCéKiGanieuh()
=======
        public void KiCéKiGanieuh()
<<<<<<< HEAD
        {
            IDictionary<string, int> PointsPersonnages = new Dictionary<string, int>()
        {
            {"Kaaris", PointKaaris},
            {"SnoopDogg", PointSnoopDogg},
            {"ClaudeFrancois", PointClaudeFrançois},
            {"EmmaWatson", PointEmmaWatson},
            {"PassePartout", PointPassePartout},
            {"DesinBrognart", PointDenisBrogniart},
            {"MaitreGims", PointMaitreGims},
            {"EmiliaClark", PointEmiliaClark},
            {"MadsMikkelsen", PointMadsMikkelsen},
            {"ScarletteJohanson", PointScarlettJohansson}
        };

            int dozo = PointsPersonnages.Values.Max();
            
            foreach (string mek in PointsPersonnages.Keys)
            {

            }
=======

>>>>>>> acbd561eee749c67427f3f0c9a2ab200d328988b
        {
            List<int> PointsPersonnages = new List<int>();
        PointsPersonnages.Add(PointKaaris);
            PointsPersonnages.Add(PointSnoopDogg);
            PointsPersonnages.Add(PointClaudeFrançois);
            PointsPersonnages.Add(PointEmmaWatson);
            PointsPersonnages.Add(PointPassePartout);
            PointsPersonnages.Add(PointDenisBrogniart);
            PointsPersonnages.Add(PointMaitreGims);
            PointsPersonnages.Add(PointEmiliaClark);
            PointsPersonnages.Add(PointMadsMikkelsen);
            PointsPersonnages.Add(PointScarlettJohansson);

<<<<<<< HEAD
            int max = PointsPersonnages.Max();

            return max;
=======
            

        }

        private void btnLancerPartie_Click(object sender, EventArgs e)
        {
            // Lancer la partie
            NewGame();
            NextQuestion();
        
>>>>>>> acbd561eee749c67427f3f0c9a2ab200d328988b
>>>>>>> 3fe001712effc5a01341de57f002fdcaf024a170
        }

        public void 
    }
}
