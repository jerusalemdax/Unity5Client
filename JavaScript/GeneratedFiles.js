this.Enum = {};

if (typeof(JsTypes) == "undefined")
    var JsTypes = [];

// SceneManagerEx
_jstype =
{
    definition: {},
    staticDefinition: {},
    fields: {},
    staticFields: {},
    assemblyName: "",
    Kind: "Class",
    fullname: "SceneManagerEx", 
    baseTypeName: "System.Object"
};

var _found = false;
for (var i = 0; i < JsTypes.length; i++) {
    if (JsTypes[i].fullname == _jstype.fullname) {
        JsTypes[i] = _jstype;
        _found = true;
        break;
    }
}
if (!_found) {
    JsTypes.push(_jstype);
}


_jstype.definition.ctor = function() { CS.Call(5, 0, 0, true, this); }

// fields

// properties

_jstype.staticDefinition.get_Instance = function() { return CS.Call(2, 0, 0, true); }
_jstype.staticDefinition.set_Instance = function(v) { return CS.Call(3, 0, 0, true, v); }

// methods

/* Void */
_jstype.definition.Init = function() {
    
    return CS.Call(4, 0, 0, false, this);
}
/* Void */
_jstype.definition.ShowScene = function(a0/*String*/) {
    
    return CS.Call(4, 0, 1, false, this, a0);
}

if (typeof(JsTypes) == "undefined")
    var JsTypes = [];

// UIManager
_jstype =
{
    definition: {},
    staticDefinition: {},
    fields: {},
    staticFields: {},
    assemblyName: "",
    Kind: "Class",
    fullname: "UIManager", 
    baseTypeName: "System.Object"
};

var _found = false;
for (var i = 0; i < JsTypes.length; i++) {
    if (JsTypes[i].fullname == _jstype.fullname) {
        JsTypes[i] = _jstype;
        _found = true;
        break;
    }
}
if (!_found) {
    JsTypes.push(_jstype);
}


_jstype.definition.ctor = function() { CS.Call(5, 1, 0, true, this); }

// fields

// properties

_jstype.staticDefinition.get_Instance = function() { return CS.Call(2, 1, 0, true); }
_jstype.staticDefinition.set_Instance = function(v) { return CS.Call(3, 1, 0, true, v); }

// methods

/* Void */
_jstype.definition.ClosePanel = function(a0/*String*/) {
    
    return CS.Call(4, 1, 0, false, this, a0);
}
/* Void */
_jstype.definition.Init = function() {
    
    return CS.Call(4, 1, 1, false, this);
}
/* Void */
_jstype.definition.ShowPanel = function(a0/*String*/) {
    
    return CS.Call(4, 1, 2, false, this, a0);
}

if (typeof(JsTypes) == "undefined")
    var JsTypes = [];

// HttpManager
_jstype =
{
    definition: {},
    staticDefinition: {},
    fields: {},
    staticFields: {},
    assemblyName: "",
    Kind: "Class",
    fullname: "HttpManager", 
    baseTypeName: "System.Object"
};

var _found = false;
for (var i = 0; i < JsTypes.length; i++) {
    if (JsTypes[i].fullname == _jstype.fullname) {
        JsTypes[i] = _jstype;
        _found = true;
        break;
    }
}
if (!_found) {
    JsTypes.push(_jstype);
}


_jstype.definition.ctor = function() { CS.Call(5, 2, 0, true, this); }

// fields

// properties

_jstype.staticDefinition.get_Instance = function() { return CS.Call(2, 2, 0, true); }
_jstype.staticDefinition.set_Instance = function(v) { return CS.Call(3, 2, 0, true, v); }

// methods

/* Void */
_jstype.definition.StartHttpGet = function(a0/*String*/, a1/*Action`1*/) {
    
    return CS.Call(4, 2, 0, false, this, a0, a1);
}

if (typeof(JsTypes) == "undefined")
    var JsTypes = [];

// UnityEngine$MonoBehaviour
_jstype =
{
    definition: {},
    staticDefinition: {},
    fields: {},
    staticFields: {},
    assemblyName: "",
    Kind: "Class",
    fullname: "UnityEngine.MonoBehaviour", 
    baseTypeName: "UnityEngine.Behaviour"
};

var _found = false;
for (var i = 0; i < JsTypes.length; i++) {
    if (JsTypes[i].fullname == _jstype.fullname) {
        JsTypes[i] = _jstype;
        _found = true;
        break;
    }
}
if (!_found) {
    JsTypes.push(_jstype);
}



// fields

// properties

_jstype.definition.get_useGUILayout = function() { return CS.Call(2, 3, 0, false, this); }
_jstype.definition.set_useGUILayout = function(v) { return CS.Call(3, 3, 0, false, this, v); }

// methods

/* Void */
_jstype.definition.CancelInvoke$$String = function(a0/*String*/) {
    
    return CS.Call(4, 3, 0, false, this, a0);
}
/* Void */
_jstype.definition.CancelInvoke = function() {
    
    return CS.Call(4, 3, 1, false, this);
}
/* Void */
_jstype.definition.Invoke = function(a0/*String*/, a1/*Single*/) {
    
    return CS.Call(4, 3, 2, false, this, a0, a1);
}
/* Void */
_jstype.definition.InvokeRepeating = function(a0/*String*/, a1/*Single*/, a2/*Single*/) {
    
    return CS.Call(4, 3, 3, false, this, a0, a1, a2);
}
/* Boolean */
_jstype.definition.IsInvoking$$String = function(a0/*String*/) {
    
    return CS.Call(4, 3, 4, false, this, a0);
}
/* Boolean */
_jstype.definition.IsInvoking = function() {
    
    return CS.Call(4, 3, 5, false, this);
}
/* Coroutine */
_jstype.definition.StartCoroutine$$String$$Object = function(a0/*String*/, a1/*Object*/) {
    
    return CS.Call(4, 3, 6, false, this, a0, a1);
}
/* Coroutine */
_jstype.definition.StartCoroutine$$String = function(a0/*String*/) {
    
    return CS.Call(4, 3, 7, false, this, a0);
}
/* Coroutine */
_jstype.definition.StartCoroutine$$IEnumerator = function(a0/*IEnumerator*/) {
    
    return CS.Call(4, 3, 8, false, this, a0);
}
/* Coroutine */
_jstype.definition.StartCoroutine_Auto = function(a0/*IEnumerator*/) {
    
    return CS.Call(4, 3, 9, false, this, a0);
}
/* Void */
_jstype.definition.StopAllCoroutines = function() {
    
    return CS.Call(4, 3, 10, false, this);
}
/* Void */
_jstype.definition.StopCoroutine$$Coroutine = function(a0/*Coroutine*/) {
    
    return CS.Call(4, 3, 11, false, this, a0);
}
/* Void */
_jstype.definition.StopCoroutine$$String = function(a0/*String*/) {
    
    return CS.Call(4, 3, 12, false, this, a0);
}
/* Void */
_jstype.definition.StopCoroutine$$IEnumerator = function(a0/*IEnumerator*/) {
    
    return CS.Call(4, 3, 13, false, this, a0);
}
/* static Void  */
_jstype.staticDefinition.print = function(a0/*Object*/) {
    
    return CS.Call(4, 3, 14, true, a0);
}

if (typeof(JsTypes) == "undefined")
    var JsTypes = [];

// UnityEngine$Behaviour
_jstype =
{
    definition: {},
    staticDefinition: {},
    fields: {},
    staticFields: {},
    assemblyName: "",
    Kind: "Class",
    fullname: "UnityEngine.Behaviour", 
    baseTypeName: "UnityEngine.Component"
};

var _found = false;
for (var i = 0; i < JsTypes.length; i++) {
    if (JsTypes[i].fullname == _jstype.fullname) {
        JsTypes[i] = _jstype;
        _found = true;
        break;
    }
}
if (!_found) {
    JsTypes.push(_jstype);
}


_jstype.definition.ctor = function() { CS.Call(5, 4, 0, true, this); }

// fields

// properties

_jstype.definition.get_enabled = function() { return CS.Call(2, 4, 0, false, this); }
_jstype.definition.set_enabled = function(v) { return CS.Call(3, 4, 0, false, this, v); }

_jstype.definition.get_isActiveAndEnabled = function() { return CS.Call(2, 4, 1, false, this); }
_jstype.definition.set_isActiveAndEnabled = function(v) { return CS.Call(3, 4, 1, false, this, v); }

// methods


if (typeof(JsTypes) == "undefined")
    var JsTypes = [];

// UnityEngine$Component
_jstype =
{
    definition: {},
    staticDefinition: {},
    fields: {},
    staticFields: {},
    assemblyName: "",
    Kind: "Class",
    fullname: "UnityEngine.Component", 
    baseTypeName: "UnityEngine.Object"
};

var _found = false;
for (var i = 0; i < JsTypes.length; i++) {
    if (JsTypes[i].fullname == _jstype.fullname) {
        JsTypes[i] = _jstype;
        _found = true;
        break;
    }
}
if (!_found) {
    JsTypes.push(_jstype);
}


_jstype.definition.ctor = function() { CS.Call(5, 5, 0, true, this); }

// fields

// properties

_jstype.definition.get_transform = function() { return CS.Call(2, 5, 0, false, this); }
_jstype.definition.set_transform = function(v) { return CS.Call(3, 5, 0, false, this, v); }

_jstype.definition.get_gameObject = function() { return CS.Call(2, 5, 1, false, this); }
_jstype.definition.set_gameObject = function(v) { return CS.Call(3, 5, 1, false, this, v); }

_jstype.definition.get_tag = function() { return CS.Call(2, 5, 2, false, this); }
_jstype.definition.set_tag = function(v) { return CS.Call(3, 5, 2, false, this, v); }

// methods

/* Void */
_jstype.definition.BroadcastMessage$$String$$Object$$SendMessageOptions = function(a0/*String*/, a1/*Object*/, a2/*SendMessageOptions*/) {
    
    return CS.Call(4, 5, 0, false, this, a0, a1, a2);
}
/* Void */
_jstype.definition.BroadcastMessage$$String$$Object = function(a0/*String*/, a1/*Object*/) {
    
    return CS.Call(4, 5, 1, false, this, a0, a1);
}
/* Void */
_jstype.definition.BroadcastMessage$$String$$SendMessageOptions = function(a0/*String*/, a1/*SendMessageOptions*/) {
    
    return CS.Call(4, 5, 2, false, this, a0, a1);
}
/* Void */
_jstype.definition.BroadcastMessage$$String = function(a0/*String*/) {
    
    return CS.Call(4, 5, 3, false, this, a0);
}
/* Boolean */
_jstype.definition.CompareTag = function(a0/*String*/) {
    
    return CS.Call(4, 5, 4, false, this, a0);
}
/* Component */
_jstype.definition.GetComponent$$Type = function(a0/*Type*/) {
    
    return CS.Call(4, 5, 5, false, this, a0);
}
/* Component */
_jstype.definition.GetComponent$$String = function(a0/*String*/) {
    
    return CS.Call(4, 5, 6, false, this, a0);
}
/* T */
_jstype.definition.GetComponent$1 = function(t0) {
        var native_t0 = t0.getNativeType();

    return CS.Call(4, 5, 7, false, this, native_t0);
}
/* Component */
_jstype.definition.GetComponentInChildren$$Type$$Boolean = function(a0/*Type*/, a1/*Boolean*/) {
    
    return CS.Call(4, 5, 8, false, this, a0, a1);
}
/* T */
_jstype.definition.GetComponentInChildren$1$$Boolean = function(t0, a0/*Boolean*/) {
        var native_t0 = t0.getNativeType();

    return CS.Call(4, 5, 9, false, this, native_t0, a0);
}
/* Component */
_jstype.definition.GetComponentInChildren$$Type = function(a0/*Type*/) {
    
    return CS.Call(4, 5, 10, false, this, a0);
}
/* T */
_jstype.definition.GetComponentInChildren$1 = function(t0) {
        var native_t0 = t0.getNativeType();

    return CS.Call(4, 5, 11, false, this, native_t0);
}
/* Component */
_jstype.definition.GetComponentInParent$$Type = function(a0/*Type*/) {
    
    return CS.Call(4, 5, 12, false, this, a0);
}
/* T */
_jstype.definition.GetComponentInParent$1 = function(t0) {
        var native_t0 = t0.getNativeType();

    return CS.Call(4, 5, 13, false, this, native_t0);
}
/* Void */
_jstype.definition.GetComponents$$Type$$List$1$Component = function(a0/*Type*/, a1/*List`1*/) {
    
    return CS.Call(4, 5, 14, false, this, a0, a1);
}
/* Void */
_jstype.definition.GetComponents$1$$List$1 = function(t0, a0/*List`1*/) {
        var native_t0 = t0.getNativeType();

    return CS.Call(4, 5, 15, false, this, native_t0, a0);
}
/* Component[] */
_jstype.definition.GetComponents$$Type = function(a0/*Type*/) {
    
    return CS.Call(4, 5, 16, false, this, a0);
}
/* T[] */
_jstype.definition.GetComponents$1 = function(t0) {
        var native_t0 = t0.getNativeType();

    return CS.Call(4, 5, 17, false, this, native_t0);
}
/* Component[] */
_jstype.definition.GetComponentsInChildren$$Type$$Boolean = function(a0/*Type*/, a1/*Boolean*/) {
    
    return CS.Call(4, 5, 18, false, this, a0, a1);
}
/* Void */
_jstype.definition.GetComponentsInChildren$1$$Boolean$$List$1 = function(t0, a0/*Boolean*/, a1/*List`1*/) {
        var native_t0 = t0.getNativeType();

    return CS.Call(4, 5, 19, false, this, native_t0, a0, a1);
}
/* Component[] */
_jstype.definition.GetComponentsInChildren$$Type = function(a0/*Type*/) {
    
    return CS.Call(4, 5, 20, false, this, a0);
}
/* Void */
_jstype.definition.GetComponentsInChildren$1$$List$1 = function(t0, a0/*List`1*/) {
        var native_t0 = t0.getNativeType();

    return CS.Call(4, 5, 21, false, this, native_t0, a0);
}
/* T[] */
_jstype.definition.GetComponentsInChildren$1$$Boolean = function(t0, a0/*Boolean*/) {
        var native_t0 = t0.getNativeType();

    return CS.Call(4, 5, 22, false, this, native_t0, a0);
}
/* T[] */
_jstype.definition.GetComponentsInChildren$1 = function(t0) {
        var native_t0 = t0.getNativeType();

    return CS.Call(4, 5, 23, false, this, native_t0);
}
/* Component[] */
_jstype.definition.GetComponentsInParent$$Type$$Boolean = function(a0/*Type*/, a1/*Boolean*/) {
    
    return CS.Call(4, 5, 24, false, this, a0, a1);
}
/* Void */
_jstype.definition.GetComponentsInParent$1$$Boolean$$List$1 = function(t0, a0/*Boolean*/, a1/*List`1*/) {
        var native_t0 = t0.getNativeType();

    return CS.Call(4, 5, 25, false, this, native_t0, a0, a1);
}
/* T[] */
_jstype.definition.GetComponentsInParent$1$$Boolean = function(t0, a0/*Boolean*/) {
        var native_t0 = t0.getNativeType();

    return CS.Call(4, 5, 26, false, this, native_t0, a0);
}
/* Component[] */
_jstype.definition.GetComponentsInParent$$Type = function(a0/*Type*/) {
    
    return CS.Call(4, 5, 27, false, this, a0);
}
/* T[] */
_jstype.definition.GetComponentsInParent$1 = function(t0) {
        var native_t0 = t0.getNativeType();

    return CS.Call(4, 5, 28, false, this, native_t0);
}
/* Void */
_jstype.definition.SendMessage$$String$$Object$$SendMessageOptions = function(a0/*String*/, a1/*Object*/, a2/*SendMessageOptions*/) {
    
    return CS.Call(4, 5, 29, false, this, a0, a1, a2);
}
/* Void */
_jstype.definition.SendMessage$$String$$SendMessageOptions = function(a0/*String*/, a1/*SendMessageOptions*/) {
    
    return CS.Call(4, 5, 30, false, this, a0, a1);
}
/* Void */
_jstype.definition.SendMessage$$String$$Object = function(a0/*String*/, a1/*Object*/) {
    
    return CS.Call(4, 5, 31, false, this, a0, a1);
}
/* Void */
_jstype.definition.SendMessage$$String = function(a0/*String*/) {
    
    return CS.Call(4, 5, 32, false, this, a0);
}
/* Void */
_jstype.definition.SendMessageUpwards$$String$$Object$$SendMessageOptions = function(a0/*String*/, a1/*Object*/, a2/*SendMessageOptions*/) {
    
    return CS.Call(4, 5, 33, false, this, a0, a1, a2);
}
/* Void */
_jstype.definition.SendMessageUpwards$$String$$Object = function(a0/*String*/, a1/*Object*/) {
    
    return CS.Call(4, 5, 34, false, this, a0, a1);
}
/* Void */
_jstype.definition.SendMessageUpwards$$String$$SendMessageOptions = function(a0/*String*/, a1/*SendMessageOptions*/) {
    
    return CS.Call(4, 5, 35, false, this, a0, a1);
}
/* Void */
_jstype.definition.SendMessageUpwards$$String = function(a0/*String*/) {
    
    return CS.Call(4, 5, 36, false, this, a0);
}

if (typeof(JsTypes) == "undefined")
    var JsTypes = [];

// UnityEngine$Object
_jstype =
{
    definition: {},
    staticDefinition: {},
    fields: {},
    staticFields: {},
    assemblyName: "",
    Kind: "Class",
    fullname: "UnityEngine.Object", 
    baseTypeName: "System.Object"
};

var _found = false;
for (var i = 0; i < JsTypes.length; i++) {
    if (JsTypes[i].fullname == _jstype.fullname) {
        JsTypes[i] = _jstype;
        _found = true;
        break;
    }
}
if (!_found) {
    JsTypes.push(_jstype);
}


_jstype.definition.ctor = function() { CS.Call(5, 6, 0, true, this); }

// fields

// properties

_jstype.definition.get_name = function() { return CS.Call(2, 6, 0, false, this); }
_jstype.definition.set_name = function(v) { return CS.Call(3, 6, 0, false, this, v); }

_jstype.definition.get_hideFlags = function() { return CS.Call(2, 6, 1, false, this); }
_jstype.definition.set_hideFlags = function(v) { return CS.Call(3, 6, 1, false, this, v); }

// methods

/* Boolean */
_jstype.definition.Equals = function(a0/*Object*/) {
    
    return CS.Call(4, 6, 0, false, this, a0);
}
/* Int32 */
_jstype.definition.GetHashCode = function() {
    
    return CS.Call(4, 6, 1, false, this);
}
/* Int32 */
_jstype.definition.GetInstanceID = function() {
    
    return CS.Call(4, 6, 2, false, this);
}
/* String */
_jstype.definition.toString = function() {
    
    return CS.Call(4, 6, 3, false, this);
}
/* static Void  */
_jstype.staticDefinition.Destroy$$Object$$Single = function(a0/*Object*/, a1/*Single*/) {
    
    return CS.Call(4, 6, 4, true, a0, a1);
}
/* static Void  */
_jstype.staticDefinition.Destroy$$Object = function(a0/*Object*/) {
    
    return CS.Call(4, 6, 5, true, a0);
}
/* static Void  */
_jstype.staticDefinition.DestroyImmediate$$Object$$Boolean = function(a0/*Object*/, a1/*Boolean*/) {
    
    return CS.Call(4, 6, 6, true, a0, a1);
}
/* static Void  */
_jstype.staticDefinition.DestroyImmediate$$Object = function(a0/*Object*/) {
    
    return CS.Call(4, 6, 7, true, a0);
}
/* static Void  */
_jstype.staticDefinition.DestroyObject$$Object$$Single = function(a0/*Object*/, a1/*Single*/) {
    
    return CS.Call(4, 6, 8, true, a0, a1);
}
/* static Void  */
_jstype.staticDefinition.DestroyObject$$Object = function(a0/*Object*/) {
    
    return CS.Call(4, 6, 9, true, a0);
}
/* static Void  */
_jstype.staticDefinition.DontDestroyOnLoad = function(a0/*Object*/) {
    
    return CS.Call(4, 6, 10, true, a0);
}
/* static Object  */
_jstype.staticDefinition.FindObjectOfType$$Type = function(a0/*Type*/) {
    
    return CS.Call(4, 6, 11, true, a0);
}
/* static T  */
_jstype.staticDefinition.FindObjectOfType$1 = function(t0) {
        var native_t0 = t0.getNativeType();

    return CS.Call(4, 6, 12, true, native_t0);
}
/* static Object[]  */
_jstype.staticDefinition.FindObjectsOfType$$Type = function(a0/*Type*/) {
    
    return CS.Call(4, 6, 13, true, a0);
}
/* static T[]  */
_jstype.staticDefinition.FindObjectsOfType$1 = function(t0) {
        var native_t0 = t0.getNativeType();

    return CS.Call(4, 6, 14, true, native_t0);
}
/* static Object  */
_jstype.staticDefinition.Instantiate$$Object$$Vector3$$Quaternion = function(a0/*Object*/, a1/*Vector3*/, a2/*Quaternion*/) {
    
    return CS.Call(4, 6, 15, true, a0, a1, a2);
}
/* static Object  */
_jstype.staticDefinition.Instantiate$$Object = function(a0/*Object*/) {
    
    return CS.Call(4, 6, 16, true, a0);
}
/* static T  */
_jstype.staticDefinition.Instantiate$1$$T = function(t0, a0/*T*/) {
        var native_t0 = t0.getNativeType();

    return CS.Call(4, 6, 17, true, native_t0, a0);
}
/* static Boolean  */
_jstype.staticDefinition.op_Equality = function(a0/*Object*/, a1/*Object*/) {
    
    return CS.Call(4, 6, 18, true, a0, a1);
}
/* static Boolean  */
_jstype.staticDefinition.op_Implicit = function(a0/*Object*/) {
    
    return CS.Call(4, 6, 19, true, a0);
}
/* static Boolean  */
_jstype.staticDefinition.op_Inequality = function(a0/*Object*/, a1/*Object*/) {
    
    return CS.Call(4, 6, 20, true, a0, a1);
}

if (typeof(JsTypes) == "undefined")
    var JsTypes = [];

// UnityEngine$Debug
_jstype =
{
    definition: {},
    staticDefinition: {},
    fields: {},
    staticFields: {},
    assemblyName: "",
    Kind: "Class",
    fullname: "UnityEngine.Debug", 
    baseTypeName: "System.Object"
};

var _found = false;
for (var i = 0; i < JsTypes.length; i++) {
    if (JsTypes[i].fullname == _jstype.fullname) {
        JsTypes[i] = _jstype;
        _found = true;
        break;
    }
}
if (!_found) {
    JsTypes.push(_jstype);
}


_jstype.definition.ctor = function() { CS.Call(5, 7, 0, true, this); }

// fields

// properties

_jstype.staticDefinition.get_logger = function() { return CS.Call(2, 7, 0, true); }
_jstype.staticDefinition.set_logger = function(v) { return CS.Call(3, 7, 0, true, v); }

_jstype.staticDefinition.get_developerConsoleVisible = function() { return CS.Call(2, 7, 1, true); }
_jstype.staticDefinition.set_developerConsoleVisible = function(v) { return CS.Call(3, 7, 1, true, v); }

_jstype.staticDefinition.get_isDebugBuild = function() { return CS.Call(2, 7, 2, true); }
_jstype.staticDefinition.set_isDebugBuild = function(v) { return CS.Call(3, 7, 2, true, v); }

// methods

/* static Void  */
_jstype.staticDefinition.Assert$$Boolean$$String$$Object = function(a0/*Boolean*/, a1/*String*/, a2/*Object*/) {
    
    return CS.Call(4, 7, 0, true, a0, a1, a2);
}
/* static Void  */
_jstype.staticDefinition.Assert$$Boolean$$Object$$Object = function(a0/*Boolean*/, a1/*Object*/, a2/*Object*/) {
    
    return CS.Call(4, 7, 1, true, a0, a1, a2);
}
/* static Void  */
_jstype.staticDefinition.Assert$$Boolean$$Object = function(a0/*Boolean*/, a1/*Object*/) {
    
    return CS.Call(4, 7, 2, true, a0, a1);
}
/* static Void  */
_jstype.staticDefinition.Assert$$Boolean$$Object = function(a0/*Boolean*/, a1/*Object*/) {
    
    return CS.Call(4, 7, 3, true, a0, a1);
}
/* static Void  */
_jstype.staticDefinition.Assert$$Boolean$$String = function(a0/*Boolean*/, a1/*String*/) {
    
    return CS.Call(4, 7, 4, true, a0, a1);
}
/* static Void  */
_jstype.staticDefinition.Assert$$Boolean = function(a0/*Boolean*/) {
    
    return CS.Call(4, 7, 5, true, a0);
}
/* static Void  */
_jstype.staticDefinition.AssertFormat$$Boolean$$Object$$String$$Object$Array = function(a0/*Boolean*/, a1/*Object*/, a2/*String*/, a3/*Object[]*/) {
    
    return CS.Call(4, 7, 6, true, a0, a1, a2, jsb_formatParamsArray(3, a3, arguments));
}
/* static Void  */
_jstype.staticDefinition.AssertFormat$$Boolean$$String$$Object$Array = function(a0/*Boolean*/, a1/*String*/, a2/*Object[]*/) {
    
    return CS.Call(4, 7, 7, true, a0, a1, jsb_formatParamsArray(2, a2, arguments));
}
/* static Void  */
_jstype.staticDefinition.Break = function() {
    
    return CS.Call(4, 7, 8, true);
}
/* static Void  */
_jstype.staticDefinition.ClearDeveloperConsole = function() {
    
    return CS.Call(4, 7, 9, true);
}
/* static Void  */
_jstype.staticDefinition.DebugBreak = function() {
    
    return CS.Call(4, 7, 10, true);
}
/* static Void  */
_jstype.staticDefinition.DrawLine$$Vector3$$Vector3$$Color$$Single$$Boolean = function(a0/*Vector3*/, a1/*Vector3*/, a2/*Color*/, a3/*Single*/, a4/*Boolean*/) {
    
    return CS.Call(4, 7, 11, true, a0, a1, a2, a3, a4);
}
/* static Void  */
_jstype.staticDefinition.DrawLine$$Vector3$$Vector3$$Color$$Single = function(a0/*Vector3*/, a1/*Vector3*/, a2/*Color*/, a3/*Single*/) {
    
    return CS.Call(4, 7, 12, true, a0, a1, a2, a3);
}
/* static Void  */
_jstype.staticDefinition.DrawLine$$Vector3$$Vector3$$Color = function(a0/*Vector3*/, a1/*Vector3*/, a2/*Color*/) {
    
    return CS.Call(4, 7, 13, true, a0, a1, a2);
}
/* static Void  */
_jstype.staticDefinition.DrawLine$$Vector3$$Vector3 = function(a0/*Vector3*/, a1/*Vector3*/) {
    
    return CS.Call(4, 7, 14, true, a0, a1);
}
/* static Void  */
_jstype.staticDefinition.DrawRay$$Vector3$$Vector3$$Color$$Single$$Boolean = function(a0/*Vector3*/, a1/*Vector3*/, a2/*Color*/, a3/*Single*/, a4/*Boolean*/) {
    
    return CS.Call(4, 7, 15, true, a0, a1, a2, a3, a4);
}
/* static Void  */
_jstype.staticDefinition.DrawRay$$Vector3$$Vector3$$Color$$Single = function(a0/*Vector3*/, a1/*Vector3*/, a2/*Color*/, a3/*Single*/) {
    
    return CS.Call(4, 7, 16, true, a0, a1, a2, a3);
}
/* static Void  */
_jstype.staticDefinition.DrawRay$$Vector3$$Vector3$$Color = function(a0/*Vector3*/, a1/*Vector3*/, a2/*Color*/) {
    
    return CS.Call(4, 7, 17, true, a0, a1, a2);
}
/* static Void  */
_jstype.staticDefinition.DrawRay$$Vector3$$Vector3 = function(a0/*Vector3*/, a1/*Vector3*/) {
    
    return CS.Call(4, 7, 18, true, a0, a1);
}
/* static Void  */
_jstype.staticDefinition.Log$$Object$$Object = function(a0/*Object*/, a1/*Object*/) {
    
    return CS.Call(4, 7, 19, true, a0, a1);
}
/* static Void  */
_jstype.staticDefinition.Log$$Object = function(a0/*Object*/) {
    
    return CS.Call(4, 7, 20, true, a0);
}
/* static Void  */
_jstype.staticDefinition.LogAssertion$$Object$$Object = function(a0/*Object*/, a1/*Object*/) {
    
    return CS.Call(4, 7, 21, true, a0, a1);
}
/* static Void  */
_jstype.staticDefinition.LogAssertion$$Object = function(a0/*Object*/) {
    
    return CS.Call(4, 7, 22, true, a0);
}
/* static Void  */
_jstype.staticDefinition.LogAssertionFormat$$Object$$String$$Object$Array = function(a0/*Object*/, a1/*String*/, a2/*Object[]*/) {
    
    return CS.Call(4, 7, 23, true, a0, a1, jsb_formatParamsArray(2, a2, arguments));
}
/* static Void  */
_jstype.staticDefinition.LogAssertionFormat$$String$$Object$Array = function(a0/*String*/, a1/*Object[]*/) {
    
    return CS.Call(4, 7, 24, true, a0, jsb_formatParamsArray(1, a1, arguments));
}
/* static Void  */
_jstype.staticDefinition.LogError$$Object$$Object = function(a0/*Object*/, a1/*Object*/) {
    
    return CS.Call(4, 7, 25, true, a0, a1);
}
/* static Void  */
_jstype.staticDefinition.LogError$$Object = function(a0/*Object*/) {
    
    return CS.Call(4, 7, 26, true, a0);
}
/* static Void  */
_jstype.staticDefinition.LogErrorFormat$$Object$$String$$Object$Array = function(a0/*Object*/, a1/*String*/, a2/*Object[]*/) {
    
    return CS.Call(4, 7, 27, true, a0, a1, jsb_formatParamsArray(2, a2, arguments));
}
/* static Void  */
_jstype.staticDefinition.LogErrorFormat$$String$$Object$Array = function(a0/*String*/, a1/*Object[]*/) {
    
    return CS.Call(4, 7, 28, true, a0, jsb_formatParamsArray(1, a1, arguments));
}
/* static Void  */
_jstype.staticDefinition.LogException$$Exception$$Object = function(a0/*Exception*/, a1/*Object*/) {
    
    return CS.Call(4, 7, 29, true, a0, a1);
}
/* static Void  */
_jstype.staticDefinition.LogException$$Exception = function(a0/*Exception*/) {
    
    return CS.Call(4, 7, 30, true, a0);
}
/* static Void  */
_jstype.staticDefinition.LogFormat$$Object$$String$$Object$Array = function(a0/*Object*/, a1/*String*/, a2/*Object[]*/) {
    
    return CS.Call(4, 7, 31, true, a0, a1, jsb_formatParamsArray(2, a2, arguments));
}
/* static Void  */
_jstype.staticDefinition.LogFormat$$String$$Object$Array = function(a0/*String*/, a1/*Object[]*/) {
    
    return CS.Call(4, 7, 32, true, a0, jsb_formatParamsArray(1, a1, arguments));
}
/* static Void  */
_jstype.staticDefinition.LogWarning$$Object$$Object = function(a0/*Object*/, a1/*Object*/) {
    
    return CS.Call(4, 7, 33, true, a0, a1);
}
/* static Void  */
_jstype.staticDefinition.LogWarning$$Object = function(a0/*Object*/) {
    
    return CS.Call(4, 7, 34, true, a0);
}
/* static Void  */
_jstype.staticDefinition.LogWarningFormat$$Object$$String$$Object$Array = function(a0/*Object*/, a1/*String*/, a2/*Object[]*/) {
    
    return CS.Call(4, 7, 35, true, a0, a1, jsb_formatParamsArray(2, a2, arguments));
}
/* static Void  */
_jstype.staticDefinition.LogWarningFormat$$String$$Object$Array = function(a0/*String*/, a1/*Object[]*/) {
    
    return CS.Call(4, 7, 36, true, a0, jsb_formatParamsArray(1, a1, arguments));
}
