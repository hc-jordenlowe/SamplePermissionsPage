import { Component } from '@angular/core';
import { authorizePermissions } from '../shared/models/authorize-permissions';
import { AuthorizationPermissions } from '../shared/models/authorization-permissions.enum';


@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html'
})
export class CounterComponent {
  public currentCount = 0;

  @authorizePermissions([AuthorizationPermissions.canBeUnicorn])
  public incrementCounter() {
    this.currentCount++;
  }
}
