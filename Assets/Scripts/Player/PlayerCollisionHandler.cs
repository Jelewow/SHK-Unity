using UnityEngine;
using UnityEngine.Events;

public class PlayerCollisionHandler : MonoBehaviour
{
    public event UnityAction EnemyKilled;
    public event UnityAction<float> BoosterPicked;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out EnemyMover enemyMover))
        {
            enemyMover.gameObject.SetActive(false);
            EnemyKilled?.Invoke();
        }
        if(collision.TryGetComponent(out Booster booster))
        {
            booster.gameObject.SetActive(false);
            BoosterPicked?.Invoke(booster.BonusSpeed);
        }
    }
}