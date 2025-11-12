public class Word
{
    private readonly string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide() => _isHidden = true;

    public bool IsHidden() => _isHidden;

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // Preserve punctuation if present
            char lastChar = _text[_text.Length - 1];
            if (char.IsPunctuation(lastChar))
            {
                return new string('_', _text.Length - 1) + lastChar;
            }
            return new string('_', _text.Length);
        }
        return _text;
    }
}
