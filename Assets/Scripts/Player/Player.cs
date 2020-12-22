using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(PlayerCollisionHandler))]
public class Player : MonoBehaviour
{
    [SerializeField] private EnemySpawner _enemies;

    private int _amountOfKillToWin;
    private int _currentAmountOfKill;
    private PlayerCollisionHandler _enemyTrigger;

    public event UnityAction EndGame;

    private void Awake()
    {
        _enemyTrigger = GetComponent<PlayerCollisionHandler>();
        _amountOfKillToWin = _enemies.Capacity;
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
        _currentAmountOfKill++;

        if (_currentAmountOfKill == _amountOfKillToWin)
            EndGame?.Invoke();
    }
}
