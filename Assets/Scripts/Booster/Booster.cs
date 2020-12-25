using UnityEngine;

public class Booster : MonoBehaviour
{
    [SerializeField] private float _bonusSpeed;
    [SerializeField] private float _duration;
    [SerializeField] private BoostTimer _timer;

    public float BonusSpeed => _bonusSpeed;
    public float Duration => _duration;

    private void OnDisable()
    {
        _timer.InvokeTimer(_duration);
    }
}