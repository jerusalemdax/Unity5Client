CS.require("Clr/jsclr");
CS.require("Clr/clrlibrary");
CS.require("GeneratedFiles");
CS.require("Controller/UpdateController");
CS.require("Controller/LoginController");
CS.require("Clr/myclrhandler");

//为了在editor下可以直接跑其他场景，所以只有场景为Start的时候才切换为Update
if (SceneManagerEx.get_Instance().GetShowedSceneName() == "Start")
{
    SceneManagerEx.get_Instance().ShowScene("Update");
}


