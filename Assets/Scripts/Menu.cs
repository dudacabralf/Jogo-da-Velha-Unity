using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void JogadorxJogador()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void JogadorxIA()
    {
        SceneManager.LoadSceneAsync(2);
    }
}