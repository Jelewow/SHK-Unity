using System.Collections;
using UnityEngine;

[RequireComponent(typeof(PlayerCollisionHandler))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    public void Moving(float x, float y)
    {
        var speedFactor = _speed * Time.deltaTime;
        transform.Translate(x * speedFactor, y * speedFactor, 0);
    }

    public void StartBoosting(float bonusSpeed, float duration)
    {
        StartCoroutine(Boosting(bonusSpeed, duration));
    }

    private IEnumerator Boosting(float bonusSpeed, float duration)
    {
        _speed += bonusSpeed;
        yield return new WaitForSeconds(duration);
        _speed -= bonusSpeed;
    }
}