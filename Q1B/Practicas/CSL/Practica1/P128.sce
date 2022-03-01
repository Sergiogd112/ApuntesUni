// Programa para el estudio de la respuesta temporal de un circuito a partir de su función de transferencia [H(s)]
// En SCILAB no es necesario declarar las variables.
// Podemos asignarles directamente un valor
R=100000; // Valor de los elementos
L=100e-3;
C=1e-9;
// Definimos la función de red
s=poly(0,'s'); //Definimos el polinomio s
numerador=1/(L*C);
denominador=s**2+R/L*s +1/(L*C); // ** indica elevado
H=numerador/denominador; // Introducimos la función de red
// Definimos el sistema lineal que trabaja en tiempo continuo (analógico)
// y cuya función de red es H
y=syslin('c',H);
// Definimos el vector de tiempo en el que simularemos el sistema.
t=1e-6:1e-6:2e-3; // En este caso las respuestas se mostrarán entre 1 µs y 2 ms en intervalos de 1 µs.
// Obtenemos la respuesta al escalón y la respuesta impulsional
z1=csim('step',t,y);
z2=csim('impuls',t,y);
// Representamos gráficamente las respuestas
scf(0);xset("window",0);//xselect(); // Creamos una ventana de gráficos
plot2d([t',t'],[z1',0*t']) // Dibujamos la respuesta z1
scf(1);xset("window",1);//xselect(); // Creamos otra ventana de gráficos
plot2d([t',t'],[z2',0*t']) // Dibujamos la respuesta z2
// Representamos el diagrama de polos y ceros del sistema lineal y
scf(2);xset("window",2);//xselect(); // Creamos una tercera ventana
plzr(y); // Diagrama de polos y ceros de y.
