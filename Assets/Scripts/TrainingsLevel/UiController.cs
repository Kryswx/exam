using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _counterUi;

    private int _pointsCounter = 0;
    
    public void RemovePoints(int number)
    {
        if(_pointsCounter - number >= 0)
        {
            _pointsCounter -= number;
            ChangeCounterValue(_pointsCounter);
        }
        else
        {
            _counterUi.color = Color.red;
            _counterUi.text = "LOSE";
            Invoke(nameof(ReturnToMenu), 1);
        }
    }

    public void AddOnePoint()
    {
        ChangeCounterValue(++_pointsCounter);
        if(_pointsCounter >= 15)
        {
            _counterUi.color = Color.green;
            Invoke(nameof(ReturnToMenu), 1);
        }
    }

    public void ChangeCounterValue(int value)
    {
        _counterUi.text = value.ToString();
    }

    private void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
