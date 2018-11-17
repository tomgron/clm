import { CertificateStore } from "./certificateStore";
import { UserStore } from "./userStore";

/* Interfaces */

export interface IAllStores {
  userStore: UserStore;
  certificateStore: CertificateStore;
}

/* Classes */
export class AllStores implements IAllStores {
  public userStore: UserStore = new UserStore();
  public certificateStore = new CertificateStore();
}

/* Ready made instance export */

export const allStores = new AllStores();
