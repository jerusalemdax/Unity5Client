Unity 5 客户端工程

环境：
Unity 5.3.5
pomelo 1.2.3

支持Javascript和assetbundle资源热更新

客户端：

运行方法：

1.先用Unity打开工程

2.点击菜单上的JSB->Generate JS and CS Binding 生成js绑定

3.点击菜单上的Build->Build Script生成库文件

4.选择Assetbundle->Simulator Mode 或者 点击Assetbundle->Build Assetbundles生成资源

5.运行工程

服务端：

游戏服务端：

1.安装node和pomelo

2.进入Server, 执行npm-install.sh(.bat)

3.进入Server/game-server，执行pomelo start