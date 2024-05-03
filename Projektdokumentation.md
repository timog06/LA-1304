# Projekt-Dokumentation

KeiAhnig : Rebecca Willi, Timo Goedertier

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|01.03.2024| 0.0.1   | Plan erstellt und User-Storys geschrieben. |
|08.03.2024| 0.0.2   | Testfälle, Arbeitspakete und Realisation so weit möglich ausgefüllt, mit dem Realisieren begonnen.|
|15.03.2024| 0.0.3   | Realisieren |
|22.03.2024| 0.0.4   | Realisieren |
|05.04.2024| 0.0.5   | Fertig realisiert|
|26.04.2024| 0.0.6   | Kontrolle und Portfolio| 

## 1 Informieren

### 1.1 Ihr Projekt

Unser Projekt geht um das Backend um Blackjack auf einer Webseite zu spielen.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | Muss     |Funktional   | Als User möchte ich, dass mein Benutzerkonto gespeichert wird. |
| 2    | Muss     |Funktional   | Als User möchte ich, dass mein Passwort zum Benutzerkonto gespeichert wird.|
| 3    | Muss     |Funktional   | Als User möchte ich, dass mein Kontostand gespeichert wird.|
| 4    | Kann     |Funktional   | Als Programmierer möchte ich, dass die Benutzerdaten in einer SQL-Datenbank gesepeichert werden| 
| 5    | Muss     |Funktional   | Als User möchte ich meine Benutzerkontodaten aktualisieren können.| 
| 6    | Muss     |Qualität     | Als User möchte ich, mein Benutzerkonto löschen können.| 
| 7    | Muss     |Funktional   | Als User möchte ich, dass mein Kontostand aktualisiert wird.|
| 8    | Muss     |Funktional   | Als User möchte ich, eine neue Karte ziehen können.|
| 9    | Muss     |Funktional   | Als User möchte ich, keine neue Karte ziehen können.|
| 10   | Muss     |Funktional   | Als User möchte ich, meinen Einsatz verdoppeln können.|
| 11   | Muss     |Funktional   | Als User möchte ich, meine Karten aufteilen können.|



### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |neues Benutzerkonto wird erstellt|alle Felder ausfüllen und bestätigen|Benutzerkonto wird erfolgreich gespeichert|
| 2.1  |Benutzer erstellt ein Passwort für sein Konto|Passwort bestätigen|Passwort wird zum dazugehörigen Konto gespeichert|
| 3.1  |
| 4.1  |Benutzerkonto erstellt| Benutzerdaten eingeben| Benutzerdaten in SQL Datenbank gespeichert|
| 5.1  | Benutzerkonto ausgewählt|Neue Benutzerdaten eingeben & speichern|Benutzerdaten werden erfolgreich aktualisiert.|
| 6.1  | Benutzerkonto ausgewählt| Benutzer löschen| Benutzer erfolgreich gelöscht|
| 7.1  |Runde gestartet|Benutzer gewinnt die Runde| Kontostand wird aktualisiert|
| 8.1  | Runde gestartet| Benutzer fordert neue Karte an| Benutzer erhält neue Karte|
| 9.1 | Spiel gestartet| User möchte keine neue Karte| Runde geht zum nächsten Spieler|
| 10.1 | Benutzer ist am Zug| Benutzer möchte den Einsatz verdoppeln| gesezter Betrag wird verdoppelt|
| 11.1 | Benutzer hat Karten erhalten| Benutzer möchte sie aufteilen| Score wird aufgeteilt|

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.



## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |05.04.2024|Rebecca Willi|Benutzerkonen erstelllen| 60min|
| 2.A  |05.04.2024|Rebecca Willi| Passwort für die Benutzerkonten|45min|
| 3.A  |05.04.2024|Rebecca Willi|Kontostand speichern|45min| 
| 4.A  |05.04.2024|Timo Goedertier|SQL Datenbank|60min| 
| 5.A  |05.04.2024|Rebecca Willi|Benutzerkonto aktualisieren|45min|
| 6.A  |05.0.,2024|Rebecca Willi|Benutzerkonto löschen|45min| 
| 7.A  |05.04.2024|Timo Goedertier|Kontostand aktualisieren|45min|
| 8.A  |05.04.2024|Timo Goedertier|Neue Karte ziehen|75min| 
| 9.A  |05.04.2024|Timo Goedertier|Keine neue Karte| 45min| 
| 10.A |05.04.2024|Timo Goedertier|Einsatz verdoppeln|45min| 
| 11.A |05.04.2024|Timo Goedertier|Split Funktion| 60min| 


## 3 Entscheiden



## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |15.03.2024|Rebecca Willi|60min|90min|
| 2.A  |15.03.2024|Rebecca Willi|45min|60min|
| 3.A  |22.03.2024|Rebecca Willi|45min|60min|
| 4.A  |
| 5.A  |22.03.2024|Rebecca Willi|45min|60min|
| 6.A  |05.04.2024|Rebecca Willi|45min|60min|
| 7.A  |15.03.2024| Timo Goedertier|45min|45min|
| 8.A  |15.03.2024| Timo Goedertier|75min|90min|
| 9.A  |22.03.2024|Timo Goedertier| 45min|45min|
| 10.A |22.03.2024|Timo Goedertier|45min|60min|
| 11.A |05.04.2024|Timo Goedertier|45min|60min|


✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |26.04.2024|OK|Rebecca Willi|
| 2.1  |26.04.2024|OK|Rebecca Willi|
| 3.1  |26.04.2024|OK|Rebecca Willi|
| 5.1  |26.04.2024|OK|Rebecca Willi|
| 6.1  |26.04.2024|OK|Rebecca Willi|
| 7.1  |26.04.2024|OK|Rebecca Willi|
| 8.1  |26.04.2024|OK|Rebecca Willi|
| 9.1  |26.04.2024|OK|Rebecca Willi|
| 10.1 |26.04.2024|OK|Rebecca Willi|
| 11.1 |26.04.2024|OK|Rebecca Willi|

Da die Datenbank nicht existiert, werden auf Swagger fehler ausggegeben. Durch andere Testtools konnte dann aber alles überprüft werden und es funktioniert. 



