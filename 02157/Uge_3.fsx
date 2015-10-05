not true <> false;;

1 = 2 || 1 - 1 = 0;;

    let isLowerCaseVowel ch = 
    ch ='a' || ch='e' || ch='i' || ch='o' || ch='u';;
    let isLowerCaseConsonant ch =
      System.Char.IsLower ch && not (isLowerCaseVowel ch);;
      isLowerCaseVowel 'i' && not (isLowerCaseConsonant 'i');;
isLowerCaseVowel 'I' || isLowerCaseConsonant 'I';;
not (isLowerCaseVowel 'z') && isLowerCaseConsonant 'z';;

String.length "1234";;

String.length "sdfkaæle,ds.mvf";;

String.length "";;

let text = "abcd1234";;

text + text;;

text + " " = text;;

text + "" = text;;

"abc".[0];;

"abcdefghijklmnopqrstuvxyzæøå".[26];;

"abc" + string 'd';;

let nameAge(name,age) =
      name + " is " + (string age) + " years old";;

      nameAge("Adam",1+3);;
let even n = n % 2 = 0;;
even 4;;

even 7;;

let pi = System.Math.PI;;
let circleArea r = pi * r * r;;

[("b",2);("c",3);("e",5)];;

['1'; '2'; '3'] < ['1'; '2'; '3'; '4'];;

["research"; "articles"] < ["research"; "books"];;

//Taken by the letter
["research"; "articles"] < ["research"; "books"];;

[1; 1; 6; 10] <= [1; 1; 6; 9];;

let x0::x1::xs = [1.1; 2.2; 3.3; 4.4; 5.5];;

//List counting up
[ -20 .. 5 ];;

[2.4 .. 3.0 ** 2.2];;

//List counting down
[6 .. -1 .. 2];;