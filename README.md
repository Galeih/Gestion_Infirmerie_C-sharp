# Gestion Infirmerie 🩹

Application de gestion d’infirmerie scolaire développée en **C# / .NET Framework 4.7.2**.  
Elle permet à l’équipe de vie scolaire et à l’infirmier·ère de centraliser les informations sur les élèves, leurs visites, les médicaments et les statistiques de santé tout en conservant un historique sécurisé.

> Ce dépôt contient l’ensemble de la solution Visual Studio (architecture N-tiers) ainsi que la documentation fonctionnelle et technique.

---

## Sommaire

- [Fonctionnalités](#fonctionnalités)
- [Architecture](#architecture)
- [Pré-requis](#pré-requis)
- [Installation](#installation)
- [Configuration de la base de données](#configuration-de-la-base-de-données)
- [Lancement de l’application](#lancement-de-lapplication)
- [Structure du dépôt](#structure-du-dépôt)
- [Documentation](#documentation)

---

## Fonctionnalités

- **Authentification** : écran de connexion sécurisé avec contrôle des identifiants stockés en base.  
- **Gestion des élèves** : CRUD complet sur les fiches élèves — identité, contacts, tiers-temps, etc.  
- **Suivi des visites** : enregistrement des passages à l’infirmerie (date, heure, motif, actions) et historique.  
- **Médicaments** : catalogue, suivi du stock et traçabilité des distributions.  
- **Statistiques** : tableaux de bord de base (nombre de visites par période, motifs les plus fréquents…).  
- **Multi-utilisateurs** : rôles distincts (infirmier·ère, CPE…) extensibles dans la BDD.  

---

## Architecture

```text
┌──────────────────┐
│     InfirmerieGUI│  ← Interface graphique Windows Forms (.NET FW 4.7.2)
└──────┬───────────┘
       │ appelle
┌──────▼───────────┐
│   InfirmerieBLL  │  ← Business Logic Layer : règles métiers, validations
└──────┬───────────┘
       │ dialogue avec
┌──────▼───────────┐
│   InfirmerieDAL  │  ← Data Access Layer : requêtes SQL, DAO
└──────┬───────────┘
       │ manipule
┌──────▼───────────┐
│   InfirmerieBO   │  ← Business Objects : Eleve, Visite, Medicament…
└──────────────────┘
```
L’architecture N-tiers facilite la maintenance : chaque couche est indépendante et testable.

## Pré-requis

- Windows 10 / 11

- Visual Studio 2022 ou plus récent (télécharger)

- .NET Framework 4.7.2 (documentation)

- SQL Server Express ou supérieur (télécharger)

- Git pour le clonage (télécharger)

- NuGet (restauration automatique dans Visual Studio)

##Installation

- Cloner le dépôt :

```bash
git clone https://github.com/<votre-organisation>/Gestion_Infirmerie_C-sharp.git
cd Gestion_Infirmerie_C-sharp
```

- Ouvrir la solution GestionInfirmerie.sln dans Visual Studio.

- Restaurer les packages NuGet (si ce n’est pas automatique).

- Configurer la chaîne de connexion.

## Configuration de la base de données

- Créer une base SQL Server (exemple : GestionInfirmerieDB).

- Exécuter le script SQL présent dans Documentation/Dossier de spécification technique/Script_SQL_bdd.sql.

- Modifier la clé ConnectionStringSetting du fichier InfirmerieGUI/App.config :

```xml
<connectionStrings>
  <add name="ConnectionStringSetting"
       connectionString="Data Source=localhost;Initial Catalog=GestionInfirmerieDB;Integrated Security=True"/>
</connectionStrings>
```

## Lancement de l’application

- Définir InfirmerieGUI comme projet de démarrage.

- F5 ou Démarrer dans Visual Studio.

- Se connecter avec un utilisateur existant dans la table Utilisateur.

## Structure du dépôt

```text
├── Application C#/
│   ├── GestionInfirmerie/     ← Solution racine
│   ├── InfirmerieGUI/         ← Présentation (WinForms)
│   ├── InfirmerieBLL/         ← Logique métier
│   ├── InfirmerieDAL/         ← Accès données
│   └── InfirmerieBO/          ← Objets métiers
└── Documentation/
    ├── Cahier des charges/
    └── Dossier de spécification technique/
```

## Documentation
La documentation fonctionnelle (cahier des charges, cas d’utilisation) et la documentation technique (MCD, dictionnaire de données, cahier de recettes) se trouvent dans le dossier Documentation/.
