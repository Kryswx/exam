using UnityEngine;

public class SpawnTrainingLevel : MonoBehaviour
{
    [SerializeField] private GameObject _spherePrefab;
    [SerializeField] private GameObject _sphereSpawnPositions;
    [SerializeField] private GameObject _spheresFolder;
    [SerializeField] private int _spawnTime;

    private void Start()
    {
        StartSpawnSpheres();
    }

    private void StartSpawnSpheres()
    {
        int rand = Random.Range(0, 9);

        GameObject newSphere = Instantiate(_spherePrefab, _sphereSpawnPositions.transform.GetChild(rand).position, Quaternion.identity);
        newSphere.transform.SetParent(_spheresFolder.transform);
        Invoke(nameof(ClearAllSpheres), _spawnTime);
        Invoke(nameof(StartSpawnSpheres),_spawnTime);
    }

    private void ClearAllSpheres()
    {
        for(int i = 0; i < _spheresFolder.transform.childCount; i++)
        {
            Destroy(_spheresFolder.transform.GetChild(i).gameObject);
        }
    }
}
