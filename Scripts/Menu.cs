using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void ChangeScene(int n)
    {
        SceneManager.LoadScene(n);
    }

    public void ExitGame(int n)
    {
        Application.Quit(n);
    }
}
