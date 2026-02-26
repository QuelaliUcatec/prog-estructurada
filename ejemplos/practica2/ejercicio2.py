# Dados los tres lados de un triángulo, determina si es: equilátero, isósceles o escaleno
def ejecutar_triangulo():
    lado1 = 10
    lado2 = 10
    lado3 = 10

    if lado1 == lado2 and lado2 == lado3: 
        print("EQUILATERO")
    elif lado1 == lado2 or lado2 == lado3 or lado1 == lado3:
        print("ISOCELES")
    else:
        print("ESCALENO")

if __name__ == "__main__":
    ejecutar_triangulo()