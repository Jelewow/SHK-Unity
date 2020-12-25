using UnityEngine;

[RequireComponent(typeof(PlayerCollisionHandler))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private BoostTimer _timer;

    private PlayerCollisionHandler _playerCollision;
    private float _bonusSpeed;

    private void Awake()
    {
        _playerCollision = GetComponent<PlayerCollisionHandler>();
    }

    private void OnEnable()
    {
        _playerCollision.BoosterPicked += OnBoosterPicked;
        _timer.TimerEnded += OnTimerEnded;
    }

    private void OnDisable()
    {
        _playerCollision.BoosterPicked -= OnBoosterPicked;
        _timer.TimerEnded -= OnTimerEnded;
    }

    public void Moving(float x, float y)
    {
        var speedFactor = _speed * Time.deltaTime;
        transform.Translate(x * speedFactor, y * speedFactor, 0);
    }

    private void OnBoosterPicked(float bonusSpeed)
    {
        _bonusSpeed = bonusSpeed;
        _speed += bonusSpeed;
    }

    private void OnTimerEnded()
    {
        _speed -= _bonusSpeed;
    }
}