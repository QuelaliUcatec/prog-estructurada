#Ingresar una nota (0–100) y mostrar si el estudiante aprueba o reprueba.
nota = int(input("Ingresa la nota del estudiante (0-100): "))
if nota >= 51:
    print("El estudiante aprueba")
else:
    print("El estudiante reprueba")