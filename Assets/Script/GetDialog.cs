﻿using System;
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

    [SerializeField]
    private GameObject Gamemanager;

    [SerializeField]
    private GameObject CanvasFin;

    [SerializeField]
    private GameObject audioSource;

    [SerializeField]
    private GameObject audioSource_Dialogue;

    private int dialogueIndex;

    public string[] txtArray;

    bool scenario;
    


    // Start is called before the first frame update
    void Start()
    {
        scenario = true;
        try
        {
            //play sound 
            switch (Nom)
            {
                case "FilleBistrot":
                    audioSource.GetComponent<MusicController>().PlayChatter();
                    break;
                case "FilleDag":
                    audioSource.GetComponent<MusicController>().PlayClub();
                    break;
                case "FilleIntel":
                    audioSource.GetComponent<MusicController>().PlayClub();
                    break;
                case "FilleStrengh":
                    audioSource.GetComponent<MusicController>().PlayChatter();
                    break;
            }
            scenario = true;
            dialogueIndex = 0;
            //Load a text file (Assets/Resources/Text/textFile01.txt)
            var textFile = Resources.Load<TextAsset>("Dialog/" + Nom + "/" + TypeDialog);
            if (textFile == null)
                throw new InvalidOperationException("Fichier inexistant");

            else
            {
                Dialog = textFile.text;
                txtArray = getDialog();
                //Dialog_Text.text = Dialog.ToString();
                Dialog_Text.text = txtArray[0];
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

    public void ClickDialogueMike()
    {
        dialogueIndex++;
        if (dialogueIndex < txtArray.Length)
            Dialog_Text.text = txtArray[dialogueIndex];
        else if (scenario == true)
          {
            scenario = false;
            changeDialogue(Gamemanager.GetComponent<CurrentBarScript>().getBarString());

           }
        else
            Gamemanager.GetComponent<ButtonHandler>().Click_Continue();



    }

    public void changeDialogue(string dialogue)
    {

        try
        {
            TypeDialog = dialogue;
            dialogueIndex = 0;
            //Load a text file (Assets/Resources/Text/textFile01.txt)
            var textFile = Resources.Load<TextAsset>("Dialog/" + Nom + "/" + TypeDialog);
            if (textFile == null)
                throw new InvalidOperationException("Fichier inexistant");

            else
            {
                Dialog = textFile.text;
                txtArray = getDialog();
                //Dialog_Text.text = Dialog.ToString();
                Dialog_Text.text = txtArray[0];
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


    public void ClickDialogue()
    {
        dialogueIndex++;
        if (dialogueIndex < txtArray.Length)
            Dialog_Text.text = txtArray[dialogueIndex];
        else
        {
            CanvasFin.SetActive(true);
            if (TypeDialog == "Dialog2")
            {
                CanvasFin.transform.GetChild(1).GetComponent<GetDialog>().TypeDialog = "Fin_Loose";
                audioSource_Dialogue.GetComponent<AudioPlayer>().PlayMaleDefeat();

            }
                
            else
            {
                CanvasFin.transform.GetChild(1).GetComponent<GetDialog>().TypeDialog = "Fin_Win";
                audioSource_Dialogue.GetComponent<AudioPlayer>().PlayMaleWin();
            }
               

            this.transform.parent.gameObject.SetActive(false);

            
        
        }
        



    }

    public void ClickDialogueMike2()
        {
            dialogueIndex++;
            if (dialogueIndex < txtArray.Length)
                Dialog_Text.text = txtArray[dialogueIndex];
            else
            {
                Debug.Log("GameFinished");
                Application.Quit();
            }
        }
    }
