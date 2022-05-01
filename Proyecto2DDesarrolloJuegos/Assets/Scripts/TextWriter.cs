using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TextWriter : MonoBehaviour
{
    private static TextWriter instance;

    private List<TextWriterSingle> textWriterSingleList;

    private void Awake()
    {
        instance = this;
        textWriterSingleList = new List<TextWriterSingle>();
    }

    public static void AddWriter_static(TextMeshProUGUI texto, string textToWrite, float timePerCharacter, bool invisibleCharacters)
    {
        instance.AddWriter(texto, textToWrite, timePerCharacter, invisibleCharacters);
    }

    private void AddWriter(TextMeshProUGUI texto, string textToWrite, float timePerCharacter, bool invisibleCharacters)
    {
        textWriterSingleList.Add(new TextWriterSingle(texto, textToWrite, timePerCharacter, invisibleCharacters));
    }

    private void Update()
    {
        for(int i = 0; i< textWriterSingleList.Count; i++)
        {
            bool destroyeInstance = textWriterSingleList[i].Update();
            if (destroyeInstance)
            {
                textWriterSingleList.RemoveAt(i);
                i--;
            }
        }
        
    }

    public class TextWriterSingle
    {
        private TextMeshProUGUI texto;
        private string textToWrite;
        private int characterIndex;
        private float timePerCharacter;
        private float timer;
        private bool invisibleCharacters;

        public TextWriterSingle(TextMeshProUGUI texto, string textToWrite, float timePerCharacter, bool invisibleCharacters)
        {
            this.texto = texto;
            this.textToWrite = textToWrite;
            this.timePerCharacter = timePerCharacter;
            this.invisibleCharacters = invisibleCharacters;
            characterIndex = 0;
        }

        //Return true on complete
        public bool Update()
        {
            timer -= Time.deltaTime;
            while (timer <= 0f)
            {
                //Display next Character
                timer += timePerCharacter;
                characterIndex++;
                string text = textToWrite.Substring(0, characterIndex);
                if (invisibleCharacters)
                {
                    text += "<color=#00000000>" + textToWrite.Substring(characterIndex) + "</color>";
                }
                texto.text = text;

                if (characterIndex >= textToWrite.Length)
                {
                    //Entire string displayed
                    texto = null;
                    return true;
                }
            }
            return false;
        }
    }
}




