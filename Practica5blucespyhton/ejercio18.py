## El programa genera un número aleatorio entre 1 y 20. El usuario debe intentar adivinarlo; el programa dará pistas ("más alto" o "más bajo") hasta que acierte

import random

secreto = random.randint(1, 20)
intento = 0

while intento != secreto:
    intento = int(input("Adivina el número (1-20): "))
    
    if intento < secreto:
        print("Es más alto")
    elif intento > secreto:
        print("Es más bajo")

print("¡Ganaste!")