using UnityEngine;

public class ClickBomb : MonoBehaviour
{
    [SerializeField] private UiController _uiControllerScript;

    private void OnMouseDown()
    {
        Destroy(gameObject);
        _uiControllerScript.RemovePoints(2);
    }
}
