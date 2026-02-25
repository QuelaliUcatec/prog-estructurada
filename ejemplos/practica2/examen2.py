nota= int(input("Ingresa la nota (0-100): "))

if nota == 100:
    print("excelente")
    print("puntaje perfecto")
elif nota >= 90:
    print("Excelente" )
elif nota >= 70 and nota <= 89:
    print("Aprobado" )
elif nota < 70:
    print("Reprobado" )