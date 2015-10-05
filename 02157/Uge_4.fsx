type Shape = |Circle of float
             |Square of float
             |Triangle of float*float*float;;

let isShape = function
    |Circle r ->r > 0.0
    |Square a -> a > 0.0
    |Triangle (a,b,c) -> 
        a > 0.0 && b > 0.0 && c > 0.0
        && a < b + c && b < c+a && c < a+b;;

let area = function
    |Circle r -> System.Math.PI*r*r
    |Square a -> a*a
    |Triangle (a,b,c) -> 
        let s = (a+b+c)/2.0
        sqrt(s*(s-a)*(s-b)*(s-c));;






//Excersises:
//Make a type Solution capturing the three capabilities for roots in a quadratic equation: 
//two roots, one root and no root (cf. Section 3.5). Declare a corresponding solve function.

type Roots = |NoRoot of int*int*int
             |OneRoot of int*int*int
             |TwoRoots of int*int*int;;

let findRoot = function
    |NoRoot (a,b,c) -> b * b - 4 * a * c < 0
    |OneRoot (a,b,c) -> b * b - 4 * a * c = 0
    |TwoRoots (a,b,c) -> b * b - 4 * a * c > 0;;

let equation = function
    |
    


   