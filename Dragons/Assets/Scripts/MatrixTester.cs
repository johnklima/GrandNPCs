using UnityEngine;

public class MatrixTester : MonoBehaviour
{
    public DragonCouncilAbsoluteMatrix matrix;

    void Start()
    {
        var dialogue =
            matrix.Matrix["Hiroshi"]["Dragon"];

        Debug.Log(dialogue.forceful);
        Debug.Log(dialogue.wise);
        Debug.Log(dialogue.sarcastic);
    }
}
