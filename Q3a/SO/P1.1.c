#include <stdio.h>
#include <stdlib.h>

int ContarPares(int vector[10]) {
  int count = 0;
  int i = 0;
  int len = *(&vector + 1) - vector;
  while ((i < len) && (vector[i] != 10)) {
    if (vector[i] % 2 == 0) {
      count += 1;
    }
    i += 1;
  }
  return count * (vector[i] == 10) - (vector[i] != 10);
}
int Cumple(int vector[10]) {
  int count = 0;
  for (int i = 0; i < 10; i++) {
    if (vector[i] > 10 && vector[i] < 50 && vector[i] % 7 == 0) {
      count++;
    }
  }
  return count;
}
int main(void) {
  int n = 0;
  int len = 10;
  int vector[10];
  int i = 0;
  int err = 0;
  printf("Escribe 10 numeros cada uno en una line diferente\n");
  while (i < len) {
    err = scanf("%d", &n);
    if (err != 1) {
      printf("Error no escribiste ningun número");
      continue;
    }
    vector[i] = n;
    i++;
  }
  printf("Hay %d numeros pares antes del primer 10 y %d que cumplen las "
         "condiciones\n",
         ContarPares(vector), Cumple(vector));
}