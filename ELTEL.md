# Electronica de telecomunicaciones

## Index

- [Electronica de telecomunicaciones](#electronica-de-telecomunicaciones)
  - [Index](#index)
  - [Laboratorio](#laboratorio)
    - [Practica 1](#practica-1)
      - [Preg 0](#preg-0)
      - [Preg 1](#preg-1)
      - [Preg 2](#preg-2)
      - [Preg 3](#preg-3)
      - [Preg 6](#preg-6)
  - [Teoria](#teoria)
    - [Análisis de circuitos](#análisis-de-circuitos)
    - [Componentes](#componentes)
      - [Generico](#generico)
      - [Resistencia](#resistencia)
      - [Circuito abierto](#circuito-abierto)
      - [Corto circuito](#corto-circuito)
      - [Condensadores](#condensadores)
      - [Bobina/Inductor](#bobinainductor)
      - [Fuente ideal de tensión](#fuente-ideal-de-tensión)
      - [Fuente ideal de corriente](#fuente-ideal-de-corriente)

## Laboratorio

### Practica 1

#### Preg 0

Reviseu els instruments que teniu en el vostre lloc de treball i comproveu que coincideixen amb els de la Taula 1 del guió. En cas de que en hi hagin dos, marqueu el que correspongui. Si no hi ha coincidència, actualitzeu el model. D’aquí en endavant haureu de consultar els manuals dels instruments corresponents.

#### Preg 1

Llegiu la introducció de la FA d’aquest guió i el manual de l’instrument que trobareu aquí (per saber el model, consulteu primer el laboratori que teniu assignat per les pràctiques i desprès la Taula 1) i contesteu els següents apartats:

a) Anoteu el marge d’ajust de tensió i del corrent límit de cadascuna de les sortides de la FA

- Dreta:[0,30]V, 1A
- Centre: 5V,2A
- Esquerra:[0,30]V,1A

b) Descriviu el procediment per a fixar un límit de corrent i què ocorre si s’excedeix el límit de corrent fixat.

- Per augmentar la tolerancia girar la rodeta inferior en sentit horari
- En cas de superar la corren es talla la alimentació

c)Es vol configurar una de les sortides amb una tensió de 5 V i un límit de corrent de 50 mA. Deduïu la tensió i corrent de sortida quan es connecti a la sortida una resistència de:

1. 220 Ω $\Rarr$22,7mA

2. 47 Ω. $\Rarr$106mA

#### Preg 2

Llegiu la introducció del MD d’aquest guió i el manual del MD que trobareu aquí (per saber el model, consulteu la Taula 1)i contesteu als següents apartats:

a. Expresseu la resolució del MD en nombre de dígits i en nombre de comptes.

- 0.1mV en un rang de 400mV
- 1μA en un rang de 4mA
- $0.1\Omega$ en el rang de $400\Omega$
- 1pF en un rang de 4nF

b.Descriviu breument el procediment per a la mesura de tensions, corrents i resistències

- per mesurar tensió posem el MD en el rang desitjat i coloquem els terminals seguint la polaritat del circui i en paralel.
- per mesurar la corrent posem el MD en el rang desitjat i coloquem els terminals seguint la polaritat del circuit i en serie al mateix.
- per mesurar la resistencia posem el MD en el rang desitjat i coloquem els terminal als extrems del circuit a mesurar

c. Descriviu com commutar entre la selecció d’escales manual o automàtica i com commutar entre la mesura en DC o AC

- per passar a mode manual pulsem el buto "Manual Range button" i per tornar al automàtic el mantenim pulsat per 2s
-

d.Anoteu les escales disponibles i la resolució associada per les mesures de tensió i corrent continus (DC) així com de resistència.

- Tensió
  - 400mV$\Rarr$ ± (0.75% + 2D)
  - 4V,40V,400V,600V$\Rarr$ ± (0.5% + 2D)
- Corrent
  - 4mA a 400mA $\Rarr$ ± (0.75% + 2D)
  - 10A $\Rarr$ ± (1.5% + 4D)

#### Preg 3

Es vol mesurar amb el MD la tensió d’una de les sortides de la FA configurada segons la qüestió P1.c. (Nota: ja no s’han d’emprar les resistències de 220 Ω i 47 Ω)

a. Indiqueu les connexions que heu de realitzar entre ambdós instruments.

- El Negatiu amb el negatiu i el positiu de la FA en el el "COM input terminal"

b.Representeu el circuit equivalent modelant la FA com a la Figura 3 i el MD com a la Figura 6.b. Busqueu al manual del MD el valor de la seva resistència (o impedància) d’entrada quan es configura per a la mesura de tensions.
![Circuit](practicas/ELTEL/Q1/Practica1/Practica1ELTELC1A/Practica1ELTELC1A.svg)

Impedancia $\Rarr$ 10M $\Omega$

c.Indiqueu la funció que escollireu del MD i indiqueu la lectura que proporcionarà l’instrument per a cadascuna de les escales. Així mateix, busqueu al manual la incertesa a cada escala. Nota: La incertesa és el terme correcte però moltes vegadess’utilitzen encara els termesprecisió o exactitud.

Utilitzariem la funció de mesura de voltatge en el rang de 4V, ja que en altres escales pot ser que no ho pogui detectar.

#### Preg 6

Respecte a les resistències d’1 kΩ i d’1 MΩ.

a.Busqueu un parell de cadascuna en el vostre material.[ x ]
b.Identifiqueu la tolerància i anoteu l’interval de valors possibles.
<!-- TODO -->
c.Descriviu com connectar i configurar el MD per a mesurar les resistències.

Conectem els terminals al negatiu al port am el simbol $\Omega$, posem la roda en $4k\Omega$ en el cas de la resistència de $1k\Omega$ i $4M\Omega$ en el cas de la de $1M\Omega$ i els extrems dels cables als terminals de la resistencia.

d.Busqueu al manual del MD la incertesa per a les escales de 4 kΩ i 4 MΩ.

- $4k\Omega\Rarr± (0.75\% + 2D)$
- $4M\Omega\Rarr± (1\% + 3D)$

## Teoria

### Análisis de circuitos

- Carga:$Q\Rarr[Q]=C\Rarr$ Coulomb
  - $q_e=1.6·10^{-19}$
- Corriente: $\frac{\Delta Q}{\Delta t}=I\Rarr[I]=A$
- Diferencia de potencial: $\frac{\Delta W}{\Delta Q}=V\Rarr[V]=V=\frac{J}{C}$
- Potencia: $P=\frac{\Delta W}{\Delta t}=VI\Rarr[P]=W=\frac{J}{s}$
- Resistencia: $R=\frac{V}{I}\Rarr[R]=\Omega=\frac{Js}{C^2}$
- Conductáncia: $G=\frac{1}{R}\Rarr[G]=S=\frac{c^2}{Js}$

### Componentes

#### Generico

- $P>0$ Libera energia
- $P<0$ Absorve energia
  ![Generico](Imagenes/ELTEL/schematic-symbols-resistor-europe.png)

#### Resistencia

![Resistencia](Imagenes/ELTEL/schematic-symbols-resistor-europe.png) ![Resistencia](Imagenes/ELTEL/schematic-symbols-resistor-america.png)

#### Circuito abierto

![Circuito abierto](Imagenes/ELTEL/opencircuit.svg)

#### Corto circuito

#### Condensadores

#### Bobina/Inductor

#### Fuente ideal de tensión

#### Fuente ideal de corriente
