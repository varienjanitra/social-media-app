import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from '../data/user.model';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private httpService = inject(HttpClient);

  baseUrl = 'http://localhost:5077';

  getUsers$(): Observable<User[]> {
    return this.httpService.get<User[]>(this.baseUrl + '/Users')
  }

}
