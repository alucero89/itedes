age = int(input("Ingrese su año de nacimiento: "))

anio = 2018

res = (anio - age)

if (res >= 18):
	print("Ud es mayor de edad.")
elif (res < 18):
	print("Ud es menor de edad.")
else:
	print("Error.")
