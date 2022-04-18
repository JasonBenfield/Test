import { AppApiFactory } from "@jasonbenfield/sharedwebapp/Api/AppApiFactory";
import { ModalErrorComponent } from "@jasonbenfield/sharedwebapp/Error/ModalErrorComponent";
import { ModalErrorComponentView } from "@jasonbenfield/sharedwebapp/Error/ModalErrorComponentView";
import { TestAppApi } from "../Test/Api/TestAppApi";

export class Apis {
    private readonly modalError: ModalErrorComponent;

    constructor(modalError: ModalErrorComponentView) {
        this.modalError = new ModalErrorComponent(modalError);
    }

    Test() {
        let apiFactory = new AppApiFactory(this.modalError)
        return apiFactory.api(TestAppApi);
    }
}