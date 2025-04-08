using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAdd : MonoBehaviour
{
    [SerializeField] Text score;
    string defaultText;

    int intScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        defaultText = "Score : ";
        score.text = defaultText + intScore.ToString();
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            intScore++;            
            score.text = defaultText + intScore.ToString();
            other.GetComponent<BallCS>().ReSetPos();
        }
    }
}
