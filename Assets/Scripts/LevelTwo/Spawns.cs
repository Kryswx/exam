using UnityEngine;

public class Spawns : MonoBehaviour
{
    [SerializeField] private GameObject _spherePrefab;
    [SerializeField] private GameObject _bombPrefab;
    [SerializeField] private GameObject _spawnPositions;
    [SerializeField] private GameObject _objectsFolder;
    [SerializeField] private int _spawnTime;
    [SerializeField] private UiController _uiController;

    private void Start()
    {
        StartSpawnSpheres();
    }

    private void StartSpawnSpheres()
    {
        int rand = Random.Range(0, 9);
        int typeRand = Random.Range(1, 5);

        if(typeRand > 1)
        {
            GameObject newSphere = Instantiate(_spherePrefab, _spawnPositions.transform.GetChild(rand).position, Quaternion.identity);
            newSphere.name = "Sphere";
            newSphere.transform.SetParent(_objectsFolder.transform);
        }
        else if(typeRand == 1)
        {
            GameObject newBomb = Instantiate(_bombPrefab, _spawnPositions.transform.GetChild(rand).position, Quaternion.identity);
            newBomb.name = "Bomb";
            newBomb.transform.SetParent(_objectsFolder.transform);
        }

        Invoke(nameof(ClearAllSpheres), _spawnTime);
        Invoke(nameof(StartSpawnSpheres), _spawnTime);
    }

    private void ClearAllSpheres()
    {
        for (int i = 0; i < _objectsFolder.transform.childCount; i++)
        {
            if (_objectsFolder.transform.GetChild(i))
            {
                if (_objectsFolder.transform.GetChild(i).gameObject.name.Equals("Sphere"))
                {
                    _uiController.RemovePoints(1);
                }
                Destroy(_objectsFolder.transform.GetChild(i).gameObject);
            }
        }
    }
}
