## Crear una lista con 10 números predefinidos. Pedir al usuario un valor y decirle si se encuentra en la lista y en qué índice.
numeros = [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]


busqueda = int(input("¿Qué número buscas?: "))


for indice, valor in enumerate(numeros):
    if valor == busqueda:
        print(f"El número {busqueda} está en el índice {indice}.")
        break 
else:
      print("El número no está en la lista.")