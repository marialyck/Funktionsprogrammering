//Declare function upto: int -> int list such that upto n = [1; 2; . . . ; n].

let i_i = 10;;
let increaseList = [for i_i in 1 .. i_i -> i_i];;

//Declare function downto1: int -> int list such that the value of downto1 n is the list[n; n − 1; . . . ; 1].
let d_i = 10;;
let decreaseList = [for d_i in 1 .. d_i -> -d_i];;


//Declare function evenN: int -> int list such that evenN n generates the list of the first n non-negative even numbers.
let even n = n % 2 = 0;;

//Sorting a list 
let sortedList1 = List.sort [1; 4; 8; -2; 5]
printfn "%A" sortedList1

// A simple for...to loop. 
let function1() =
  for i = 1 to 10 do
    printf "%d " i
  printfn ""

  // A for...to loop that counts in reverse. 
let function2() =
  for i = 10 downto 1 do
    printf "%d " i
  printfn ""

function1()
function2()

// Finding all the prime numbers from 1-100
let IsPrimeMultipleTest n x =
   x = n || x % n <> 0

let rec RemoveAllMultiples listn listx =
   match listn with
   | head :: tail -> RemoveAllMultiples tail (List.filter (IsPrimeMultipleTest head) listx)
   | [] -> listx


let GetPrimesUpTo n =
    let max = int (sqrt (float n))
    RemoveAllMultiples [ 2 .. max ] [ 1 .. n ]

printfn "Primes Up To %d:\n %A" 100 (GetPrimesUpTo 100)
//Here printing all the primes from 1-100

//Making a reverse list:
let rec naiveRev xls  =
match xls with
| [] -> []
| x::xs -> naiveRev xs @ [x];;

naiveRev[5;4;3]
1
let list1 = [1; 2; 3]
let list2 = [4; 5; 6]
//List.iter (fun x -> printfn "List.iter: element is %d" x) list2
//List.iteri(fun i x -> printfn "List.iteri: element %d is %d" i x) list1
//List.iter2 (fun x y -> printfn "List.iter2: elements are %d %d" x y) list1 list2
List.iteri2 (fun i x y ->
               printfn "List.iteri2: element %d of list1 is %d element %d of list2 is %d"
                 i x i y)
            list1 list2
