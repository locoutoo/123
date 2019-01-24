import { Component} from '@angular/core';
import { Router } from "@angular/router";
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-marcas',
  templateUrl: './marcas.component.html'
})
export class MarcasComponent {

  public marcas: Marca[];

  constructor(private http: HttpClient,
              private router: Router) {

    this.loadData();
  }

  loadData() {
    this.http.get<Marca[]>('api/Marcas').subscribe(result => {
      this.marcas = result;
    }, error => console.error(error));
  }

  onCreate() {
    this.router.navigate(["marcas/create"]);
  }

  onEdit(marca: Marca) {
    this.router.navigate(["marcas/edit", marca.marcaId]);
  }
  onDelete(marca: Marca) {
    if (confirm("Quer mesmo apagar esta marca?")) {
      var url = "api/marcas/" + marca.marcaId;
      this.http
        .delete(url)
        .subscribe(res => console.log("A marca " + marca.marcaId + " foi apagada."));
      this.loadData();
    }
  }
}

