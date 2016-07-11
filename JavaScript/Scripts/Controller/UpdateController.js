var UpdateController = {
    fullname: "UpdateController",
    definition: {
        Start: function(){
            print("UpdateController Start");
			UIManager.get_Instance().ShowPanel("UpdatePanel", this.LateStart);
        },
        LateStart: function()
        {
            ProtocalManager.get_Instance().Request("connector.entryHandler.version", "", function(str) {
                var jsonData = JSON.parse(str);
                if (jsonData["code"] == 200)
                {
                    SceneManagerEx.get_Instance().ShowScene("Login");
                }
                else
                {
                    var statusText = UnityEngine.GameObject.Find("StatusText").GetComponent$$String("UnityEngine.UI.Text");
                    statusText.set_text("Server connect failed");
                }

            });
        },
		OnDestroy: function(){
			print("UpdateController OnDestroy");
			UIManager.get_Instance().ClosePanel("UpdatePanel");
		}
    }
};
JsTypes.push(UpdateController);