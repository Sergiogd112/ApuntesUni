# Calculo

## Indice

- [Calculo](#calculo)
  - [Indice](#indice)
  - [Documentos](#documentos)
  - [T1 Funciones](#t1-funciones)
    - [Intro](#intro)
    - [Parametricación función](#parametricación-función)
      - [Dominio](#dominio)
      - [Imagen](#imagen)
      - [Funcions elementals](#funcions-elementals)

## Documentos

- [Funciones Elementales](Documentos/CALC/Funcions_elementals.pdf)
- [Llista total excecicis](Documentos/CALC/Llista%20total%20exercicis.pdf)
- [T1 Equacions i grafiques](Documentos/CALC/T1_Equacions_i_grafiques-c.pdf)

## T1 Funciones

### Intro

- Funcion ($\R$ de variable $\R$): $f: A\subset\R \rightarrow \R$
  - objeto matemàtico q asigna a cada $A$ un **único** num $\in \R$
    - Ej: $f(x)=x^2$
  - Toda f permite una representación en el plano cómo curva

![curva de una función en el plano](Imagenes/ELTEL/grafica-funcion-continua.png)

  - Ergo:
    - $f(x)=x \Rightarrow$ <a name="#funció">funció</a>
    - $y=x^2 \Rarr$ curva en el plano de [f(x)](#función)
  - Toda curva tiene una función asociada?
    - NO, pero se puede describir como un conjunto de estas

### Parametricación función

#### Dominio

- Conjuntos de valores para los cuales existe imagen $\exist f(x)$
- $Dom\ f=\{x\in \R; \exist f(x)\}$

#### Imagen

- $Im \ f=\{y\in\R;\ y=f(x),\ \forall x \in f(x)\}$

#### Funcions elementals

- **Lineal** $\Rarr f(x)=mx$
  - $m$: pendiente
  - $m=tan(\theta)$ siendo $\theta$ el angulo con eje-$x$
- **Afín** $\Rarr f(x)=mx+n$
  - $n$ ordenada de origen aka corte con y aka $f(0)$
- **Polinómica** $\Rarr f(x)=a_nx^n+a_{n-1}x^{n-1}+\dots+a_1x+a_0$
  - $a_i \in \R, \forall i$
- **Exponencial** $\Rarr f(x)=a^x$
  - $Dom\ f=(-\infty,\infty);Im\ f=(0\infty)$ 
  - $a>1$
    - $x>0 \Rarr a^x<1$
    - $x<0 \Rarr a^x>1$
  - $0<a<1$
    - $x>0 \Rarr a^x>1$
    - $x<0 \Rarr a^x<1$
  - $a^0=1$
  - $a^{x+y}=a^xa^y$
  - $a^{-y}=\frac{1}{a^{y}}$
  - $a^{xy}=(a^x)^y$
  - $a^{\log_ax}=x$
  - $a^x>0\forall x$
- **Logaritmica** $\Rarr f(x)=log_ax$
  - $a$: base
  - $Dom\ f=(0,+\infty); Img\ f= (-\infty,+\infty)$
  - $a>1$
    - $\log_ax<0$ si $0<x<1$
    - $\log_ax>0$ si $1<x$
  - $a<1$
    - $\log_ax<0$ si $x>1$
    - $\log_ax>0$ si $1<1$
  - $\log_a1=0$
  - $\log_auv=\log_au+\log_av$
  - $\log_a\frac{1}{v}=-\log_av$
  - $\log_au^v=v\log_au$
  - $\log_ax=\frac{\log_bx}{\log_ba}$
  - $\log_aa^x=x$
  - $\log_ax$ no $\exist$ si $x\leq0$
  
- **Valor absoluto** $\Rarr f(x)=|x|=\{x\ \forall\ x \geq0; -x\ \forall\ x \leq0\}$
  - $Dom\ f=\R; Img\ f= [ 0,+\infty)$
  - $|x|=|-x|$
  - $|x|=0\iff x=0$
  - $|x|=c\Rarr, c\geq0 x=\plusmn c$
  - $|x|=y\Rarr x=\plusmn y$
  - $|x|\leq c, c\geq 0 \iff -c\leq x\leq c$
  - $|x|\geq c, x\geq c o x\leq -c$
  - $|x+y|\leq|x|+|y|$
- **Trigonométricas**
  - Radianes