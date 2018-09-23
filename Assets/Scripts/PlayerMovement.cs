using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody rb;
    private int Count;

    public float MovementSpeed;
    public Text countText;
    public Text winText;


    void Start() {

        rb = GetComponent<Rigidbody>();
        Count = 0;
        RecordCount();
        winText.text = "";

    }
    // Update is called once per frame
    void FixedUpdate () {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        //rb.AddForce(movement * MovementSpeed * Time.deltaTime);
        rb.AddForce(movement * MovementSpeed);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            Count = Count + 1;
            RecordCount();

        }
    }

    void RecordCount()
    {
        countText.text = "Count: " + Count.ToString();
        if(Count >= 8)
        {
            winText.text = "Winner";
        }
    }
}
