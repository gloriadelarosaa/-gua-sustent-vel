const contador = document.getElementById("contador");

let valor = 0;

function atualizarContador() {
    valor += 125;
    contador.textContent = valor.toLocaleString("pt-BR");
}

setInterval(atualizarContador, 50);
