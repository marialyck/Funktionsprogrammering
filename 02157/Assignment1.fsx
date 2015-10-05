//Maria Lyck Carstensen
//s144478
//Alexander Aalykke 
//s091890

//Since telephonenumbers doesn't need to be calculated in any ways, it's made as a string.
type Client = {name : string; telephone : string ; sex : string; birthyear : int ; interests : string list}

type DatingRegister = Client list;;

//Making a list register containing the clients for the dating bureau.
let DatingRegister = [{name = "Peter"; telephone = "21212121"; sex ="M"; birthyear = 1905 ; interests = ["Sport"; "Videogames"; "Music"]};
                     {name = "Hans"; telephone = "112"; sex ="M"; birthyear = 1950 ; interests = ["Sport"; "Videogames"; "Music"]};
                     {name = "Sine"; telephone = "113"; sex ="M"; birthyear = 1905 ; interests = ["Sport"; "Videogames"; "Music"]};
                     {name = "Christian"; telephone = "114"; sex ="M"; birthyear = 1905 ; interests = ["Videogames"; "Music"]}
                     ];;


//The list where you add a person for comparing if there's anyone in the database that suits you. 
let newClient = [{name = "Luise"; telephone = "115"; sex ="F"; birthyear = 1990 ; interests = ["Sport"; "Theater"; "Musicals"]};;


//The 3 functions is listed here.
//Now having a function for checking the sex of the clients 
    let findOpSex ownsex = function                      //1
    |"F" when "M" = ownsex -> true
    |"M" when "F" = ownsex -> true
    |_ -> false;;



//Folowing function will find clients in the intervall less than +/-10 years
    let checkAge ownage = function                   // 2
    |candidateage when ownage < (candidateage + 10) && ownage > (candidateage - 10) -> true
    |_ -> false;;


//Following function will compare interests
    let rec checkInterests owninterests = function                //3
    | [] -> false
    | interest::otherinterests -> if List.exists (fun i -> i=interest) owninterests 
                                  then true
                                  else checkInterests owninterests otherinterests;;    


//Following function will check for a match                     
    let isMatch (own:Client, candidate:Client) = findOpSex own.sex candidate.sex                //4
                                                 && checkAge own.birthyear candidate.birthyear 
                                                 && checkInterests own.interests candidate.interests;;

   
//The 5th function is collecting the other functions and printing the result. 
//Following function wil print all the matching candidates
    let rec getResponse newClient = function                        //5
    |[] -> []
    | candidate::otherCandidates -> if isMatch (newClient, candidate)
                                    then (candidate.name, candidate.telephone, candidate.interests)::(getResponse newClient otherCandidates)
                                    else getResponse newClient otherCandidates;;    
    
    
                                                    

//The greatest issue in this program is that the running time is O(n) for each list it has to run through. It can easily get a very long 
//running time. An array is prefered to use instead. Unfortunately I had quite some struggles trying to figure out how to that. 

               //Whitebox test 

 //   | Choice |Input Data Set | Input Property                                    | 
 // 1 | true   |    A          | M or F                                            |
 // 1 | false  |    A          | M if M and F if F                                 |
 // 2 | false  |    A          | Any other letter than F or M                      |
 // 2 | true   |    B          | An integer                                        |
 // 2 | false  |    B          | An age difference greater than 9 or less than 9   |
 // 3 | true   |    C          | Common interests                                  |
 // 3 | false  |    C          | No common interests                               |
 // 4 | true   |    D          | Returning a match                                 |
 // 4 | false  |    D          | Returning no match                                |
 // 5 | true   |    E          | all matching candidates                           |
 // 5 | false  |    E          | an empty let name = []                            |
 //________________________________________________________________________________|

 // | Input Data Set | Contents                              | Expected Output                 |
 // |       A        | M or F                                | F                               |
 // |       B        | 1950                                  | 1950 +/-9                       |
 // |       C        | "Sport"; "Theater"; "Musicals"        | true                            |
 // |       D        | Luise & Peter                         | A matching candidate            |

