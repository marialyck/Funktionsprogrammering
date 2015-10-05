//1. Declare a function f: int -> bool such that f(n) = true exactly when n is divisible by 2 or divisible by 3 
//but not divisible by 5. Write down the expected values of f(24), f(27), f(29) and f(30) and compare with the result. 
//Hint: n is divisible by q when n%q = 0.

let f = function
|f -> f % 2 = 0;;



//Boolean for even number:
let even n = n % 2 = 0;;


let rec gcd = function
| (0,n) -> n
| (m,n) -> gcd(n % m,m);;

