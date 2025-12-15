# BLOC2.AC03.JenkinsCats

## Classes de equivalència
- Classe 1: El resultat és zero.
- Classe 2: El resultat és positiu.
- Classe 3: El resultat és negatiu.

## Valors limit
Els valors limit per les variables a, b i c son: (-∞, 0 ,∞)

## Casos de prova

| Cas | Nom del cas de prova | Descripció | Entrada | Accions | Resultat esperat | Resultat obtingut |
|-----|----------------------|------------|---------|---------|------------------|-------------------|
| CP1 | Resultat 0 | Comprova que el resultat serà 0 fent que a sigui menor o igual que 0. | a=0 | Verificar que a sigui més petita o igual que 0, assignar el valor 0 al resultat. Mostrar un missatge de que el resultat es 0. | resultat=0, missatge = "El resultat és 0." | |
| CP2 | Resultat a | Comprova que el resultat serà a fent que a sigui major que 0 i b igual a 0. | a=1, b=0 | Verificar que a sigui més gran que 0, que b sigui més petita o igual  a 0 i assignar el valor de a al resultat. Mostrar un missatge de que el resultat es positiu. | resultat=1, missatge = "El resultat és positiu."  | |
| CP3 | Resultat a+b | Comprova que el resultat serà a+b fent que a i b siguin majors que 0 i c igual a 0. | a=1, b=1, c=0 | Verificar que a sigui més gran que 0, que b sigui més gran que 0, que c sigui més petita o igual que 0 i assignar el valor de a+b al resultat. Mostrar un missatge de que el resultat es positiu. | resultat=2, missatge = "El resultat és positiu." | |
| CP4 | Resultat a+b+c | Comprova que el resultat serà a+b+c fent que a, b i c siguin majors que 0. | a=1, b=1, c=1 | Verificar que a sigui més gran que 0, que b sigui més gran que 0, que c sigui més gran que 0 i assignar el valor de a+b+c al resultat. Mostrar un missatge de que el resultat es positiu. | resultat=3, missatge = "El resultat és positiu." | |
