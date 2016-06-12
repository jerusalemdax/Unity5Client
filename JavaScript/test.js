var TestA = {
    fullname: "TestA",
    baseTypeName: "UnityEngine.MonoBehaviour",
    assemblyName: "SharpKitProj",
    Kind: "Class",
    definition: {
        ctor: function (){
            this.valueOfA = 0;
            UnityEngine.MonoBehaviour.ctor.call(this);
        },
        Awake: function (){
            UnityEngine.MonoBehaviour.print(System.String.Format$$String$$Object$$Object("ping test"));
        }
    }
};
JsTypes.push(TestA);