---
title: "CTM"
fontsize: 10pt
output:
  pdf_document
  html_document:
    css: style.css
---

# Formulario

| Propiededades mecanicas                                                                                               | Dislocaciones y endurecimiento                                       |
| --------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------- |
| $\sigma=\frac{F_t}{A_0}\ \square\ \tau=\frac{F_s}{A_o}\ \square\ \sigma_R=\frac{F}{A_i}$                              | Fuerza de traccion: $F_n=F\cos(\varphi)$                             |
| $\varepsilon=\frac{\Delta L}{L_0}=\frac{L-L_0}{L_0}$                                                                  | Fuerza cizalladura: $F_c=\cos(\lambda)$                              |
| $\varepsilon_L=\frac{\Delta\varnothing}{\varnothing_0}=\frac{\varnothing-\varnothing_0}{\varnothing_0}$               | $A_\varphi=\frac{A}{\cos(\varphi)}$                                  |
| $\gamma=\tan(\theta)\ \square\ \tau=G\gamma$                                                                          | $\sigma_n=\sigma\cos(\varphi)^2$                                     |
| $\upsilon=-\frac{\varepsilon_L}{\varepsilon}\ \epsilon\  [-1, 0.5]$                                                   | $\tau_r=\sigma\cos(\varphi)\cos(\lambda)$                            |
| $P=-K\frac{\Delta V}{V_0}$                                                                                            | $\sigma_y=\frac{\tau_{CRSS}}{(\cos(\varphi)\cos(\lambda))_{MAX}}$    |
| $U_R=\int_0^{\varepsilon_y}\sigma d\varepsilon=0.5\varepsilon_y\sigma_y=\\=\frac{\sigma^2_y}{2E}=0.5E\varepsilon_y^2$ | $\text{mejor caso: }\\\varphi=\lambda=45º\rArr\sigma_y=2\tau_{CRSS}$ |
| $\%EL=\frac{L_f-L_0}{L_0}\times100$                                                                                   | $\sigma_y=\sigma_0+k_yd^{-1/2}$                                      |
| $\%AR=\frac{A_0-A_f}{A_0}\times100$                                                                                   | $\%CW=\frac{A_o-A_d}{A_o}\times100$                                  |
| $U_t=\int_0^{\varepsilon_f}\sigma d \varepsilon=U_r+\int_{\varepsilon_y}^{\varepsilon_f}\sigma d\varepsilon$          | $d^n-d_0^n=Kt$                                                       |

- σo límite elástico del material en estado monocristalino (cte)
- ky parámetro de ajuste (cte)
- d diámetro medio de los granos (variable)

| Fracture                     | Fatigue                                                           | Diffusion                                                 | Creep                                                  |
| ---------------------------- | ----------------------------------------------------------------- | --------------------------------------------------------- | ------------------------------------------------------ |
| $K_c=Y\sigma_c\sqrt{\pi a}$  | $\sigma_m=\frac{\sigma_{max}+\sigma_{min}}{2}$                    | $N_\upsilon=N_0\exp(-\frac{Q}{kT})$                       | $\dot{\varepsilon}_s=K_1\sigma^n$                      |
| $K_{Ic}=Y\sigma\sqrt{\pi a}$ | $\sigma_r=\sigma_{max}-\sigma_{min}$                              | $J=\frac{1}{A}\frac{dM}{dt}$                              | $\dot{\varepsilon}_s=K_2\sigma^n\exp(-\frac{Q_c}{RT})$ |
| A3                           | $\sigma_a=\frac{\sigma_{max}-\sigma_{min}}{2}=\frac{\sigma_r}{2}$ | $J=-D\frac{dC}{dx}$                                       |                                                        |
| A3                           | $R=\frac{\sigma_{min}}{\sigma_{max}}$                             | $\frac{\delta C}{\delta t}=D\frac{\delta^2C}{\delta x^2}$ |                                                        |
| A3                           | $\Delta\sigma\cdot N^a_f=C_1$                                     | $\frac{C_x-C_0}{C_s-C_0}=1-erf(\frac{x}{2\sqrt{Dt}})$     |                                                        |
| A3                           | $\sum \frac{n_i}{NN_i}=1$                                         | $\frac{C_x-C_0}{C_s-C_0}=1-erf(z)$                        |                                                        |

| Failure  | Temperature T    | Load/Stress $\sigma$  |
| -------- | ---------------- | --------------------- |
| Fracture | Low              | static                |
| Fatige   | Low              | cyclic time-dependent |
| Creep    | High($T>0.4T_m$) | static                |
