## #Solicitar al usuario 5 notas, sumarlas y mostrar el promedio final.
suma = 0

for i in range(5):
    nota = float(input("Ingresa una nota: "))
    suma = suma + nota  

promedio = suma / 5

print("Suma total:", suma)
print("Promedio final:", promedio)