using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Buttons : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Night()
    {
        SceneManager.LoadScene("Night");

    }

    public void Day()
    {
        SceneManager.LoadScene("Day");

    }


    public void Quit()
    {
        Application.Quit();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (SceneManager.GetActiveScene().name == "Night")
            {
                SceneManager.LoadScene("Day");


            }

            else 
            {
                SceneManager.LoadScene("Night");
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        
        }

    }

}
