using UnityEngine;

class UpdateManager
{
    private static UpdateManager _instance;

    public static UpdateManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new UpdateManager();
            }
            return _instance;
        }
    }

    public void Start()
    {
        Debug.Log("UpdateManager Start");
        UIManager.Instance.ShowPanel("UpdatePanel");
        HttpManager.Instance.StartHttpGet("http://www.baidu.com", content =>
        {
            Debug.Log(content);
        });
    }

    public void OnDestroy()
    {
        Debug.Log("UpdateManager OnDestroy");
    }
}
