using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimersCountdown : MonoBehaviour
{
    public Text lapTime;
    public Text startCountdownTime;

    public float totalLapTime;
    public float totalCountdownTime;
    public CodeyMove codeyMove;


    // Update is called once per frame
    void Update()
    {
        
        if(totalCountdownTime >= 0)
        {
            totalCountdownTime -= Time.deltaTime;
            startCountdownTime.text = totalCountdownTime.ToString();

        }
        else
        {

            codeyMove.canMove = true;
        }
            
        if(totalCountdownTime <= 0)
        {
            if (startCountdownTime.IsActive())
            {
                startCountdownTime.gameObject.SetActive(false);
                Debug.Log("Active");
            }
            totalLapTime -= Time.deltaTime;
            lapTime.text = totalLapTime.ToString();
        }

        if (totalLapTime <= 0)
        {
            Debug.Log("Time is up!");
            lapTime.text = Mathf.Round(totalLapTime).ToString();
            startCountdownTime.text = Mathf.Round(totalCountdownTime).ToString();
            SceneManager.LoadScene(2);
        }
    }
}
