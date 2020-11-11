# GMLocalize (version number two)

Extract text strings for localization from a GameMaker Studio 2 project, and save it to a JSON file.

I might make this a proper text localization tool later. Who knows.

### Usage

This tool will pull out any bare string passed as the first parameter to a **localization** function.

    var localized_text = __("The quick brown fox jumped over Donald Trump");

The localization function can be named anything. The default is two underscores (`__`).

Anything that is not a bare string **will not work,** and will probably cause the output to break:

    var localized_text = __("The quick brown fox " + "jumped over Donald Trump");
    /* name = "Donald Trump" */
    var localized_text = __("The quick brown fox jumped over " + name);
    /* text = "The quick brown fox jumped over Donald Trump" */
    var localized_text = __(text);

In any event, if you actually want to translate a game to different languages, you're going to need some kind of string formatter anyway, because most languages don't follow the same rules as whatever language you are developing in.

    /* name = "Donald Trump" */
    var localized_text = __("The quick brown fox jumped over %0");
    var formatted_text = format(localized_text, name);

From there, you can save it to a json file.

### Building

It's a Visual Studio project, or something

### Credits

 - Program icon - Language by The Icon Z from the Noun Project