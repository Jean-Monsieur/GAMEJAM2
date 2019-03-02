using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GetDialog : MonoBehaviour
{

    public string Nom;
    public string TypeDialog;
    private string Dialog;

    public Text textDialog;

    // Start is called before the first frame update
    void Start()
    {
        try
        {
            //Load a text file (Assets/Resources/Text/textFile01.txt)
            var textFile = Resources.Load<TextAsset>("Dialog/"+Nom+"/"+TypeDialog);
            if (textFile == null)
                throw new InvalidOperationException("Fichier inexistant");
            
            else
                Dialog = textFile.text;
        }
        catch (InvalidOperationException e)
        {
            Debug.LogError(e.ToString());
            this.enabled = false;
        }
        catch (Exception e)
        {
            Debug.LogError(e.StackTrace.ToString());
            Debug.LogError("Erreur avec le fichier");
            this.enabled = false;
        }
        Debug.Log(Dialog);
    }

    // Update is called once per frame
    void Update()
    {
        setDialog();
    }

    public string getDialog()
    {
        return Dialog;
    }

    public void setDialog()
    {
        textDialog.text = getDialog();
    }

}
