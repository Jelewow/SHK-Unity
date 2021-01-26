using UnityEngine;
using UnityEngine.Events;

public class PlayerCollisionHandler : MonoBehaviour
{
    [SerializeField] private PlayerMover _playerMover;

    public event UnityAction EnemyKilled;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out EnemyMover enemyMover))
        {
            enemyMover.gameObject.SetActive(false);
            EnemyKilled?.Invoke();
        }

        if(collision.TryGetComponent(out Booster booster))
        {
            _playerMover.StartBoosting(booster.BonusSpeed, booster.Duration);
            booster.gameObject.SetActive(false);
        }
    }
}