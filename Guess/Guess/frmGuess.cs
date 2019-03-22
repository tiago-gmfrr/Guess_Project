using System;
using System.Collections.Generic;
using System.Linq;
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

        //num de la question
        int countRound = 0;

        //en jeu ou sur le menu
        bool enJeu = false;

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
            //Position boutons
            //Btn quitter (en bas a gauche) 38; 270
            btnQuitter.Top = 270;
            btnQuitter.Left = 38;

            //Btn lancer partie (en bas a droite) 243; 270
            btnLancerPartie.Top = 270;
            btnLancerPartie.Left = 230;

            //btn Non (en bas a gauche)
            btnNon.Top = 270;
            btnNon.Left = 38;

            //btn Oui (en bas a droite)
            btnOui.Top = 270;
            btnOui.Left = 230;

            //lbl Question (centre)
            lblQuestion.Top = 194;
            lblQuestion.Left = 73;
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
            NextQuestion();

        }
        /// <summary>
        /// Les boutons deviennet invisibles / visibles
        /// Les pints de chaque personne sont mis a 0
        /// La liste de question est initialisé
        /// </summary>
        //Creation d'une nouvelle liste de question
        public void NewGame()
        {
            btnLancerPartie.Visible = false;
            btnQuitter.Visible = false;

            btnOui.Visible = true;
            btnNon.Visible = true;
            lblQuestion.Visible = true;

            countRound = 0; //numéro du tour

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

        public string KiCéKiGanieuh()
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
            
            string personnageGagnant = string.Empty;


            foreach (KeyValuePair<string, int> personnage in PointsPersonnages)
            {
                if (personnage.Value == Convert.ToInt32(PointsPersonnages.Values.Max()))
                {
                    if (personnageGagnant == string.Empty)
                    {

                    }
                    personnageGagnant = personnage.Key;
                }
            }
            return personnageGagnant;
        }

        //Traitement de la liste des questions + Affichage de la question
        public void NextQuestion()
        {
            //La question    = index [random] de questionList

            int questionRestante = questionList.Count(); //Compte le nombre de questions restantes
            string phraseAffichee; //Phrase qui sera affichée à la fin
            countRound++;

            //Vérifie s'il reste des questions
            if (questionRestante > 0)
            {

                questionActuelle = questionList[question.Next(questionList.Count)]; //Génère question en fonction d'un random index
                phraseAffichee = countRound + ". " + QuestionsPrincipales[questionActuelle];
                questionList.Remove(questionActuelle);  //Retire le critère de la liste des questions
            }
            else
            {
                //Affichage des personnages
                phraseAffichee = "Vous avez terminé les questions."
                    + Environment.NewLine
                    + "Il s'agit de "
                    + KiCéKiGanieuh();

                //Modification des boutons en fin de partie
                buttonVisibilite();
                btnLancerPartie.Text = "Recommencer";

                enJeu = false;

                //Assure la visibilité du label
                lblQuestion.Visible = true;
            }

            //print dans le label la question
            lblQuestion.Text = phraseAffichee;

            /*
             * lbl question restante . text = "Question restante : "+questionRestante;
             */
        }

        private void btnLancerPartie_Click(object sender, EventArgs e)
        {
            // Lancer la partie
            enJeu = true;
            NewGame();
            NextQuestion();
        }

        private void buttonVisibilite()
        {
            btnLancerPartie.Visible = !btnLancerPartie.Visible;
            btnQuitter.Visible = !btnQuitter.Visible;

            btnOui.Visible = !btnOui.Visible;
            btnNon.Visible = !btnNon.Visible;
            lblQuestion.Visible = !lblQuestion.Visible;
        }
        

        private void mtsMenuPrincipal_Click(object sender, EventArgs e)
        {
            if (enJeu)
            {
                buttonVisibilite();
                enJeu = false;
            }
            
        }

        private void mtsQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Si l'utilisateur essaie de fermer le programme, une MessageBox aparait pour demander la confirmation
        /// </summary>
        private void frmGuess_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Voulez vous Quitter?", "Fermer Application", MessageBoxButtons.YesNo  ) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void àproposdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abxAPropos aPropos = new abxAPropos();
            aPropos.ShowDialog();
        }

        private void listeDesPersonnagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListePerso per = new frmListePerso();
            per.Show();
        }

        private void frmGuess_Load(object sender, EventArgs e)
        {

        }
    }
}
