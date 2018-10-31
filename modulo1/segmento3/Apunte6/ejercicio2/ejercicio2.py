print("Para realizar la suma debe ingresar dos numeros")

num1 = int(input("Primer numero: "))
num2 = int(input("Segundo numero: "))

res = num1 + num2

print("El resultado es: ",  res)

salir = input("¿Desea continuar haciendo sumas? s/n: ")

while (salir != "n"):
	num1 = int(input("Primer numero: "))
	num2 = int(input("Segundo numero: "))
 
	res = num1 + num2
 
	print("El resultado es: ", res)

	salir = input("¿Desea continuar haciendo sumas? s/n: ")

