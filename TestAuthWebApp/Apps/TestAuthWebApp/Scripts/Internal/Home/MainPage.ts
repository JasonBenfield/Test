import { Startup } from '@jasonbenfield/sharedwebapp/Startup';
import { PageFrameView } from '@jasonbenfield/sharedwebapp/PageFrameView';
import { MainPageView } from './MainPageView';
import { TextBlock } from '@jasonbenfield/sharedwebapp/Html/TextBlock';
import { TextInputFormGroup } from '@jasonbenfield/sharedwebapp/Forms/TextInputFormGroup';
import { AsyncCommand } from '@jasonbenfield/sharedwebapp/Command/AsyncCommand';
import { MessageAlert } from '@jasonbenfield/sharedwebapp/MessageAlert';
import { TestAuthAppApi } from '../../TestAuth/Api/TestAuthAppApi';
import { Apis } from '../Apis';
import { UrlBuilder } from '@jasonbenfield/sharedwebapp/UrlBuilder';
import { HubAppApi } from '@jasonbenfield/hubwebapp/Api/HubAppApi';

class MainPage {
    private readonly testAuthApi: TestAuthAppApi;
    private readonly hubApi: HubAppApi;
    private readonly view: MainPageView;
    private readonly userName: TextInputFormGroup;
    private readonly password: TextInputFormGroup;
    private readonly loginCommand: AsyncCommand;
    private readonly alert: MessageAlert;

    constructor(page: PageFrameView) {
        new TextBlock('External Login', this.view.heading);
        this.view = new MainPageView(page);
        let apis = new Apis(page.modalError);
        this.testAuthApi = apis.TestAuth();
        this.userName = new TextInputFormGroup('', 'UserName', this.view.userName);
        this.password = new TextInputFormGroup('', 'Password', this.view.password);
        this.view.formSubmitted.register(this.onFormSubmitted.bind(this));
        this.loginCommand = new AsyncCommand(this.login.bind(this));
        this.alert = new MessageAlert(this.view.alert);
    }

    private onFormSubmitted() {
        return this.loginCommand.execute();
    }

    private async login() {
        this.alert.info('Verifying login...');
        try {
            let loginRequest: ITestAuthLoginRequest = {
                UserName: this.userName.getValue(),
                Password: this.password.getValue()
            };
            let result = await this.testAuthApi.Home.Login(loginRequest);
            if (result) {
                this.alert.info('Opening page...');
                this.postLogin(loginRequest, result);
            }
        }
        finally {
            this.alert.clear();
        }
    }

    private postLogin(loginRequest: ITestAuthLoginRequest, authKey: string) {
        let form = <HTMLFormElement>document.createElement('form');
        form.action = this.hubApi.Auth.Login
            .getUrl(null)
            .value();
        form.style.position = 'absolute';
        form.style.top = '-100px';
        form.style.left = '-100px';
        form.method = 'POST';
        let userNameInput = this.createInput('UserName', loginRequest.UserName, 'text');
        let passwordInput = this.createInput('Password', loginRequest.Password, 'password');
        let authKeyInput = this.createInput('AuthKey', authKey, 'text');
        let urlBuilder = UrlBuilder.current();
        let returnKeyInput = this.createInput('ReturnKey', urlBuilder.getQueryValue('returnKey'));
        form.append(
            userNameInput,
            passwordInput,
            authKeyInput,
            returnKeyInput
        );
        document.body.append(form);
        form.submit();
    }

    private createInput(name: string, value: string, type: string = 'hidden') {
        let input = <HTMLInputElement>document.createElement('input');
        input.type = type;
        input.name = name;
        input.value = value;
        return input;
    }
}
new MainPage(new Startup().build());