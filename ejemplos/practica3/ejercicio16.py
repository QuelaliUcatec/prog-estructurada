#Ingresar el sexo de una persona (M/F) y mostrar un mensaje correspondiente.
sexo = input("Ingresa el sexo de la persona (M/F): ")
if sexo == "M":
    print("La persona es masculina")
elif sexo == "F":
    print("La persona es femenina")
else:
    print("Sexo inválido")