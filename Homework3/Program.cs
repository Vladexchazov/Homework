int num = 65;
int num1 = num/10; 
int num2 = num%10;
if(num  > 10 && num < 99){
if (num1 > num2){
    
    Console.Write($"{num1} больше, чем {num2}");
}
else  {
   
    Console.Write($"{num2} больше, чем {num1}");
}
}
else {
    Console.Write("Число не двузначное");
}

