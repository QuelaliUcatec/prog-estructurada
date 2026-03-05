## Filtrar Palabras
frutas = ["manzana", "uva", "pera", "sandia"]
nueva_lista = []

for f in frutas:
    if len(f) > 5:
        nueva_lista.append(f)

print(nueva_lista)