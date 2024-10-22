using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMeunu : MonoBehaviour
{
    public LevelLoader levelLoader;

    public void JogadorxJogador()
    {
        levelLoader.Transition("JogadorxJogador");
    }

    public void JogadorxIA()
    {
        levelLoader.Transition("JogadorxIA");
    }
}