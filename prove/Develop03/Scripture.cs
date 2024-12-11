using System;
using System.Collections.Generic;
public class Scripture
{
      private string _word1 = "The ";
    private string _word2 = "glory ";
    private string _word3 = "of ";
    private string _word4 = "God ";
    private string _word5 = "is ";
    private string _word6 = "intelligence ";
    private string _word7 = "or ";
    private string _word8 = "in ";
    private string _word9 = "other ";
    private string _word10 = "words ";
    private string _word11 = "light ";
    private string _word12 = "and ";
    private string _word13 = "truth";
    private string _word14 = "";
   

public List<string> Words { get; private set; }
    public Scripture()
    {
        // Initialize the list in the constructor
        Words = new List<string>{_word1, _word2, _word3, _word4, _word5,_word6, _word7, _word8, _word9, _word10,_word11, _word12, _word13, _word14};
    }
// "The glory of God is intelligence, or, in other words, light and truth."
private List<int> GoneNumbers;

List<string> HiddenWords = new List<string> {"--- ","----- ","-- ","--- ","-- ","------------ ","-- ","-- ","----- ","----- ","----- ","--- ","----- ",""};
public void Scripture2(int _charles,int _maren)
{


 GoneNumbers = new List<int> {};
    GoneNumbers.Add(_maren);
    GoneNumbers.Add(_charles);
 foreach (var number in GoneNumbers)
 {
    Words[number] = HiddenWords[number];
 }
 foreach (var word in Words){
 Console.Write(word);
 }
}





 public void GetFullScripture()
 {
   
     foreach (var word in Words){
       Console.Write(word);
 }






}}


