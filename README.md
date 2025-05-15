# 🍃 Animal Crossing AR – POC Unity avec Vuforia

Ce projet Unity propose une expérience en réalité augmentée autour du personnage [**Celeste**](https://sketchfab.com/3d-models/celeste-animal-crossing-new-horizons-2f328b60753b4b88b246fe18963d98e5)  d’Animal Crossing. L’utilisateur interagit avec le personnage via une image cible, des animations, des sons et des effets visuels.

## 🧠 Objectif du projet

Créer un POC d’une application interactive en réalité augmentée :
- Détection d’une image cible via **Vuforia**
- Interaction avec un **modèle 3D animé**
- Présentation d’informations et personnalisation

## 🕹️ Fonctionnalités principales

### ✅ Reconnaissance AR
- Utilisation de **Vuforia** pour reconnaître une **image cible** et faire apparaître le modèle 3D dans la scène.

### 🎨 Interactions
1. **Animations avec sons**  
   → Des boutons déclenchent des animations différentes du personnage, avec un **son associé** à chaque animation.
2. **Changement de couleur**  
   → Des boutons permet de **changer la couleur d’un accessoire** (le nœud du personnage).
3. **Affichage d’informations**  
   → Un bouton dédié affiche un **panneau d’information** sur le personnage.  

### 🔊 Intégration sonore
- Sons d’ambiance 
- Sons liés aux animations

### 📱 Navigation
- **Menu d’accueil** avec :
  - Bouton pour lancer la scène AR
  - Fond sonore
- **Scène AR** avec :
  - Bouton retour vers le menu principal

## 📦 Technologies utilisées

- Unity (URP)
- Vuforia Engine
- Mixamo (animations)
- C# (scripts)

## 🚀 Lancer le projet

1. Ouvrir le projet dans Unity 
2. Importer le SDK **Vuforia Engine**
3. Assurez-vous que la **licence Vuforia** est configurée
4. Build sur Android ou utiliser l’éditeur en mode Simulation
