import { Component, OnInit } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { Pessoa } from "../../modelo/pessoa";

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})

export class LoginComponent implements OnInit {  
  public titulo = "Biblioteca do Centro Espírita Allan Kardec";
  public pessoa;
  public returnUrl: string;

  //public usuarioAutenticado: boolean;

  constructor(private router: Router, private activatedRouter: ActivatedRoute) {        

  }

    ngOnInit(): void {
      this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
      this.pessoa = new Pessoa();
    }

  entrar() {
    /*if (this.pessoa.ds_Email_Pessoa == "luiac13@hotmail.com" && this.pessoa.ds_Senha_Pessoa == "abc123")
    {
      this.usuarioAutenticado = true;
    }*/

    if (this.pessoa.ds_Email_Pessoa == "luiac13@hotmail.com" && this.pessoa.ds_Senha_Pessoa == "abc123")
    {
      sessionStorage.setItem("usuario-autenticado", "1");

      this.router.navigate([this.returnUrl]);
    }

  }

}
