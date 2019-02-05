import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-value',
  templateUrl: './value.component.html',
  styleUrls: ['./value.component.css']
})
export class ValueComponent implements OnInit {
// declarar una propiedad
// no necesitamos por el momento declarar el tipo de variable que va a ser
values: any;
// inyectar un servicio para que podamos usarlo en nuestra clase
  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getValues();
  }
  // metodo obtener valores
  getValues() {
    // primer parametro url
    // obtenemos informacion del servidor
    // el metodo get devuelve observables o corriente de datos

    // para poder obtener esos datos observables debemos suscribirnos
    // el primer parametro de la suscripcion toma una funcion para decirnos que queremos hacer
    // el segundo parametro nos dira que hacer en el caso que de un error y tambien toma una funcion
    // el tercer parametro nos dira que hacer cuando se completa la suscripcion
    this.http.get('http://localhost:5000/api/values').subscribe(response => {
      // lo que queremos hacer es pasar response (respuesta) a nuestra propiedad values
      // para que podamos decir que la lista de valores es igual a la respuesta
      this.values = response; // cuando los datos sean devueltos tendremos esta respuesta dentro de una propiedad

    }, error => {
      // en caso que de error aparecera por consola
      console.log(error);
    });
  }

}
