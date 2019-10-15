using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class QuizManager : MonoBehaviour
{   public float time;
    public TextMeshProUGUI finalScore;
    public static int score = 0;

public UnityEvent delayedClick;

    void Awake ()
    {
        if (delayedClick == null)
            delayedClick = new UnityEvent();
    }
    IEnumerator next (float time)
    {
        yield return new WaitForSeconds(time);
        delayedClick.Invoke();
    }

    public void incrementScore()
    {
        score += 1;
    }

    public void initClick ()
    {
        StartCoroutine(next(time));
    }

    void Update()
    {
        
        if (finalScore != null)
        {
            if (finalScore.isActiveAndEnabled) finalScore.SetText( "Your score is: \n" + score.ToString() );
        }

    }
}
