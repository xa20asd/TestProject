
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    string playName;
    public float hp, energy;
    float maxhp, maxenergy;
    public int money, level, exp, lvupExp, lvupExpPlus;
    public int eventNum;
    int startMoney;
    public GameObject gameoverWindow, playnametext, gamestartWindow, playerstatuswindow;
    public Text nameText, hptext, lvtext, exptext, moneytext;
    public InputField inputplayname;
    public GameObject[] monsters;
    public TestBox textobj; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        lvupExp = 10;
        lvupExpPlus = 2;
        maxhp = 50;
        hp = maxhp;

        maxenergy = 10;
        energy = maxenergy;

        startMoney = money;

        //nameText.text = playName;
        //hptext.text = hp.ToString();
        //playnametext.GetComponent<Text>().text = playName;

    }

    // Update is called once per frame
    void Update()
    {
        

        energy += Time.deltaTime;
        if (energy > maxenergy)
        {
            energy = maxenergy;
        }

        

        //showplayer();
    }

    public void showplayer()
    {
        lvtext.text = level.ToString() + "等";
        hptext.text = hp.ToString() + "/" + maxhp.ToString();
        exptext.text = exp.ToString() + "/" + lvupExp.ToString();
        moneytext.text = money.ToString() + "元";
        Debug.Log("玩家名稱:" + playName);
        Debug.Log("玩家等級:" + level);
        Debug.Log("玩家血量:" + hp);
        Debug.Log("玩家經驗值:" + exp);
        Debug.Log("金錢:" + money + "元");
    }

    public void go()
    {
        eventNum = Random.Range(0, 100);

        if (energy >= 2)
        {
            energy -= 2;
            Debug.Log("體力消耗");
        }
        else
        {
            Debug.Log("體力不足，無法繼續冒險下去");
            return;
        }

        


        if (eventNum >= 65)
        {

            int monsterNum = Random.Range(0, monsters.Length);
            hp -= monsters[monsterNum].GetComponent<Monster>().mFp;
            exp += monsters[monsterNum].GetComponent<Monster>().mExp;
            //hp -= Random.Range(5,25);
            //exp += Random.Range(5, 10);
            
            if (exp >= lvupExp)
            {
                exp -= lvupExp;
                level++;
                lvupExp += lvupExpPlus;
                lvupExpPlus += 2;
                hp = maxhp;
                //Debug.Log("玩家等級提升了");

                Debug.Log(
                "<color=red>遭遇" + monsters[monsterNum].GetComponent<Monster>().monsterName +
                "攻擊，生命值減少" + monsters[monsterNum].GetComponent<Monster>().mFp +
                "，經驗值增加" + monsters[monsterNum].GetComponent<Monster>().mExp +
                "，玩家等級提升了</color>"
                );
                textobj.createText(
                    "遭遇" + monsters[monsterNum].GetComponent<Monster>().monsterName +
                    "攻擊，生命值減少" + monsters[monsterNum].GetComponent<Monster>().mFp +
                    "，經驗值增加" + monsters[monsterNum].GetComponent<Monster>().mExp +
                    "，玩家等級提升了"
                );
            }
            else 
            {
                Debug.Log(
                "<color=red>遭遇" + monsters[monsterNum].GetComponent<Monster>().monsterName +
                "攻擊，生命值減少" + monsters[monsterNum].GetComponent<Monster>().mFp +
                "，經驗值增加" + monsters[monsterNum].GetComponent<Monster>().mExp +
                "</color>"
                );
                textobj.createText(
                    "遭遇" + monsters[monsterNum].GetComponent<Monster>().monsterName +
                    "攻擊，生命值減少" + monsters[monsterNum].GetComponent<Monster>().mFp +
                    "，經驗值增加" + monsters[monsterNum].GetComponent<Monster>().mExp
                );
            }
        }
        else if (eventNum < 64 && eventNum >= 50)
        {
            money += 150;
            Debug.Log("<color=aqua>發現寶藏，得到金錢1500元</color>");
            textobj.createText("發現寶藏，得到金錢1500元");
        }
        else if (eventNum < 50 && eventNum >= 45)
        {
            maxhp += 10;
            hp += 10;
            Debug.Log("<color=green>發現生命果實，生命值增加10點</color>");
            textobj.createText("發現生命果實，生命值增加10點");
        }
        else if (eventNum < 45 && eventNum >= 30)
        {
            hp += 10;
            Debug.Log("<color=orange>撿到傷藥，生命值恢復10點</color>");
            textobj.createText("撿到傷藥，生命值恢復10點");
        }
        else
        {
            Debug.Log("沒有發生任何事，平安度過");
            textobj.createText("沒有發生任何事，平安度過");
        }

        


        if (hp > maxhp)
        {
            hp = maxhp;
        }

        if (hp <= 0)
        {
            hp = 0;
            gameoverWindow.SetActive(true);
        }

        lvtext.text = level.ToString() + "等";
        hptext.text = hp.ToString() + "/" + maxhp.ToString();
        exptext.text = exp.ToString() + "/" + lvupExp.ToString();
        moneytext.text = money.ToString() + "元";




    }

    public void reStartgame()
    {
        //maxhp = 50;
        //hp = maxhp;

        //maxenergy = 10;
        //energy = maxenergy;

        //level = 1;
        //exp = 0;

        //money = startMoney;
        Debug.Log("玩家復活，重新開始遊戲");

        SceneManager.LoadScene(1);
    }
    public void startGame()
    {
        playName = inputplayname.text;
        nameText.text = playName;
        
        showplayer();

        

    }

}
