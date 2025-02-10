using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed, lifetime;
    public float startTime;
    Rigidbody2D rb;
    public float power;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //if (gameObject.GetComponent<Player2D>().transform.rotation.y == 0)
        //{
        //    transform.rotation = Quaternion.Euler(0, 0, 0);
        //}
        //else if (gameObject.GetComponent<Player2D>().transform.rotation.y == 180)
        //{
        //    transform.rotation = Quaternion.Euler(0, 180, 0);
        //}

        transform.position += new Vector3(speed * Time.deltaTime, 0);
        //rb.velocity = Vector2.right * speed * Time.deltaTime;
        startTime += Time.deltaTime;
        if (startTime > lifetime) 
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            //Object.FindObjectOfType<GameManager>.addScorePoint(10);
            collision.gameObject.GetComponent<Enemy>().onHit(power);
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.right * 100);
            //Destroy(collision.gameObject);
            Destroy(gameObject);

        }
    }
}
