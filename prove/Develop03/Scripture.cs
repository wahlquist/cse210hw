using System;

public class Scripture
{
    private string _word1;
    private string _word2;
    private string _word3;
    private string _word4;
    private string _word5;
    private string _word6;
    private string _word7;
    private string _word8;
    private string _word9;
    private string _word10;
    private string _word11;
    private string _word12;
    private string _word13;
// "The glory of God is intelligence, or, in other words, light and truth."



public Scripture()
{
    _word1 = "The";
    _word2 = "glory";
    _word3 = "of";
    _word4 = "God";
    _word5 = "is";
    _word6 = "intelligence";
    _word7 = "or";
    _word8 = "in";
    _word9 = "other";
    _word10 = "words";
    _word11 = "light";
    _word12 = "and";
    _word13 = "truth";
List<string> GoneNumbers = new List<string>();


}


public string GetFullScripture()
{
    return $"{_word1} {_word2} {_word3} {_word4} {_word5} {_word6}, {_word7}, {_word8} {_word9} {_word10}, {_word11} {_word12} {_word13}.";
}






}