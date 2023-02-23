#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#define LEN 5
typedef char TTablaFrases[LEN][80]; // una tabla de 5 frases

void EscribirMasLarga(TTablaFrases tabla) {
  int larga = 0;
  int len_larga = 0;
  int i;
  for (i = 1; i < LEN; i++) {
    if (strlen(tabla[i]) > len_larga) {
      larga = i;
      len_larga = strlen(tabla[larga]);
    }
  }
  printf("La frase más larga es: %s\n", tabla[larga]);
}
void AcabvaConN(TTablaFrases tabla) {
  int found = 0;
  int i = 0;
  while (!found && i < LEN) {
    if ('n' == tabla[i][strlen(tabla[i]) - 1]) {
      found = 1;
      printf("Acaba en 'n':\n");
      printf("%s\n", tabla[i]);
    }
    i++;
  }
}
int main(void) {
  char frase[80];
  TTablaFrases tabla;
  printf("Escribe 5 frases\n");
  for (int i = 0; i < LEN; i++) {
    gets(frase);
    strcpy(tabla[i], frase);
  }
  EscribirMasLarga(tabla);
  AcabvaConN(tabla);
}