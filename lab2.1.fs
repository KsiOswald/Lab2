open System

//Получить список из первых цифр чисел, содержащихся в исходном списке

// Функция ввода
let input N = [ 
    for i in 1..N do
        printf "Введите число: "
        let numb = int(Console.ReadLine()) 
        yield numb
    ]

//Функция нахождения первой цифры числа
let First_Digit input =
    let abs_input = abs input
    let rec Get_First_Digit numb =
        if numb<10 then
            numb
        else Get_First_Digit (numb/10)
    Get_First_Digit abs_input



[<EntryPoint>]
let main _ =
    printfn "Программа создает список из первых цифр числа "
    printf "Введите количество чисел: "
    let n = int(Console.ReadLine()) 
    if n <=0 then printf "Неверный ввод"
    let List_of_Numbs = (input n)
    let List_of_Difits = List.map First_Digit (List_of_Numbs)
    printfn "Исходный список: %A" List_of_Numbs
    printfn "Cписок первых цифр из чисел исходного списка: %A" List_of_Difits
    0