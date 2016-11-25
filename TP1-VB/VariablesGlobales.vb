﻿Public Class VariablesGlobales
  Public Shared ADMIN_CONNECTION As Boolean = False
  Public Shared ReadOnly ADMIN_UTILISATEUR As String = "admin"
  Public Shared ReadOnly ADMIN_MDP As String = "4242"

  Public Shared ReadOnly TPS_VALEUR As Double = 0.05
  Public Shared ReadOnly TVQ_VALEUR As Double = 0.09975

  Public Shared ReadOnly FACT_NOM As String = "COOP"
  Public Shared ReadOnly FACT_ADD As String = "175, rue De La Vérendrye"
  Public Shared ReadOnly FACT_VILLE As String = "Sept-Îles"
  Public Shared ReadOnly FACT_PROV As String = "QC"
  Public Shared ReadOnly FACT_CP As String = "G4R 5B7"
  Public Shared ReadOnly FACT_TEL As String = "418 962-9848"
  Public Shared ReadOnly FACT_FAX As String = "418 962-2458"
  Public Shared ReadOnly FACT_COURRIEL As String = "communications@cegepsi.ca"

  Public Shared ReadOnly CAT_NOM() As String = {
    "Livres",
    "Papetrie",
    "Divers",
    "Fournitures de bureau inutilisée",
    "Alimentation",
    "Vêtement",
    "Calculatrice",
    "Informatique",
    "Sans catégorie"
  }
  Public Shared ReadOnly DEP_NOM() As String = {
    "0",
    "1",
    "3",
    "4",
    "5",
    "6",
    "7",
    "8",
    "12",
    "14",
    "18",
    "19",
    "21",
    "22",
    "23",
    "25",
    "30",
    "32"
  }
  Public Shared ReadOnly FOURN_NOM() As String = {
    "UQAC",
    "Les éditions RDL",
    "Septembre editeur",
    "",
    "L'artichaut",
    "Chenelière",
    "OIIQ",
    "Cheneliere",
    "Cemeq",
    "Erpi",
    "Teluq",
    "Lexis Nexis",
    "Mac Graw Hill",
    "ADP",
    "Socadis",
    "HMH",
    "Dimedia",
    "CEC",
    "Prologue",
    "Modulo",
    "Lirairie Las Americas",
    "Logitell",
    "Somabec",
    "Coop de ste-foy",
    "Prodafor",
    "Éditions RG",
    "Press internationnal",
    "Reynald Goulet",
    "Publication du QC",
    "NC Cégep",
    "Cancel",
    "Acme",
    "Westcott",
    "Hilroy",
    "Acco",
    "Tops",
    "Staedtler",
    "Sanford",
    "3M",
    "Novexco",
    "Sargent-Welch",
    "Géo",
    "Pentel",
    "Pilot",
    "VLB",
    "Oxfort",
    "Dist, Mélinda",
    "Winnable",
    "Avery",
    "Merangue",
    "Blueline",
    "Gemex",
    "Pas à pas",
    "Wilson Jones",
    "Oxford",
    "Lepage",
    "Style et papier",
    "Elmer's",
    "Acme (novexco)",
    "Filexec",
    "Acme ",
    "Coop de B-C",
    "Rolland",
    "Identification Sport",
    "IBM",
    "Louis Hebert",
    "Louis Hébert",
    "Sharp",
    "Sharp ",
    "GB micro",
    "Fédération",
    "Dist.Mélinda",
    "Dollorama",
    "Esselte",
    "Ganz",
    "Presto",
    "Ketto",
    "Shag Wear",
    "Master Lock",
    "EB",
    "Thermor",
    "Holiday",
    "Domtar",
    "Marley",
    "Holliday",
    "G1-Sac",
    "Mondoux",
    "Prestige",
    "Agence 2L",
    "Poste canada",
    "Fortsum",
    "Jlinc",
    "Denbro",
    "Bureau plus",
    "Bureau en Gros",
    "Login Canada"
  }
End Class
