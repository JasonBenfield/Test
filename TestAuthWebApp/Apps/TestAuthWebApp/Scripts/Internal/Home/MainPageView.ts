import { ButtonCommandItem } from '@jasonbenfield/sharedwebapp/Command/ButtonCommandItem';
import { ContextualClass } from '@jasonbenfield/sharedwebapp/ContextualClass';
import { InputFormGroupView } from '@jasonbenfield/sharedwebapp/Forms/InputFormGroupView';
import { FormView } from '@jasonbenfield/sharedwebapp/Html/FormView';
import { TextHeading1View } from '@jasonbenfield/sharedwebapp/Html/TextHeading1View';
import { MessageAlertView } from '@jasonbenfield/sharedwebapp/MessageAlertView';
import { PageFrameView } from '@jasonbenfield/sharedwebapp/PageFrameView';

export class MainPageView {
    readonly heading: ITextComponentView;
    readonly userName: InputFormGroupView;
    readonly password: InputFormGroupView;
    readonly submitButton: ButtonCommandItem;
    readonly formSubmitted: IEventHandler<any>;
    readonly alert: MessageAlertView;

    constructor(page: PageFrameView) {
        this.heading = page.addContent(new TextHeading1View());
        let form = page.addContent(new FormView());
        this.userName = form.addContent(new InputFormGroupView());
        this.password = form.addContent(new InputFormGroupView());
        this.submitButton = form.addContent(new ButtonCommandItem());
        this.submitButton.setText('Login');
        this.submitButton.changeTypeToSubmit();
        this.submitButton.useOutlineStyle();
        this.submitButton.setContext(ContextualClass.primary);
        this.alert = page.addContent(new MessageAlertView());
        this.formSubmitted = form.submitted;
    }
}