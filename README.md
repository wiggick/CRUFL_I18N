# CRUFLI18N (A Crystal Reports User Function Library for I18N)

CRUFLI18N is a Crystal Reports User Function Library that provides Key/Value Pair lookup in JSON content, to provide
a dynamic method of replacing Title and column headings using formula fields and pasing in the key and the JSON content into the I18NTranslatorGetTranslation function in the UFL.

# Note:
This project was my first exploration using the following;
  - Visiual Studio 2017 Community Edition
  - Creating a .NET library
  - Implementing Microsft's UnitTest Framework
  - NewtonSoft's json.NET
  - adding functionality into Crystal Reports Designer with a (UFL) User Function Library
  - 
For a weekend's bit of work, it's functional and it was a great learning experience.  
For another example of a UFL for translaction look at the sample that SAP provides at https://apps.support.sap.com/sap/support/knowledge/public/en/1525014. which uses BabelFish.

### System Requirements
 - .Net Framework 4.5
 - Only tested with Crsytal Reports Designer 2016
 
### Installation (Based on Crystal Reports Designer 2016 Install )
Copy the following files to your C:\Program Files (x86)\SAP BusinessObjects\SAP BusinessObjects Enterprise XI 4.0\win32_x86 Directory.
 - CRUFL_I18N.dll
 - Newtonsoft.Json.dll
 - Newtonsoft.Json.xml  

Run the provided Install.bat file with Administrator privileges.

### Usage
 - Open up Crystal Reports Designer and add a Formula field.  
 - In the functions tree, select Additional Functions -> COM and .NET UFLs
 - Add the I18NTranslatorGetTranslation function

I used a hard coded JSON string for the test.  In production you could provide the JSON formatted key value pairs stored as CLOB's and retreive various translations as needed using  selection criteria based on your needs.
```
Local StringVar json := "{'Translations' :[ {'Key':'Title','Value':'Los Estados Unidos de América'},{'Key':'Name','Value':'Nombre'}]}";
I18NTranslationGetTranslation( "Name", json )
```

<img src="https://github.com/wiggick/CRUFL_I18N/blob/master/usage.PNG">


License
----

MIT

