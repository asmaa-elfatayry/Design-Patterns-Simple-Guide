// See https://aka.ms/new-console-template for more information
using SingletonLiveExample;

Console.WriteLine("Normal Class Demo!");

var obj1 = new Fingerprint_Normal("bank");
var obj2 = new Fingerprint_Normal("university");
Console.WriteLine("obj1 == obj2 " + object.ReferenceEquals(obj1, obj2)); // false -> two diffrent instance

Console.WriteLine("Senglton Demo!");
var bank = FingerprintSingletonThreadSafe.GetInstance();
var university = FingerprintSingletonThreadSafe.GetInstance();

Console.WriteLine("bank == university " + object.ReferenceEquals(bank, university)); // true -> same object