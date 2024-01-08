int num = 46;
int num1 = 7;
int num2 = 23;
if(num%num1 == 0){
    Console.WriteLine("Да, число кратно 7!");
}
else{
    Console.WriteLine($"Нет число не кратно 7, {num%num1}");
}
if(num%num2 == 0){
    Console.WriteLine("Да число кратно 23!");
}
else{
    Console.WriteLine($"Нет, число не кратно 23, {num%num2}");
}