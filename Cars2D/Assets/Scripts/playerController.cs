using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public GameObject Player;

    public GameManager GameManager;
    // Start is called before the first frame update

    private void FixedUpdate()              //Движение персонажа
    {
        float direction = Input.GetAxis("Horizontal");
        transform.position += new Vector3(direction, 0, 0) * speed * Time.fixedDeltaTime;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision) //При встрече с монеткой (топливом), бак полный
    {
        if (collision.gameObject.tag == "Topl")
        {
            GameManager.Scrollbar.size = 1;
        }
    }
}
