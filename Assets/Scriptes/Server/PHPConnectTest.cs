using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class PHPConnectTest : MonoBehaviour
{
    private const string WWW = "http://localhost/php/UnityTest.php";

    private void Start()
    {
        Conect();
    }

    public void Conect()
    {
        StartCoroutine(DoConect());
    }

    IEnumerator DoConect()
    {
        var request = UnityWebRequest.Post(WWW,"a");
        yield return request.SendWebRequest();
        Debug.Log(request.downloadHandler.text);
    }
}
