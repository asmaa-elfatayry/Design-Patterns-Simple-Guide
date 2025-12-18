using AdapterLiveExample;

ArabicSpeaker arabicPerson = new ArabicSpeaker();
IEnglishSpeakerNewSystem translator = new LanguageAdapter(arabicPerson);
Console.WriteLine(translator.SpeakEnglish());
