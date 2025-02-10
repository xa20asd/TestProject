
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
        lvtext.text = level.ToString() + "��";
        hptext.text = hp.ToString() + "/" + maxhp.ToString();
        exptext.text = exp.ToString() + "/" + lvupExp.ToString();
        moneytext.text = money.ToString() + "��";
        Debug.Log("���a�W��:" + playName);
        Debug.Log("���a����:" + level);
        Debug.Log("���a��q:" + hp);
        Debug.Log("���a�g���:" + exp);
        Debug.Log("����:" + money + "��");
    }

    public void go()
    {
        eventNum = Random.Range(0, 100);

        if (energy >= 2)
        {
            energy -= 2;
            Debug.Log("��O����");
        }
        else
        {
            Debug.Log("��O�����A�L�k�~��_�I�U�h");
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
                //Debug.Log("���a���Ŵ��ɤF");

                Debug.Log(
                "<color=red>�D�J" + monsters[monsterNum].GetComponent<Monster>().monsterName +
                "�����A�ͩR�ȴ��" + monsters[monsterNum].GetComponent<Monster>().mFp +
                "�A�g��ȼW�[" + monsters[monsterNum].GetComponent<Monster>().mExp +
                "�A���a���Ŵ��ɤF</color>"
                );
                textobj.createText(
                    "�D�J" + monsters[monsterNum].GetComponent<Monster>().monsterName +
                    "�����A�ͩR�ȴ��" + monsters[monsterNum].GetComponent<Monster>().mFp +
                    "�A�g��ȼW�[" + monsters[monsterNum].GetComponent<Monster>().mExp +
                    "�A���a���Ŵ��ɤF"
                );
            }
            else 
            {
                Debug.Log(
                "<color=red>�D�J" + monsters[monsterNum].GetComponent<Monster>().monsterName +
                "�����A�ͩR�ȴ��" + monsters[monsterNum].GetComponent<Monster>().mFp +
                "�A�g��ȼW�[" + monsters[monsterNum].GetComponent<Monster>().mExp +
                "</color>"
                );
                textobj.createText(
                    "�D�J" + monsters[monsterNum].GetComponent<Monster>().monsterName +
                    "�����A�ͩR�ȴ��" + monsters[monsterNum].GetComponent<Monster>().mFp +
                    "�A�g��ȼW�[" + monsters[monsterNum].GetComponent<Monster>().mExp
                );
            }
        }
        else if (eventNum < 64 && eventNum >= 50)
        {
            money += 150;
            Debug.Log("<color=aqua>�o�{�_�áA�o�����1500��</color>");
            textobj.createText("�o�{�_�áA�o�����1500��");
        }
        else if (eventNum < 50 && eventNum >= 45)
        {
            maxhp += 10;
            hp += 10;
            Debug.Log("<color=green>�o�{�ͩR�G��A�ͩR�ȼW�[10�I</color>");
            textobj.createText("�o�{�ͩR�G��A�ͩR�ȼW�[10�I");
        }
        else if (eventNum < 45 && eventNum >= 30)
        {
            hp += 10;
            Debug.Log("<color=orange>�ߨ���ġA�ͩR�ȫ�_10�I</color>");
            textobj.createText("�ߨ���ġA�ͩR�ȫ�_10�I");
        }
        else
        {
            Debug.Log("�S���o�ͥ���ơA���w�׹L");
            textobj.createText("�S���o�ͥ���ơA���w�׹L");
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

        lvtext.text = level.ToString() + "��";
        hptext.text = hp.ToString() + "/" + maxhp.ToString();
        exptext.text = exp.ToString() + "/" + lvupExp.ToString();
        moneytext.text = money.ToString() + "��";




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
        Debug.Log("���a�_���A���s�}�l�C��");

        SceneManager.LoadScene(1);
    }
    public void startGame()
    {
        playName = inputplayname.text;
        nameText.text = playName;
        
        showplayer();

        

    }

}
