---
uid: arc42-de-building-block-view
---

# Bausteinsicht

> [!TIP]
> **Inhalt.**
> 
> Diese Sicht zeigt die statische Zerlegung des Systems in Bausteine
> (Module, Komponenten, Subsysteme, Klassen, Interfaces, Pakete,
> Bibliotheken, Frameworks, Schichten, Partitionen, Tiers, Funktionen,
> Makros, Operationen, Datenstrukturen…) sowie deren Beziehungen.
> 
> Diese Sicht sollte in jeder Architekturdokumentation vorhanden sein . In
> der Analogie zum Hausbau bildet die Bausteinsicht den *Grundrissplan*.
> 
> **Motivation.**
> 
> Behalten Sie den Überblick über den Quellcode, indem Sie die statische
> Struktur des Systems durch Abstraktion verständlich machen.
> 
> Damit ermöglichen Sie Kommunikation auf abstrakterer Ebene, ohne zu
> viele Implementierungsdetails offenlegen zu müssen.
> 
> **Form.**
> 
> Die Bausteinsicht ist eine hierarchische Sammlung von Blackboxen und
> Whiteboxen (siehe Abbildung unten) und deren Beschreibungen.
> 
> ![Baustein Sichten](images/05_building_blocks-DE.png)
> 
> **Ebene 1** ist die Whitebox-Beschreibung des Gesamtsystems, zusammen
> mit Blackbox-Beschreibungen der darin enthaltenen Bausteine.
> 
> **Ebene 2** zoomt in einige Bausteine der Ebene 1 hinein. Sie enthält
> somit die Whitebox-Beschreibungen ausgewählter Bausteine der Ebene 1,
> jeweils zusammen mit Blackbox-Beschreibungen darin enthaltener
> Bausteine.
> 
> **Ebene 3** zoomt in einige Bausteine der Ebene 2 hinein, usw.

## Whitebox Gesamtsystem

> [!TIP]
> An dieser Stelle beschreiben Sie die Zerlegung des Gesamtsystems anhand
> des nachfolgenden Whitebox-Templates. Dieses enthält:
> 
> * Ein Übersichtsdiagramm
> * die Begründung dieser Zerlegung
> * Blackbox-Beschreibungen der hier enthaltenen Bausteine. Dafür haben
>   Sie verschiedene Optionen:
>   * in *einer* Tabelle, gibt einen kurzen und pragmatischen
>     Überblick über die enthaltenen Bausteine sowie deren
>     Schnittstellen.
>   * als Liste von Blackbox-Beschreibungen der Bausteine, gemäß dem
>     Blackbox-Template (siehe unten). Diese Liste können Sie, je nach
>     Werkzeug, etwa in Form von Unterkapiteln (Text), Unter-Seiten
>     (Wiki) oder geschachtelten Elementen (Modellierungswerkzeug)
>     darstellen.
> * (optional:) wichtige Schnittstellen, die nicht bereits im
>   Blackbox-Templates eines der Bausteine erläutert werden, aber für
>   das Verständnis der Whitebox von zentraler Bedeutung sind. Aufgrund
>   der vielfältigen Möglichkeiten oder Ausprägungen von Schnittstellen
>   geben wir hierzu kein weiteres Template vor. Im schlimmsten Fall
>   müssen Sie Syntax, Semantik, Protokolle, Fehlerverhalten,
>   Restriktionen, Versionen, Qualitätseigenschaften, notwendige
>   Kompatibilitäten und vieles mehr spezifizieren oder beschreiben. Im
>   besten Fall kommen Sie mit Beispielen oder einfachen Signaturen
>   zurecht.
> 
> ***&lt;Übersichtsdiagramm&gt;***
> 
> Begründung
> :  *&lt;Erläuternder Text&gt;*
> 
> Enthaltene Bausteine
> : *&lt;Beschreibung der enhaltenen Bausteine (Blackboxen)&gt;*
> 
> Wichtige Schnittstellen
> : *&lt;Beschreibung wichtiger Schnittstellen&gt;*
> 
> Hier folgen jetzt Erläuterungen zu Blackboxen der Ebene 1.
> 
> Falls Sie die tabellarische Beschreibung wählen, so werden Blackboxen
> darin nur mit Name und Verantwortung nach folgendem Muster beschrieben:
> 
> **Name**             | **Verantwortung**
> -------------------- | ------------------
> *&lt;Blackbox 1&gt;* |  *&lt;Text&gt;*
> *&lt;Blackbox 2&gt;* |  *&lt;Text&gt;*
> 
> Falls Sie die ausführliche Liste von Blackbox-Beschreibungen wählen,
> beschreiben Sie jede wichtige Blackbox in einem eigenen
> Blackbox-Template. Dessen Überschrift ist jeweils der Namen dieser
> Blackbox.

### &lt;Name Blackbox 1&gt;

> [!TIP]
> An dieser Stelle beschreiben Sie die &lt;Blackbox 1&gt; anhand des
> folgenden Blackbox-Templates:
> 
> * Zweck/Verantwortung
> * Schnittstelle(n), sofern sie nicht als eigenständige Beschreibungen
>   herausgezogen sind. Hierzu gehören eventuell auch Qualitäts- und
>   Leistungsmerkmale dieser Schnittstelle.
> * (Optional) Qualitäts-/Leistungsmerkmale der Blackbox, beispielsweise
>   Verfügbarkeit, Laufzeitverhalten…
> * (Optional) Ablageort/Datei(en)
> * (Optional) Erfüllte Anforderungen, falls Sie Traceability zu
>   Anforderungen benötigen.
> * (Optional) Offene Punkte/Probleme/Risiken
> 
> *&lt;Zweck/Verantwortung&gt;*
> 
> *&lt;Schnittstelle(n)&gt;*
> 
> *&lt;(Optional) Qualitäts-/Leistungsmerkmale&gt;*
> 
> *&lt;(Optional) Ablageort/Datei(en)&gt;*
> 
> *&lt;(Optional) Erfüllte Anforderungen&gt;*
> 
> *&lt;(optional) Offene Punkte/Probleme/Risiken&gt;*

### &lt;Name Blackbox 2&gt;

> [!TIP]
> *&lt;Blackbox-Template&gt;*

### &lt;Name Blackbox n&gt;

> [!TIP]
> *&lt;Blackbox-Template&gt;*

### &lt;Name Schnittstelle 1&gt;

…

### &lt;Name Schnittstelle m&gt;

## Ebene 2

> [!TIP]
> An dieser Stelle können Sie den inneren Aufbau (einiger) Bausteine aus
> Ebene 1 als Whitebox beschreiben.
> 
> Welche Bausteine Ihres Systems Sie hier beschreiben, müssen Sie selbst
> entscheiden. Bitte stellen Sie dabei Relevanz vor Vollständigkeit.
> Skizzieren Sie wichtige, überraschende, riskante, komplexe oder
> besonders volatile Bausteine. Normale, einfache oder standardisierte
> Teile sollten Sie weglassen.

### Whitebox *&lt;Baustein 1&gt;*

> [!TIP]
> …zeigt das Innenleben von *Baustein 1*.
> 
> *&lt;Whitebox-Template&gt;*

### Whitebox *&lt;Baustein 2&gt;*

> [!TIP]
> *&lt;Whitebox-Template&gt;*

…

### Whitebox *&lt;Baustein m&gt;*

> [!TIP]
> *&lt;Whitebox-Template&gt;*

## Ebene 3

> [!TIP]
> An dieser Stelle können Sie den inneren Aufbau (einiger) Bausteine aus
> Ebene 2 als Whitebox beschreiben.
> 
> Bei tieferen Gliederungen der Architektur kopieren Sie diesen Teil von
> arc42 für die weiteren Ebenen.

### Whitebox &lt;\_Baustein x.1\_&gt;

> [!TIP]
> …zeigt das Innenleben von *Baustein x.1*.
> 
> *&lt;Whitebox-Template&gt;*

### Whitebox &lt;\_Baustein x.2\_&gt;

> [!TIP]
> *&lt;Whitebox-Template&gt;*

### Whitebox &lt;\_Baustein y.1\_&gt;

> [!TIP]
> *&lt;Whitebox-Template&gt;*
