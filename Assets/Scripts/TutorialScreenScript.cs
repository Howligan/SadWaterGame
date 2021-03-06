﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialScreenScript : MonoBehaviour {

    public GameObject WelcomeText;
    public GameObject GoOverText;
    public GameObject ControlLeftText;
    public GameObject ControlRightText;
    public GameObject GrabBottleText;
    public GameObject CatchWaterText;
    public GameObject DirtyWaterText;
    public GameObject NewBottleText;
    public GameObject FillBottleText;
    public GameObject BackOfTruckText;
    public GameObject ScoreText;
    public GameObject HPText;
    public GameObject LoseConText;
    public GameObject TutorialDoneText;
    public int StepCounter;

    private void Start()
    {
        StepCounter = 0;
    }

    private void Update()
    {
        InfoCounter();
    }

    void InfoCounter()
    {
        if (StepCounter == 0) // Welcome Text
        {
            WelcomeText.GetComponent<Text>().enabled = true;
            GoOverText.GetComponent<Text>().enabled = false;
            ControlLeftText.GetComponent<Text>().enabled = false;
            ControlRightText.GetComponent<Text>().enabled = false;
            GrabBottleText.GetComponent<Text>().enabled = false;
            CatchWaterText.GetComponent<Text>().enabled = false;
            DirtyWaterText.GetComponent<Text>().enabled = false;
            NewBottleText.GetComponent<Text>().enabled = false;
            FillBottleText.GetComponent<Text>().enabled = false;
            BackOfTruckText.GetComponent<Text>().enabled = false;
            ScoreText.GetComponent<Text>().enabled = false;
            HPText.GetComponent<Text>().enabled = false;
            LoseConText.GetComponent<Text>().enabled = false;
            TutorialDoneText.GetComponent<Text>().enabled = false;
        }
        else
        if (StepCounter == 1) // Go Over Text
        {
            WelcomeText.GetComponent<Text>().enabled = false;
            GoOverText.GetComponent<Text>().enabled = true;
            ControlLeftText.GetComponent<Text>().enabled = false;
            ControlRightText.GetComponent<Text>().enabled = false;
            GrabBottleText.GetComponent<Text>().enabled = false;
            CatchWaterText.GetComponent<Text>().enabled = false;
            DirtyWaterText.GetComponent<Text>().enabled = false;
            NewBottleText.GetComponent<Text>().enabled = false;
            FillBottleText.GetComponent<Text>().enabled = false;
            BackOfTruckText.GetComponent<Text>().enabled = false;
            ScoreText.GetComponent<Text>().enabled = false;
            HPText.GetComponent<Text>().enabled = false;
            LoseConText.GetComponent<Text>().enabled = false;
            TutorialDoneText.GetComponent<Text>().enabled = false;
        }
        else
        if (StepCounter == 2) // Control Left Text
        {
            WelcomeText.GetComponent<Text>().enabled = false;
            GoOverText.GetComponent<Text>().enabled = false;
            ControlLeftText.GetComponent<Text>().enabled = true;
            ControlRightText.GetComponent<Text>().enabled = false;
            GrabBottleText.GetComponent<Text>().enabled = false;
            CatchWaterText.GetComponent<Text>().enabled = false;
            DirtyWaterText.GetComponent<Text>().enabled = false;
            NewBottleText.GetComponent<Text>().enabled = false;
            FillBottleText.GetComponent<Text>().enabled = false;
            BackOfTruckText.GetComponent<Text>().enabled = false;
            ScoreText.GetComponent<Text>().enabled = false;
            HPText.GetComponent<Text>().enabled = false;
            LoseConText.GetComponent<Text>().enabled = false;
            TutorialDoneText.GetComponent<Text>().enabled = false;
        }
        else
         if (StepCounter == 3) // Control Right Text
        {
            WelcomeText.GetComponent<Text>().enabled = false;
            GoOverText.GetComponent<Text>().enabled = false;
            ControlLeftText.GetComponent<Text>().enabled = false;
            ControlRightText.GetComponent<Text>().enabled = true;
            GrabBottleText.GetComponent<Text>().enabled = false;
            CatchWaterText.GetComponent<Text>().enabled = false;
            DirtyWaterText.GetComponent<Text>().enabled = false;
            NewBottleText.GetComponent<Text>().enabled = false;
            FillBottleText.GetComponent<Text>().enabled = false;
            BackOfTruckText.GetComponent<Text>().enabled = false;
            ScoreText.GetComponent<Text>().enabled = false;
            HPText.GetComponent<Text>().enabled = false;
            LoseConText.GetComponent<Text>().enabled = false;
            TutorialDoneText.GetComponent<Text>().enabled = false;
        }
        else
        if (StepCounter == 4) // Grab Bottle Text
        {
            WelcomeText.GetComponent<Text>().enabled = false;
            GoOverText.GetComponent<Text>().enabled = false;
            ControlLeftText.GetComponent<Text>().enabled = false;
            ControlRightText.GetComponent<Text>().enabled = false;
            GrabBottleText.GetComponent<Text>().enabled = true;
            CatchWaterText.GetComponent<Text>().enabled = false;
            DirtyWaterText.GetComponent<Text>().enabled = false;
            NewBottleText.GetComponent<Text>().enabled = false;
            FillBottleText.GetComponent<Text>().enabled = false;
            BackOfTruckText.GetComponent<Text>().enabled = false;
            ScoreText.GetComponent<Text>().enabled = false;
            HPText.GetComponent<Text>().enabled = false;
            LoseConText.GetComponent<Text>().enabled = false;
            TutorialDoneText.GetComponent<Text>().enabled = false;
        }
        else
        if (StepCounter == 5) // Catch Water Text
        {
            WelcomeText.GetComponent<Text>().enabled = false;
            GoOverText.GetComponent<Text>().enabled = false;
            ControlLeftText.GetComponent<Text>().enabled = false;
            ControlRightText.GetComponent<Text>().enabled = false;
            GrabBottleText.GetComponent<Text>().enabled = false;
            CatchWaterText.GetComponent<Text>().enabled = true;
            DirtyWaterText.GetComponent<Text>().enabled = false;
            NewBottleText.GetComponent<Text>().enabled = false;
            FillBottleText.GetComponent<Text>().enabled = false;
            BackOfTruckText.GetComponent<Text>().enabled = false;
            ScoreText.GetComponent<Text>().enabled = false;
            HPText.GetComponent<Text>().enabled = false;
            LoseConText.GetComponent<Text>().enabled = false;
            TutorialDoneText.GetComponent<Text>().enabled = false;
        }
        else
         if (StepCounter == 6) // Dirty Water Text
        {
            WelcomeText.GetComponent<Text>().enabled = false;
            GoOverText.GetComponent<Text>().enabled = false;
            ControlLeftText.GetComponent<Text>().enabled = false;
            ControlRightText.GetComponent<Text>().enabled = false;
            GrabBottleText.GetComponent<Text>().enabled = false;
            CatchWaterText.GetComponent<Text>().enabled = false;
            DirtyWaterText.GetComponent<Text>().enabled = true;
            NewBottleText.GetComponent<Text>().enabled = false;
            FillBottleText.GetComponent<Text>().enabled = false;
            BackOfTruckText.GetComponent<Text>().enabled = false;
            ScoreText.GetComponent<Text>().enabled = false;
            HPText.GetComponent<Text>().enabled = false;
            LoseConText.GetComponent<Text>().enabled = false;
            TutorialDoneText.GetComponent<Text>().enabled = false;
        }
        else
        if (StepCounter == 7) // New Bottle Text
        {
            WelcomeText.GetComponent<Text>().enabled = false;
            GoOverText.GetComponent<Text>().enabled = false;
            ControlLeftText.GetComponent<Text>().enabled = false;
            ControlRightText.GetComponent<Text>().enabled = false;
            GrabBottleText.GetComponent<Text>().enabled = false;
            CatchWaterText.GetComponent<Text>().enabled = false;
            DirtyWaterText.GetComponent<Text>().enabled = false;
            NewBottleText.GetComponent<Text>().enabled = true;
            FillBottleText.GetComponent<Text>().enabled = false;
            BackOfTruckText.GetComponent<Text>().enabled = false;
            ScoreText.GetComponent<Text>().enabled = false;
            HPText.GetComponent<Text>().enabled = false;
            LoseConText.GetComponent<Text>().enabled = false;
            TutorialDoneText.GetComponent<Text>().enabled = false;
        }
        else
        if (StepCounter == 8) // Fill Bottle Text
        {
            WelcomeText.GetComponent<Text>().enabled = false;
            GoOverText.GetComponent<Text>().enabled = false;
            ControlLeftText.GetComponent<Text>().enabled = false;
            ControlRightText.GetComponent<Text>().enabled = false;
            GrabBottleText.GetComponent<Text>().enabled = false;
            CatchWaterText.GetComponent<Text>().enabled = false;
            DirtyWaterText.GetComponent<Text>().enabled = false;
            NewBottleText.GetComponent<Text>().enabled = false;
            FillBottleText.GetComponent<Text>().enabled = true;
            BackOfTruckText.GetComponent<Text>().enabled = false;
            ScoreText.GetComponent<Text>().enabled = false;
            HPText.GetComponent<Text>().enabled = false;
            LoseConText.GetComponent<Text>().enabled = false;
            TutorialDoneText.GetComponent<Text>().enabled = false;
        }
        else
         if (StepCounter == 9) // Back of Truck Text
        {
            WelcomeText.GetComponent<Text>().enabled = false;
            GoOverText.GetComponent<Text>().enabled = false;
            ControlLeftText.GetComponent<Text>().enabled = false;
            ControlRightText.GetComponent<Text>().enabled = false;
            GrabBottleText.GetComponent<Text>().enabled = false;
            CatchWaterText.GetComponent<Text>().enabled = false;
            DirtyWaterText.GetComponent<Text>().enabled = false;
            NewBottleText.GetComponent<Text>().enabled = false;
            FillBottleText.GetComponent<Text>().enabled = false;
            BackOfTruckText.GetComponent<Text>().enabled = true;
            ScoreText.GetComponent<Text>().enabled = false;
            HPText.GetComponent<Text>().enabled = false;
            LoseConText.GetComponent<Text>().enabled = false;
            TutorialDoneText.GetComponent<Text>().enabled = false;
        }
        else
        if (StepCounter == 10) // Score Text
        {
            WelcomeText.GetComponent<Text>().enabled = false;
            GoOverText.GetComponent<Text>().enabled = false;
            ControlLeftText.GetComponent<Text>().enabled = false;
            ControlRightText.GetComponent<Text>().enabled = false;
            GrabBottleText.GetComponent<Text>().enabled = false;
            CatchWaterText.GetComponent<Text>().enabled = false;
            DirtyWaterText.GetComponent<Text>().enabled = false;
            NewBottleText.GetComponent<Text>().enabled = false;
            FillBottleText.GetComponent<Text>().enabled = false;
            BackOfTruckText.GetComponent<Text>().enabled = false;
            ScoreText.GetComponent<Text>().enabled = true;
            HPText.GetComponent<Text>().enabled = false;
            LoseConText.GetComponent<Text>().enabled = false;
            TutorialDoneText.GetComponent<Text>().enabled = false;
        }
        else
        if (StepCounter == 11) // HP text
        {
            WelcomeText.GetComponent<Text>().enabled = false;
            GoOverText.GetComponent<Text>().enabled = false;
            ControlLeftText.GetComponent<Text>().enabled = false;
            ControlRightText.GetComponent<Text>().enabled = false;
            GrabBottleText.GetComponent<Text>().enabled = false;
            CatchWaterText.GetComponent<Text>().enabled = false;
            DirtyWaterText.GetComponent<Text>().enabled = false;
            NewBottleText.GetComponent<Text>().enabled = false;
            FillBottleText.GetComponent<Text>().enabled = false;
            BackOfTruckText.GetComponent<Text>().enabled = false;
            ScoreText.GetComponent<Text>().enabled = false;
            HPText.GetComponent<Text>().enabled = true;
            LoseConText.GetComponent<Text>().enabled = false;
            TutorialDoneText.GetComponent<Text>().enabled = false;
        }
        else
        if (StepCounter == 12) // Lose Con Text
        {
            WelcomeText.GetComponent<Text>().enabled = false;
            GoOverText.GetComponent<Text>().enabled = false;
            ControlLeftText.GetComponent<Text>().enabled = false;
            ControlRightText.GetComponent<Text>().enabled = false;
            GrabBottleText.GetComponent<Text>().enabled = false;
            CatchWaterText.GetComponent<Text>().enabled = false;
            DirtyWaterText.GetComponent<Text>().enabled = false;
            NewBottleText.GetComponent<Text>().enabled = false;
            FillBottleText.GetComponent<Text>().enabled = false;
            BackOfTruckText.GetComponent<Text>().enabled = false;
            ScoreText.GetComponent<Text>().enabled = false;
            HPText.GetComponent<Text>().enabled = false;
            LoseConText.GetComponent<Text>().enabled = true;
            TutorialDoneText.GetComponent<Text>().enabled = false;
        }
        else
        if (StepCounter == 13) // Tutorial Done Text
        {
            WelcomeText.GetComponent<Text>().enabled = false;
            GoOverText.GetComponent<Text>().enabled = false;
            ControlLeftText.GetComponent<Text>().enabled = false;
            ControlRightText.GetComponent<Text>().enabled = false;
            GrabBottleText.GetComponent<Text>().enabled = false;
            CatchWaterText.GetComponent<Text>().enabled = false;
            DirtyWaterText.GetComponent<Text>().enabled = false;
            NewBottleText.GetComponent<Text>().enabled = false;
            FillBottleText.GetComponent<Text>().enabled = false;
            BackOfTruckText.GetComponent<Text>().enabled = false;
            ScoreText.GetComponent<Text>().enabled = false;
            HPText.GetComponent<Text>().enabled = false;
            LoseConText.GetComponent<Text>().enabled = false;
            TutorialDoneText.GetComponent<Text>().enabled = true;
        }
        else
        if (StepCounter == 14)
        {
            SceneManager.LoadScene("main");
        }
    }

    public void ScreenButton()
    {
        StepCounter++;
    }
}
