using UnityEngine;
using static UnityEditor.Progress;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float moveSpeed;
    Rigidbody2D rb;
    public float enemyHp, maxHp, hp_p;
    public GameObject hpreal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
        updateHp();
        maxHp = enemyHp;
    }

    // Update is called once per frame
    void Update()
    {
        //rb.linearVelocity = new Vector2(moveSpeed, transform.position.y);


        if (enemyHp <= 0)
        {
            //Object.FindObjectOfType<GameManager>.addScorePoint(10);
            Destroy(gameObject);    
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" /*|| collision.gameObject.tag == "Fireball"*/)
        {
            Debug.Log("被遇到了");
            Destroy(gameObject);
            //Object.FindObjectOfType<GameManager>.addScorePoint(10);

        }
        //if (collision.gameObject.tag == "Fireball")
        //{
        //    Debug.Log("被遇到了");
        //    //Object.FindObjectOfType<GameManager>.addScorePoint(10);
        //    Destroy(collision.gameObject);
        //    Destroy(gameObject);

        //}
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<Player2D>().hitByEnemy();
        Debug.Log("玩家血量減少");
    }
    public void onHit(float power)
    { 
        enemyHp -= power;
        updateHp();
    }
    void updateHp()
    {
        hp_p = enemyHp / maxHp;
        Debug.Log("血量%:" + hp_p);
        hpreal.GetComponent<RectTransform>().localScale = new Vector3(hp_p, 1,1);
    }
}
