using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public GameObject bulletPrefab;
    public Transform firePoint;

    private Vector2 movementInput;
    private PlayerInputActions inputActions;

    private void Awake()
    {
        inputActions = new PlayerInputActions();
        inputActions.Gameplay.Move.performed += ctx => movementInput = ctx.ReadValue<Vector2>();
        inputActions.Gameplay.Move.canceled += ctx => movementInput = Vector2.zero;
        inputActions.Gameplay.Fire.performed += ctx => Fire();
    }

    private void OnEnable() => inputActions.Gameplay.Enable();
    private void OnDisable() => inputActions.Gameplay.Disable();

    void Update()
    {
        Vector3 move = new Vector3(movementInput.x, 0f, movementInput.y) * moveSpeed * Time.deltaTime;
        transform.Translate(move, Space.World);
    }

    void Fire()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
