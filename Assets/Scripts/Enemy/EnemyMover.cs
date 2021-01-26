using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private const float Radius = 4;

    private Vector3 _target;

    private void Start()
    {
        _target = GetNewTarget();
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);

        if (transform.position == _target)
        {
            _target = GetNewTarget();
        }
    }

    private Vector3 GetNewTarget()
    {
        var targetPosition = Random.insideUnitCircle * Radius;
        return targetPosition;
    }
}