var UpdateController = {
    fullname: "UpdateController",
    definition: {
        Start: function(){
            print("UpdateController Start");
			UIManager.get_Instance().ShowPanel("UpdatePanel");
            ProtocalManager.get_Instance().Request("connector.entryHandler.version", "hello", function(str) {
                print(str);
				SceneManagerEx.get_Instance().ShowScene("Login");
            });
        },
		OnDestroy: function(){
			print("UpdateController OnDestroy");
			UIManager.get_Instance().ClosePanel("UpdatePanel");
		}
    }
};
JsTypes.push(UpdateController);