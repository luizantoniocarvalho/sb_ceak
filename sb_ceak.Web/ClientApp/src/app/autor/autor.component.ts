import { Component } from "@angular/core";

@Component({
  selector: "autor",
  template: "<html><body>{{obterNome()}}</body></html>"
  })

export class AutorComponent {
  public nome: string;

  public obterNome(): string {
    return "Emmanuel";
  }
}
