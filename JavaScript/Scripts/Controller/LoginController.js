var LoginController = {
    fullname: "LoginController",
    definition: {
        Start: function(){
            print("LoginController Start");
        },
		OnDestroy: function(){
			print("LoginController OnDestroy");
		}
    }
};
JsTypes.push(LoginController);