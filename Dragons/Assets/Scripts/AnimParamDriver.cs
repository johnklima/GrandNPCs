using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

/// <summary>
/// Small class to lerp a single animation parameter by name
/// </summary>
public class AnimParamDriver : MonoBehaviour
{
    private Animator animTree;
    private string[] parmams = { "chat", "bow", "flirt", "insult", "bless", "whisper", "agro", "snob", "ignore" , "walk"};

    public float T = 0;
    public bool lerpValue = true; //lerp them into an initial "idle"
    public float endValue;
    public float startValue;
    public string parmName;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animTree = GetComponent<Animator>();
        StartCoroutine(LerpParam(parmName, startValue, endValue));
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator LerpParam(string parmName, float startValue, float endValue)
    {
        while (T <= 1.1f)
        {
            //slerp them
            float newVal = Mathf.Lerp(startValue, endValue, T);

            //elegant!
            animTree.SetFloat(parmName, newVal);

            T += Time.deltaTime;

            yield return null;
        }
        T = 0;
        yield return null;

    }
}
