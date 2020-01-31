# Nuvyta.Infernal

.NET Core 3.0 application


## Comandi GIT

Clonare un repository remoto (l'URL è su Azure DevOps 
sotto => Repositories => branch develop => Clone')
`git clone https://maurobussini.visualstudio.com/DefaultCollection/Nuvyta.Infernal/_git/nuvyta-infernal-api`
`cd nuvyta-infernal-api`

Sincronizzare i dati locali con il server remoto
`git fetch`
`git pull`

Spostarsi sul branch **develop**
`git checkout develop`

Sincronizzare ancora con il remoto
`git fetch`
`git pull`

Creare un nuovo branch per lavorare (es. branch userstory125)
`git checkout -b feature/userstory125`

Push del branch in remoto (meglio modificare qualche cosa prima, es. un commento)
`git add .`
`git commit -m "Added branch"`
`git push -u origin feature/userstory125`

Commit dei singoli file locali (fare fotografie in locale)
`git add .`
`git commit -m "Questo è il titolo della foto"`

Annullare tiutte le modifiche locali non inviate al server
`git reset --hard`
`git reset HEAD`