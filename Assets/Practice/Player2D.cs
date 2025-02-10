using UnityEngine;
using UnityEngine.UI;

public class Player2D : MonoBehaviour
{
    public float moveSpeed, h, v, jumpforce, hitTime;
    public float startMoveSpeed, startjumpForce, startHitTime;
    Rigidbody2D rb;
    public bool isGround, isRun, isHit, canFire, threeFire, isshotgunFire, isBigfire, isturnBigFire;
    public int hp;
    public int maxHp;
    public GameObject[] hearts;
    public GameObject windowGameover, fireball, bigfireball;
    public Transform fireballPos;
    public Sprite[] playerSkin;
    public float bigfireTime, startBigfireTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position += new Vector3(0,0, 0);
        rb.GetComponent<Rigidbody2D>();
        startMoveSpeed = moveSpeed;
        startjumpForce = jumpforce;
        hp = 3;
        maxHp = hp;
        canFire = false;
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(h * moveSpeed, v * moveSpeed, 0);

        if (h != 0 || v != 0)
        {
            transform.position += move;

            if (h > 0)
            {
                //transform.localScale = new Vector3(1, 1, 1);
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else 
            {
                //transform.localScale = new Vector3(-1, 1, 1);
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            //if (isRun)
            //{
            //    jumpforce = 11.25f;
            //}
            //else 
            //{
            //    jumpforce = startjumpForce;
            //}
        }

        //if (Input.GetKeyDown(KeyCode.Space) && isGround)
        //{
        //    transform.position += new Vector3(0, 2.5f, 0);
        //    rb.linearVelocity = new Vector2(0, jumpforce);
        //}
        //if (Input.GetKeyDown(KeyCode.LeftShift)) 
        //{
        //    moveSpeed *= 2;
        //    isRun = true;
        //    jumpforce *= 1.5f;
        //}
        //if (Input.GetKeyUp(KeyCode.LeftShift))
        //{
        //    moveSpeed = startMoveSpeed;
        //    isRun = false;
        //    jumpforce = startjumpForce;
        //}
        if (isHit)
        {
            startHitTime += Time.deltaTime;
            flashplayer();
            if (startHitTime > hitTime)
            {
                startHitTime = 0;
                isHit = false;
                gameObject.GetComponent<SpriteRenderer>().color = new Vector4(1, 1, 1, 1);
            }
        }
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Fire");
            //fire();
            if (threeFire)
            {
                fire();
                Invoke("fire", 0.1f);
                Invoke("fire", 0.2f);
            }
            else if (isshotgunFire)
            {
                isShotgun();
            }
            else if (isBigfire)
            {
                isturnBigFire = true;
                return;
            }
            else if (canFire)
            {
                fire();
            }
            
        }
        if (isturnBigFire)
        {
            flashplayer();
            startBigfireTime = Time.deltaTime;
            if (startBigfireTime > bigfireTime)
            {
                gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 1, 0.6f);

            }

            if (Input.GetButtonUp("Fire1") && canFire)
            {
                if (startBigfireTime > bigfireTime)
                {
                    
                    Instantiate(bigfireball, fireballPos);
                }
                else
                {
                    fire();
                }
                startBigfireTime = 0;
                isBigfire = false;
            }
        }


        /*
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)) 
        {
            transform.position += new Vector3(0, v*moveSpeed, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(h*moveSpeed, 0, 0);
        }
        */

    }
    void flashplayer()
    {
        SpriteRenderer SR = gameObject.GetComponent<SpriteRenderer>();
        SR.color = new Vector4(SR.color.r, SR.color.g, SR.color.b, Random.Range(0.5f,1));
    }
    public void iscanfire()
    { 
        canFire = true;
        gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        //gameObject.GetComponent<SpriteRenderer>().sprite = playerSkin[1];
    }
    void fire()
    { 
        Instantiate(fireball, fireballPos);
    }
    void shotgunfire()
    {
        Instantiate(fireball, fireballPos);
    }
    public void isThreeFire()
    {
        threeFire = true;
        if (threeFire)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.green;
            Debug.Log("是連射" + threeFire);
            //threeFire = false;
            isshotgunFire = false;

        }
        else
        {
            iscanfire();
        }
    }
    public void isShotgun()
    {
        isshotgunFire = true;
        if (isshotgunFire)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
            threeFire = false;
            //isshotgunFire = false;
        }
        else
        {
            iscanfire();
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("著地" + collision.gameObject.name);
        if (collision.gameObject.name == "Ground")
        {
            isGround = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("離開" + collision.gameObject.name);
        if (collision.gameObject.name == "Ground")
        {
            isGround = false;
        }
    }
    /*
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("待在" + collision.gameObject.name);
    }
    */

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            isGround = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            isGround = false;
        }
    }
    public void hitByEnemy()
    {

        if (isHit) 
        {
            return;
        }

        hp--;
        isHit = true;
        canFire = false;
        isBigfire = false;
        threeFire = false;
        isshotgunFire = false;
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        //gameObject.GetComponent<SpriteRenderer>().sprite = playerSkin[0];

        for (int j = 0; j < hearts.Length; j++) 
        {
            hearts[j].SetActive(false);
        }

        for (int i = 0; i < hp; i++) 
        {
            hearts[i].SetActive(true);
        }

        if (hp <= 0)
        {
            hp = 0;
            windowGameover.SetActive(true);
        }
    }
    public void addHp()
    {
        hp++;
        if (hp > maxHp)
        { 
            hp = maxHp;
        }
        for (int j = 0; j < hearts.Length; j++)
        {
            hearts[j].SetActive(false);
        }

        for (int i = 0; i < hp; i++)
        {
            hearts[i].SetActive(true);
        }
    }
}
