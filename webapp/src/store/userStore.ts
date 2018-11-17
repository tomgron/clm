import {observable, action} from 'mobx'

export interface IUserStore {
    users:IUser[]
    addUser(user:IUser):void

}

export interface IUser {
    userName:string,
    password:string,
    token:string
}
export class UserStore implements IUserStore {
    @observable public users:User[] = []
    @action addUser = (user:IUser) => this.users.push(user)
}

export class User implements IUser {
    userName:string = ""
    password:string = ""
    token:string = ""
}