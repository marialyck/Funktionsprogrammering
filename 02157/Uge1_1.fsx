let square x = x * x;;


let rec power = function
    | (x, 0) -> 1.0                (* 1 *)
    | (x, n) -> x * power(x,n-1)   (* 2 *);;


  let rec fact = function
      | 0 -> 1
      | n -> n * fact(n-1);;


      let rec altsum = function
    | []         -> 0
    | [x]        -> x
    | x0::x1::xs -> x0 - x1 + altsum xs;;

    let price = 125;;

    price*20;;

  let circleArea r = System.Math.PI * r * r;;

  circleArea (2.0);;

  fun r -> System.Math.PI * r * r;;

  it 10;;

  function
| 1 -> 31 // January
| 2 -> 28 // February 
|3 ->31 //March
|4 ->30 //April
|5 ->31 //May
|6 ->30 //June
|7 ->31 //July
| 8 -> 31 // August
| 9 -> 30 // September 
| 10 -> 31 // October
| 11 -> 30 // November 
| 12 -> 31;;// December
function
^

let rec fact = function
      | 0 -> 1
      | n -> n * fact(n-1);;
  