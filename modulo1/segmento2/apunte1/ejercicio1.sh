declare location=""
read -p "�Cu�l es el barrio de la comisaria?" location

declare address=""
read -p "�Cu�l es su direcci�n?" address

declare street1=""
read -p "�Entre que calles? Escriba el nombre de la primera calle" street1

declare street2=""
read -p "Escriba el nombre de la segunda calle" street2

echo "La direcci�n de la comisaria es  $address  entre las calles  $street1  y  $street2  ubicado en el barrio  $location"

exit 0
