using UnityEngine;

[RequireComponent(typeof(PlayerMover))]
public class PlayerInput : MonoBehaviour
{
    private PlayerMover _mover;

    private void Start()
    {
        _mover = GetComponent<PlayerMover>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
            _mover.MoveTo(Vector3.up);

        if (Input.GetKey(KeyCode.S))
            _mover.MoveTo(Vector3.down);

        if (Input.GetKey(KeyCode.A))
            _mover.MoveTo(Vector3.left);

        if (Input.GetKey(KeyCode.D))
            _mover.MoveTo(Vector3.right);
    }
}
