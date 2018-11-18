import { observable, action } from "mobx";

export interface CertificateStoreInterface {
  certificates: Certificate[];
}

export interface CertificateInterface {
  name: string;
  thumbprint: string;
  validFrom: number;
  validTo: number;
}

export class CertificateStore implements CertificateStoreInterface {
  @observable public certificates: CertificateInterface[] = [];
  @action addCertificate = (certificate: CertificateInterface): void => {
    this.certificates.push(certificate);
  };
  @action removeCertificate = (thumbprint: string): void => {
    this.certificates = this.certificates.filter((i: CertificateInterface) => i.thumbprint !== thumbprint);
  };
}

export class Certificate implements CertificateInterface {
  @observable public name = "";
  @observable public thumbprint = "";
  @observable public validFrom: number;
  @observable public validTo: number;

  constructor(name: string, thumbprint: string, validFrom: number, validTo: number) {
    this.name = name;
    this.thumbprint = thumbprint;
    this.validFrom = validFrom;
    this.validTo = validTo;
  }
}
