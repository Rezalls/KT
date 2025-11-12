using UnityEngine;

public class LevelSpavner : MonoBehaviour
{
    [SerializeField] private Level _prefab;
    [SerializeField] private Transform _spawnPosition;
    [SerializeField] private int _levelsCount = 20;
    [SerializeField] private int _levelLock = 16;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 1; i < _levelsCount; i++)
        {
            Instantiate(_prefab, _spawnPosition);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
