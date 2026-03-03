## Pedir una cadena de texto y mostrar sus caracteres uno por uno en orden inverso.
texto = input("ingrese un texto:" )

print("Caracteres en orden inverso:")
for letra in reversed(texto):
    print(letra)