import { observable, action } from "mobx";

export interface UserStoreInterface {
  users: User[];
  addUser(user: User): void;
}

export interface UserInterface {
  userName: string;
  password: string;
  token: string;
}
export class UserStore implements UserStoreInterface {
  @observable public users: User[] = [];
  @action addUser = (user: UserInterface) => this.users.push(user);
}

export class User implements UserInterface {
  userName = "";
  password = "";
  token = "";
}
