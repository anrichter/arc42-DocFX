---
uid: arc42-de-deployment-view
---

# Verteilungssicht

> [!TIP]
> **Inhalt.**
> 
> Die Verteilungssicht beschreibt:
> 
> 1. die technische Infrastruktur, auf der Ihr System ausgeführt wird,
>    mit Infrastrukturelementen wie Standorte, Umgebungen, Rechnern,
>    Prozessoren, Kanälen und Netztoplogien sowie sonstigen Bestandteilen
>    und
> 2. die Abbildung von (Software-)Bausteinen auf diese Infrastruktur.
> 
> Häufig laufen Systeme in unterschiedlichen Umgebungen ab, beispielsweise
> Entwicklung-/Test- oder Produktionsumgebungen. In solchen Fällen sollten
> Sie alle relevanten Umgebungen aufzeigen.
> 
> Nutzen Sie die Verteilungssicht insbesondere, wenn Ihre Software auf
> mehr als einem Rechner, Prozessor, Server oder Container abläuft oder
> Sie Ihre Hardware sogar selbst konstruieren.
> 
> Aus Softwaresicht genügt es auf die Aspekte zu achten, die für die
> Softwareverteilung relevant sind. Hardwarearchitekten können bei Bedarf
> die Infrastruktur mit beliebigen Details beschreiben.
> 
> **Motivation.**
> 
> Software läuft nicht ohne Infrastruktur. Diese zugrundeliegende
> Infrastruktur beeinflusst Ihr System und/oder querschnittliche
> Lösungskonzepte, daher müssen Sie diese Infrastruktur kennen.
> 
> Das oberste Verteilungsdiagramm könnte bereits in Ihrem technischen
> Kontext enthalten sein, mit Ihrer Infrastruktur als EINE Black-Box.
> Jetzt zoomen Sie in diese Infrastruktur mit weiteren
> Verteilungsdiagrammen hinein:
> 
> * Die UML stellt mit Verteilungsdiagrammen (Deployment diagrams) eine
>   Diagrammart zur Verfügung, um diese Sicht auszudrücken. Nutzen Sie
>   diese, evtl. auch geschachtelt, wenn Ihre Verteilungsstruktur es
>   verlangt.
> * Falls Ihre Infrastruktur-Stakeholder andere Diagrammarten
>   bevorzugen, die Prozessoren und Kanäle zeigen, sind die hier
>   ebenfalls einsetzbar.

## Infrastruktur Ebene 1

> [!TIP]
> An dieser Stelle beschreiben Sie (als Kombination von Diagrammen mit
> Tabellen oder Texten):
> 
> * die Verteilung des Gesamtsystems auf mehrere Standorte, Umgebungen,
>   Rechner, Prozessoren oä. sowie die physischen Verbindungskanäle
>   zwischen diesen,
> * wichtige Begründungen für dieser Verteilungsstruktur,
> * Qualitäts- und/oder Leistungsmerkmale dieser Infrastruktur,
> * Zuordnung von Softwareartefakten zu Bestandteilen der Infrastruktur
> 
> Für mehrere Umgebungen oder alternatives Deployment kopieren Sie diesen
> Teil von arc42 für alle wichtigen Umgebungen.
> 
> ***&lt;Übersichtsdiagramm&gt;***
> 
> Begründung
> :   *&lt;Erläuternder Text&gt;*
> 
> Qualitäts- und/oder Leistungsmerkmale
> :   *&lt;Erläuternder Text&gt;*
> 
> Zuordnung von Bausteinen zu Infrastruktur
> :   *&lt;Beschreibung der Zuordnung&gt;*

## Infrastruktur Ebene 2

> [!TIP]
> An dieser Stelle können Sie den inneren Aufbau (einiger)
> Infrastrukturelemente aus Ebene 1 beschreiben.
> 
> Für jedes Infrastrukturelement kopieren Sie die Struktur aus Ebene 1.

### *&lt;Infrastrukturelement 1&gt;*

> [!TIP]
> *&lt;Diagramm + Erläuterungen&gt;*

### *&lt;Infrastrukturelement 2&gt;*

> [!TIP]
> *&lt;Diagramm + Erläuterungen&gt;*

…

### *&lt;Infrastrukturelement n&gt;*

> [!TIP]
> *&lt;Diagramm + Erläuterungen&gt;*
