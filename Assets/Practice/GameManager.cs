using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject cam;
    public Transform[] camPos;
    public Text scorePointText;
    public int scorePoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void restartGame(string stageName)
    { 
        SceneManager.LoadScene(stageName);
    }

    public void changeCamPos(int camNum)
    {
        cam.transform.position = camPos[camNum].position;
    }
    public void addScorePoint(int sp)
    {
        scorePoint += sp;
        scorePointText.text = scorePoint.ToString();
    }

}
