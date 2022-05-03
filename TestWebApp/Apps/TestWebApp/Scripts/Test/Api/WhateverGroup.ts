// Generated code

import { AppApiGroup } from "@jasonbenfield/sharedwebapp/Api/AppApiGroup";
import { AppApiAction } from "@jasonbenfield/sharedwebapp/Api/AppApiAction";
import { AppApiView } from "@jasonbenfield/sharedwebapp/Api/AppApiView";
import { AppApiEvents } from "@jasonbenfield/sharedwebapp/Api/AppApiEvents";
import { AppResourceUrl } from "@jasonbenfield/sharedwebapp/Api/AppResourceUrl";

export class WhateverGroup extends AppApiGroup {
	constructor(events: AppApiEvents, resourceUrl: AppResourceUrl) {
		super(events, resourceUrl, 'Whatever');
		this.DoSomethingAction = this.createAction<IEmptyRequest,IEmptyActionResult>('DoSomething', 'Do Something');
	}
	
	readonly DoSomethingAction: AppApiAction<IEmptyRequest,IEmptyActionResult>;
	
	DoSomething(errorOptions?: IActionErrorOptions) {
		return this.DoSomethingAction.execute({}, errorOptions || {});
	}
}