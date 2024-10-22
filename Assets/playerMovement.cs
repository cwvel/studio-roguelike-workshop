using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    // Start is called before the first frame update
    void Start() {
        Debug.Log("start~");
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnMove(InputValue value) {
        Vector2 dir = value.Get<Vector2>();
        rb.velocity = dir * 10;
    }
}
