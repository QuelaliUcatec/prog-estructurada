## Pedir al usuario que ingrese una palabra y contar cuántas vocales tiene (a, e, i, o, u).
palabra = int(input("Ingrese una palabra: "))
vocales = "aeiou"
contador = 0
for letra in palabra:
        if letra in vocales:
            contador += 1
print(f"La palabra {palabra} tiene {contador} vocales.")



   