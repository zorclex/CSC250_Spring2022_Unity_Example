using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxScript : MonoBehaviour
{
    private int count;
    private Rigidbody rb;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start() //like a constructor
    {
        count = 0;
        rb = this.gameObject.GetComponent<Rigidbody>();
        int dir = Random.Range(1, 4);
        print("dir is: " + dir);
        if(dir == 1)
        {
            rb.velocity = Vector3.right * speed;
        }
        else if(dir == 2)
        {
            rb.velocity = Vector3.back * speed;
        }
        else if(dir == 3)
        {
            rb.velocity = Vector3.left * speed;
        }
        else if(dir == 4)
        {
            rb.velocity = Vector3.right * speed;
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            CORE.display();
            count++;
            if(count == 3)
            {
                this.gameObject.SendMessage("DoSomething"); //Is this a thing we made or is this actually a method in the gameObject class??
                Destroy(this.gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //cabbage
}
