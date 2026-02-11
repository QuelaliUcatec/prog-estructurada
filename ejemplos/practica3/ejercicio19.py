#Leer la cantidad de respuestas correctas de un examen y determinar el nivel de desempeño.
respuestas_correctas = int(input("Ingresa la cantidad de respuestas correctas: "))
if respuestas_correctas >= 18:
    print("Nivel de desempeño: Excelente")
elif 12 <= respuestas_correctas < 18:
    print("Nivel de desempeño: Bueno")
elif 6 <= respuestas_correctas < 12:
    print("Nivel de desempeño: Regular")
else:
    print("Nivel de desempeño: Deficiente")