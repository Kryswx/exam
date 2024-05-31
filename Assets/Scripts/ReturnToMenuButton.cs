using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenuButton : MonoBehaviour
{
    public void OnMouseUp(int index)
    {
        if (index == 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
