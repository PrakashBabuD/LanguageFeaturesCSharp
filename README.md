# LanguageFeaturesCSharp
This application is used to demonstrate C# Language features

Analysis of Delegates and Events :

Delegates have the ability to be composoble .
As result if we keep on adding the functions to be called ,like f1+f2 to the delegate object and called single composed delegate object 
then all the functions can be invoded .
This feature of the delegates is used in implementing Events .
So we append all the subscriber methods to the delegate object .
Whenever event happens we just call the composed delegate ,as a result all the subscriber methods .

All the subscriber methods must implement the Delgate Signature .

