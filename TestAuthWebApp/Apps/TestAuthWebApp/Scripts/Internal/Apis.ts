import { HubAppApi } from "@jasonbenfield/hubwebapp/Api/HubAppApi";
import { AppApiFactory } from "@jasonbenfield/sharedwebapp/Api/AppApiFactory";
import { ModalErrorComponent } from "@jasonbenfield/sharedwebapp/Error/ModalErrorComponent";
import { ModalErrorComponentView } from "@jasonbenfield/sharedwebapp/Error/ModalErrorComponentView";
import { TestAuthAppApi } from "../TestAuth/Api/TestAuthAppApi";

export class Apis {
    private readonly modalError: ModalErrorComponent;

    constructor(modalError: ModalErrorComponentView) {
        this.modalError = new ModalErrorComponent(modalError);
    }

    Hub() {
        let apiFactory = new AppApiFactory(this.modalError)
        return apiFactory.api(HubAppApi);
    }

    TestAuth() {
        let apiFactory = new AppApiFactory(this.modalError)
        return apiFactory.api(TestAuthAppApi);
    }
}