int num = 255;
 num = Math.Abs(num);
 int num1 = (num%100)/10;
 int num2 = num%10;
 int num3 = 1;
for(int i = 1; i<=num2;i++){
 num3 = num3 * num1;
}
 Console.Write(num3);