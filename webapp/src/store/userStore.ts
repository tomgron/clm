import { observable, action } from "mobx";

export interface UserStoreInterface {
  users: User[];
  loggedInUser?: UserInterface;
  loggedInReturnUrl?: string;

  addUser(user: User): void;
  login(username: string, password: string);
  logout();
}

export interface UserInterface {
  userName: string;
  accessToken: string;
  idToken: string;
  expiresAt: string;
}
export class UserStore implements UserStoreInterface {
  @observable public users: User[] = [];
  @observable public loggedInUser?;
  @observable public loggedInReturnUrl;

  @action addUser = (user: UserInterface) => this.users.push(user);
  @action logout = () => (this.loggedInUser = undefined);
  @action login = (username: string, password: string) => {
    this.loggedInUser = new User();
    this.loggedInUser.userName = username;
  };
}

export class User implements UserInterface {
  userName = "";
  accessToken = "";
  idToken = "";
  expiresAt = "";

  // constructor(userName: string, accessToken: string, idToken: string, expiresAt: string) {
  //   this.userName = userName;
  //   this.accessToken = accessToken;
  //   this.idToken = idToken;
  //   this.expiresAt = expiresAt;
  // }
}
