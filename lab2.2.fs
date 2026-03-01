open System

//Сколько раз в списке встречается заданное число? 

// Функция ввода
let input N = [ 
    for i in 1..N do
        printf "Введите число: "
        let numb = float(Console.ReadLine())
        yield numb
    ]


let search list: int =
    printf "Введите искомое число: "
    let find_num = float(Console.ReadLine())
    let quantity_of_occ = List.fold(fun coun elemen_of_list -> 
        if elemen_of_list = find_num then coun+1 else coun) 0 list
    quantity_of_occ

[<EntryPoint>]
let main _ =
    printfn "Программа находит количество вхождений определнного числа в список "
    printf "Введите количество чисел: "
    let n = int(Console.ReadLine()) 
    if n <=0 then printf "Неверный ввод"
    let List_of_Numbs = (input n)
    let result = search List_of_Numbs
    printfn "Список для поиска: %A" List_of_Numbs
    printf "Количество совпадений: %i" result
    0