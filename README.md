# pixels bots
le projet complet


## récuperer pour la première fois le projet
```
git clone https://gitlab.com/le-group2/pixels bots.git

cd pixels bots

git pull origin main

```

## mettre à jour le projet local
```
cd chemin/vers/pixels bots

git add .
git commit -m "Sauvegarde locale avant pull"

git pull origin main

git status
```


## mettre à jour le projet distant (depôt)
```
cd chemin/vers/pixels bots

git add .
git commit -m "message de commit"

git push origin main
```

### si probleme avec push
```
git pull origin main --rebase
git push origin main
```



## Vérifier l’état du dépôt
```
git status
```