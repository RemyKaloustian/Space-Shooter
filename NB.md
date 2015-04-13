NB pour Unity:


Camera est un composant ajouté à la scène.
Laisser le joueur à la position initiale (0,0,0), déplacer la caméra.


Ajouter lumière : create - Directional Light.
On peut changer la rotation et l'intensité.

Background :create - Quad -  cliquer glisser image sur le quad - 
Pour caméra : vue du jeu, tester les différents axes (x,y) - mettre le background sous le joueur
Pour lumière  : shader -unlit - texture

Script : Ajouter les script sur les composants

Enlever noir sur une texture (par exemple bolt) : Shader - particles - additive

Faire des boundaries : create - cube- 	mettre IsTrigger pour intéragir avec des déclenchements - adapter la taille à l'écran/map

Angular Drag simule la résitance de l'air et freine la rotation jusqu'à stop.

Pour les explosions, on peut utiliser Destroy(object,time) afin de spécifier le temps entre l'instanciation et la destruction
