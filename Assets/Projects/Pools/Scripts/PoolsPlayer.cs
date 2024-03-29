using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PoolsPlayer : MonoBehaviour
{
    private PoolsPlayerInputActions inputActions;

    [SerializeField] private float speed;

    private PoolScript bulletPool;
    private Rigidbody2D rb;

    private void Awake()
    {
        inputActions = new PoolsPlayerInputActions();
        bulletPool = GameObject.Find("BulletPool").GetComponent<PoolScript>();
    }

    void Start()
    {
        inputActions.Enable();
        rb = GetComponent<Rigidbody2D>();

        inputActions.Standard.Shoot.performed += Shoot;
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        Vector2 direction = new Vector2(0, inputActions.Standard.Movement.ReadValue<float>()).normalized;
        rb.AddForce(direction * speed);
    }

    private void Shoot(InputAction.CallbackContext context)
    {
        GameObject bullet = bulletPool.RequestObject();
        bullet.SetActive(true);
        bullet.transform.position = transform.position;
    }
}
