function cotizar() {
	const pesos = document.getElementById("uno").value;
	const dolar = document.getElementById("dos").value;
	
	res = pesos / dolar;
	
	alert("La cotizacion es: " + res );
}
	