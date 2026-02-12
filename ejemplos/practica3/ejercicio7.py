#ejercicio 7 : Leer una nota (0–100) y clasificarla como Excelente, Bueno, Regular o Reprobado.

nota = int(input("Ingresa un número: "))

if nota == 100 :
        print("La nota es excelente ")
if nota > 85 < 100:
        print("La nota es buena ")
elif nota > 71 < 85:
        print("La nota es regular ")
elif nota < 51 :
        print("La nota es mala o reprobado ")        
                