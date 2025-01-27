using UnityEngine;

public class SetTitle : MonoBehaviour
{
    private GameObject end;
    private GameObject win;

    void Start()
    {
        end = GameObject.FindGameObjectWithTag("End");
        win = GameObject.FindGameObjectWithTag("Win");

        if (DataManager.Title == 1)
        {
            end.SetActive(true);
            win.SetActive(false);
        }
        else
        {
            end.SetActive(false);
            win.SetActive(true);
        }
    }
}
