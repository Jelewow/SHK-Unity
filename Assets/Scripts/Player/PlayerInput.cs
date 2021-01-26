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
        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");
        _mover.Moving(x, y);
    }
}