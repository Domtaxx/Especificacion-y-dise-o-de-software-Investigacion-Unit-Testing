// clase calculadora a la que se le va a realizar las pruebas
class Calculadora {

    suma(x1, x2) {
        return x1 + x2;
    }

    resta(x1, x2) {
        return x1 - x2;
    }

    multiplicacion(x1, x2) {
        return x1 * x2;
    }

    division(x1, x2) {
        if (x2 == 0) {
            return "No se puede dividir por 0";
        } else {
            return x1 / x2;
        }
    }
}

// se crea una instancia de la clase para ser exportada
const calcu = new Calculadora();
module.exports = {calcu};