using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void OnMouseUp(int index)
    {
        if(index == 0)
        {
            SceneManager.LoadScene(1);
        }
        else if (index == 1)
        {
            SceneManager.LoadScene(2);
        }
        else if (index == 2)
        {
            SceneManager.LoadScene(3);
        }
        else if (index == 3)
        {
            Application.OpenURL("https://kryswx.github.io/Krysw.github.io/");
        }
        else if (index == 4)
        {
            Application.Quit();
        }
    }
}
