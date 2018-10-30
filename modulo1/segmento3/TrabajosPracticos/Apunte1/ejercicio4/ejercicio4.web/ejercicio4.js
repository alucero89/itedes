function comparar() {
	var num1 = document.getElementById("num1");
	var num2 = document.getElementById("num2");
	var num3 = document.getElementById("num3");
	var num4 = document.getElementById("num4");
	
	if ((num1.value == num2.value) && (num3.value != num4.value)) {
		alert("El primer numero y el segundo numero son iguales.");
		return;
	}
	
	if ((num3.value == num4.value) && (num1.value != num2.value)) {
		alert("El tercer numero y el cuarto numero son iguales");
		return;
	}
	
	if ((num1.value == num2.value) && (num3.value == num4.value)) {
		alert("El primer numero y el segundo numero son iguales. El tercer numero y el cuarto numero son iguales");
		return;
	}
	
	if ((num1.vale != num2.value) && (num3.value != num4.value)) {
		alert("Todos los numeros son distintos");
		return;
	}
	
	else {
		alert("Error")
		return;
	}
}	
