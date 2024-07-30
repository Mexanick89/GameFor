using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class FishkaControll : MonoBehaviour
{
    private GameObject GameMainPoints;
    private LineBox scriptLineBox;

    public float speed = 2f;


    Vector3 Point0100 = new Vector3(0f, 10f);
    Vector3 Point0101 = new Vector3(0f, 8f);
    Vector3 Point0102 = new Vector3(0f, 6f);
    Vector3 Point0103 = new Vector3(0f, 4f);
    Vector3 Point0104 = new Vector3(0f, 2f);
    Vector3 Point0105 = new Vector3(0f, 0f);

    Vector3 Point0200 = new Vector2(2f, 10f);
    Vector3 Point0201 = new Vector2(2f, 8f);
    Vector3 Point0202 = new Vector2(2f, 6);
    Vector3 Point0203 = new Vector2(2f, 4f);
    Vector3 Point0204 = new Vector2(2f, 2f);
    Vector3 Point0205 = new Vector2(2f, 0f);

    Vector3 Point0300 = new Vector2(4f, 10f);
    Vector3 Point0301 = new Vector2(4f, 8f);
    Vector3 Point0302 = new Vector2(4f, 6f);
    Vector3 Point0303 = new Vector2(4f, 4f);
    Vector3 Point0304 = new Vector2(4f, 2f);
    Vector3 Point0305 = new Vector2(4f, 0f);

    Vector3 Point0400 = new Vector2(6f, 10f);
    Vector3 Point0401 = new Vector2(6f, 8f);
    Vector3 Point0402 = new Vector2(6f, 6f);
    Vector3 Point0403 = new Vector2(6f, 4f);
    Vector3 Point0404 = new Vector2(6f, 2f);
    Vector3 Point0405 = new Vector2(6f, 0f);

    Vector3 Point0500 = new Vector2(8f, 10f);
    Vector3 Point0501 = new Vector2(8f, 8f);
    Vector3 Point0502 = new Vector2(8f, 6f);
    Vector3 Point0503 = new Vector2(8f, 4f);
    Vector3 Point0504 = new Vector2(8f, 2f);
    Vector3 Point0505 = new Vector2(8f, 0f);

    private void Start()
    {
        GameMainPoints = GameObject.Find("MainPoints");
        scriptLineBox = GameMainPoints.GetComponent<LineBox>();
    }

    private void FixedUpdate()
    {
        CheckPosition01();
        CheckPosition02();
        CheckPosition03();
        CheckPosition04();
        CheckPosition05();
    }

    void Move0101()
    {
        Vector3 direction = (Point0101 - Point0100).normalized;
        Point0100 += direction * speed * Time.deltaTime;
        transform.position = Point0100;

        if (Vector3.Distance(Point0100, Point0101) <= 0.1f)
        {
            Point0100 = Point0101;
        }
    }
    void Move0102()
    {
        Vector3 direction2 = (Point0102 - Point0101).normalized;
        Point0101 += direction2 * speed * Time.deltaTime;
        transform.position = Point0101;

        if (Vector3.Distance(Point0101, Point0102) <= 0.1f)
        {
            Point0101 = Point0102;
        }
    }
    void Move0103()
    {
        Vector3 direction3 = (Point0103 - Point0102).normalized;
        Point0102 += direction3 * speed * Time.deltaTime;
        transform.position = Point0102;

        if (Vector3.Distance(Point0102, Point0103) <= 0.1f)
        {
            Point0102 = Point0103;
        }
    }
    void Move0104()
    {
        Vector3 direction4 = (Point0104 - Point0103).normalized;
        Point0103 += direction4 * speed * Time.deltaTime;
        transform.position = Point0103;

        if (Vector3.Distance(Point0103, Point0104) <= 0.1f)
        {
            Point0103 = Point0104;
        }
    }
    void Move0105()
    {
        Vector3 direction5 = (Point0105 - Point0104).normalized;
        Point0104 += direction5 * speed * Time.deltaTime;
        transform.position = Point0104;

        if (Vector3.Distance(Point0104, Point0105) <= 0.1f)
        {
            Point0104 = Point0105;
        }
    }

    private void CheckPosition01()
    {
            if (Vector3.Distance(transform.position, Point0100) == 0.0f)
            {
                if (scriptLineBox.point0101 == true)
                {
                Move0101();
                }
            }

            if (Vector3.Distance(transform.position, Point0101) <= 0.10f)
            {
                if (scriptLineBox.point0102 == true)
                {
                Move0102();
                }
            }

            if (Vector3.Distance(transform.position, Point0102) <= 0.10f)
            {
                if (scriptLineBox.point0103 == true)
                {
                Move0103();
                }
            }

            if (Vector3.Distance(transform.position, Point0103) <= 0.10f)
            {
                if (scriptLineBox.point0104 == true)
                {
                Move0104();
                }
            }

            if (Vector3.Distance(transform.position, Point0104) <= 0.10f)
            {
                if (scriptLineBox.point0105 == true)
                {
                Move0105();
                }
            }
    }

    void Move0201()
    {
        Vector3 direction02 = (Point0201 - Point0200).normalized;
        Point0200 += direction02 * speed * Time.deltaTime;
        transform.position = Point0200;

        if (Vector3.Distance(Point0200, Point0201) <= 0.1f)
        {
            Point0200 = Point0201;
        }
    }
    void Move0202()
    {
        Vector3 direction022 = (Point0202 - Point0201).normalized;
        Point0201 += direction022 * speed * Time.deltaTime;
        transform.position = Point0201;

        if (Vector3.Distance(Point0201, Point0202) <= 0.1f)
        {
            Point0201 = Point0202;
        }
    }
    void Move0203()
    {
        Vector3 direction023 = (Point0203 - Point0202).normalized;
        Point0202 += direction023 * speed * Time.deltaTime;
        transform.position = Point0202;

        if (Vector3.Distance(Point0202, Point0203) <= 0.1f)
        {
            Point0202 = Point0203;
        }
    }
    void Move0204()
    {
        Vector3 direction024 = (Point0204 - Point0203).normalized;
        Point0203 += direction024 * speed * Time.deltaTime;
        transform.position = Point0203;

        if (Vector3.Distance(Point0203, Point0204) <= 0.1f)
        {
            Point0203 = Point0204;
        }
    }
    void Move0205()
    {
        Vector3 direction025 = (Point0205 - Point0204).normalized;
        Point0204 += direction025 * speed * Time.deltaTime;
        transform.position = Point0204;

        if (Vector3.Distance(Point0204, Point0205) <= 0.1f)
        {
            Point0204 = Point0205;
        }
    }

    private void CheckPosition02()
    {
        if (Vector3.Distance(transform.position, Point0200) == 0.0f)
        {
            if (scriptLineBox.point0201 == true)
            {
                Move0201();
            }
        }

        if (Vector3.Distance(transform.position, Point0201) <= 0.10f)
        {
            if (scriptLineBox.point0202 == true)
            {
                Move0202();
            }
        }

        if (Vector3.Distance(transform.position, Point0202) <= 0.10f)
        {
            if (scriptLineBox.point0203 == true)
            {
                Move0203();
            }
        }

        if (Vector3.Distance(transform.position, Point0203) <= 0.10f)
        {
            if (scriptLineBox.point0204 == true)
            {
                Move0204();
            }
        }

        if (Vector3.Distance(transform.position, Point0204) <= 0.10f)
        {
            if (scriptLineBox.point0205 == true)
            {
                Move0205();
            }
        }
    }

    void Move0301()
    {
        Vector3 direction03 = (Point0301 - Point0300).normalized;
        Point0300 += direction03 * speed * Time.deltaTime;
        transform.position = Point0300;

        if (Vector3.Distance(Point0300, Point0301) <= 0.1f)
        {
            Point0300 = Point0301;
        }
    }
    void Move0302()
    {
        Vector3 direction032 = (Point0302 - Point0301).normalized;
        Point0301 += direction032 * speed * Time.deltaTime;
        transform.position = Point0301;

        if (Vector3.Distance(Point0301, Point0302) <= 0.1f)
        {
            Point0301 = Point0302;
        }
    }
    void Move0303()
    {
        Vector3 direction033 = (Point0303 - Point0302).normalized;
        Point0302 += direction033 * speed * Time.deltaTime;
        transform.position = Point0302;

        if (Vector3.Distance(Point0302, Point0303) <= 0.1f)
        {
            Point0302 = Point0303;
        }
    }
    void Move0304()
    {
        Vector3 direction034 = (Point0304 - Point0303).normalized;
        Point0303 += direction034 * speed * Time.deltaTime;
        transform.position = Point0303;

        if (Vector3.Distance(Point0303, Point0304) <= 0.1f)
        {
            Point0303 = Point0304;
        }
    }
    void Move0305()
    {
        Vector3 direction035 = (Point0305 - Point0304).normalized;
        Point0304 += direction035 * speed * Time.deltaTime;
        transform.position = Point0304;

        if (Vector3.Distance(Point0304, Point0305) <= 0.1f)
        {
            Point0304 = Point0305;
        }
    }

    private void CheckPosition03()
    {
        if (Vector3.Distance(transform.position, Point0300) == 0.0f)
        {
            if (scriptLineBox.point0301 == true)
            {
                Move0301();
            }
        }

        if (Vector3.Distance(transform.position, Point0301) <= 0.10f)
        {
            if (scriptLineBox.point0302 == true)
            {
                Move0302();
            }
        }

        if (Vector3.Distance(transform.position, Point0302) <= 0.10f)
        {
            if (scriptLineBox.point0303 == true)
            {
                Move0303();
            }
        }

        if (Vector3.Distance(transform.position, Point0303) <= 0.10f)
        {
            if (scriptLineBox.point0304 == true)
            {
                Move0304();
            }
        }

        if (Vector3.Distance(transform.position, Point0304) <= 0.10f)
        {
            if (scriptLineBox.point0305 == true)
            {
                Move0305();
            }
        }
    }

    void Move0401()
    {
        Vector3 direction04 = (Point0401 - Point0400).normalized;
        Point0400 += direction04 * speed * Time.deltaTime;
        transform.position = Point0400;

        if (Vector3.Distance(Point0400, Point0401) <= 0.1f)
        {
            Point0400 = Point0401;
        }
    }
    void Move0402()
    {
        Vector3 direction042 = (Point0402 - Point0401).normalized;
        Point0401 += direction042 * speed * Time.deltaTime;
        transform.position = Point0401;

        if (Vector3.Distance(Point0401, Point0402) <= 0.1f)
        {
            Point0401 = Point0402;
        }
    }
    void Move0403()
    {
        Vector3 direction043 = (Point0403 - Point0402).normalized;
        Point0402 += direction043 * speed * Time.deltaTime;
        transform.position = Point0402;

        if (Vector3.Distance(Point0102, Point0103) <= 0.1f)
        {
            Point0402 = Point0403;
        }
    }
    void Move0404()
    {
        Vector3 direction044 = (Point0404 - Point0403).normalized;
        Point0403 += direction044 * speed * Time.deltaTime;
        transform.position = Point0403;

        if (Vector3.Distance(Point0403, Point0404) <= 0.1f)
        {
            Point0403 = Point0404;
        }
    }
    void Move0405()
    {
        Vector3 direction045 = (Point0405 - Point0404).normalized;
        Point0404 += direction045 * speed * Time.deltaTime;
        transform.position = Point0404;

        if (Vector3.Distance(Point0404, Point0405) <= 0.1f)
        {
            Point0404 = Point0405;
        }
    }

    private void CheckPosition04()
    {
        if (Vector3.Distance(transform.position, Point0400) == 0.0f)
        {
            if (scriptLineBox.point0401 == true)
            {
                Move0401();
            }
        }

        if (Vector3.Distance(transform.position, Point0401) <= 0.10f)
        {
            if (scriptLineBox.point0402 == true)
            {
                Move0402();
            }
        }

        if (Vector3.Distance(transform.position, Point0402) <= 0.10f)
        {
            if (scriptLineBox.point0403 == true)
            {
                Move0403();
            }
        }

        if (Vector3.Distance(transform.position, Point0403) <= 0.10f)
        {
            if (scriptLineBox.point0404 == true)
            {
                Move0404();
            }
        }

        if (Vector3.Distance(transform.position, Point0404) <= 0.10f)
        {
            if (scriptLineBox.point0405 == true)
            {
                Move0405();
            }
        }
    }

    void Move0501()
    {
        Vector3 direction05 = (Point0501 - Point0500).normalized;
        Point0500 += direction05 * speed * Time.deltaTime;
        transform.position = Point0500;

        if (Vector3.Distance(Point0500, Point0501) <= 0.1f)
        {
            Point0500 = Point0501;
        }
    }
    void Move0502()
    {
        Vector3 direction052 = (Point0502 - Point0501).normalized;
        Point0501 += direction052 * speed * Time.deltaTime;
        transform.position = Point0501;

        if (Vector3.Distance(Point0501, Point0502) <= 0.1f)
        {
            Point0501 = Point0502;
        }
    }
    void Move0503()
    {
        Vector3 direction053 = (Point0503 - Point0502).normalized;
        Point0502 += direction053 * speed * Time.deltaTime;
        transform.position = Point0502;

        if (Vector3.Distance(Point0502, Point0503) <= 0.1f)
        {
            Point0502 = Point0503;
        }
    }
    void Move0504()
    {
        Vector3 direction054 = (Point0504 - Point0503).normalized;
        Point0503 += direction054 * speed * Time.deltaTime;
        transform.position = Point0503;

        if (Vector3.Distance(Point0503, Point0504) <= 0.1f)
        {
            Point0503 = Point0504;
        }
    }
    void Move0505()
    {
        Vector3 direction055 = (Point0505 - Point0504).normalized;
        Point0504 += direction055 * speed * Time.deltaTime;
        transform.position = Point0504;

        if (Vector3.Distance(Point0504, Point0505) <= 0.1f)
        {
            Point0504 = Point0505;
        }
    }

    private void CheckPosition05()
    {
        if (Vector3.Distance(transform.position, Point0500) == 0.0f)
        {
            if (scriptLineBox.point0501 == true)
            {
                Move0501();
            }
        }

        if (Vector3.Distance(transform.position, Point0501) <= 0.10f)
        {
            if (scriptLineBox.point0502 == true)
            {
                Move0502();
            }
        }

        if (Vector3.Distance(transform.position, Point0502) <= 0.10f)
        {
            if (scriptLineBox.point0503 == true)
            {
                Move0503();
            }
        }

        if (Vector3.Distance(transform.position, Point0503) <= 0.10f)
        {
            if (scriptLineBox.point0504 == true)
            {
                Move0504();
            }
        }

        if (Vector3.Distance(transform.position, Point0504) <= 0.10f)
        {
            if (scriptLineBox.point0505 == true)
            {
                Move0505();
            }
        }
    }

}

