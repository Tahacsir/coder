string coder(int shift,string text)
{
    text = text.ToLower();
    string alfba = "abcdefghijklmnopqrstuvwxyz";
    if (shift > 0) shift = shift;      
    else  shift = shift + 26 ; 
    for (int i = 0; i <= text.Length - 1; i++)
    {
        char b = text[i]; int index = alfba.IndexOf(b);
        char a = alfba[(index + shift) % 26];
        text = text.Replace(b, a);
    }
    return text;
}
void decoder(string text){
    for (int i = 0; i <26; i++)
    {
        Console.WriteLine(coder(i,text));
    }
}
decoder("taha");