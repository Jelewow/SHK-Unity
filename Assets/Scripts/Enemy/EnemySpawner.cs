using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private int _capacity;
    [SerializeField] private float _spawnRadius;
    [SerializeField] private PlayerCollisionHandler _player;
    
    public int Capacity => _capacity;

    private void OnEnable()
    {
        _player.EnemyKilled += OnEnemyKilled;
    }

    private void OnDisable()
    {
        _player.EnemyKilled -= OnEnemyKilled;
    }

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
        var x = GetRandomPoint(transform.position.x);
        var y = GetRandomPoint(transform.position.y);
        var randomPosition = new Vector2(x, y);
        return randomPosition;
    }

    private float GetRandomPoint(float startPoint)
    {
        var randomPoint = Random.Range(startPoint * -_spawnRadius, startPoint * _spawnRadius);
        return randomPoint;
    }

    private void OnEnemyKilled()
    {
        _capacity--;
    }
}