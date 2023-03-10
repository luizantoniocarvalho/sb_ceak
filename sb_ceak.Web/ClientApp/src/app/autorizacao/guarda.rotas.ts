import { Injectable } from '@angular/core';
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
  })

export class GuardaRotas implements CanActivate {

  constructor(private router: Router) {

  }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
    var autenticado = sessionStorage.getItem("usuario-autenticado");

    if (autenticado == "1")
    {
      return true;
    }

    this.router.navigate(['/entrar'], { queryParams: { returnUrl: state.url } });
        //se usuário autenticado
    return false;
    }

}
