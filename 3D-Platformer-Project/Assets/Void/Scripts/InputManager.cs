using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] public float horizontal;
    [SerializeField] public float vertical;
    [SerializeField] public bool jump;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    // FixedUpdate is called 50 times per second
    private void FixedUpdate()
    {
        GetInputs();
    }

    public void GetInputs()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        jump = (Input.GetAxis("Jump") > 0) ? true : false;
    }
}
