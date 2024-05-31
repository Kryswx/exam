using UnityEngine;

public class ClickSphere : MonoBehaviour
{
    [SerializeField] private UiController _uiControllerScript;
    [SerializeField] private GameObject _particle;

    private void Start()
    {
        _particle.SetActive(false);
    }

    private void OnMouseEnter()
    {
        _particle.SetActive(true);
    }

    private void OnMouseExit()
    {
        _particle.SetActive(false);
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        _uiControllerScript.AddOnePoint();
    }

   

    
}
