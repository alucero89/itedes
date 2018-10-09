function guardar(){
	var nombre = document.getElementById("uno");
	var apellido = document.getElementById("dos");
	//alert(nombre.value);
	//alert(apellido.value);
	alert(nombre.value.concat(" " + apellido.value));
}
