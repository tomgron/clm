import { observable, action } from "mobx";

export interface ICertificateStore {
  certificates: ICertificate[];
}

export interface ICertificate {
  name: string;
  thumbprint: string;
  validFrom: number;
  validTo: number;
}

export class CertificateStore implements ICertificateStore {
  @observable public certificates: ICertificate[] = [];
  @action addCertificate = (certificate: ICertificate) => this.certificates.push(certificate);
}

export class Certificate implements ICertificate {
  @observable public name: string = "";
  @observable public thumbprint: string = "";
  @observable public validFrom: number;
  @observable public validTo: number;

  constructor(name: string, thumbprint: string, validFrom: number, validTo: number) {
    this.name = name;
    this.thumbprint = thumbprint;
    this.validFrom = validFrom;
    this.validTo = validTo;
  }
}
