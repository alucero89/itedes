declare location=""
read -p "¿Cuál es el barrio de la comisaria?" location

declare address=""
read -p "¿Cuál es su dirección?" address

declare street1=""
read -p "¿Entre que calles? Escriba el nombre de la primera calle" street1

declare street2=""
read -p "Escriba el nombre de la segunda calle" street2

echo "La dirección de la comisaria es  $address  entre las calles  $street1  y  $street2  ubicado en el barrio  $location"

exit 0
