function tabla() {
	const num = document.getElementById("num").value;
	
	for (let i=0;i<=10;i++) {
		const res = num * i;
		//alert(res);
		let parrafo = document.getElementById('texto');

		parrafo.innerHTML = parrafo.innerHTML + res.toString() + '<br>';
	}
}