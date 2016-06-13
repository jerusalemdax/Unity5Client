var UpdateManager = {
    fullname: "UpdateManager",
    definition: {
        Start: function (){
            print("UpdateManager Start");
            UIManager.get_Instance().ShowPanel("UpdatePanel");
        }
    }
};
JsTypes.push(UpdateManager);