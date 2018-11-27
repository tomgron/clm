import { RouterStore } from "mobx-react-router";
import { CertificateStore } from "./certificateStore";
import { UserStore } from "./userStore";

/* Interfaces */

export interface AllStoresInterface {
  userStore: UserStore;
  certificateStore: CertificateStore;
}

/* Classes */
export class AllStores implements AllStoresInterface {
  public userStore: UserStore = new UserStore();
  public certificateStore = new CertificateStore();
  public routingStore = new RouterStore();
}

/* Ready made instance export */

export const allStores = new AllStores();
