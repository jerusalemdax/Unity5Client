var LoginController = {
    fullname: "LoginController",
    definition: {
        Start: function(){
            print("LoginController Start");
			UIManager.get_Instance().ShowPanel("LoginPanel");
        },
		OnDestroy: function(){
			print("LoginController OnDestroy");
			UIManager.get_Instance().ClosePanel("LoginPanel");
		},
		EnterGame: function(){
			print("Enter Game")
			SceneManagerEx.get_Instance().ShowScene("2DCharacter");
		}
    }
};
JsTypes.push(LoginController);