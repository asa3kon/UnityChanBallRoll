using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    private float moveHorizontal;
    private float moveVertical;
    public float speed;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Input系はUpdateで
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        // 実際に動かすのはFixedUpdateで
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        // アイテムゲット
        if (other.gameObject.CompareTag("Item"))
        {
            other.gameObject.SetActive(false);
        }
    }
}