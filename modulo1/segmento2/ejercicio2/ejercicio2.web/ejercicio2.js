function guardar(){
	var nombre = document.getElementById("uno");
	var apellido = document.getElementById("dos");
	var dni = document.getElementById("tres");
	var direccion = document.getElementById("cuatro");
	var telefono = document.getElementById("cinco");
	
	alert("Su nombre y apellido es " + nombre.value.concat(" " + apellido.value + ", su documento es " + dni.value + ", vive en la direccion " + direccion.value + " y su telefono es " + telefono.value ));
}

