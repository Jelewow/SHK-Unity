using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private int _capacity;
    [SerializeField] private float _spawnRadius;

    public int Capacity => _capacity;

    private void Start()
    {
        for (int i = 0; i < _capacity; i++)
        {
            var randomPosition = GetRandomPosition();
            Instantiate(_prefab, randomPosition, Quaternion.identity);
        }
    }

    private Vector2 GetRandomPosition()
    {
        var x = Random.Range(transform.position.x * -_spawnRadius, transform.position.x * _spawnRadius);
        var y = Random.Range(transform.position.y * -_spawnRadius, transform.position.y * _spawnRadius);
        var randomPosition = new Vector2(x, y);
        return randomPosition;
    }
}
