#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#define MAXP 10
#define NAMELEN 20
typedef struct {
  char nombre[NAMELEN];
  int edad;
} TPersona;

typedef struct {
  int num;
  TPersona personas[MAXP];
} TListaPersonas;

// Y ahora la función
int ContarMayoresEdad(TListaPersonas lista) {
  int cont = 0;
  int i;
  for (i = 0; i < lista.num; i++)
    if (lista.personas[i].edad > 18)
      cont = cont + 1;
  return cont;
}

int BuscarPers(TListaPersonas lista, char nombre[NAMELEN]) {
  int edad = -1;
  for (int i = 0; i < lista.num; i++) {
    if (lista.personas[i].nombre == nombre) {
      return lista.personas[i].edad;
    }
  }
  return edad;
}

int main(void) {
  int edad;
  char nombre[NAMELEN];
  TListaPersonas lista;
  lista.num = 0;
  int i = 0;
  int err = 0;
  while (i < MAXP) {
    printf("Escribe nombre y edad separados por un espacio\n");
    err = scanf("%s %d", nombre, &edad);
    if (err != 2) {
      printf("Error al parsear escribe asegurate de que cumples el formato");
      continue;
    }
    TPersona pers;
    strcpy(pers.nombre, nombre);
    pers.edad = edad;
    lista.personas[i].edad = edad;
    lista.num++;
    i++;
  }
  printf("Hay %d mayores de edad", ContarMayoresEdad(lista));
  printf("Escribe un nombre\n");
  err = scanf("%s", nombre);
  if (err != 1) {
    printf("Error al parsear escribe asegurate de que cumples el formato");
  } else {
    printf("%s tiene %d años", nombre, BuscarPers(lista, nombre));
  }
}