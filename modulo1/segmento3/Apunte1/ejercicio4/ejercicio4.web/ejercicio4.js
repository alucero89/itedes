function comparar() {
	var num1 = document.getElementById("num1").value;
	var num2 = document.getElementById("num2").value;
	var num3 = document.getElementById("num3").value;
	var num4 = document.getElementById("num4").value;
	
	if ((num1 == num2) && (num3 != num4)) {
		alert("El primer numero y el segundo numero son iguales.");
		return;
	}
	
	if ((num3 == num4) && (num1 != num2)) {
		alert("El tercer numero y el cuarto numero son iguales");
		return;
	}
	
	if ((num1 == num2) && (num3 == num4)) {
		alert("El primer numero y el segundo numero son iguales. El tercer numero y el cuarto numero son iguales");
		return;
	}
	
	if ((num1 != num2) && (num3 != num4)) {
		alert("Todos los numeros son distintos");
		return;
	}
	
	else {
		alert("Error")
		return;
	}
}	
