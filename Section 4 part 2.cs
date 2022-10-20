string CapitalizeSentence(string text)
{
    var words = text.Split();
    var newText = "";
    foreach (var word in words) newText += " " + CapitalizeWord(word);

    return newText;
}

string CapitalizeWord(string word)
{
    return char.ToUpper(word[0]) + word.Substring(1);
}