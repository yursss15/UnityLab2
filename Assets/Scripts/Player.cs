using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Player : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    private float speed = 2.0f;
    private float jumpForce = 5.0f;

    public void Move(Vector3 direction)
    {
        this.transform.position += direction * this.speed * Time.deltaTime;
    }

    public void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
