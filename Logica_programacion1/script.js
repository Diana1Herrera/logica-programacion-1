
let numero1 = prompt("Ingresa el primer número:");
numero1 = Number(numero1); 


if (isNaN(numero1)) {
    console.error(" Número inválido.");
} else {
    
    let numero2 = prompt("Ingresa el segundo número:");
    numero2 = Number(numero2); 

    
    if (isNaN(numero2)) {
        console.error("Número inválido.");
    } else {
        // Comparar los números
        if (numero1 > numero2) {
            console.log(`El primer número (${numero1}) es mayor que el segundo (${numero2}).`);
        } else if (numero1 < numero2) {
            console.log(`El segundo número (${numero2}) es mayor que el primero (${numero1}).`);
        } else {
            console.log(`Ambos números son iguales (${numero1}).`);
        }
    }
}