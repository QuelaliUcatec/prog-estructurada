#Leer una nota (0–100) y clasificarla como Excelente, Bueno, Regular o Reprobado.
nota = int(input("Ingresa la nota del estudiante (0-100): "))
if nota >= 90:
    print("La nota es Excelente")
elif nota >= 70:
    print("La nota es Buena")
elif nota >= 51:
    print("La nota es Regular")
else:
    print("La nota es Reprobado")