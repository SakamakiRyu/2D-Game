using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    [SerializeField]
    private Button _startButton;

    private void Awake()
    {
        _startButton.onClick.AddListener(LoadScene);
    }

    private void LoadScene()
    {
        SceneManager.LoadSceneAsync("InGame");
    }
}
