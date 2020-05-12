using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    [SerializeField]
    GameObject inputParamA;
    [SerializeField]
    GameObject inputParamB;
    [SerializeField]
    GameObject inputParamC;

    [SerializeField]
    Text textParamA;
    [SerializeField]
    Text textParamB;
    [SerializeField]
    Text textParamC;

    [SerializeField]
    Text labelFigure;
    [SerializeField]
    Text labelResult;

    double paramA;
    double paramB;
    double paramC;
    double totalArea;

    public string ParamA {
        get => paramA.ToString();
        set {
            double toDouble;
            if (double.TryParse(value, out toDouble) == true) {
                paramA = toDouble;
            }
        }
    }

    public string ParamB {
        get => paramB.ToString();
        set {
            double toDouble;
            if (double.TryParse(value, out toDouble) == true) {
                paramB = toDouble;
            }
        }
    }

    public string ParamC {
        get => paramC.ToString();
        set {
            double toDouble;
            if (double.TryParse(value, out toDouble) == true) {
                paramC = toDouble;
            }
        }
    }

    public string TotalArea {
        get => totalArea.ToString();
        set {
            double toDouble;
            if (double.TryParse(value, out toDouble) == true) {
                totalArea = toDouble;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckInputFields();
    }

    public void ButtonCalculate() {
        Debug.Log(paramA + ", " + paramB + ", " + paramC);
        if (paramA != 0 && paramB == 0 && paramC == 0) {
            labelResult.text = "Total area: " + FigureArea.CircleAreaByRadius(paramA).ToString();
        } else if (paramA != 0 && paramB != 0 && paramC == 0) {
            labelResult.text = "Total area: " + FigureArea.RectangleAreaBy2Sides(paramA, paramB).ToString();
        } else if (paramA != 0 && paramB != 0 && paramC != 0) {
            labelResult.text = "Total area: " + FigureArea.TriangleAreaBy3Sides(paramA, paramB, paramC).ToString();
        }
    }

    void CheckInputFields() {
        if (textParamA.text != "") {
            inputParamB.SetActive(true);
            labelFigure.text = "It is a circle! :D";
            if (textParamB.text != "") {
                inputParamC.SetActive(true);
                labelFigure.text = "It is a rectangle! :D";
                if (textParamC.text != "") {
                    if (FigureArea.IsRightTriangle(paramA, paramB, paramC) == true) {
                        labelFigure.text = "It is a right triangle! :D";
                    } else {
                        labelFigure.text = "It is a triangle! :D";
                    }
                }
            }
            else {
                inputParamC.SetActive(false);
                textParamC.text = "";
            }
        }
        else {
            inputParamB.SetActive(false);
            textParamB.text = "";
            labelFigure.text = "What figure is it?";
        }
        
    }


}
