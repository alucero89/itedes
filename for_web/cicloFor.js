function cicloFor() { 
	alert(1);
	for(let i = 0; i <= 99; i++){
		let parrafo = document.getElementById('texto');

		parrafo.innerHTML = parrafo.innerHTML+i.toString()+'<br>';
	}
}

function borrar() {
	document.getElementById('texto').innerHTML="";

}	
