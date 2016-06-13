CS.require("Clr/jsclr");
CS.require("Clr/clrlibrary");
CS.require("GeneratedFiles");
CS.require("test");
CS.require("Clr/myclrhandler");
HttpManager.get_Instance().StartHttpGet("http://www.baidu.com", function(str) {
	print(str);
});
UIManager.get_Instance().ShowPanel("UpdatePanel");
SceneManagerEx.get_Instance().ShowScene("Login");

