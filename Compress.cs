public class Challenge
{
    public static string Compress(string text)
    {
        string sonuc = string.Empty;
        int count = 1;
        if (text == "")
        {
            return "";
        }
        if (text == null)
        {
            return null;
        }
        if (text.Length == 1)
        {
            if (text == " ")
            {
                sonuc = text;
            }
            else
            {
                sonuc = string.Concat(text, count);
            }
        }
        else
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    //Son karakter kontrolü
                    if (i == text.Length - 1)
                    {
                        sonuc += " ";
                    }
                    else
                    {
                        if (text[i] == text[i + 1])
                        {
                            continue;
                        }
                        else
                        {
                            sonuc += " ";
                        }
                    }
                }
                else
                {
                    //Son karakter kontrolü
                    if (i == text.Length - 1)
                    {
                        if (text[i] == text[i - 1])
                        {
                            sonuc += string.Concat(text[i], count.ToString());
                        }
                        else
                        {
                            sonuc += string.Concat(text[i], count.ToString());
                        }
                    }
                    else
                    {
                        if (text[i] == text[i + 1])
                        {
                            count++;
                        }
                        else
                        {
                            sonuc += string.Concat(text[i], count.ToString());
                            count = 1;
                        }
                    }
                }
            }
        }


        return sonuc;
    }
}
