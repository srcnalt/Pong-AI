using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongAcademy : Academy
{
    [HideInInspector]
    public float paddleScale;

    public bool isTraining;

    public override void InitializeAcademy()
    {
        if (isTraining)
        {
            GameObject.Find("Paddle_2").SetActive(false);
        }
        else
        {
            GameObject.Find("TrainingWall").SetActive(false);
        }
    }

    public override void AcademyReset()
    {
        paddleScale = resetParameters["paddleScale"];
    }
}
