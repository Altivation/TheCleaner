using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calendar : MonoBehaviour
{
    [SerializeField] GameObject CalendarPage;

    private bool isCalaendarClicked;
    void Start()
    {
        CalendarPage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenCalendar()
    {
        if (!isCalaendarClicked)
        {
            CalendarPage.SetActive(true);
            isCalaendarClicked = true;
        }
        else
        {
            CalendarPage.SetActive(false);
            isCalaendarClicked = false;
        }
        
     
    }

    public void CloseCalendar()
    {
        CalendarPage.SetActive(false);
        isCalaendarClicked = false;
    }
}
