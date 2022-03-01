// This code represents the amplification and phase shift curves
// of a circuit using its network function H(s).
// -----------------FREQUENCY MARGIN -----------------------
f = [10:100:1e6];
// The vector of frequencies is a vector that contains frequencies
// from 1 Hz to 1MHz with steps of 100 Hz.
// The final semicolon is optional. If you don't use it, then all the
// components of vector will be displayed in the screen.
// -------------------COMPONENTS OF THE CIRCUIT --------------------
L=36e-3 // Coil 33 mH
C=4e-9 // Capacitance 10 nF
R=1.3e3 // Resistance 1KΩ
// In SCILAB declaring variables is not necessary.
// We can assign them directly a value.
// -------------------NETWORK FUNCTION--------------------------------
s=poly(0,'s'); // We define the polynomial s
num_H=s*R/L; //** indicates power
den_H=s**2+s*R/L+1/(L*C); // We introduce the denominator
H=num_H/den_H; // We introduce the network function
// -------------------LINEAR SYSTEM--------------------------------
y=syslin('c',H);
// We define the linear system that works in continuous time (analog)
// and whose network function is H(s)
// ------------------AMPLIFICATION AND PHASE SHIFT CURVES-----------
bode(y,f);
// This function represents the amplification (in dB)
// and phase shift (in degrees) curves, with the
// frequency axis in logarithmic scale.
