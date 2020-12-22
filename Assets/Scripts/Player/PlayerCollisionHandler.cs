using UnityEngine;
using UnityEngine.Events;

public class PlayerCollisionHandler : MonoBehaviour
{
    public event UnityAction EnemyKilled;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out EnemyMover enemyMover))
        {
            enemyMover.gameObject.SetActive(false);
            EnemyKilled?.Invoke();
        }
    }
}
