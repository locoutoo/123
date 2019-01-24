import { Component, Inject, OnInit } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { HttpClient } from "@angular/common/http";

@Component({
  selector: "marca-edit",
  templateUrl: './marca-edit.component.html'
})

export class MarcaEditComponent {
  marca: Marca;

  editMode: boolean;

  constructor(private activatedRoute: ActivatedRoute,
    private router: Router,
    private http: HttpClient) {

    // create an empty object from the Quiz interface
    this.marca = <Marca>{};

    var id = +this.activatedRoute.snapshot.params["id"];

    // check if we're in edit mode or not
    this.editMode = (this.activatedRoute.snapshot.url[1].path === "edit");

    if (this.editMode) {

      var url = "api/marcas/" + id;
      this.http.get<Marca>(url).subscribe(result => this.marca = result,
        error => console.error(error));
    }
    else {
      this.marca.marcaId= id;
    }
  }

  onSubmit(marca: Marca) {
    var url = "api/marcas/";

    if (this.editMode) {
      this.http.put<Marca>(url + marca.marcaId, marca).subscribe(r => console.log("A marca " + marca.marcaId + " foi atualizada."));
      this.router.navigate(["marcas"]);
    }
    else {
      marca.marcaId = 0;
      this.http.post<Marca>(url, marca).subscribe(r => console.log("A marca " + marca.designacao + " foi criada."));
      this.router.navigate(["marcas"]);
    }
  }

  onBack() {
    this.router.navigate(["marcas"]);
  }
}

