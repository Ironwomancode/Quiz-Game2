using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;
using System.ComponentModel;
using static UnityEditor.Experimental.GraphView.GraphView;

public class GameManager_L1 : MonoBehaviour
{
    public Question[] questions;
    //have the question to desapier after answering 
    private static List<Question> unansweredQuestions;
    private Question currentQuestion;


    private int totalCorrect = 0;

    public Transform scoreObj;

    //setting up the UI text on the quizz
    [SerializeField]
    //private Text factText;

    //time between question - one second
   // [SerializeField]
    private float timeBetweenQuestions = 1f;

    [SerializeField]
    //private Text trueAnswerText;
    //[SerializeField]
    //private Text falseAnswerText;

    //[SerializeField]
    private Animator animator;

    void Start()
    {
        //playerMoveText = GameObject.Find("playerMoveText");
        //player = GameObject.Find("Player1");
        //player.GetComponent<FollowThePath>().moveAllowed = false;
        //method to have the question till finish
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<Question>();
        }
        SetCurrentQuestion();
        //Debug.Log(currentQuestion.fact + " is " + currentQuestion.isTrue);
    }
    void SetCurrentQuestion()
    {

        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];
        //access the current question
        //factText.text = currentQuestion.fact;

        if (currentQuestion.isTrue)
        {
            //scoreObj.GetComponent<Text>().text = "Score:" + totalCorrect;
            //trueAnswerText.text = "Correct";
           // falseAnswerText.text = "Wrong";
        }
        else
        {
           // trueAnswerText.text = "Wrong";
           // falseAnswerText.text = "Correct";
        }

    }

    IEnumerator TransitionToNextQuestion()
    {
        //dont peak the same question twice
        unansweredQuestions.Remove(currentQuestion);
        yield return new WaitForSeconds(timeBetweenQuestions);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void UserSelectTrue()
    {
        //scoreObj.GetComponent<Text>().text = "Score:" + totalCorrect;
        animator.SetTrigger("True");
        if (currentQuestion.isTrue)
        {
            Debug.Log("Correct");
            totalCorrect += 10;

        }
        else
        {
            Debug.Log("Wrong");
        }
        StartCoroutine(TransitionToNextQuestion());
    }
    public void UserSelectFalse()
    {
        //scoreObj.GetComponent<Text>().text = "Score: " + totalCorrect;
        animator.SetTrigger("False");
        if (!currentQuestion.isTrue)
        {
            Debug.Log("Correct");
            //totalCorrect += 10;

        }
        else
        {
            Debug.Log("Wrong");
        }
        StartCoroutine(TransitionToNextQuestion());
    }
}


