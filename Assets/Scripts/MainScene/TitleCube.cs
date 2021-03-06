﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleCube : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(RotateToAngle());
    }

    private Vector3 GetRandomAngle()
    {
        int xAxis = Random.Range(0, 2) == 0 ? Random.Range(5, 20) : Random.Range(-5, -20);
        int yAxis = Random.Range(0, 2) == 0 ? Random.Range(0, 10) : Random.Range(0, -10);
        int zAxis = Random.Range(0, 2) == 0 ? Random.Range(5, 20) : Random.Range(-5, -20);

        return new Vector3(xAxis, yAxis, zAxis);
    }

    IEnumerator RotateToAngle()
    {
        Vector3 startAngle = gameObject.transform.eulerAngles;
        Vector3 toAngle = GetRandomAngle();
        float timer = 0;

        while(timer <= 1)
        {
            timer += Time.deltaTime / 2;
            gameObject.transform.eulerAngles = Vector3.Lerp(startAngle, toAngle, timer);
            yield return new WaitForFixedUpdate();
        }
    }
}
