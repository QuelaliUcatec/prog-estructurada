## Pedir una frase completa y contar cuántas palabras contiene (asumiendo que están separadas por espacios).

frase = input("Ingresa una frase: ").strip()

if frase == "":
    contador = 0
else:
    contador = 1
    
    for letra in frase:
        if letra == " ":
            contador = contador + 1

print(f"La frase tiene {contador} palabras.")