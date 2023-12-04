# Programa de Registro de Votación por Universidades

Este programa, desarrollado en C#, ha sido creado para facilitar el proceso de recuento de votaciones por universidades, siguiendo las indicaciones de la CONFECH. A continuación, se describe cómo utilizar y comprender el funcionamiento del programa:

## Instrucciones de Uso

1. **Ingresar la Cantidad de Universidades:**El programa solicitará al usuario ingresar la cantidad de universidades que participan en el proceso de votación.

2. **Registro de Votos por Universidad:**Para cada universidad, el usuario debe ingresar el nombre de la universidad y los votos de sus alumnos.Los votos pueden ser: aceptar (A), rechazar (R), nulo (N) o blanco (B).Indique el término de la votación ingresando una X.

3. **Visualización de Totales por Universidad:**Al finalizar la votación, el programa mostrará los totales de votos de cada universidad con un formato claro y comprensible.

4. **Resultado de la Votación:**Finalmente, el programa mostrará el resultado global de la votación.Indicará la cantidad de universidades que aceptan, que rechazan y aquellas en las que hubo empate entre estas dos opciones.



## Ejemplo de Formato de Votación

```
Universidad: NombreUni1
Votos: A R N B X
Totales:
Aceptan: 10
Rechazan: 5
Nulos: 2
Blancos: 3

...

Resultado de la Votación:
Aceptan: 5 Universidades
Rechazan: 3 Universidades
Empate: 2 Universidades
```

Este programa proporciona una solución eficiente y organizada para el recuento de votos, cumpliendo con los requisitos establecidos por la CONFECH.