C# CSV Reader
==========

I initially made this to use with Unity so it's raw C#.

Supports:
- empty cells
- cells with quotes/double quotes
- cells with commas
- cells with CRLF
- utf8 characters

I'm mainly using it to read localized texts for game development (exported from a Google Doc sheet).

How To Use
-------

You need to write a delegate:
    void ReadLine(int line_index, List<string> line)
line_index is the line number (starting at 0)
line is a list of each cell of the line

To use with Unity:
    
    void MyReader(int line_index, List<string> line)
    {
        ...
    }

    TextAsset text_asset = Resources.Load("csv_file");
    fgCSVReader.LoadFromString(text_asset.text, new fgCSVReader.ReadLineDelegate(MyReader));

See Test.cs for sample code.


License
-----
Free for commercial and personal use.
Send me a tweet @Frozax if you use or improve it!
