using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PHPConnect : MonoBehaviour
{
    class UserModel
    {
        public int user_id;
        public string name;
        public bool is_login;
    }

    const string URL = "http://localhost/php/UnityTest.php";

    private void Start()
    {
        StartCoroutine(Connect<UserModel>(URL));
    }

    IEnumerator Connect<T>(string url)
    {
        var request = UnityWebRequest.Get(url);
        yield return request.SendWebRequest();
        var text = request.downloadHandler.text;
        var user = JsonUtility.FromJson<T>(text);
        yield return user;
    }
}
