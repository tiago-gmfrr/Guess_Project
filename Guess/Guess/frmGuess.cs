﻿using System;
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
        };
        IDictionary<string, bool> EmmaWatson = new Dictionary<string, bool>()
        {
            {"Masculin", false},
            {"PlusDe35Ans", false},
            {"CheveuxLongs", true},
            {"EnVie", true},
            {"NoirDePeau", false},
            {"Barbe", false},
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
            {"Tanos", true}
        };



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

        private string NewGame()
        {
            //RANDOM QUESTIONS

            //Variable random
            Random question = new Random();
            //Création d'une liste des clés du dictionnaire des questions car dictionnaire ne contient pas d'index
            List<string> questionList = new List<string>(QuestionsPrincipales.Keys);
            //La question    = index x de questionList;
            string randomKey = questionList[question.Next(questionList.Count)];
            //Retourne la question choisi aux hasards
            return QuestionsPrincipales[randomKey];






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
