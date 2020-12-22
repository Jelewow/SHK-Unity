using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private const float _radius = 4;

    private Vector3 _targetPosition;

    private void Start()
    {
        _targetPosition = SetNewTargetPosition();
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _speed * Time.deltaTime);

        if (transform.position == _targetPosition)
        {
            _targetPosition = SetNewTargetPosition();
        }
    }

    private Vector3 SetNewTargetPosition()
    {
        var targetPosition = Random.insideUnitCircle * _radius;
        return targetPosition;
    }
}
