// See https://aka.ms/new-console-template for more information
using TestCodeWars;

var testarr = new string[]{
"4873279",
"ITS-EASY",
"888-4567",
"3-10-10-10",
"888-GLOP",
"TUT-GLOP",
"967-11-11",
"310-GINO",
"F101010",
"888-1200",
"-4-8-7-3-2-7-9-",
"487-3279"};
var result = new string[]{
"310-1010:2",
"487-3279:4",
"888-4567:3"};
var a = result == KataPhoneDuplicate.FindDuplicatePhoneNumbers(testarr);
Console.WriteLine(a);



//for regex https://www.rexegg.com/regex-quickstart.html