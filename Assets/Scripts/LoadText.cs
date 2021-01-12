using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadText : MonoBehaviour
{
    public string[] textMessage; 
    public string[,] textWords;

    private int rowLength; //行数
    public int RowLength { get { return rowLength; } }
    private int columnLength; //列数

    int page = 0;

    private string characterName;
    public string CharacterName { get { return characterName; } }

    private int face;
    public int Face { get { return face; } }

    private string messageText;
    public string MessageText { get { return messageText; } }

    private int position;
    public int Position { get { return position; } }

    MessageText messageTextScript;

    private bool reading;

    bool flag = false;
    private void Start()
    {
        TextAsset textasset = new TextAsset();
        textasset = Resources.Load("TextData", typeof(TextAsset)) as TextAsset;
        string TextLines = textasset.text;

        textMessage = TextLines.Split('\n');

        columnLength = textMessage[0].Split('\t').Length;
        rowLength = textMessage.Length;

        textWords = new string[rowLength, columnLength];

        messageTextScript = GetComponent<MessageText>();

        PageCount(page);
    }

    private void Update()
    {
        reading = messageTextScript.Finish;

        if (Input.GetMouseButtonDown(0) && page < rowLength && !reading)
        {
            PageCount(page);
        }
    }

    void PageCount(int count)
    {
        string[] tempWords = textMessage[count].Split('\t');

        for (int i = 0; i < 4; i++)
        {
            textWords[page, i] = tempWords[i];

            if (i == 0)
            {
                characterName = textWords[page, 0];
            }
            else if(i == 1)
            {
                face = int.Parse(textWords[page, 1]);
            }
            else if(i == 2)
            {
                messageText = textWords[page, 2];
            }
            else
            {
                position = int.Parse(textWords[page, 3]);
            }
        }

        page++;
    }
}