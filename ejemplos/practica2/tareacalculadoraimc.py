#DADO UN PESO Y UNA TALLA, CALCULAR EL IMC E INDICAR A QUE CATEGORIA CORRESPONDE

num1= 90
num2=1.73

resultado= num1/num2

print (resultado)

if resultado< 18.5:
    print ("bajo peso")
if 18.5<resultado< 24.9:
    print ("normal")
if 25<resultado< 29.9:
    print ("sobre peso")
if 30<resultado== 30:
    print ("obesidad")
