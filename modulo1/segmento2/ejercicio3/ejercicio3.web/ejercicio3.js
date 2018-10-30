function guardar() {
	var num1 = document.getElementById("uno");
	var num2 = document.getElementById("dos");
	var num3 = document.getElementById("tres");
	var num4 = document.getElementById("cuatro");
	var num5 = document.getElementById("cinco");
	
	alert("Los numeros ingresados de manera inversa queda de la siguiente forma: " + num5.value.concat(" " + num4.value + " " + num3.value + " " + num2.value + " " + num1.value));
}