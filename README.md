# Comuni italiani e stradario - Control Library DotNet
## Control Library Suggest Free DotNet
Comuni italiani e stradario. Soluzione C# per l'utilizzo del della libreria di controlli autocomplete del servizio SUGGEST Free.

### Ambiente di sviluppo
  - C#
  - Framework 4.6.1
  - Visual Studio Professional 2017 
  
### Librerie NuGet
  - Modernhttpclient 2.4.2
  - Newtonsoft.Json 11.0.2

### Condizioni
Per l'utilizzo registrarsi sul sito http://streetmaster.it e richiedere la chiave per il servizio SUGGEST.
Il servizio gratuito gestisce il livello comune e permette di effettuare in maniera gratuita 140.000 chiamate mensili. 
Per volumi di utilizzo maggiori o per estendere il servizio consultare nel sito i piani di utilizzo.
Se non viene utilizzata una chiave valida il servizio restituisce nel menu a tendina un avviso.

Il servizio ha una copertura a livello di strada su tutto il territorio nazionale ma la modalità Free permette di accedere al solo livello provincia\comune\frazione.
La base dati di riferimento è costantemente aggiornata con le variazioni amministrative e postali ufficiali.

### User control
  - SuggestTown : controllo textbox con funzione di autocompletamento del comune

### Ouput
L'autocompletamento del comune si attiva in automatico appena l'utente comincia a scrivere nel textbox

Output di base:
  - comune\cap\provincia\frazione verificato e corretto

### Aggiornamenti base dati comunale
  - 01/01/2016 Istituzione
  - 05/12/2016 Inserimento nuovi comuni di Alpago e Val di Zoldo
  - 05/12/2016 Soppressione comuni di Zoldo Alto,Forno di Zoldo,Prestine, Ivano-Francena,Farra d'Alpago,Pieve d'Alpago,Puos d'Alpago
  - 08/05/2017 Inserimento nuovi comuni di Abetone Cutigliano,San Marcello Piteglio,Valfornace,Colli al Metauro,Terre Roveresche,Alta Valle Intelvi,Terre del Reno
  - 08/05/2017 Soppressione comuni di Selve Marcone,Cavallasca,Acquacanina,Abetone,Cutigliano,San Marcello Pistoiese,Piteglio,San Giovanni D'Asso,Fiordimonte,Pievebovigliana,Piagge,Barchi,Orciano Di Pesaro,San Giorgio Di Pesaro,Montemaggiore Al Metauro,Saltara,Serrungarina,Mirabello,Sant'Agostino,Lanzo D'Intelvi,Pellio Intelvi,Ramponio Verna
  - 06/12/2017 Adeguamento struttura amministrativa della Sardegna. Soppressione delle provincie di Medio Campidano,Carbonia-Iglesias, Olbia-Tempio, Ogliastra e creazione della provincia Sud Sardegna
      
### Support
Per ogni domanda o chiarimento manda una mail a supporto@streetmaster.it

