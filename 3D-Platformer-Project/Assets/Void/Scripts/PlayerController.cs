using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] InputManager inputManager;
    [SerializeField] Rigidbody rigidBody;

    [SerializeField] float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        GetObjects();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        CharacterMovement();
    }

    private void CharacterMovement()
    {
        /*
        Vector3 direction = new Vector3(inputManager.horizontal, 0, inputManager.vertical).normalized;

        if(direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, targetAngle, 0);

            rigidBody.MovePosition(direction * moveSpeed * Time.deltaTime);
        }
        */

        Vector3 direction = (transform.forward * inputManager.vertical + transform.right * inputManager.horizontal).normalized;
        rigidBody.MovePosition(transform.position + direction * moveSpeed * Time.deltaTime);

    }

    private void GetObjects()
    {
        inputManager = GetComponent<InputManager>();
        rigidBody = GetComponent<Rigidbody>();
    }
}
