using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineBox : MonoBehaviour
{


    public bool point0101 = false;
    public bool point0102 = false;
    public bool point0103 = false;
    public bool point0104 = false;
    public bool point0105 = false;

    public bool point0201 = false;
    public bool point0202 = false;
    public bool point0203 = false;
    public bool point0204 = false;
    public bool point0205 = false;

    public bool point0301 = false;
    public bool point0302 = false;
    public bool point0303 = false;
    public bool point0304 = false;
    public bool point0305 = false;

    public bool point0401 = false;
    public bool point0402 = false;
    public bool point0403 = false;
    public bool point0404 = false;
    public bool point0405 = false;

    public bool point0501 = false;
    public bool point0502 = false;
    public bool point0503 = false;
    public bool point0504 = false;
    public bool point0505 = false;

    private BoolBox scriptBoolBox;

    private GameObject BoolBoxPoint0101;
    private GameObject BoolBoxPoint0102;
    private GameObject BoolBoxPoint0103;
    private GameObject BoolBoxPoint0104;
    private GameObject BoolBoxPoint0105;

    private GameObject BoolBoxPoint0201;
    private GameObject BoolBoxPoint0202;
    private GameObject BoolBoxPoint0203;
    private GameObject BoolBoxPoint0204;
    private GameObject BoolBoxPoint0205;

    private GameObject BoolBoxPoint0301;
    private GameObject BoolBoxPoint0302;
    private GameObject BoolBoxPoint0303;
    private GameObject BoolBoxPoint0304;
    private GameObject BoolBoxPoint0305;

    private GameObject BoolBoxPoint0401;
    private GameObject BoolBoxPoint0402;
    private GameObject BoolBoxPoint0403;
    private GameObject BoolBoxPoint0404;
    private GameObject BoolBoxPoint0405;

    private GameObject BoolBoxPoint0501;
    private GameObject BoolBoxPoint0502;
    private GameObject BoolBoxPoint0503;
    private GameObject BoolBoxPoint0504;
    private GameObject BoolBoxPoint0505;


    private void Start()
    {

        BoolBoxPoint0101 = GameObject.Find("0101");
        BoolBoxPoint0102 = GameObject.Find("0102");
        BoolBoxPoint0103 = GameObject.Find("0103");
        BoolBoxPoint0104 = GameObject.Find("0104");
        BoolBoxPoint0105 = GameObject.Find("0105");

        BoolBoxPoint0201 = GameObject.Find("0201");
        BoolBoxPoint0202 = GameObject.Find("0202");
        BoolBoxPoint0203 = GameObject.Find("0203");
        BoolBoxPoint0204 = GameObject.Find("0204");
        BoolBoxPoint0205 = GameObject.Find("0205");

        BoolBoxPoint0301 = GameObject.Find("0301");
        BoolBoxPoint0302 = GameObject.Find("0302");
        BoolBoxPoint0303 = GameObject.Find("0303");
        BoolBoxPoint0304 = GameObject.Find("0304");
        BoolBoxPoint0305 = GameObject.Find("0305");

        BoolBoxPoint0401 = GameObject.Find("0401");
        BoolBoxPoint0402 = GameObject.Find("0402");
        BoolBoxPoint0403 = GameObject.Find("0403");
        BoolBoxPoint0404 = GameObject.Find("0404");
        BoolBoxPoint0405 = GameObject.Find("0405");

        BoolBoxPoint0501 = GameObject.Find("0501");
        BoolBoxPoint0502 = GameObject.Find("0502");
        BoolBoxPoint0503 = GameObject.Find("0503");
        BoolBoxPoint0504 = GameObject.Find("0504");
        BoolBoxPoint0505 = GameObject.Find("0505");

        scriptBoolBox = BoolBoxPoint0101.GetComponent<BoolBox>();
        scriptBoolBox = BoolBoxPoint0102.GetComponent<BoolBox>();
        scriptBoolBox = BoolBoxPoint0103.GetComponent<BoolBox>();
        scriptBoolBox = BoolBoxPoint0104.GetComponent<BoolBox>();
        scriptBoolBox = BoolBoxPoint0105.GetComponent<BoolBox>();

        scriptBoolBox = BoolBoxPoint0201.GetComponent<BoolBox>();
        scriptBoolBox = BoolBoxPoint0202.GetComponent<BoolBox>();
        scriptBoolBox = BoolBoxPoint0203.GetComponent<BoolBox>();
        scriptBoolBox = BoolBoxPoint0204.GetComponent<BoolBox>();
        scriptBoolBox = BoolBoxPoint0205.GetComponent<BoolBox>();

        scriptBoolBox = BoolBoxPoint0301.GetComponent<BoolBox>();
        scriptBoolBox = BoolBoxPoint0302.GetComponent<BoolBox>();
        scriptBoolBox = BoolBoxPoint0303.GetComponent<BoolBox>();
        scriptBoolBox = BoolBoxPoint0304.GetComponent<BoolBox>();
        scriptBoolBox = BoolBoxPoint0305.GetComponent<BoolBox>();

        scriptBoolBox = BoolBoxPoint0401.GetComponent<BoolBox>();
        scriptBoolBox = BoolBoxPoint0402.GetComponent<BoolBox>();
        scriptBoolBox = BoolBoxPoint0403.GetComponent<BoolBox>();
        scriptBoolBox = BoolBoxPoint0404.GetComponent<BoolBox>();
        scriptBoolBox = BoolBoxPoint0405.GetComponent<BoolBox>();

        scriptBoolBox = BoolBoxPoint0501.GetComponent<BoolBox>();
        scriptBoolBox = BoolBoxPoint0502.GetComponent<BoolBox>();
        scriptBoolBox = BoolBoxPoint0503.GetComponent<BoolBox>();
        scriptBoolBox = BoolBoxPoint0504.GetComponent<BoolBox>();
        scriptBoolBox = BoolBoxPoint0505.GetComponent<BoolBox>();



    }

    private void FixedUpdate()
    {

        point0101 = BoolBoxPoint0101.GetComponent<BoolBox>().MainCheck;
        point0102 = BoolBoxPoint0102.GetComponent<BoolBox>().MainCheck;
        point0103 = BoolBoxPoint0103.GetComponent<BoolBox>().MainCheck;
        point0104 = BoolBoxPoint0104.GetComponent<BoolBox>().MainCheck;
        point0105 = BoolBoxPoint0105.GetComponent<BoolBox>().MainCheck;

        point0201 = BoolBoxPoint0201.GetComponent<BoolBox>().MainCheck;
        point0202 = BoolBoxPoint0202.GetComponent<BoolBox>().MainCheck;
        point0203 = BoolBoxPoint0203.GetComponent<BoolBox>().MainCheck;
        point0204 = BoolBoxPoint0204.GetComponent<BoolBox>().MainCheck;
        point0205 = BoolBoxPoint0205.GetComponent<BoolBox>().MainCheck;

        point0301 = BoolBoxPoint0301.GetComponent<BoolBox>().MainCheck;
        point0302 = BoolBoxPoint0302.GetComponent<BoolBox>().MainCheck;
        point0303 = BoolBoxPoint0303.GetComponent<BoolBox>().MainCheck;
        point0304 = BoolBoxPoint0304.GetComponent<BoolBox>().MainCheck;
        point0305 = BoolBoxPoint0305.GetComponent<BoolBox>().MainCheck;

        point0401 = BoolBoxPoint0401.GetComponent<BoolBox>().MainCheck;
        point0402 = BoolBoxPoint0402.GetComponent<BoolBox>().MainCheck;
        point0403 = BoolBoxPoint0403.GetComponent<BoolBox>().MainCheck;
        point0404 = BoolBoxPoint0404.GetComponent<BoolBox>().MainCheck;
        point0405 = BoolBoxPoint0405.GetComponent<BoolBox>().MainCheck;

        point0501 = BoolBoxPoint0501.GetComponent<BoolBox>().MainCheck;
        point0502 = BoolBoxPoint0502.GetComponent<BoolBox>().MainCheck;
        point0503 = BoolBoxPoint0503.GetComponent<BoolBox>().MainCheck;
        point0504 = BoolBoxPoint0504.GetComponent<BoolBox>().MainCheck;
        point0505 = BoolBoxPoint0505.GetComponent<BoolBox>().MainCheck;

    }

}
