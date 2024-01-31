using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public static Player Instance; 
    private PlayerInputActions playerInputActions;

    [SerializeField] private float speed;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float timeToShoot;
    [SerializeField] private int maxLife;

    private Rigidbody2D rb;
    private bool canShoot;
    private float shootTimer;
    private int life;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        playerInputActions = new PlayerInputActions();
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        canShoot = true;
        shootTimer = timeToShoot;
        life = maxLife;

        playerInputActions.Enable();
        playerInputActions.Standard.Shoot.performed += Shoot;
    }

    private void FixedUpdate()
    {
        Move();
    }

    void Update()
    {
        FireRate();
    }

    private void Move()
    {
        Vector3 direction = new Vector3(playerInputActions.Standard.Move.ReadValue<Vector2>().x, playerInputActions.Standard.Move.ReadValue<Vector2>().y, 0).normalized;
        rb.AddForce(direction * speed);
    }

    private void FireRate()
    {
        if (!canShoot)
        {
            shootTimer -= Time.deltaTime;
            if (shootTimer <= 0)
            {
                canShoot = true;
                shootTimer = timeToShoot;
            }
        }
    }

    private void Shoot(InputAction.CallbackContext context)
    {
        if (context.action.activeControl != null && canShoot)
        {
            string inputKey = context.control.name;
            Debug.Log(inputKey);
            switch (inputKey)
            {
                case "downArrow":
                    Instantiate(bulletPrefab, transform.position, Quaternion.Euler(0, 0, -90));
                    break;

                case "upArrow":
                    Instantiate(bulletPrefab, transform.position, Quaternion.Euler(0, 0, 90));
                    break;

                case "leftArrow":
                    Instantiate(bulletPrefab, transform.position, Quaternion.Euler(0, 0, 180));
                    break;

                case "rightArrow":
                    Instantiate(bulletPrefab, transform.position, Quaternion.identity);
                    break;
            }
            canShoot = false;
        }
        
    }

    public void Hit(int damage)
    {
        life -= damage;
        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
