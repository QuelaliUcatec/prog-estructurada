#ejercicio 6 : Ingresar una nota (0–100) y mostrar si el estudiante aprueba o reprueba

nota = int(input("Ingresa un número: "))

if nota < 51:
        print("El estudiante reprueba ")
elif nota > 51:
        print("El estudiante aprueba")
        