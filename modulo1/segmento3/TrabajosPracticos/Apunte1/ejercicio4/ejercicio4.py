print ("Para realizar la comparacion debe ingresar 4 números")

num1 = int(input("Ingrese el primer numero"))
num2 = int(input("Ingrese el segundo numero"))
num3 = int(input("Ingrese el tercer numero"))
num4 = int(input("Ingrese el cuarto numero"))

if ( (num1 == num2) and (num3 != num4) ):
	print ("El primer numero y el segundo numero son iguales.")

if	( (num3 == num4) and (num1 != num2) ):
	print ("El tercer numero y el cuarto numero son iguales.")
	
if ( (num1 == num2) and (num3 == num4)):
	print ("El primer numero y el segundo numero son iguales. El tercer numero y el cuarto numero son iguales")