function sumar() {
	const num1 = document.getElementById('uno').value;
	const num2 = document.getElementById('dos').value;
	
	const suma = parseInt(num1) + parseInt(num2);
	
	alert(`El resultado de la suma es: ${suma}`);
}