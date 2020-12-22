using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    public void MoveTo(Vector3 direction)
    {
        transform.Translate(direction * _speed * Time.deltaTime);
    }
}
