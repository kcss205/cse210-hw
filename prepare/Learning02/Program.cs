using System;

class Program
{
    static void Main(string[] args)
    {
        Person fred = new Person("Fred", "Flinstone");
        //fred.givenName = "Fred";
        //fred.familyName = "Flinstone";

        Person steve = new Person("Steve", "Minecraft");
        //steve.givenName = "Steve";
        //steve.familyName = "Minecraft";

        fred.EasternStyleName();
        steve.WesternStyleName();
    }
}