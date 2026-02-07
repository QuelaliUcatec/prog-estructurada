# Dados los tres lados de un triángulo, determina si es: equilátero, isósceles o escaleno

lado1 = 10
lado2 = 10
lado3 = 10

if lado1 == lado2 and lado2 == lado3: 
    print("EQUILATERO")
elif lado1 == lado2 or lado2 == lado3 or lado1 == lado3:
    print("ISOCELES")
elif lado1!=lado2 and lado2 != lado3 and lado1 != lado3:
    print("ESCALENO")
