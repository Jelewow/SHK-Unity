using UnityEngine;

public class Booster : MonoBehaviour
{
    [SerializeField] private float _bonusSpeed;
    [SerializeField] private float _duration;

    public float BonusSpeed => _bonusSpeed;
    public float Duration => _duration;
}