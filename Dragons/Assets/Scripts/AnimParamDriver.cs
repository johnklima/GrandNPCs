using System.Collections;
using UnityEngine;


/// <summary>
/// Small class to lerp a single animation parameter by name
/// </summary>
public class AnimParamDriver : MonoBehaviour
{
    private Animator animTree;

    //all params
    private string[] parmams = { "chat", "bow", "flirt", "insult", "bless", "whisper", "agro", "snob", "ignore" , "walk"};

    //subset for talking
    private string[] tones = { "agro", "whisper", "snob" };
    
    
    //LERPERS
    public float[] T;
    public float endValue;
    public float startValue;
    public string parmName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //TODO deal with the dragon
        if (parmName == "null")
            return;


        animTree = GetComponent<Animator>();

        int index = 0;
        //TODO something about this
        for (int i = 0; i < animTree.parameterCount;i++)
        {
            if (parmams[i] == parmName)
                index = i;
        }
        
        StartCoroutine( LerpParam(parmName, startValue, endValue, 1.0f, T[index]) );
        
    }

    public void Talk(int tone)
    {
        float start;    //from where
        float end;      //to where

         //lerp them all down, walk take over
        ResetAllButMe(tones[tone]);

        start = animTree.GetFloat(tones[tone]);
        end = 1.0f;

        int index = 0;
        //TODO something about this
        for (int i = 0; i < parmams.Length; i++)
        {
            if (parmams[i] == tones[tone])
                index = i;
        }

        StartCoroutine(LerpParam(tones[tone], start, end, 1.0f, T[index]));
        

    }
    public void Walk()
    {

        float start;    //from where
        float end;      //to where

        //lerp them all down, walk take over
        ResetAllButMe("walk");
        start = animTree.GetFloat("walk");
        end = 1.0f;

        int index = 0;
        //TODO something about this
        for (int i = 0; i < parmams.Length; i++)
        {
            if (parmams[i] == "walk")
                index = i;
        }

        StartCoroutine(LerpParam("walk", start, end, 1.0f, T[index]));
        
    }
    void ResetAllButMe(string me)
    {
        float start;    //from where
        float end;      //to where

        //lerp them all down, walk take over
        for (int i = 0; i < animTree.parameterCount; i++)
        {
            string parm = animTree.GetParameter(i).name;
            if (parm != me)
            {
                start = animTree.GetFloat(parm);
                end = 0;

                //animTree.SetFloat(parm, 0);
                StartCoroutine(LerpParam(parm, start, end, 1.0f, T[i]));
                
            }
        }

    }
    IEnumerator LerpParam(string parmName, float startValue, float endValue, float rate, float time)
    {
        while (time <= 1.1f)
        {
            //lerp them
            float newVal = Mathf.Lerp(startValue, endValue, time);

            //elegant!
            animTree.SetFloat(parmName, newVal);

            time += Time.deltaTime * rate;

            yield return null;
        }
        time = 0;
        yield return null;

    }
}
