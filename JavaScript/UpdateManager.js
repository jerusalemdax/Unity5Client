var UpdateManager = {
    fullname: "UpdateManager",
    definition: {
        Start: function (){
            print("UpdateManager Start");
            HttpManager.get_Instance().StartHttpGet("http://www.baidu.com", function(str) {
                print(str);
                UIManager.get_Instance().ShowPanel("UpdatePanel");
            });

        }
    }
};
JsTypes.push(UpdateManager);