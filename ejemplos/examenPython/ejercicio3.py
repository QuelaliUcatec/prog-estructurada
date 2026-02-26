# Un estudiante recibe una nota de 0 a 100. Si la nota es 90 o más: "Excelente". 
# Si está entre 70 y 89: "Aprobado". 
# Si es menor a 70: "Reprobado". 
# Extra: Si la nota es exactamente 100, mostrar un mensaje adicional: "¡Felicidades, puntaje perfecto!".

def ejercicio3():
    nota = float(input("Ingresa la nota del estudiante (0-100): "))

    if nota >= 90:
        print("Excelente")
        if nota == 100:
            print("¡Felicidades, puntaje perfecto!")
    elif 70 <= nota < 90:
        print("Aprobado")
    else:
        print("Reprobado")