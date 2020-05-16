
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text text;
    public Font fontOfText;
    public Color colorOfText;

    public string name;
    public string surname;
    public int collegeLevel;
    public string specialty;
    public int albumNumber;

    public int amount;

    public void Start()
    {
        //INI
        text.color = colorOfText;
        text.font = fontOfText;
        text.text = "My name : "+name+" "+surname+"\n\nCollege level : "+collegeLevel+"\n\nSpeciality : "+specialty+"\n\nAlbum number : "+albumNumber;

        //SPAM
        for(int i = 0; i < amount; i++)
        {
            Debug.Log(name + " " + surname);
        }
    }
}
