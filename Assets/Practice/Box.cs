using UnityEngine;

public class Box : MonoBehaviour
{
    public GameObject box, item, item2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("¸I¨ìª±®a");
            Destroy(gameObject);
            Instantiate(box, transform.position, transform.rotation);

            if (collision.gameObject.GetComponent<Player2D>().hp == 3)
            {
                Instantiate(item2, transform.position + new Vector3(0, 1.15f, 0), transform.rotation);
            }
            else
            {
                Instantiate(item, transform.position + new Vector3(0, 1.15f, 0), transform.rotation);
            }
        }
    }
}
