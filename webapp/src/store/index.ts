import {observable, action} from 'mobx'
import {IUser, UserStore, User} from './userStore'
/* Interfaces */

export interface IAllStores {
    userStore:UserStore
}

/* Classes */
export class AllStores implements IAllStores {
    public userStore:UserStore = new UserStore();
}

/* Ready made instance export */ 
export const allStores = new AllStores()