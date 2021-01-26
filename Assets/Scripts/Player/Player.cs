using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(PlayerCollisionHandler))]
public class Player : MonoBehaviour
{
    [SerializeField] private EnemySpawner _enemies;

    private PlayerCollisionHandler _enemyTrigger;

    public event UnityAction AllEnemiesKilled;

    private void Awake()
    {
        _enemyTrigger = GetComponent<PlayerCollisionHandler>();
    }

    private void OnEnable()
    {
        _enemyTrigger.EnemyKilled += OnEnemyKilled;
    }

    private void OnDisable()
    {
        _enemyTrigger.EnemyKilled -= OnEnemyKilled;
    }

    private void OnEnemyKilled()
    {
        if (_enemies.Capacity == 0)
            AllEnemiesKilled?.Invoke();
    }
}