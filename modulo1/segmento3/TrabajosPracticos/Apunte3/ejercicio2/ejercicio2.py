caract = input("Ingrese un caracter para saber si es una vocal, consonante o un numero: ")

if (caract == '0' or
	caract == '1' or
	caract == '2' or
	caract == '3' or
	caract == '4' or
	caract == '5' or
	caract == '6' or
	caract == '7' or
	caract == '8' or
	caract == '9'
	):
	print("Ud. ingreso un numero")

elif (caract == 'a' or 
	  caract == 'e' or
	  caract == 'i' or
	  caract == 'o' or
	  caract == 'u'
	 ):
	 print("Ud. ingreso una vocal")

elif (caract == 'b' or
	  caract == 'c' or
	  caract == 'd' or
	  caract == 'f' or
	  caract == 'g' or
	  caract == 'h' or
	  caract == 'j' or
	  caract == 'k' or
	  caract == 'l' or
	  caract == 'm' or
	  caract == 'ñ' or
	  caract == 'p' or
	  caract == 'q' or
	  caract == 'r' or
	  caract == 's' or
	  caract == 't' or
	  caract == 'v' or
	  caract == 'w' or
	  caract == 'x' or
	  caract == 'y' or
	  caract == 'z' 
	 ):
	print("Ud. ingreso una consonante")

else: 
	print("Ud. ingreso un simbolo")
