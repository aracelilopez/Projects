var variable_valor;
var variable_modificacion;



var request = new XMLHttpRequest();

request.open('GET', 'https://api.cambio.today/v1/quotes/ARS/BRL/json?quantity=50&key=1552|pyZ4DMRXKoR7n7msg6CFRHkkY2TTOaVe', true);
request.onload = function () {

  // Begin accessing JSON data here
  var data = JSON.parse(this.response);
  variable_valor = data.result.value;
  variable_modificacion = data.result.updated;
 


}

request.send();




function convertir_a_real(pesos)
	{
      numero = /[0-9\.]$/
      if (!numero.exec(pesos))
      {
      alert("esto no es un número");
        }
       else 
      {
      dolar= variable_valor;
      resultado = pesos/dolar;
      document.getElementById("total").innerHTML="su conversion a reales es de R$ "+ resultado;

        document.getElementById("texto").innerHTML="Esta moneda se encuentra cotizada a " + cotizacion + ",en la fecha y hora " + modificacion;
      
      }
    }   
