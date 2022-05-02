// Generated code

import { AppApiGroup } from "@jasonbenfield/sharedwebapp/Api/AppApiGroup";
import { AppApiAction } from "@jasonbenfield/sharedwebapp/Api/AppApiAction";
import { AppApiView } from "@jasonbenfield/sharedwebapp/Api/AppApiView";
import { AppApiEvents } from "@jasonbenfield/sharedwebapp/Api/AppApiEvents";
import { AppResourceUrl } from "@jasonbenfield/sharedwebapp/Api/AppResourceUrl";

export class HomeGroup extends AppApiGroup {
	constructor(events: AppApiEvents, resourceUrl: AppResourceUrl) {
		super(events, resourceUrl, 'Home');
		this.Index = this.createView<IEmptyRequest>('Index');
		this.LoginAction = this.createAction<ITestAuthLoginRequest,string>('Login', 'Login');
	}
	
	readonly Index: AppApiView<IEmptyRequest>;
	readonly LoginAction: AppApiAction<ITestAuthLoginRequest,string>;
	
	Login(model: ITestAuthLoginRequest, errorOptions?: IActionErrorOptions) {
		return this.LoginAction.execute(model, errorOptions || {});
	}
}