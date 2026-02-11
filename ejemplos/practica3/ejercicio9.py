#Leer un número y verificar si es múltiplo de 5.
numero = int(input("Ingresa un número: "))
if numero % 5 == 0:
    print(f"El número {numero} es múltiplo de 5")
else:
    print(f"El número {numero} no es múltiplo de 5")