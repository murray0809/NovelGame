using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadText : MonoBehaviour
{
    public string[] textMessage; //テキストの加工前の一行を入れる変数
    public string[,] textWords; //テキストの複数列を入れる2次元は配列 

    private int rowLength; //テキスト内の行数を取得する変数
    public int RowLength { get { return rowLength; } }
    private int columnLength; //テキスト内の列数を取得する変数

    int page = 0;

    private string characterName;
    public string CharacterName { get { return characterName; } }

    private int face;
    public int Face { get { return face; } }

    private string messageText;
    public string MessageText { get { return messageText; } }

    MessageText messageTextScript;

    private bool reading;

    bool flag = false;
    private void Start()
    {
        TextAsset textasset = new TextAsset(); //テキストファイルのデータを取得するインスタンスを作成
        textasset = Resources.Load("TextData", typeof(TextAsset)) as TextAsset; //Resourcesフォルダから対象テキストを取得
        string TextLines = textasset.text; //テキスト全体をstring型で入れる変数を用意して入れる

        //Splitで一行づつを代入した1次配列を作成
        textMessage = TextLines.Split('\n'); //

        //行数と列数を取得
        columnLength = textMessage[0].Split('\t').Length;
        rowLength = textMessage.Length;

        //2次配列を定義
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
        string[] tempWords = textMessage[count].Split('\t'); //textMessageをカンマごとに分けたものを一時的にtempWordsに代入

        for (int i = 0; i < 3; i++)
        {
            textWords[page, i] = tempWords[i];

            if (i == 0)
            {
                characterName = textWords[page, 0];
            }
            else if(i == 1)
            {
                face = int.Parse(textWords[page, i]);
            }
            else
            {
                messageText = textWords[page, 2];
            }   
        }

        page++;
    }
}