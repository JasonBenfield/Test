import { HubAppApi } from '@jasonbenfield/hubwebapp/Api/HubAppApi';
import { PostToLogin } from '@jasonbenfield/hubwebapp/PostToLogin';
import { AsyncCommand } from '@jasonbenfield/sharedwebapp/Command/AsyncCommand';
import { TextInputFormGroup } from '@jasonbenfield/sharedwebapp/Forms/TextInputFormGroup';
import { TextBlock } from '@jasonbenfield/sharedwebapp/Html/TextBlock';
import { MessageAlert } from '@jasonbenfield/sharedwebapp/MessageAlert';
import { PageFrameView } from '@jasonbenfield/sharedwebapp/PageFrameView';
import { Startup } from '@jasonbenfield/sharedwebapp/Startup';
import { TestAuthAppApi } from '../../TestAuth/Api/TestAuthAppApi';
import { Apis } from '../Apis';
import { MainPageView } from './MainPageView';

class MainPage {
    private readonly testAuthApi: TestAuthAppApi;
    private readonly hubApi: HubAppApi;
    private readonly view: MainPageView;
    private readonly userName: TextInputFormGroup;
    private readonly password: TextInputFormGroup;
    private readonly loginCommand: AsyncCommand;
    private readonly alert: MessageAlert;

    constructor(page: PageFrameView) {
        this.view = new MainPageView(page);
        new TextBlock('External Login', this.view.heading);
        let apis = new Apis(page.modalError);
        this.hubApi = apis.Hub();
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
            let authKey = await this.testAuthApi.Home.Login(loginRequest);
            if (authKey) {
                this.alert.info('Opening page...');
                new PostToLogin(this.hubApi).execute(loginRequest, authKey);
            }
        }
        finally {
            this.alert.clear();
        }
    }
}
new MainPage(new Startup().build());