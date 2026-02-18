#ejercicio 19 : Leer la cantidad de respuestas correctas de un examen y determinar el nivel de desempeño.
acierto= int(input("Ingrese la cantidad de aciertos del examen: "))

if acierto == 10 : 
   print( " desempeño excelente ") 
elif acierto >= 8 : 
   print( " desempeño muy bueno ") 
elif acierto > 6 : 
   print( " desempeño bueno ") 
elif acierto > 5 : 
   print( " desempeño regular ") 
elif acierto < 5 : 
   print( " desempeño malo ") 
