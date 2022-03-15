//importar los assert
const assert = require('assert');
const assert_chai = require('chai').assert;

//se instancia la clase calculadora
const { calcu } = require('../calculadora');


// se realiza el suite de prueba
describe.skip('segundo suite de prueba', function () {
    // bloque de pruebas 
    it('Resta dos numeros', function () {
        assert.equal(4, calcu.resta(7, 3));
    });

    it('Es menor', function () {
        assert.equal(9,calcu.multiplicacion(3, 3));
    });
});

// suite principal de pruebas
describe('pruebas para la calculadora', function () {
    // bloque de pruebas
    it('Suma dos numeros', function () {
        assert.equal(10, calcu.suma(7, 3));
    });

    it('Divide por cero', function () {
        assert.toString('string', calcu.division(9, 0));
    });

    it('Es menor', function () {
        assert_chai.isBelow(calcu.multiplicacion(3, 3), 10);
    });

});
