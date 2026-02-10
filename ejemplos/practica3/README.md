1. Leer un número e indicar si es positivo, negativo o cero.
2. Leer un número y determinar si es par o impar.
3. Ingresar la edad de una persona y mostrar si es mayor o menor de edad.
4. Leer dos números y mostrar cuál es mayor, o si son iguales.
5. Leer tres números y mostrar cuál es el mayor.
6. Ingresar una nota (0–100) y mostrar si el estudiante aprueba o reprueba.
7. Leer una nota (0–100) y clasificarla como Excelente, Bueno, Regular o Reprobado.
8. Ingresar el precio de una compra y aplicar un descuento del 10% si supera cierto monto.
9. Leer un número y verificar si es múltiplo de 5.
10. Ingresar un año y determinar si es bisiesto.
11. Leer el número de un mes (1–12) y mostrar cuántos días tiene.
12. Ingresar un número del 1 al 7 y mostrar el día de la semana correspondiente.
13. Leer la hora del día (0–23) y mostrar si es mañana, tarde o noche.
14. Ingresar dos lados de un rectángulo y determinar si es un cuadrado.
15. Leer la temperatura y mostrar si hace frío, templado o calor.
16. Ingresar el sexo de una persona (M/F) y mostrar un mensaje correspondiente.
17. Leer el total de una compra y determinar si obtiene envío gratis según el monto.
18. Ingresar un número y verificar si está dentro de un rango dado.
19. Leer la cantidad de respuestas correctas de un examen y determinar el nivel de desempeño.
20. Ingresar tres ángulos y determinar si pueden formar un triángulo.

Ejercicio 1:
``` python
numero = int(input("Ingresa un número: "))

if numero > 0:
    print("El número es positivo")
elif numero < 0:
    print("El número es negativo")
else:
    print("El número es cero")

```