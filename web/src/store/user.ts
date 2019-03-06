import {observable} from 'mobx'

export class UserStore {
  @observable
  public Users: Array<User> | undefined
}

export class User implements IUser {
  name: string | undefined;
  token: string | undefined;
  roles: string[] | undefined;
}

export interface IUser {
  name:string | undefined,
  token:string | undefined,
  roles:Array<string> | undefined
}
