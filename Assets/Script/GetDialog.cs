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
    [SerializeField]
    private Text Dialog_Text;

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
            {
                Dialog = textFile.text;
                //Dialog_Text.text = Dialog.ToString();
                Dialog_Text.text = getDialog()[0];
            }
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

    }

    // Update is called once per frame
    void Update()
    {

    }

    /*renvoie le contenu du fichier text sous forme de tableau representant**
     *chaque dialog afficher*/
    public string[] getDialog()
    {
        return Dialog.Split('#');
    }
}
