var UpdateController = {
    fullname: "UpdateController",
    definition: {
        Start: function(){
            print("UpdateManager Start");
			UIManager.get_Instance().ShowPanel("UpdatePanel");
            HttpManager.get_Instance().StartHttpGet("http://www.baidu.com", function(str) {
				SceneManagerEx.get_Instance().ShowScene("Login");
            });
        },
		OnDestroy: function(){
			print("Update Manager OnDestroy");
			UIManager.get_Instance().ClosePanel("UpdatePanel");
		}
    }
};
JsTypes.push(UpdateController);