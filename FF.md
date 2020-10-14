# Fonaments de la física

- [Fonaments de la física](#fonaments-de-la-física)
  - [Intro](#intro)
  - [Mates](#mates)
  - [Vectores](#vectores)
    - [Producto escalar](#producto-escalar)
    - [Producto Vectorial](#producto-vectorial)
  - [Cinemática](#cinemática)
    - [Velocidad, Acceleración Promedio y Medidias semi-instantanea](#velocidad-acceleración-promedio-y-medidias-semi-instantanea)
      - [Velocidad](#velocidad)
      - [Acceleración](#acceleración)
      - [Acceleración a Velocidad](#acceleración-a-velocidad)
    - [Velocidad i acceleración instantanea](#velocidad-i-acceleración-instantanea)
    - [Componentes Intrinsicas aceleración](#componentes-intrinsicas-aceleración)
    - [Movimiento circular](#movimiento-circular)
  - [Leyes de Newton](#leyes-de-newton)
    - [Primera](#primera)
    - [Segunda](#segunda)
  - [Tema 3 Trabajo y energia](#tema-3-trabajo-y-energia)
    - [Trabajo 1D Fuerza constante Energia cinetica](#trabajo-1d-fuerza-constante-energia-cinetica)
    - [Trabajo fuerza variable](#trabajo-fuerza-variable)
    - [Trabajo y energia cinetica 3d: integral de camino](#trabajo-y-energia-cinetica-3d-integral-de-camino)
    - [Fuerzas conservativas](#fuerzas-conservativas)
    - [Energia Potencial y Energia Mecanica](#energia-potencial-y-energia-mecanica)
    - [Problemas energia](#problemas-energia)

## Intro

| Mecánica                   | Electromagnétismo        |
| -------------------------- | ------------------------ |
| Cinemática                 | Electrostática           |
| Leyes Newton               | Condensadores            |
| W y Energía                | Corriente                |
| Rotación en torno a un eje | Magnetostatica =>Bobinas |
|                            | Generadores              |
| Ondas Mecanicas            | Ondas EM                 |

## Mates

- Requerido
  - Álgebra básica
  - Funciones básicas
    - Quadràtica
    - Exponenciales
    - Logarítmica
  - Trigonometría
- Recomendado
  - Derivadas
  - Concepto límite
  - Integrales

## Vectores

### Producto escalar

- $\overrightarrow{v} · \overrightarrow{u}=v_xu_x+v_yu_y+v_zu_z$
- Proyección de un vector sobre otro

### Producto Vectorial

- $î\times î = \hat{j}\times\hat{j}=\hat{k}\times\hat{k}=0$
- $\hat{i}\times\hat{j}=\hat{k}$
- $\hat{j}\times\hat{i}=-\hat{k}$
- $\hat{i}\times\hat{k}=-\hat{j}$
- $\hat{k}\times\hat{i}=\hat{k}$

> **$\hat{i},\hat{j},\hat{k}\Rarr+$**<br>**$\hat{j},\hat{i},\hat{k}\Rarr-$**

## Cinemática

- Reloj(tiempo)$\Rarr$tiene una resolucion
- Reglas(posicion(3))$\Rarr$tiene una resolución

### Velocidad, Acceleración Promedio y Medidias semi-instantanea

#### Velocidad

- Prom: $\overrightarrow{v}_M\big|_{t_1}^{t_2}=\frac{\overrightarrow{r}(t_2)-\overrightarrow{r}(t_1)}{t_2-t_1}$
- Semi-instantanea: $\overrightarrow{v}_M\big|_t=\frac{\overrightarrow{r}(t +\Delta t)-\overrightarrow{r}(t)}{\Delta t}$

#### Acceleración

- Prom: $\overrightarrow{a}_M\big|_{t_1}^{t_2}=\frac{\overrightarrow{v}_M\big|_{t_2}-\overrightarrow{v}_M\big|_{t_1}}{t_2-t_1}$
- Semi-instantanea: $\overrightarrow{a}_M\big|_t=\frac{\overrightarrow{v}_M\big|_{t +\Delta t}-\overrightarrow{v}_M\big|_{t}}{\Delta t}$

#### Acceleración a Velocidad

$$
a_x(t_a)=\frac{dv_x}{dt}\\
a_x\approx\frac{\Delta v_x}{\Delta t}\\
a_x\Delta t\approx\Delta v_x\\
v_x(t)\approx v_{x0}+a_xt
$$

### Velocidad i acceleración instantanea

$$
\overrightarrow{r}=\int\overrightarrow{v}dt+\overrightarrow{R}=\int(\int\overrightarrow{a}dt)+\overrightarrow{C}dt+\overrightarrow{R}\\
\overrightarrow{v}=\lim_{\Delta t\to0}\frac{\Delta\overrightarrow{r}}{\Delta t}=\frac{d\overrightarrow{r}}{dt}=\int \overrightarrow{a}dt+C\\
\overrightarrow{a}=\lim_{\Delta t\to0}\frac{\Delta\overrightarrow{v}}{\Delta t}=\frac{d\overrightarrow{v}}{dt}
$$

### Componentes Intrinsicas aceleración

$$
\frac{d|\overrightarrow{v}|}{dt}=\frac{d}{dt}\sqrt{v_x^2+v_y^2+v_z^2}=\\=\frac{d}{dt}\sqrt{v_x(t)^2+v_y(t)^2+v_z(t)^2}=\frac{1}{2|\overrightarrow{v}}\frac{d}{dt}(v_x^2+v_y^2+v_z^2)=\\=\overrightarrow{a}·\frac{\overrightarrow{v}}{|\overrightarrow{v}|}
$$

### Movimiento circular

- $|\overrightarrow{r(t)}|=R$
- $R, \theta(t)$
  - $\overrightarrow{r}(t)= R(\cos(\theta(t)),\sin\theta(t))$
  - $\overrightarrow{v}=R\frac{d\theta}{dt}(-\sin\theta(t),\cos\theta(t))=R\omega(-\sin\theta(t),\cos\theta(t))$
  - $\overrightarrow{a}=R\frac{d²\theta}{dt²}(-\sin\theta(t),\cos\theta(t))+R\omega(-\cos\theta(t),-\sin\theta(t))$

## Leyes de Newton

### Primera

Un cuerpo no sometido a impulsos sigue una trayectoria rectilínea a velocidad constante siempre ques estes en un sistema de referencia no inercial.

### Segunda

- Un objeto sometido a un impulso(caracter vectorial) cambia la velocidad.

- $\overrightarrow{F}=\frac{d\overrightarrow{p}}{dt}$ si $m=ctt\Rarr \overrightarrow{F}=m\overrightarrow{a}$ en un SRI

- Fuerzas conocidas en el sXVII:
  - Gravedad
    - $\overrightarrow{F}_T=m_gg=ma\Rarr g=a \Rarr \overrightarrow{F}=m\overrightarrow{g}$
  - Normal
  - Fricción
  - Cuerdas
  - Elastica
    - $\overrightarrow{F}=-K(sx-l_0)\overrightarrow{l}$
    - $x(t)=s(t)=A\cos(\omega t+\delta)$
    - $v_x(t)=\overset{.}{s}=-A\omega\sin(\omega t +\delta)$
    - $a_x(t)=\overset{..}{s}=-A\omega^2\cos(\omega t+\delta)$
    - $\omega^2=\frac{K}{m}$
    - caso muelle suelo
      - $y(t)=y_{eq}+Acos(\omega t+\delta)$
      - $y_{eq}=l_0-\frac{mg}{k}$
    - caso muelle techo
      - $y(t)=y_{eq}+Acos(\omega t+\delta)$
      - $y_{eq}=l_0+\frac{mg}{k}$
  - Animal

## Tema 3 Trabajo y energia

### Trabajo 1D Fuerza constante Energia cinetica

- $$
  \\
  x(t)=F_x\frac{F_x}{m}t^+v_ot+x_0
  \\
  $$

- $$
  \\
  W\big|^{x_f}_{x_0}=\frac{1}{2}m(v^2-v_0^2)
  \\
  $$

### Trabajo fuerza variable

$$
K=\frac{1}{2}m|v|^2\\
W=\int^{x_f}_{x_0}Fdx=\int^{x_f}_{x_0}F(t)dx=K_f-K_0
$$

### Trabajo y energia cinetica 3d: integral de camino
$$
\overrightarrow{F}=m\frac{d\overrightarrow{v}}{dt}\\
\overline{F}\approx m\frac{\Delta\overrightarrow{v}}{\Delta t}\\
\overline{F}·\Delta\overrightarrow{r}\approx m\frac{\Delta\overrightarrow{v}·\overrightarrow{r}}{\Delta t}\\
\overline{F}·\Delta\overrightarrow{r}\approx m\Delta\overrightarrow{v}·\overrightarrow{v}=m\frac{1}{2}(\Delta(v_x^2+v_y^2+v_z^2))\\
$$
Para fuerzas dependientes posición
$$
W=\int_{\overline{r}_0}^{\overline{r}_f}\overrightarrow{F}·d\overrightarrow{r}%=\underset{N\rarr\infty;\ \Delta\overrightarrow{r}}{\lim}
$$

### Fuerzas conservativas

### Energia Potencial y Energia Mecanica

### Problemas energia
